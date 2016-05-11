using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAJunior.View.Forms.user
{
    public partial class U_AddProfil : Form
    {
        public U_AddProfil()
        {
            InitializeComponent();
        }
        public U_AddProfil(String nameProfile, String nameKeyboard, String nameApplication)
        {
            InitializeComponent();
            labelNameProfile.Text = nameProfile;
            labelKeyboard.Text = nameKeyboard;
            lv_application.Items.Add(nameApplication);
            lv_application.Items[0].BackColor = Color.Green;
        }
    }
}
