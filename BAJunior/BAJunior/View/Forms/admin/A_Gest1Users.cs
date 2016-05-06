using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAJunior.View.Forms.admin
{
    public partial class A_Gest1Users : Form
    {
        public A_Gest1Users()
        {
            InitializeComponent();
        }

        public A_Gest1Users(string name, string password, bool isAdmin)
        {
            InitializeComponent();

            tb_id.Text = name;
            tb_password.Text = password;

            if (isAdmin)            
                rbtn_yes.Checked = true;            
            else
                rbtn_no.Checked = true;
        }
    }
}
