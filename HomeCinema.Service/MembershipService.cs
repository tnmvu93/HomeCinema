using System;
using System.Collections.Generic;
using HomeCinema.Data.Entities;
using HomeCinema.Service.Abstract;
using HomeCinema.Data.BaseRepository;

namespace HomeCinema.Service
{
    public class MembershipService : IMembershipService
    {
        #region properties
        private readonly IBaseRepository<User> _userRepository;

        public MembershipService(IBaseRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion
        
        #region methods
        public User CreateUser(string username, string email, string password, int[] roles)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetUserRoles(string username)
        {
            throw new NotImplementedException();
        }

        public MembershipContext ValidateUser(string username, string password)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
