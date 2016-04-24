using System;
using System.Windows.Forms;
using BAJunior.View.Forms;
using System.Security.Cryptography;
using BAJunior.ServiceData;


namespace BAJunior
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            // éxécute le if que si c'est Alexandre qui lance le programme. Need pour tester mes classes non "visuel"
            if (userName == "Alex\\Alex.G")
            {
                InitDB initDatabase = new InitDB();
                initDatabase.testCreatedByAlex();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Connection());
            }
        }
    }
}
