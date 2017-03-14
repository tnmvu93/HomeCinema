using HomeCinema.Data.Entities;

namespace HomeCinema.Data.Configurations
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public UserConfiguration()
        {
            this.Property(x => x.Username).IsRequired().HasMaxLength(100);
            this.Property(x => x.Email).IsRequired().HasMaxLength(200);
            this.Property(x => x.HashedPassword).IsRequired().HasMaxLength(200);
            this.Property(x => x.Salt).IsRequired().HasMaxLength(200);
            this.Property(x => x.IsLocked).IsRequired();
            this.Property(x => x.DateCreated);
        }
    }
}
