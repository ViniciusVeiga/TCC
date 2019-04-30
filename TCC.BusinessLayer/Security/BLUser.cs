using System;
using System.Linq;
using System.Web;
using TCC.BusinessLayer.Base;
using TCC.Domain.Entities.Security;
using TCC.Entity.CRUD;
using static System.Web.HttpContext;

namespace TCC.BusinessLayer.Security
{
    public class BLUser
    {
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

        public static bool Autentication(string email, string passaword)
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

                Current.Response.Cookies.Add(
                    new HttpCookie("t_user", user.Token)
                    {
                        Expires = DateTime.Now.AddYears(1)
                    });

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Obter Logado

        public static ETUser GetLogged()
        {
            try
            {
                var cookie = Current.Request.Cookies["t_user"];

                if (cookie != null && !string.IsNullOrEmpty(cookie.Value))
                {
                    var user = CRUD<ETUser>
                        .Find(u => u.Token == cookie.Value && u.Active == true);

                    return user;
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

        public static bool Logoff()
        {
            try
            {
                var user = GetLogged();

                user.Token = null;
                CRUD<ETUser>.Update(user);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Validação Remota

        public static bool IsValid(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                var users = CRUD<ETUser>.All;

                if (users.Any(u => u.Email == email))
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}
