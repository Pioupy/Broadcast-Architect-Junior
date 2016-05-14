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
using BAJunior.View.Forms.user;
using System.IO;

namespace BAJunior.View.Forms.user
{
    public partial class U_AddProfil : Form
    {
        private String m_nameProfile;
        private String m_nameKeyboard;
        private List<String> m_nameApplication = new List<string>();
        public U_AddProfil()
        {
            InitializeComponent();
        }
        public U_AddProfil(String nameProfile, String nameKeyboard, String nameApplication)
        {
            InitializeComponent();
            m_nameProfile = nameProfile;
            m_nameKeyboard = nameKeyboard;
            m_nameApplication.Add(nameApplication);
            labelNameProfile.Text = nameProfile;
            labelKeyboard.Text = nameKeyboard;
            lv_application.Items.Add(nameApplication);
            lv_application.Items[0].BackColor = Color.Green;

            CommandData commandData = new CommandData();
            List<Command> listBtns;

            // Gestion de l'affichage de la liste des boutons
            listBtns = commandData.readAll();
            var imageList = new ImageList();
            /* string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + Properties.Settings.Default.DefaultImagePath;
            path = path.Replace("file:\\", "");

            [2:57] la t'a le répertoire ou y'a les images
            [2:58] apres, pour chopé les images etc, c'est surment plsu chaud que le repertoire image DANS le truc*/
            foreach (Command cmd in listBtns) {
                Bitmap img = (Bitmap)Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\bin\\Debug\\Image\\" + cmd.getPicture(), true);
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
            // Gestion de l'affichage/génération du clavier  par défaut
            String fileKeyboard = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\View\\Forms\\user\\keyboard/K_" + nameKeyboard + ".cs";
            if (File.Exists(fileKeyboard))
            {
                if (nameKeyboard == "Intellipad")
                {
                    var keyboardClass = new K_Intellipad();
                    panel_keyboard.Controls.Add(keyboardClass);
                }
                else if (nameKeyboard == "testkeyboard")
                {
                    var keyboardClass = new K_testkeyboard();
                    panel_keyboard.Controls.Add(keyboardClass);
                }
                else
                {
                    //gerer lerreur affichage !
                    MessageBox.Show("Le clavier n'existe pas !!! #hashtag tu as le seum ENCORE PLUS");
                }
                
            }
            else
            {
                MessageBox.Show("Le clavier n'existe pas !!! #hashtag tu as le seum");
            }
            
        }
        /*#######################################
          #       CODE GESTION XML              #
          #######################################*/
        void button_Click_Default_Profils(object obj, EventArgs e) // envent onClick pour les boutons des profils par défaut
        {
           
        }
        /*#######################################
          #    CODE GESTION APPLICATION         #
          #######################################*/
        private void btn_addApplication_Click(object sender, EventArgs e)
        {
            U_AddApplicationInAddProfil addApplicaion = new U_AddApplicationInAddProfil(this, m_nameApplication);
            addApplicaion.ShowDialog();
        }
        private void btn_selectApplication_Click(object sender, EventArgs e)
        {
            //récuperer valeur

            //charger paramètre

            //mettre fond vert

        }
        private void lv_application_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_application.SelectedItems.Count > 0)
            {
                int count = lv_application.Items.IndexOf(lv_application.SelectedItems[0]);
                //recuperer champs selelectionner
            }
        }
        public void addApplication(String application)
        {
            lv_application.Items.Add(application);
            m_nameApplication.Add(application);
        }
        /*#######################################
          #    CODE GESTION DES BOUTONS         #
          #######################################*/

        /*#######################################
          #    CODE GESTION DES KEYBOARD        #
          #######################################*/

    }
}
