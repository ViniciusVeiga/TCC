using System;
using System.Collections.Generic;
using System.Linq;
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
            catch (Exception)
            {
                throw;    
            }
        }

        #region Validação

        public static bool CheckEmail(string email)
        {
            var users = (List<ETUser>)CRUD<ETUser>.All;

            if (users.Any(u => u.Email == email))
            {
                return true;
            }

            return false;
        }

        #endregion

        #endregion
    }
}
