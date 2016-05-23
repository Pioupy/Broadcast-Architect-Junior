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
        private Command m_commandDragAndDrop;
        private int countListBtn;
        // Data table
        private int m_sizeButtonKeyboard;
        private int m_bank = 1;
        private int m_nbMaxBank;
        private List<JointPAC> m_listJointPAC = new List<JointPAC>();
        private List<CommandUser> m_listCommandUser = new List<CommandUser>();
        private List<List<ParamUser>> m_listParamUser = new List<List<ParamUser>>();


        public U_AddProfil()
        {
            InitializeComponent();
        }
        public U_AddProfil(String nameProfile, String nameKeyboard, String nameApplication)
        {
            InitializeComponent();
            // init value
            m_nameProfile = nameProfile;
            m_nameKeyboard = nameKeyboard;
            m_nameApplication.Add(nameApplication);
            //init visuel
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
                    var keyboardClass = new K_Intellipad(this);
                    panel_keyboard.Controls.Add(keyboardClass);
                    // init value 
                    m_sizeButtonKeyboard = 50;
                    m_nbMaxBank = 4;
                    initData();
                }
                else if (nameKeyboard == "testkeyboard")
                {
                    var keyboardClass = new K_testkeyboard(this);
                    panel_keyboard.Controls.Add(keyboardClass);
                    // init value 
                    m_sizeButtonKeyboard = 5;
                    m_nbMaxBank = 2;
                    initData();
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
          #       INIT KEYBOARD DATA            #
          #######################################*/
        private void initData()
        {
            int bank = 0;
            // Récupérer valeur ID Apllication
            ApplicationData applicationData = new ApplicationData();
            Model.Application application = applicationData.readByName(m_nameApplication[0]);//modifier siil est appeler autre par que le constructeur et detecter quelel application est charger
            //ID pofil sera modifier dans JointPAC lors de la sauvegarde
            // init list JointPAC
            for (int y=0; y<m_nbMaxBank;y++)
            {
                bank = y + 1;
                for (int i = (y*m_sizeButtonKeyboard); i < (m_sizeButtonKeyboard * (y+1)); i++)
                {
                    JointPAC jointPAC = new JointPAC(0, bank, 1, application.getId(), 0); // do it
                    m_listJointPAC.Add(jointPAC);
                    m_listCommandUser.Add(null);
                    m_listParamUser.Add(null);
                }
            }
        }
        public void loadKeyboard()
        {
            //init data 
            
            //charge data

            //afficher visuel
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

        /*#######################################
          #    CODE GESTION DRAG AND DROP       #
          #######################################*/
        private void listViewBtns_MouseDown(object sender, MouseEventArgs e)
        {
            Point mouseDownLocation = new Point(e.X, e.Y);
            // Récupérer l'index
            ListViewHitTestInfo info = listViewBtns.HitTest(e.X, e.Y);
            if (info.Item != null) { countListBtn = info.Item.Index;}
            // Set données
            CommandData commandData = new CommandData();
            Command command = commandData.readByName(listViewBtns.Items[countListBtn].Text);
            setCommand(command);
            //Les mystères de la vie
            listViewBtns.Focus();
            //listViewBtns.Invalidate();
        }

        /*#######################################
          #          GETTER / SETTER            #
          #######################################*/
        // [Getter/Setter] int m_bank
        public int getBank()
        {
            return this.m_bank;
        }
        public void setBank(int bank)
        {
            this.m_bank = bank;
        }
        // [Getter/Setter] int m_bank
        public int getNbMaxBank()
        {
            return this.m_nbMaxBank;
        }
        public void setNbMaxBank(int nbMaxBank)
        {
            this.m_nbMaxBank = nbMaxBank;
        }
        // [Getter/Setter] int m_bank
        public int getSizeButtonKeyboardk()
        {
            return this.m_sizeButtonKeyboard;
        }
        public void setSizeButtonKeyboardk(int sizeButtonKeyboard)
        {
            this.m_sizeButtonKeyboard = sizeButtonKeyboard;
        }
        // [Getter/Setter] List<JointPAC> m_listJointPAC
        public List<JointPAC> getListJointPAC()
        {
            return this.m_listJointPAC;
        }
        public void setListJointPAC(List<JointPAC> listJointPAC)
        {
            this.m_listJointPAC = listJointPAC;
        }
        // [Getter/Setter] Command m_commandDragAndDrop
        public Command getCommand()
        {
            return this.m_commandDragAndDrop;
        }
        public void setCommand(Command command)
        {
            this.m_commandDragAndDrop = command;
        }
        // [Getter/Setter] List<CommandUser> m_listCommandUser
        public List<CommandUser> getListCommandUser()
        {
            return this.m_listCommandUser;
        }
        public void setListCommandUser(List<CommandUser> commandUser)
        {
            this.m_listCommandUser = commandUser;
        }
        // [Getter/Setter] List<List<ParamUser>> m_listParamUser
        public List<List<ParamUser>> getListParamUser()
        {
            return this.m_listParamUser;
        }
        public void setListParamUser(List<List<ParamUser>> listParamUser)
        {
            this.m_listParamUser = listParamUser;
        }
        /*#######################################
          #             SAUVEGARDER             #
          #######################################*/
        private void btn_save_Click(object sender, EventArgs e)
        {
            //crée profil bd et editer object jointpac
        }
    }
}
