using HomeCinema.Data.Entities;

namespace HomeCinema.Data.Configurations
{
    public class UserRoleConfiguration : BaseEntityConfiguration<UserRole>
    {
        public UserRoleConfiguration()
        {
            this.Property(x => x.UserId).IsRequired();
            this.Property(x => x.RoleId).IsRequired();
        }
    }
}
