using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAJunior.Model;

namespace BAJunior.View.Forms.user
{
    public partial class U_Profils : Form
    {
        private User m_UserLogin; 

        public U_Profils(User UserLogged)
        {
            m_UserLogin = UserLogged;
            InitializeComponent();
        }

        private void U_choixprofils_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddProfil_Click(object sender, EventArgs e)
        {
            U_PreConfAddProfil preConfAddProfilForm = new U_PreConfAddProfil(m_UserLogin);
            preConfAddProfilForm.ShowDialog();
        }
    }
}
