using System;
using TCC.Domain.Entities.Security;
using TCC.Entity;

namespace TCC.BusinessLayer.Security
{
    public static class BLUser
    {
        public static EFContext context = new EFContext();

        public static bool Save()
        {
            try
            {
                var user = new ETUser
                {
                    Name = "dsasa",
                    Email = "dsa",
                    Password = "123e",
                    Active = true
                };

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
    }
}
