using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeCinema.Data.Entities
{
    public class Stock : BaseEntity
    {
        public int MovieId { get; set; }
        public Guid UniqueKey { get; set; }
        public bool IsAvailable { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
