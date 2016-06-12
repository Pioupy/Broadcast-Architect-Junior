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
using System.IO;

namespace BAJunior.View.Forms.user
{
    public partial class K_Intellipad : UserControl
    {
        //private int sizeKeyboard = 5;
        private U_AddProfil m_addProfil;
        private List<PictureBox> m_pictureBox = new List<PictureBox>();
        private List<JointPAC> m_listJointPAC = new List<JointPAC>();
        private List<CommandUser> m_listCommandUser = new List<CommandUser>();
        private List<List<ParamUser>> m_listParamUser = new List<List<ParamUser>>();
        public K_Intellipad()
        {
            InitializeComponent();
            m_pictureBox.InsertRange(m_pictureBox.Count, new List<PictureBox> { key1, key2, key3, key4, key5, key6, key7, key8, key9, key10, key11, key12, key13, key14, key15, key16, key17, key18, key19, key20, key21, key22, key23, key24, bank1, bank2, bank3, bank4 });
        }
        public K_Intellipad(U_AddProfil addProfil)
        {
            InitializeComponent();
            m_addProfil = addProfil;

            // init value
            this.m_listJointPAC = m_addProfil.getListJointPAC();
            this.m_listCommandUser = m_addProfil.getListCommandUser();
            this.m_listParamUser = m_addProfil.getListParamUser();
            // init list PictureBox
            m_pictureBox.InsertRange(m_pictureBox.Count, new List<PictureBox> { key1, key2, key3, key4, key5, key6, key7, key8, key9, key10, key11, key12, key13, key14, key15, key16, key17, key18, key19, key20, key21, key22, key23, key24, bank1, bank2, bank3, bank4 });
            m_addProfil.setLispictureBox(m_pictureBox);
        }
        /*#######################################
          #           GESTION BANK              #
          #######################################*/
        private void bank1_Click(object sender, EventArgs e)
        {
            //charger clavier
            m_addProfil.setBank(1);
            //loadKeyboard();
            m_addProfil.loadKeyboard();
        }
        private void bank2_Click(object sender, EventArgs e)
        {
            //charger clavier
            m_addProfil.setBank(2);
            //loadKeyboard();
            m_addProfil.loadKeyboard();
        }
        private void bank3_Click(object sender, EventArgs e)
        {
            //charger clavier
            m_addProfil.setBank(3);
            //loadKeyboard();
            m_addProfil.loadKeyboard();
        }
        private void bank4_Click(object sender, EventArgs e)
        {
            //charger clavier
            m_addProfil.setBank(4);
            //loadKeyboard();
            m_addProfil.loadKeyboard();
        }
        /*#######################################
          #           GESTION Btn               #
          #######################################*/
        private void genetiqueMethodeeEvent(PictureBox pictureBox, int id)
        {
            bool isOk = true;
            List<ParamUser> listParamUser = new List<ParamUser>();
            List<Param> listParamNeedUser = new List<Param>();
            List<Param> getListParam = new List<Param>();
            // Récuperer la command et les params
            CommandData commandData = new CommandData();
            Command command = m_addProfil.getCommand();
            List<Param> listParam = commandData.readParamByCommand(command.getId());
            string pathImage = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + Properties.Settings.Default.DefaultImagePath;
            pathImage = pathImage.Replace("file:\\", "");

            // Search getVlaue == true
            foreach (Param param in listParam)
            {
                if (param.getIsUser() == true)
                {
                    listParamNeedUser.Add(param);
                }
            }
            // Init getValue == true 
            if (listParamNeedUser.Count != 0)
            {//si pas vide appeller for U_AddParamInAddProfil
                U_AddParamInAddProfil addParamInAddProfil = new U_AddParamInAddProfil(listParamNeedUser);
                addParamInAddProfil.ShowDialog();
                isOk = addParamInAddProfil.getIsOK();
                getListParam = addParamInAddProfil.getListParam();

            }
            if (isOk == true)
            { // afficher si not cancel init value
                int i = 0;
                foreach (Param param in listParam)
                {
                    // Init List<ParamUser> paramUser
                    if (param.getIsUser() == true)
                    {//nouvelle valeur
                        ParamUser paramUser = new ParamUser(param.getName(), getListParam[i].getValue(), param.getIsUser(), param.getIdCommand());
                        listParamUser.Add(paramUser);
                    }
                    else
                    {//old valeur
                        ParamUser paramUser = new ParamUser(param.getName(), param.getValue(), param.getIsUser(), param.getIdCommand());
                        listParamUser.Add(paramUser);
                    }
                    i++;
                }
                m_listParamUser[id] = listParamUser;
                // tester necessaire
                m_addProfil.setListParamUser(m_listParamUser);
                // Init commandUser
                CommandUser commandUser = new CommandUser(command.getId(), command.getName(), command.getPicture(), command.getIdCategory());
                m_listCommandUser[id] = commandUser;
                //tester necessaire
                m_addProfil.setListCommandUser(m_listCommandUser);
                //Charger image
                pictureBox.Image = Image.FromFile(pathImage + "\\" + command.getPicture(), true);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;// mettre l'image a la taille de la box
                                                                        // Les mysteère de la vie : 
                pictureBox.Invalidate();
            }
            else
            {
                //MessageBox.Show("Bouton annuler");
            }
        }

        private int getID(int[] id)
        {
            int ID = 0;
            for (int i = 0; i <= m_addProfil.getNbMaxBank(); i++)
            {
                if (m_addProfil.getBank() == (i + 1))
                {
                    ID = id[i];
                    break;
                }
            }
            return ID;
        }
        private void key1_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 0, 24, 48, 72 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key1, ID);
        }
        private void key2_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 1, 25, 49, 73 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key2, ID);
        }
        private void key3_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 2, 26, 50, 74 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key3, ID);
        }
        private void key4_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 3, 27, 51, 75 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key4, ID);
        }
        private void key5_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 4, 28, 52, 76 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key5, ID);
        }
        private void key6_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 5, 29, 53, 77 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key6, ID);
        }
        private void key7_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 6, 30, 54, 78 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key7, ID);
        }
        private void key8_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 7, 31, 55, 79 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key8, ID);
        }
        private void key9_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 8, 32, 56, 80 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key9, ID);
        }
        private void key10_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 9, 33, 57, 81 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key10, ID);
        }
        private void key11_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 10, 34, 58, 82 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key11, ID);
        }
        private void key12_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 11, 35, 59, 83 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key12, ID);
        }
        private void key13_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 12, 36, 60, 84 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key13, ID);
        }
        private void key14_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 13, 37, 61, 85 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key14, ID);
        }
        private void key15_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 14, 38, 62, 86 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key15, ID);
        }
        private void key16_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 15, 39, 63, 87 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key16, ID);
        }
        private void key17_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 16, 40, 64, 88 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key17, ID);
        }
        private void key18_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 17, 41, 65, 89 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key18, ID);
        }
        private void key19_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 18, 42, 66, 90 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key19, ID);
        }
        private void key20_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 19, 43, 67, 91 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key20, ID);
        }
        private void key21_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 20, 44, 68, 92 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key21, ID);
        }
        private void key22_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 21, 45, 69, 93 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key22, ID);
        }
        private void key23_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 22, 46, 70, 94 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key23, ID);
        }
        private void key24_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 23, 47, 71, 95 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key24, ID);
        }
        /*#######################################
          #          GETTER / SETTER            #
          #######################################*/
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
        /* For U_Profil */
        public void setPicture1(string[] image)
        {
            string pathImage = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + Properties.Settings.Default.DefaultImagePath;
            pathImage = pathImage.Replace("file:\\", "");

            int i = 0;
            foreach (PictureBox img in m_pictureBox)
            {
                if (image[i] != null && image[i] != "")
                {
                    img.Image = Image.FromFile(pathImage + "\\" + image[i]);
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    img.Image = null;
                }
                i++;
            }
        }

        public void setPictureToZero()
        {
            foreach (PictureBox img in m_pictureBox)
            {
                img.Image = null;
            }
        }

        //public void setPicture2(Bitmap image)
        //{
        //    key2.Image = image;
        //}

    }
}
