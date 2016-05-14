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
    public partial class K_Intellipad : UserControl
    {
        private U_AddProfil m_addProfil;
        public K_Intellipad()
        {
            InitializeComponent();
        }
        public K_Intellipad(U_AddProfil addProfil)
        {
            InitializeComponent();
            m_addProfil = addProfil;
        }
        private void key1_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("cool");
        }
    }
}
