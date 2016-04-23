using System;
using System.Windows.Forms;
using BAJunior.Model;
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
            bool modeTestDataAlex = true; // Test Alexandre
            if(modeTestDataAlex == true)
            {
                InitDB initTest = new InitDB();
                initTest.testCreatedByAlex(true, true, true);
            }
            else
            {
                System.Windows.Forms.Application.EnableVisualStyles();
                System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
                System.Windows.Forms.Application.Run(new Form1());
            }  
        }
    }
}
