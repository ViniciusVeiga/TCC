using System;
using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities.Admin.Security
{
    public class ETUserAdmin : ETUser, IUser
    {
        public override string GetCookie() => "t_user_public";
    }
}
