using HomeCinema.Data.Entities;

namespace HomeCinema.Data.Configurations
{
    public class MovieConfiguration : BaseEntityConfiguration<Movie>
    {
        public MovieConfiguration()
        {
            this.Property(x => x.Title).IsRequired().HasMaxLength(100);
            this.Property(x => x.GenreId).IsRequired();
            this.Property(x => x.Director).IsRequired().HasMaxLength(100);
            this.Property(x => x.Writer).IsRequired().HasMaxLength(50);
            this.Property(x => x.Producer).IsRequired().HasMaxLength(50);
            this.Property(x => x.Writer).HasMaxLength(50);
            this.Property(x => x.Producer).HasMaxLength(50);
            this.Property(x => x.Rating).IsRequired();
            this.Property(x => x.Description).IsRequired().HasMaxLength(2000);
            this.Property(x => x.TrailerURI).HasMaxLength(200);

            this.HasMany(x => x.Stocks).WithRequired(s => s.Movie).HasForeignKey(s => s.MovieId);
        }
    }
}
