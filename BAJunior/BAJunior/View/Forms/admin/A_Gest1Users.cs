using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAJunior.ServiceData;
using BAJunior.Model;
using BAJunior.Controller;

namespace BAJunior.View.Forms.admin
{
    public partial class A_Gest1Users : Form
    {
        CtrlConnection con = new CtrlConnection();
        User actual;

        public A_Gest1Users()
        {
            InitializeComponent();
        }

        public A_Gest1Users(User userSend)
        {
            InitializeComponent();

            actual = userSend;
            
            tb_id.Text = userSend.getLogin();
            tb_password.Text = userSend.getPassword();

            if (userSend.isAdmin())            
                rbtn_yes.Checked = true;            
            else
                rbtn_no.Checked = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tb_id.Text != "" && tb_id.Text != null && tb_password.Text != "" && tb_password.Text != null)
            {
                UserData bdd = new UserData();
                if (actual != null)
                {
                    actual.setLogin(tb_id.Text);
                    actual.setPassword(con.ConvertSHA256(tb_password.Text));
                    actual.setIsAdmin(rbtn_yes.Checked);

                    bdd.update(actual);
                }
                else
                {
                    actual = new User(tb_id.Text, con.ConvertSHA256(tb_password.Text), rbtn_yes.Checked);
                    bdd.create(actual);
                }

                Form.ActiveForm.Close();
            }
            else
                MessageBox.Show("Veuillez remplir tous les champs");
        }
    }
}
