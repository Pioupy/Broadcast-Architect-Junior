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
using BAJunior.Model;

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
                CtrlConnection con = new CtrlConnection();
                User user = con.Connect(tb_Password.Text, tb_Login.Text);
                if (user == null)
                {
                    System.Windows.Forms.MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                }
                else {
                    if (user.isAdmin())
                    {

                    }
                    else
                    {

                    }
                }
            } else
            {
                System.Windows.Forms.MessageBox.Show("Veuillez remplir tous les champs.");
            }
        }
    }
}
