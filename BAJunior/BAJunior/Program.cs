﻿using System;
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
            // Testing Phase :
            InitDB initDatabase = new InitDB();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Connection());
        }
    }
}
