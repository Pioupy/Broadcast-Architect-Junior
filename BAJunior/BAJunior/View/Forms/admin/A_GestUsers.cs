using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAJunior.View.Forms.admin
{
    public partial class A_GestUsers : UserControl
    {
        public A_GestUsers()
        {
            InitializeComponent();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            var PopUp = new A_Gest1Users();
            PopUp.Show();
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            var PopUp = new A_Gest1Users("erwan","krob0!",true);
            PopUp.Show();
        }
    }
}
