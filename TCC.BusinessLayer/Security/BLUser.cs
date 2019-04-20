using System;
using TCC.Domain.Entities.Security;
using TCC.Domain.Interfaces.Repositories;
using TCC.Entity;
using TCC.Entity.Repositories;

namespace TCC.BusinessLayer.Security
{
    public class BLUser
    {
        private static readonly IRUser _users = new RUser(new EFContext());

        #region Save

        public static bool NewUser(ETUser user)
        {
            try
            {
                _users.Add(user);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        #endregion
    }
}
