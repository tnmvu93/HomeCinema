using HomeCinema.Data.Entities;
using System.Security.Principal;

namespace HomeCinema.Service
{
    public class MembershipContext
    {
        public IPrincipal Principal { get; set; }
        public User User { get; set; }
        public bool IsValid()
        {
            return Principal != null;
        }
    }
}
