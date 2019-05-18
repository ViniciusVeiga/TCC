using System;
using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities
{
    public class ETUser : ETBase, IUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }

        public virtual string GetCookie() => string.Empty;
    }
}
