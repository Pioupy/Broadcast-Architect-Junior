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
using BAJunior.ServiceData;
using BAJunior.View.Forms.admin;
using BAJunior.View.Forms.user;
using System.Security.Cryptography;

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
            // TEST START
            /*
            ## Note Alex : plus besoin, l'admin  existe déjà
            String pwd = "admin";
            SHA256 sha = SHA256.Create();
            byte[] data = sha.ComputeHash(Encoding.Default.GetBytes(pwd));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("6064060758"));
            }
            
            User u = new User("admin2", sb.ToString(), true);
            UserData uD = new UserData();
            uD.create(u);  
            */         
            // TEST END

            if (!String.IsNullOrEmpty(tb_Password.Text) && !String.IsNullOrEmpty(tb_Login.Text)) {
                CtrlConnection con = new CtrlConnection();
                User user = con.Connect(tb_Password.Text, tb_Login.Text);
                if (user == null)
                {
                    System.Windows.Forms.MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                }
                else {
                    if (!user.isAdmin())
                    {
                        /*
                        // Note Alex : Anciennement on appellait cette form, maintenant on apeplle u_profil
                        U_User userForm = new U_User();
                        userForm.ShowDialog();
                        this.Close();
                        */
                        U_Profils userForm = new U_Profils();
                        this.Hide();
                        userForm.ShowDialog();
                        this.Close();//Note alex : close peut être avant le show ? question
                    }
                    else
                    {
                        A_Administrator userAdmin = new A_Administrator();
                        
                        this.Hide();
                        userAdmin.ShowDialog();
                        this.Close();
                    }
                }
            } else
            {
                System.Windows.Forms.MessageBox.Show("Veuillez remplir tous les champs.");
            }
        }
    }
}
