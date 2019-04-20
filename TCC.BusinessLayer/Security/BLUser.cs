using System;
using TCC.Domain.Entities.Security;
using TCC.Entity;

namespace TCC.BusinessLayer.Security
{
    public static class BLUser
    {
        public static EFContext context = new EFContext();
        
        #region Save

        public static bool Save(ETUser user)
        {
            try
            {
                context.Users.Add(user);
                context.SaveChanges();

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
