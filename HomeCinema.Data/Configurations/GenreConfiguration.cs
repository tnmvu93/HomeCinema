using HomeCinema.Data.Entities;

namespace HomeCinema.Data.Configurations
{
    public class GenreConfiguration : BaseEntityConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            this.Property(x => x.Name).IsRequired().HasMaxLength(50);
        }
    }
}
