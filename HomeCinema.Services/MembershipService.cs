using System;
using System.Collections.Generic;
using HomeCinema.Data.Entities;
using HomeCinema.Service.Abstract;
using System.Linq;
using System.Security.Principal;
using HomeCinema.Data;
using HomeCinema.Services.IRepository;

namespace HomeCinema.Service
{
    public class MembershipService : IMembershipService
    {
        #region properties
        private readonly HomeCinemaContext _dbContext;
        private readonly IEncryptionService _encryptionService;
        private readonly IUserRepository _userRepository;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IRoleRepository _roleRepository;

        public MembershipService
            (HomeCinemaContext dbContext, IEncryptionService encryptionService, IUserRepository userRepository, IUserRoleRepository userRoleRepository, IRoleRepository roleRepository)
        {
            _dbContext = dbContext;
            _userRepository = userRepository;
            _encryptionService = encryptionService;
            _userRoleRepository = userRoleRepository;
            _roleRepository = roleRepository;
        }
        #endregion

        #region methods
        public MembershipContext ValidateUser(string username, string password)
        {
            var membershipContext = new MembershipContext();

            var user = _userRepository.GetUserByUsername(username);
            if (user != null && IsUserValid(user, password))
            {
                var roles = GetUserRoles(username);
                membershipContext.User = user;

                var identity = new GenericIdentity(user.Username);
                membershipContext.Principal = new GenericPrincipal(identity, roles.Select(x => x.Name).ToArray());
            }

            return membershipContext;
        }

        public User CreateUser(string username, string email, string password, int[] roles)
        {
            var existingUser = _userRepository.GetUserByUsername(username);

            if (existingUser != null)
            {
                throw new Exception("Username is already in use");
            }

            var passwordSalt = _encryptionService.CreateSalt();

            var user = new User
            {
                Username = username,
                Salt = passwordSalt,
                Email = email,
                IsLocked = false,
                HashedPassword = _encryptionService.EncryptPassword(password, passwordSalt),
                DateCreated = DateTime.Now
            };

            _userRepository.Add(user);
            _dbContext.SaveChanges();

            if (roles != null && roles.Length > 0)
            {
                foreach (var role in roles)
                {
                    AddUserToRole(user, role);
                }
            }
            _dbContext.SaveChanges();
            return user;
        }

        public User GetUser(int userId)
        {
            return _userRepository.GetById(userId);
        }

        public List<Role> GetUserRoles(string username)
        {
            var result = new List<Role>();

            var existingUser = _userRepository.GetUserByUsername(username);

            if (existingUser != null)
            {
                foreach(var userRole in existingUser.UserRoles)
                {
                    result.Add(userRole.Role);
                }
            }
            return result.Distinct().ToList();
        }
        #endregion

        #region helper methods
        private void AddUserToRole(User user, int roleId)
        {
            var role = _roleRepository.GetById(roleId);
            if (role == null)
            {
                throw new ApplicationException("Role doesn't exist.");
            }

            var userRole = new UserRole()
            {
                RoleId = role.Id,
                UserId = user.Id
            };
            _userRoleRepository.Add(userRole);
        }
        private bool IsPasswordValid(User user, string password)
        {
            return string.Equals(_encryptionService.EncryptPassword(password, user.Salt), user.HashedPassword);
        }

        private bool IsUserValid(User user, string password)
        {
            if (IsPasswordValid(user, password))
            {
                return !user.IsLocked;
            }
            return false;
        }
        #endregion
    }
}
