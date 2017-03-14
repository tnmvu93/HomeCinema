using HomeCinema.Data.Entities;

namespace HomeCinema.Data.Configurations
{
    public class RoleConfiguration : BaseEntityConfiguration<Role>
    {
        public RoleConfiguration()
        {
            this.Property(x => x.Name).IsRequired().HasMaxLength(50);
        }
    }
}
