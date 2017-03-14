using System;

namespace HomeCinema.Data.Entities
{
    public class Rental : BaseEntity
    {
        public int CustomerId { get; set; }
        public int StockId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public string Status { get; set; }

        public virtual Stock Stock { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
