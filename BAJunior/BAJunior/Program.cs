﻿using System;
using System.Windows.Forms;
using BAJunior.View.Forms;
using System.Security.Cryptography;


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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Connection());
        }
    }
}
