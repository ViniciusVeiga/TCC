using System;

namespace TCC.Domain.Interfaces.Entities
{
    public interface IUser
    {
        string Name { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }
}
