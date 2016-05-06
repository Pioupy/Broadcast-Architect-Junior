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
                // Testing Phase :
                InitDB initDatabase = new InitDB();
                initDatabase.testCreatedByAlex();
            }
            else
            {
                // Pour avoir accès à  la base de données avec qu'un seul user qui est : 
                // login: admin, mdp: admin
                //Veuilez instancier la classe 'initDB'.
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
              // Application.Run(new BAJunior.View.Forms.FormDeTest());
                //   Application.Run(new BAJunior.View.Forms.admin.A_GestionApplication());
                Application.Run(new BAJunior.View.Forms.admin.A_Administrator());
              //   Application.Run(new BAJunior.View.Forms.user.U_Profils());
               // Application.Run(new Connection());
            }
        }
    }
}
