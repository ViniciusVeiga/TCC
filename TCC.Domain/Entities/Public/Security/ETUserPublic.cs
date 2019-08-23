using System;
using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities
{
    public class ETUserPublic : ETUser, IUser
    {
        public override string GetCookie() => "t_user_public";
    }
}
