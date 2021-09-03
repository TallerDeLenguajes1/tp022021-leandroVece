using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tp2.Views.Home
{
    public class CError
    {
        //private readonly ILogger<CError> _logger;
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        //private static readonly NLog.Logger logError = NLog.LogManager.GetLogger("logError");
        //private static readonly NLog.Logger logRegistro = NLog.LogManager.GetLogger("logRegistro");

        public CError()
        {
            
        }

        public static double IsNan(string a)
        {
            try
            {

                Logger.Info("Seguimiento: " + a);
                return Convert.ToDouble(a);
            }
            catch (Exception ex)
            {

                //loguer
                Logger.Error(ex.Message);
                return -1;
            }
        }

        public static string IsAlfab(string a)
        {
            try
            {
                //¿condicicion para determinar si es solo alfavetica?
                Logger.Info("Seguimiento: " + a);
                return a;
            }
            catch (Exception ex)
            {

                //loguer
                Logger.Error(ex.Message);
                return "Error al pasar variable";
            }
        }
    }
}
