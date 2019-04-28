using System;
using System.Collections.Generic;
using System.Linq;
using TCC.Domain.Entities.Security;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.Security
{
    public class BLUser
    {
        #region Cria Usuário

        public static bool Create(ETUser user)
        {
            try
            {
                CRUD<ETUser>.Add(user);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #region Validação

        public static bool ValidationEmail(string email)
        {
            var users = CRUD<ETUser>.All;

            if (users.Any(u => u.Email == email))
            {
                return true;
            }

            return false;
        }

        #endregion

        #endregion

        #region Autenticação

        public static dynamic Autentication(string email, string passaword)
        {
            try
            {
                var user = CRUD<ETUser>
                    .Find(u => u.Email == email && u.Password == passaword && u.Active == true);

                if (user == null)
                    return false;

                user.Token = Guid.NewGuid().ToString();
                CRUD<ETUser>.Update(user);

                return user.Token;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}
