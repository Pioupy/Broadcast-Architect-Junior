using System;
using System.Windows.Forms;
using BAJunior.View.Forms;
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
            // TODO : Beaucoup de commentaire de ma part ( alex ), bien sur à la fin, il n'y aura que les 3 lignes qui appellent connectioon.cs dans le main.
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            bool testAlexandre = false;
            // éxécute le if que si c'est Alexandre qui lance le programme. Need pour tester mes classes non "visuel"
            if ((userName == "Alex\\Alex.G") && (testAlexandre == true))
            {
                // Testing Phase :
                InitDB initDatabase = new InitDB();
                //initDatabase.testCreatedByAlex();
                //initDatabase.testForOthes();
                initDatabase.createDatabaseByAlexForTest();
                //Xml profil = new Xml();
                //profil.readNameProfil("ClavierTestOne");
            }
            else
            {
                // Pour avoir accès à  la base de données avec qu'un seul user qui est : 
                // login: admin, mdp: admin
                //Veuilez instancier la classe 'initDB'. 
                //faite gaff si vous supprimez la bdd et que vous en mettez pas une autre, si initDb est pas instancier, VOUS AUREZ DES PROBLEME :D
                //InitDB initDatabase = new InitDB();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                // Application.Run(new BAJunior.View.Forms.FormDeTest());
                Application.Run(new Connection());
                //Application.Run(new BAJunior.View.Forms.admin.A_Administrator());
                //Application.Run(new BAJunior.View.Forms.user.U_Profils());
            }
        }
    }
}
