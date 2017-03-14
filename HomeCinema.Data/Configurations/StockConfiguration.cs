using HomeCinema.Data.Entities;

namespace HomeCinema.Data.Configurations
{
    public class StockConfiguration : BaseEntityConfiguration<Stock>
    {
        public StockConfiguration()
        {
            this.Property(x => x.MovieId).IsRequired();
            this.Property(x => x.UniqueKey).IsRequired();
            this.Property(x => x.IsAvailable).IsRequired();

            this.HasMany(x => x.Rentals).WithRequired(r => r.Stock).HasForeignKey(r => r.StockId);
        }
    }
}
