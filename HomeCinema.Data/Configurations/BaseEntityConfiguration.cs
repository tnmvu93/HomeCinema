using HomeCinema.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HomeCinema.Data.Configurations
{
    public class BaseEntityConfiguration<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseEntityConfiguration()
        {
            this.HasKey(x => x.Id);
        }
    }
}
