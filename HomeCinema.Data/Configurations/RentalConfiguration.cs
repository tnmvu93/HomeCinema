using HomeCinema.Data.Entities;

namespace HomeCinema.Data.Configurations
{
    public class RentalConfiguration : BaseEntityConfiguration<Rental>
    {
        public RentalConfiguration()
        {
            this.Property(x => x.CustomerId).IsRequired();
            this.Property(x => x.StockId).IsRequired();
            this.Property(x => x.Status).IsRequired().HasMaxLength(10);
            this.Property(x => x.ReturnedDate).IsOptional();
        }
    }
}
