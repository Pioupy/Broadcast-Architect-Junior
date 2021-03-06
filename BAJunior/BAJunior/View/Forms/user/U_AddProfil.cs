﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using BAJunior.ServiceData;
using BAJunior.Model;
using System.IO;

namespace BAJunior.View.Forms.user
{
    public partial class U_AddProfil : Form
    {
        // 
        private int m_status; // <=0 = addProfil, >= 1 = EditProfil
        private User m_user; // information user current
        private String m_nameProfile;
        private String m_nameKeyboard;
        private List<String> m_nameApplication = new List<string>(); // list of application
        private String m_applicationSelected; // 
        private int m_focusApplication; // focus on application current
        private Command m_commandDragAndDrop;
        private Profil m_profil = null;
        private int m_countListBtn;
        private int m_sizeButtonKeyboard;
        private int m_bank = 1;
        private int m_nbMaxBank;
        //init data
        JointPACData m_jointPACData = new JointPACData();
        CommandData m_commandData = new CommandData();
        CommandUserData m_commandUserData = new CommandUserData();
        ParamUserData m_paramUserData = new ParamUserData();
        ProfilData m_profilData = new ProfilData();
        KeyboardData m_keyboardData = new KeyboardData();
        ApplicationData m_applicationData = new ApplicationData();
        UserData m_userData = new UserData();
        //Init list
        private List<PictureBox> m_pictureBox = new List<PictureBox>();
        private List<JointPAC> m_listJointPAC = new List<JointPAC>();
        private List<CommandUser> m_listCommandUser = new List<CommandUser>();
        private List<List<ParamUser>> m_listParamUser = new List<List<ParamUser>>();
        private List<List<CommandUser>> m_listCommandUserFinal = new List<List<CommandUser>>();
        private List<List<List<ParamUser>>> m_listParamUserFinal = new List<List<List<ParamUser>>>();
        // Init Keyboard 
        K_Intellipad m_intelipadClass;
        K_testkeyboard m_testKeyboardClass;
        /// <summary>
        /// Custom constructor 
        /// </summary>
        public U_AddProfil()
        {
            InitializeComponent();
        }
        /// <summary>
        ///     Constructor for Edit
        /// </summary>
        /// <param name="idProfil"></param>
        public U_AddProfil(int idProfil)
        {
            InitializeComponent();
            m_status = 1;
            initForm();
            // Recover list
            // ==> profil
            m_profil = m_profilData.read(idProfil);
            m_nameProfile = m_profil.getName();
            labelNameProfile.Text = m_nameProfile;
            // ==> user 
            User user = m_userData.read(m_profil.getIdUser());
            m_user = user;
            // ==> keyboard
            Keyboard keyboard = m_keyboardData.read(m_profil.getIdKeyboard());
            m_nameKeyboard = keyboard.getName();
            labelKeyboard.Text = m_nameKeyboard;
            initKeyboard();
            // ==> jointPAC
            List<JointPAC> listJointPAC = m_jointPACData.readAllApplicationByProfil(m_profil.getId());
            // ==> application
            List<Model.Application> listApplication = new List<Model.Application>();
            foreach (JointPAC jointPAC in listJointPAC)
            {
                Model.Application application = m_applicationData.read(jointPAC.getIdApplication());
                if (!listApplication.Exists(x => x.getId() == application.getId()))
                {
                    listApplication.Add(application);
                }
            }
            foreach (Model.Application application in listApplication)
            {
                m_nameApplication.Add(application.getName());
            }
            m_applicationSelected = m_nameApplication[0];
            m_focusApplication = 0;
            foreach (Model.Application application in listApplication)
            {
                lv_application.Items.Add(application.getName());
            }
            lv_application.Items[0].BackColor = Color.Green;
            // Load Data
            initData();
            foreach (Model.Application applicationList in listApplication)
            {
                foreach (JointPAC joint in listJointPAC)
                {
                    if (applicationList.getId()==joint.getIdApplication())
                    {
                        int i = (joint.getBtnKeyboard() + ((joint.getBank()) - 1) * m_sizeButtonKeyboard);
                        CommandUser commandUser = m_commandUserData.read(joint.getIdCommandUser());
                        m_listCommandUser[i] = commandUser;
                        List<ParamUser> listParamUser = m_paramUserData.readbyCommand(joint.getIdCommandUser());
                        m_listParamUser[i] = listParamUser;
                    }
                }

                m_listCommandUserFinal.Add(m_listCommandUser.ToList());
                m_listParamUserFinal.Add(m_listParamUser.ToList());
                // Clean list
                m_listCommandUser.Clear();
                m_listParamUser.Clear();
                initData();
            }
            m_listCommandUser = m_listCommandUserFinal[0];
            m_listParamUser = m_listParamUserFinal[0];
            // Show picture
            loadKeyboard();
            //init data form ( name, etc )
            this.Name = "U_AddProfil";
            this.Text = "Edit";
        }
        /// <summary>
        /// Second constructor for Add profil
        /// </summary>
        /// <param name="user"></param>
        /// <param name="nameProfile"></param>
        /// <param name="nameKeyboard"></param>
        /// <param name="nameApplication"></param>
        public U_AddProfil(User user, String nameProfile, String nameKeyboard, String nameApplication)
        { // call by U_PreConfAddProfil
            InitializeComponent();
            // init values 
            m_status = 0;
            m_user = user;
            m_nameProfile = nameProfile;
            m_nameKeyboard = nameKeyboard;
            m_nameApplication.Add(nameApplication);
            m_applicationSelected = nameApplication;
            m_focusApplication = 0;
            //init visuel
            labelNameProfile.Text = nameProfile;
            labelKeyboard.Text = nameKeyboard;
            lv_application.Items.Add(nameApplication);
            lv_application.Items[0].BackColor = Color.Green;
            initForm();
            initKeyboard();
            initData();
        }
        /*#######################################
          #       INIT KEYBOARD DATA            #
          #######################################*/
        /// <summary>
        /// Initionaliza keyboard
        /// </summary>
        private void initKeyboard()
        {
            // Gestion de l'affichage/génération du clavier  par défaut
            if (m_nameKeyboard == "Intellipad")
            {
                m_intelipadClass = new K_Intellipad(this);
                panel_keyboard.Controls.Add(m_intelipadClass);
                // init values
                m_sizeButtonKeyboard = 24;
                m_nbMaxBank = 4;
            }
            else if (m_nameKeyboard == "testkeyboard")
            {
                m_testKeyboardClass = new K_testkeyboard(this);
                panel_keyboard.Controls.Add(m_testKeyboardClass);
                // init values
                m_sizeButtonKeyboard = 5;
                m_nbMaxBank = 2;
            }
            else
            {
                //Manage futur error !
                MessageBox.Show("Le clavier n'est pas identifié.");
            }
        }
        /// <summary>
        /// Initialize visual
        /// </summary>
        private void initForm()
        {
            List<Command> listBtns;
            string pathImage = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + Properties.Settings.Default.DefaultImagePath;
            pathImage = pathImage.Replace("file:\\", "");

            // Gestion de l'affichage de la liste des boutons
            listBtns = m_commandData.readAll();
            var imageList = new ImageList();
            foreach (Command cmd in listBtns)
            {
                Bitmap img = (Bitmap)Image.FromFile(pathImage + "//" +cmd.getPicture(), true);
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
            List<String> defaultProfilsList = xml.readNameProfil(m_nameKeyboard);
            Button button;
            int i = 0;
            foreach (String name in defaultProfilsList)
            {
                button = new Button();
                button.Text = name;
                button.Width = 100; // chure ? 
                button.Location = new Point(0 + i * 100, 0);//prend pas en compte le retourn a la ligne du panel 
                button.Click += button_Click_Default_Profils; // ajout de l'event onClick
                panelDefaultProfils.Controls.Add(button);
                //faire en sorte que le btn sois auto size
                //je crois que le bouton en faite se crée par dessus le premier !!!
                i++;
            }
        }
        /// <summary>
        /// Initialize Data
        /// </summary>
        private void initData()
        {
            int bank = 0;
            int idPositionCommand = 0;
            // Récupérer valeur ID Apllication
            Model.Application application = m_applicationData.readByName(m_nameApplication[m_focusApplication]);
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
            xml.loadProfil(m_nameKeyboard, "Firefox");
            if (m_nameKeyboard == "Intellipad")
            {
                //intelipadClass.
                m_intelipadClass.setListCommandUser(m_listCommandUser);
                m_intelipadClass.setListParamUser(m_listParamUser);
                //m_testKeyboardClass.loadKeyboard();
                loadKeyboard();
            }
            else if (m_nameKeyboard == "testkeyboard")
            {
                m_testKeyboardClass.setListCommandUser(m_listCommandUser);
                m_testKeyboardClass.setListParamUser(m_listParamUser);
                //m_testKeyboardClass.loadKeyboard();
                loadKeyboard();
            }
            // else if other keyboard
            else
            {
                //gerer lerreur affichage !
                MessageBox.Show("Le clavier n'est pas identifé.");
            }
        }
        public void loadKeyboard()
        {
            //init data 
            string pathImage = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + Properties.Settings.Default.DefaultImagePath;
            pathImage = pathImage.Replace("file:\\", "");
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
                    m_pictureBox[iForPictureBox].Image = Image.FromFile(pathImage + "//" + m_listCommandUser[i].getPicture(), true);
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
                for (int i=0;i<m_nameApplication.Count;i++)
                {
                    lv_application.Items[i].BackColor = Color.White;
                }
                lv_application.Items[m_focusApplication].BackColor = Color.Green;
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
          #    CODE GESTION DRAG AND DROP       #
          #######################################*/
        private void listViewBtns_MouseDown(object sender, MouseEventArgs e)
        {
            Point mouseDownLocation = new Point(e.X, e.Y);
            // Récupérer l'index
            ListViewHitTestInfo info = listViewBtns.HitTest(e.X, e.Y);
            if (info.Item != null) { m_countListBtn = info.Item.Index;}
            // Set données
            Command command = m_commandData.readByName(listViewBtns.Items[m_countListBtn].Text);
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
            //add
            if (m_status==0)
            {
                DialogResult result = MessageBox.Show("Sauvegarder le profil ?", "Message de confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
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
                        foreach (CommandUser commandUser in listCommandUser)
                        {
                            if (commandUser != null)
                            {
                                m_commandUserData.create(commandUser);
                                int id = m_commandUserData.readLastID();
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
                    foreach (List<List<ParamUser>> listOfListParamUser in m_listParamUserFinal)
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
                                    m_paramUserData.create(paramUser);
                                    int id = m_paramUserData.readLastID();
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
                    Keyboard keyboard = m_keyboardData.readByName(m_nameKeyboard);
                    Profil profil = new Profil(m_nameProfile, "passif ", m_user.getId(), keyboard.getId());
                    m_profilData.create(profil);
                    int idProfil = m_profilData.readLastID();
                    int indexBtn = 0;
                    int indexJoint = 0;
                    int index = 0;
                    foreach (List<CommandUser> listCommandUser in m_listCommandUserFinal)
                    {
                        index = 0;
                        indexBtn = 0;
                        foreach (CommandUser commandUser in listCommandUser)
                        {
                            if (commandUser != null)
                            {
                                JointPAC jointPAC = new JointPAC(indexBtn, m_listJointPAC[index].getBank(), idProfil, m_listJointPAC[indexJoint].getIdApplication(), listCommandUser[index].getId());
                                // Insert database jointPAC
                                m_jointPACData.create(jointPAC);

                            }
                            else
                            {
                                //supprimer champs 
                            }
                            if (indexBtn >= (m_sizeButtonKeyboard-1))
                            {
                                indexBtn = 0;
                            }
                            else
                            {
                                indexBtn++;
                            }
                            index++;
                            indexJoint++;
                        }
                    }
                    //close form 
                    this.Close();
                    //charger la fenetre dans la fenetre ? 
                }
            }
            else
            {//edit
                DialogResult result = MessageBox.Show("Sauvegarder le profil ?", "Message de confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
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
                        foreach (CommandUser commandUser in listCommandUser)
                        {
                            if (commandUser != null)
                            {
                                if (commandUser.getId() == 0)
                                { //add
                                    m_commandUserData.create(commandUser);
                                    int id = m_commandUserData.readLastID();
                                    commandUser.setId(id);
                                }
                                else
                                { //update
                                    m_commandUserData.update(commandUser);
                                    //int id = m_commandUserData.readLastID();
                                    //commandUser.setId(id);
                                }
                            }
                            else
                            {
                                //supprimer champs list
                            }
                        }
                    }
                    //AJOUTER ID COMMAND DANS LES LIST PARAM !
                    int indexApplication = 0;
                    foreach (List<List<ParamUser>> listOfListParamUser in m_listParamUserFinal)
                    {
                        int indexList = 0;
                        List<CommandUser> listCommandUser = m_listCommandUserFinal[indexApplication];
                        foreach (List<ParamUser> listParamUser in listOfListParamUser)
                        {
                            if (listParamUser != null)
                            {
                                foreach (ParamUser paramUser in listParamUser)
                                {
                                    if (paramUser.getId() == 0)
                                    { //add
                                        paramUser.setIdCommandUser(listCommandUser[indexList].getId());
                                        m_paramUserData.create(paramUser);
                                        int id = m_paramUserData.readLastID();
                                        paramUser.setId(id);
                                    }
                                    else
                                    { //update
                                        paramUser.setIdCommandUser(listCommandUser[indexList].getId());
                                        m_paramUserData.update(paramUser);
                                        //int id = m_paramUserData.readLastID();
                                        //paramUser.setId(id);
                                    }
                                }

                            }
                            indexList++;
                        }
                        indexApplication++;
                    }
                    // TESTER ET VALIDER LES IDCOMMANDUSER
                    //crée les data jointPAC
                    // get idprofil !!!
                    Keyboard keyboard = m_keyboardData.readByName(m_nameKeyboard);
                    //Profil profil = new Profil(m_nameProfile, "passif ", m_user.getId(), keyboard.getId());
                    //m_profilData.create(profil);
                    int idProfil = m_profil.getId();
                    int indexBtn = 0;
                    int indexJoint = 0;
                    int index = 0;
                    foreach (List<CommandUser> listCommandUser in m_listCommandUserFinal)
                    {
                        index = 0;
                        indexBtn = 0;
                        foreach (CommandUser commandUser in listCommandUser)
                        {
                            if (commandUser != null)
                            {
                                int count = m_jointPACData.countIDCommandUser(commandUser.getId());
                                if (count == 0)
                                {//add
                                    JointPAC jointPAC = new JointPAC(indexBtn, m_listJointPAC[index].getBank(), idProfil, m_listJointPAC[indexJoint].getIdApplication(), listCommandUser[index].getId());
                                    // Insert database jointPAC
                                    m_jointPACData.create(jointPAC);
                                }
                                else
                                {//update
                                    JointPAC jointPAC = new JointPAC(indexBtn, m_listJointPAC[index].getBank(), idProfil, m_listJointPAC[indexJoint].getIdApplication(), listCommandUser[index].getId());
                                    // Insert database jointPAC
                                    m_jointPACData.update(jointPAC);
                                }

                            }
                            else
                            {
                                //supprimer champs 
                            }
                            if (indexBtn >= (m_sizeButtonKeyboard - 1))
                            {
                                indexBtn = 0;
                            }
                            else
                            {
                                indexBtn++;
                            }
                            index++;
                            indexJoint++;
                        }
                    }
                    //close form 
                    this.Close();
                    //charger la fenetre dans la fenetre ? 
                }
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quitter l'application ?", "Message de confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //vider les data 
                m_listCommandUserFinal.Clear();
                m_listParamUserFinal.Clear();
                m_listCommandUser.Clear();
                m_listParamUser.Clear();
                m_listJointPAC.Clear();
                //close fenetre
                this.Close();
            }
            
        }
    }
}
