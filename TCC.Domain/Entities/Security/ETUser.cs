using TCC.Domain.Interfaces;
using TCC.Domain.Interfaces.Entities;

namespace TCC.Domain.Entities.Security
{
    public class ETUser : ETBase, IUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
