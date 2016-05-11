using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BAJunior.ServiceData;
using BAJunior.Model;

namespace BAJunior.View.Forms.user
{
    public partial class U_AddProfil : Form
    {
        private String m_nameProfile;
        private String m_nameKeyboard;
        private String m_nameApplication;
        public U_AddProfil()
        {
            InitializeComponent();
        }
        public U_AddProfil(String nameProfile, String nameKeyboard, String nameApplication)
        {
            InitializeComponent();
            m_nameProfile = nameProfile;
            m_nameKeyboard = nameKeyboard;
            m_nameApplication = nameApplication;
            labelNameProfile.Text = nameProfile;
            labelKeyboard.Text = nameKeyboard;
            lv_application.Items.Add(nameApplication);
            lv_application.Items[0].BackColor = Color.Green;

            CommandData commandData = new CommandData();
            List<Command> listBtns;

            // Gestion de l'affichage de la liste des boutons
            listBtns = commandData.readAll();
            var imageList = new ImageList();

            foreach (Command cmd in listBtns) {
                Bitmap img = (Bitmap)Image.FromFile("Image/"+cmd.getPicture(), true);
                imageList.Images.Add(cmd.getPicture(), img);                
            }
            listViewBtns.LargeImageList = imageList;
            foreach (Command cmd in listBtns)
            {
                var listViewItem = listViewBtns.Items.Add(cmd.getName());
                listViewItem.ImageKey = cmd.getPicture();
            }

            // Gestion de l'affichage/génération des boutons de profil par défaut
            Xml xml = new Xml();
            List<String> defaultProfilsList = xml.readNameProfil(nameKeyboard);
            Button button;
            foreach (String name in defaultProfilsList) {
                button = new Button();
                button.Text = name;
                button.Click += button_Click_Default_Profils; // ajout de l'event onClick
                panelDefaultProfils.Controls.Add(button);
                //faire en sorte que le btn sois auto size
                //je crois que le bouton en faite se crée par dessus le premier !!!
            }
        }
        void button_Click_Default_Profils(object obj, EventArgs e) // envent onClick pour les boutons des profils par défaut
        {
           
        }

        private void btn_addApplication_Click(object sender, EventArgs e)
        {
            U_AddApplicationInAddProfil addApplicaion = new U_AddApplicationInAddProfil(m_nameApplication);
            addApplicaion.ShowDialog();
        }
    }
}
