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
        private User m_user;
        private String m_nameProfile;
        private String m_nameKeyboard;
        private List<String> m_nameApplication = new List<string>();
        private String m_applicationSelected;
        private int m_focusApplication;
        private Command m_commandDragAndDrop;
        private int countListBtn;
        // Data table
        private int m_sizeButtonKeyboard;
        private int m_bank = 1;
        private int m_nbMaxBank;
        private List<JointPAC> m_listJointPAC = new List<JointPAC>();
        private List<CommandUser> m_listCommandUser = new List<CommandUser>();
        private List<List<ParamUser>> m_listParamUser = new List<List<ParamUser>>();
        private List<List<CommandUser>> m_listCommandUserFinal = new List<List<CommandUser>>();
        private List<List<List<ParamUser>>> m_listParamUserFinal = new List<List<List<ParamUser>>>();



        // clavier
        K_Intellipad intelipadClass;
        K_testkeyboard testKeyboardClass;
        

        private List<PictureBox> m_pictureBox = new List<PictureBox>();

        public U_AddProfil()
        {
            InitializeComponent();
        }
        public U_AddProfil(User user, String nameProfile, String nameKeyboard, String nameApplication)
        {
            InitializeComponent();
            // init value
            m_user = user;
            m_nameProfile = nameProfile;
            m_nameKeyboard = nameKeyboard;
            m_nameApplication.Add(nameApplication);
            m_applicationSelected = nameApplication;//init
            m_focusApplication = 0;
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
            int i = 0; 
            foreach (String name in defaultProfilsList) {
                button = new Button();
                button.Text = name;
                button.Width = 100; // chure ? 
                button.Location = new Point(0 + i * 100,0);//prend pas en compte le retourn a la ligne du panel 
                button.Click += button_Click_Default_Profils; // ajout de l'event onClick
                panelDefaultProfils.Controls.Add(button);
                //faire en sorte que le btn sois auto size
                //je crois que le bouton en faite se crée par dessus le premier !!!
                i ++;
            }
            // Gestion de l'affichage/génération du clavier  par défaut
            String fileKeyboard = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\View\\Forms\\user\\keyboard/K_" + nameKeyboard + ".cs";
            if (File.Exists(fileKeyboard))
            {
                if (nameKeyboard == "Intellipad")
                {
                    intelipadClass = new K_Intellipad(this);
                    panel_keyboard.Controls.Add(intelipadClass);
                    // init value 
                    m_sizeButtonKeyboard = 50;
                    m_nbMaxBank = 4;
                    initData();
                }
                else if (nameKeyboard == "testkeyboard")
                {
                    testKeyboardClass = new K_testkeyboard(this);
                    panel_keyboard.Controls.Add(testKeyboardClass);
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
            int idPositionCommand = 0;
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
                    JointPAC jointPAC = new JointPAC(idPositionCommand, bank, 1, application.getId(), 0); // do it
                    m_listJointPAC.Add(jointPAC);
                    m_listCommandUser.Add(null);
                    m_listParamUser.Add(null);
                    idPositionCommand++;
                }
            }
        }
        /*#######################################
          #       CODE GESTION XML              #
          #######################################*/
        void button_Click_Default_Profils(object obj, EventArgs e) // envent onClick pour les boutons des profils par défaut
        {
            //recuperer le nom du profil xml !!!!!!!!!!!!!!!!!!!!!!
            Xml xml = new Xml(this);
            //recup data ? 
            xml.loadProfil(m_nameKeyboard, "ProfilDos_testkeyboard");
            if (m_nameKeyboard == "Intellipad")
            {
                //intelipadClass.
            }
            else if (m_nameKeyboard == "testkeyboard")
            {
                testKeyboardClass.setListCommandUser(m_listCommandUser);
                testKeyboardClass.setListParamUser(m_listParamUser);
                testKeyboardClass.loadKeyboard();
            }
            else
            {
                //gerer lerreur affichage !
                MessageBox.Show("Le clavier n'existe pas !!! #hashtag tu as le seum ENCORE PLUS");
            }
            //fair eles inse dans le clavier 

        }
        public void loadKeyboard()
        {
            //init data 
            int initFor = ((m_bank - 1) * m_sizeButtonKeyboard);
            int maxFor = (m_bank * m_sizeButtonKeyboard);
            int iForPictureBox = 0;
            //charge data
            for (int i = initFor; i < maxFor; i++)
            {
                
                if (m_listCommandUser[i] == null)
                {//init a vide les valeur visuel
                    m_pictureBox[iForPictureBox].Image = null;
                    //mettre les autre bontou
                }
                else
                {//récupérer valeur
                    m_pictureBox[iForPictureBox].Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\bin\\Debug\\Image\\" + m_listCommandUser[i].getPicture(), true);
                    m_pictureBox[iForPictureBox].SizeMode = PictureBoxSizeMode.StretchImage;// mettre l'image a la taille de la box
                                                                                            // Les mysteère de la vie : 
                    m_pictureBox[iForPictureBox].Invalidate();
                }
                iForPictureBox++;
                
            }
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
            //Récuperer valeur via lv_application_SelectedIndexChanged
            // tester si la valeur selectionner n'est pas l'appication en cours !!!
            if (m_nameApplication.IndexOf(m_applicationSelected) != m_focusApplication)
            {
                if (m_listCommandUserFinal.Count != m_nameApplication.Count)
                {//nouvelle application
                    m_listCommandUserFinal.Add(m_listCommandUser.ToList());
                    m_listParamUserFinal.Add(m_listParamUser.ToList());
                    // Nettoyer list
                    m_listCommandUser.Clear();
                    m_listParamUser.Clear();
                    //initData();
                }
                else
                {
                    m_listCommandUserFinal[m_focusApplication] = m_listCommandUser.ToList();
                    m_listParamUserFinal[m_focusApplication] = m_listParamUser.ToList();
                    // Nettoyer list
                    m_listCommandUser.Clear();
                    m_listParamUser.Clear();
                    //init data tableau
                    //m_listCommandUser = m_listCommandUserFinal[m_nameApplication.IndexOf(m_applicationSelected)];
                    //m_listParamUser = m_listParamUserFinal[m_nameApplication.IndexOf(m_applicationSelected)];
                }
                m_focusApplication = m_nameApplication.IndexOf(m_applicationSelected);//editer valeur
                                                                                      //m_listCommandUserFinal[m_nameApplication.IndexOf(m_applicationSelected)] != null
                if (m_focusApplication <= (m_listCommandUserFinal.Count - 1))
                {
                    m_listCommandUser = m_listCommandUserFinal[m_focusApplication];
                    m_listParamUser = m_listParamUserFinal[m_focusApplication];
                }
                else
                {
                    initData();
                }

                // visuel ! 
                loadKeyboard();
                //affichage vert fond
            }
            else
            {
                //message l'appication est deja celle en cours
            }


        }
        
        public void addApplication(String application)
        {
            lv_application.Items.Add(application);
            m_nameApplication.Add(application);
            // ajouter les champs
            /*
            //init list 
            int bank = 0;
            int size = m_listCommandUser.Count;
            int idPositionCommand = 0;
            // Récupérer valeur ID Apllication
            ApplicationData applicationData = new ApplicationData();
            Model.Application applicationSelected = applicationData.readByName(application);//modifier siil est appeler autre par que le constructeur et detecter quelel application est charger
            //ID pofil sera modifier dans JointPAC lors de la sauvegarde
            // init list JointPAC
            for (int y = 1; y <= m_nbMaxBank; y++)
            {
                bank = y;
                for (int i = (size + (m_sizeButtonKeyboard * (y-1))); i < (size + (m_sizeButtonKeyboard * y )); i++)
                {
                    JointPAC jointPAC = new JointPAC(idPositionCommand, bank, 1, applicationSelected.getId(), 0); // do it
                    m_listJointPAC.Add(jointPAC);
                    m_listCommandUser.Add(null);
                    m_listParamUser.Add(null);
                    idPositionCommand++;
                }
            }
            */
        }
        private void lv_application_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_application.SelectedItems.Count > 0)
            {
                int count = lv_application.Items.IndexOf(lv_application.SelectedItems[0]);
                //recuperer champs selelectionner
                m_applicationSelected = lv_application.Items[count].Text;
            }
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
        public int getSizeButtonKeyboard()
        {
            return this.m_sizeButtonKeyboard;
        }
        public void setSizeButtonKeyboard(int sizeButtonKeyboard)
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
        // [Getter/Setter]List<PictureBox> m_pictureBox
        public List<PictureBox> getLispictureBox()
        {
            return this.m_pictureBox;
        }
        public void setLispictureBox(List<PictureBox> pictureBox)
        {
            this.m_pictureBox = pictureBox;
        }
        /*#######################################
          #             SAUVEGARDER             #
          #######################################*/
        private void btn_save_Click(object sender, EventArgs e)
        {
            // Init variable
            JointPACData jointPACData = new JointPACData();
            CommandUserData commandUserData = new CommandUserData();
            ParamUserData paramUserData = new ParamUserData();
            ProfilData profilData = new ProfilData();
            KeyboardData keyboardData = new KeyboardData();
            // Update Data of actuel keyboard
            if (m_listCommandUserFinal.Count != m_nameApplication.Count)
            {//Insert new field
                m_listCommandUserFinal.Add(m_listCommandUser.ToList());
                m_listParamUserFinal.Add(m_listParamUser.ToList());
            }
            else
            {//Update field existant
                m_listCommandUserFinal[m_focusApplication] = m_listCommandUser.ToList();
                m_listParamUserFinal[m_focusApplication] = m_listParamUser.ToList();
            }
            // Insert database list of CommandUser and ParamUser
            foreach (List<CommandUser> listCommandUser in m_listCommandUserFinal)
            {
                foreach(CommandUser commandUser in listCommandUser)
                {
                    if(commandUser != null)
                    {
                        commandUserData.create(commandUser);
                        int id = commandUserData.readLastID();
                        commandUser.setId(id);
                    }
                    else
                    {
                        //supprimer champs list
                    }
                }
            }
            //AJOUTER ID COMMAND DANS LES LIST PARAM !
            int indexApplication = 0;
            foreach(List<List<ParamUser>> listOfListParamUser in m_listParamUserFinal)
            {
                int indexList = 0;
                List<CommandUser> listCommandUser = m_listCommandUserFinal[indexApplication];
                foreach (List<ParamUser> listParamUser in listOfListParamUser)
                {
                    if (listParamUser != null)
                    {
                        foreach (ParamUser paramUser in listParamUser)
                        {
                            paramUser.setIdCommandUser(listCommandUser[indexList].getId());
                            paramUserData.create(paramUser);
                            int id = paramUserData.readLastID();
                            paramUser.setId(id);
                        }
                        
                    }
                    indexList++;
                }
                indexApplication++;
            }
            // TESTER ET VALIDER LES IDCOMMANDUSER
            //crée les data jointPAC
            // get idprofil !!!
            Keyboard keyboard = keyboardData.readByName(m_nameKeyboard);
            Profil profil = new Profil(m_nameProfile, "passif ", m_user.getId(), keyboard.getId());
            profilData.create(profil);
            int idProfil = m_user.getId();//modifier
            int indexBtn = 0;
            int index = 0;
            foreach (List<CommandUser> listCommandUser in m_listCommandUserFinal)
            {
                foreach (CommandUser commandUser in listCommandUser)
                {
                    if (commandUser != null)
                    {
                        JointPAC jointPAC = new JointPAC(indexBtn, m_listJointPAC[index].getBank(), idProfil, m_listJointPAC[index].getIdApplication(), m_listCommandUser[index].getId());
                        //m_listJointPAC[index] = jointPAC;
                        // Insert database jointPAC
                        jointPACData.create(jointPAC);

                    }
                    else
                    {
                        //supprimer champs 
                    }
                    if (indexBtn >= m_sizeButtonKeyboard)
                    {
                        indexBtn = 0;
                    }
                    else
                    {
                        indexBtn++;
                    }
                    index++;
                }
            }
            //close form 
            this.Close();
            //charger la fenetre dans la fenetre ? 

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //vider les data 

            //close fenetre
        }
    }
}
