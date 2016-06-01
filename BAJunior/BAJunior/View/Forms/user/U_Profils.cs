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
using BAJunior.ServiceMétier;

namespace BAJunior.View.Forms.user
{
    public partial class U_Profils : Form
    {
        private User m_UserLogin;
        private ProfilData m_ProfilData = new ProfilData();
        List<Profil> listProfil = new List<Profil>();

        public U_Profils(User UserLogged)
        {
            listProfil = m_ProfilData.readByUserID(UserLogged.getId());
            m_UserLogin = UserLogged;
            InitializeComponent();

            if (listProfil.Count > 0)
            {
                foreach (Profil item in listProfil)
                {
                    cb_Profils.Items.Add(item.getName());

                    if (item.getStatus() == "actif")
                    {
                        cb_Profils.SelectedIndex = cb_Profils.FindString(listProfil.Where(item2 => item2.getId() == item.getId()).FirstOrDefault().getName());
                        //charger clavier
                        loadActifKeybord(item);
                    }
                }
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

        private void btn_Load_Click(object sender, EventArgs e)
        {
            if (listProfil.Where(item => item.getName() == cb_Profils.Text).Count() > 0)
            {
                FileTools saveTool = new FileTools();
                Profil actualProfil = m_ProfilData.read(listProfil.Where(item => item.getName() == cb_Profils.Text).FirstOrDefault().getId());

                saveTool.objectToTxt(actualProfil);
                MessageBox.Show("Enregistrement fini !");
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un profil.");
            }
        }

        private void loadActifKeybord(Profil ActivProfile)
        {
            List<string> image = new List<string>();
            CommandUserData cud = new CommandUserData();
            JointPACData jpd = new JointPACData();
            JointPAC jp = jpd.readByProfilId(ActivProfile.getId()).FirstOrDefault();

            for (int i = 0; i < 28; i++)
            {
                string vide = "";
                image.Add(vide);
            }

            foreach (JointPAC jpFe in jpd.readByProfilId(ActivProfile.getId()).Where(item => item.getIdApplication() == jp.getIdApplication() && item.getBank() == jp.getBank()))
            {
                image[jpFe.getBtnKeyboard()] = cud.read(jpFe.getIdCommandUser()).getPicture();
            }

            intellipad.setPicture1(image.ToArray());
        }

        private void btn_EditProfil_Click(object sender, EventArgs e)
        {
            U_AddProfil SelectedProfil = new U_AddProfil(listProfil.Where(item => item.getName() == cb_Profils.Text).FirstOrDefault().getId());
            SelectedProfil.Show();
        }

        private void btn_DeleteProfil_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez-vous supprimer le profil ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultat == DialogResult.Yes)
            {
                m_ProfilData.delete(listProfil.Where(item => item.getName() == cb_Profils.Text).FirstOrDefault());
                                
                cb_Profils.Items.Clear();
                cb_Profils.Text = "";
                intellipad.setPictureToZero();

                listProfil = m_ProfilData.readByUserID(m_UserLogin.getId());
                if (listProfil.Count > 0)
                {
                    foreach (Profil item in listProfil)
                    {
                        cb_Profils.Items.Add(item.getName());

                        if (item.getStatus() == "actif")
                        {
                            cb_Profils.SelectedIndex = cb_Profils.FindString(listProfil.Where(item2 => item2.getId() == item.getId()).FirstOrDefault().getName());
                            //charger clavier
                            loadActifKeybord(item);
                        }
                    }
                }
            }
        }
    }
}
