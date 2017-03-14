using HomeCinema.Data.Entities;

namespace HomeCinema.Data.Configurations
{
    public class CustomerConfiguration : BaseEntityConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            this.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            this.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            this.Property(x => x.IdentityCard).IsRequired();
            this.Property(x => x.UniqueKey).IsRequired();
            this.Property(x => x.Mobile).HasMaxLength(10);
            this.Property(x => x.Email).IsRequired().HasMaxLength(200);
            this.Property(x => x.DateOfBirth).IsRequired();
        }
    }
}
