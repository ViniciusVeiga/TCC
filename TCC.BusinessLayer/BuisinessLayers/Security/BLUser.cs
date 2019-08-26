using System;
using System.Linq;
using System.Web;
using TCC.BusinessLayer.BusinessLayers;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;
using static System.Web.HttpContext;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLUser<T> where T : ETUser
    {
        private static readonly string _cookie = ((T)Activator.CreateInstance(typeof(T))).GetCookie();

        #region Cria Usuário

        public static bool Create(T user)
        {
            try
            {
                user.Password = BLEncrypt.Encrypt(user.Password);

                CRUD<T>.Add(user);

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

                var user = CRUD<T>
                    .Find(u => u.Email == email && u.Password == passaword && u.Active == true);

                if (user == null)
                    return false;

                user.Token = Guid.NewGuid().ToString();
                CRUD<T>.Update(user);

                Current.Response.Cookies.Add(
                    new HttpCookie(_cookie, user.Token)
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

        public static T GetLogged()
        {
            try
            {
                var cookie = Current.Request.Cookies[_cookie];

                if (cookie != null && !string.IsNullOrEmpty(cookie.Value))
                {
                    var user = CRUD<T>
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
                CRUD<T>.Update(user);

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
                var users = CRUD<T>.All;

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
