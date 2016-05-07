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
    public partial class U_PreConfAddProfil : Form
    {
        public U_PreConfAddProfil()
        {
            InitializeComponent();
            // Recover Keyboard on database
            KeyboardData keyboardData = new KeyboardData();
            List<Keyboard> keyboardList = keyboardData.readAll();
            for (int i = 0; i < keyboardList.Count; i++)
            {
                String keyboard = keyboardList[i].getName();
                this.cb_keyboard.Items.AddRange(new object[] {
                    keyboard
                });
            }
            // Recover Application on Database
            ApplicationData applicationData = new ApplicationData();
            List<Model.Application> applicationList = applicationData.readAll();
            for (int i = 0; i < applicationList.Count; i++)
            {
                String application = applicationList[i].getName();
                this.cb_application.Items.AddRange(new object[] {
                    application
                });
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            //TODO : Faire les test si les champs son rempli !!!!!!!!
            if ((tb_nameProfile.Text != "") && (cb_keyboard.Text != "") && (cb_application.Text != ""))
            {
                //U_AddProfil userForm = new U_AddProfil();
                //Constructeur avec les informations récupérées ici 
                U_AddProfil profilForm = new U_AddProfil(tb_nameProfile.Text, cb_keyboard.Text, cb_application.Text);
                this.Hide();
                profilForm.ShowDialog();
                this.Close();// note Alex : avant le show ? 
            }
            else
            {
                MessageBox.Show("Vous n'avez pas remplis tous les champs.");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
