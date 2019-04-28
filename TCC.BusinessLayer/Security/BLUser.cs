using System;
using System.Collections.Generic;
using System.Linq;
using TCC.Domain.Entities.Security;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.Security
{
    public class BLUser
    {
        private static ETUser _user;

        #region Cria Usuário

        public static bool Create(ETUser user)
        {
            try
            {
                user.Password = BLEncrypt.Encrypt(user.Password);

                CRUD<ETUser>.Add(user);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Autenticação

        public static dynamic Autentication(string email, string passaword)
        {
            try
            {
                passaword = BLEncrypt.Encrypt(passaword);

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

        #region Obter Logado

        public ETUser GetLogged(string token)
        {
            try
            {
                if (string.IsNullOrEmpty(token))
                {
                    var user = CRUD<ETUser>
                        .Find(u => u.Token == token && u.Active == true);

                    _user = user;

                    return _user;
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }

        }

        #endregion

        #region Deslogar

        public bool Logoff()
        {
            try
            {
                _user.Token = null;
                CRUD<ETUser>.Update(_user);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Validações

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
    }
}
