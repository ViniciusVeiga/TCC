using System;
using TCC.Domain.Entities.Security;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.Security
{
    public class BLUser
    {
        #region Novo Usuário

        public static bool NewUser(ETUser user)
        {
            try
            {
                CRUD<ETUser>.Add(user);

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
