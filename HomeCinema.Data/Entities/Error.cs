using System;

namespace HomeCinema.Data.Entities
{
    public class Error : BaseEntity
    {
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
