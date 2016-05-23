using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAJunior.Model;
using System.IO;
using BAJunior.ServiceData;

namespace BAJunior.View.Forms.user
{
    public partial class K_testkeyboard : UserControl
    {
        //private int sizeKeyboard = 5;
        private U_AddProfil m_addProfil;
        private List<PictureBox> m_pictureBox = new List<PictureBox>();
        private List<JointPAC> m_listJointPAC = new List<JointPAC>();
        private List<CommandUser> m_listCommandUser = new List<CommandUser>();
        private List<List<ParamUser>> m_listParamUser = new List<List<ParamUser>>();
        
        public K_testkeyboard()
        {
            InitializeComponent();
        }
        public K_testkeyboard(U_AddProfil addProfil)
        {
            InitializeComponent();
            m_addProfil = addProfil;
            // init value
            this.m_listJointPAC = m_addProfil.getListJointPAC();
            this.m_listCommandUser = m_addProfil.getListCommandUser();
            this.m_listParamUser = m_addProfil.getListParamUser();
            // init list PictureBox
            m_pictureBox.InsertRange(m_pictureBox.Count, new List<PictureBox> { pictureBox3, key1, key6, pictureBox2, pictureBox1 });

        }
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
                pictureBox.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\bin\\Debug\\Image\\" + command.getPicture(), true);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;// mettre l'image a la taille de la box
                                                                       // Les mysteère de la vie : 
                pictureBox.Invalidate();
            }
            else
            {
                MessageBox.Show("Bouton annuler");
            }
        }

        private int getID(int [] id)
        {
            int ID=0;
            for(int i = 0; i <= m_addProfil.getNbMaxBank(); i++)
            {
                if (m_addProfil.getBank() == (i+1))
                {
                    ID=id[i];
                    break;
                }
            }
            return ID;
        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 0, 5};
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(pictureBox3, ID);
        }
        private void key1_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 1, 6 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key1, ID);
        }

        private void key6_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 2, 7 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(key6, ID);
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 3, 8 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(pictureBox2, ID);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int[] idChoise = new int[] { 4, 9 };
            int ID = getID(idChoise);
            genetiqueMethodeeEvent(pictureBox1, ID);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            m_addProfil.setBank(1);
            //charger clavier
            loadKeyboard();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //charger clavier
            m_addProfil.setBank(2);
            loadKeyboard();
        }
        
        //{ pictureBox3, key1, key6, pictureBox2, pictureBox1 }
        private void loadKeyboard()
        {
            //init data 
            int initFor = ((m_addProfil.getBank() - 1) * m_addProfil.getSizeButtonKeyboardk());
            int maxFor = (m_addProfil.getBank() * m_addProfil.getSizeButtonKeyboardk());
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
            //afficher visuel
        }
    }
}
