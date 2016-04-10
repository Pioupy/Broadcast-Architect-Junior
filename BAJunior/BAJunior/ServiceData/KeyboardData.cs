using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace BAJunior.ServiceData
{
    class KeyboardData
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog log = LogManager.GetLogger(typeof(KeyboardData));
        public KeyboardData()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
        }
    }
}
