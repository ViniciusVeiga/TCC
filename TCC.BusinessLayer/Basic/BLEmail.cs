using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.BusinessLayer
{
    public class BLEmail
    {
        #region Enviar

        public static bool Send()
        {
            try
            {


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}
