﻿using System.Collections.Generic;

namespace HomeCinema.Data.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Movie> Movies {get; set;}
    }
}
