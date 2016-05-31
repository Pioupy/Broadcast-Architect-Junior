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
using BAJunior.ServiceData;

namespace BAJunior.View.Forms.user
{
    public partial class U_Profils : Form
    {
        private User m_UserLogin;
        private ProfilData m_ProfilData = new ProfilData(); 

        public U_Profils(User UserLogged)
        {
            List<Profil> listProfil = m_ProfilData.readByUserID(UserLogged.getId());
            m_UserLogin = UserLogged;
            InitializeComponent();

            foreach (Profil item in listProfil)
            {
                cb_Profils.Items.Add(item.getName());
            }
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
