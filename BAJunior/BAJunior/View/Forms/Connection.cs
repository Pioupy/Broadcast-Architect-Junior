using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAJunior.Controller;

namespace BAJunior.View.Forms
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
            // Assign the asterisk to be the password character.
            tb_Password.PasswordChar = '*';

        }

        private void btn_Connection_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_Password.Text) && !String.IsNullOrEmpty(tb_Login.Text)) {

            } else
            {
                System.Windows.Forms.MessageBox.Show("Veuillez remplir tous les champs.");
            }
        }
    }
}
