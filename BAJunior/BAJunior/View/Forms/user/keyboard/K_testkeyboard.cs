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
        private int sizeKeyboard = 5;
        private U_AddProfil m_addProfil;
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
            for(int i=0;i<sizeKeyboard;i++)
            {
                m_listCommandUser.Add(null);
                m_listParamUser.Add(null);
            }
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
                m_listParamUser.Insert(id, listParamUser);
                // Init commandUser
                CommandUser commandUser = new CommandUser(command.getId(), command.getName(), command.getPicture(), command.getIdCategory());
                m_listCommandUser.Insert(id, commandUser);
                //Charger image
                pictureBox3.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\bin\\Debug\\Image\\" + command.getPicture(), true);
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;// mettre l'image a la taille de la box
                                                                       // Les mysteère de la vie : 
                pictureBox3.Invalidate();
            }
            else
            {
                MessageBox.Show("Bouton annuler");
            }
        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            // init variable local 
            int ID = 3;
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
                if(param.getIsUser() == true)
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
            if(isOk == true)
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
                m_listParamUser.Insert(ID, listParamUser);
                //commanduser et paramuser ?
                // Init commandUser
                CommandUser commandUser = new CommandUser(command.getId(), command.getName(), command.getPicture(), command.getIdCategory());
                m_listCommandUser.Insert(ID, commandUser);
                //Charger image
                pictureBox3.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\bin\\Debug\\Image\\" + command.getPicture(), true);
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;// mettre l'image a la taille de la box
                                                                       // Les mysteère de la vie : 
                pictureBox3.Invalidate();
            }
            else
            {
                MessageBox.Show("Bouton annuler");
            }
        }
        // [Getter/Setter] List<CommandUser> m_listCommandUser
        public List<CommandUser> getCommandUser()
        {
            return this.m_listCommandUser;
        }
        public void setCommandUser(List<CommandUser> commandUser)
        {
            this.m_listCommandUser = commandUser;
        }
        private void key1_MouseUp(object sender, MouseEventArgs e)
        {
            int ID = 1;
            genetiqueMethodeeEvent(key1, ID);
        }

        private void key6_MouseUp(object sender, MouseEventArgs e)
        {
            int ID = 2;
            genetiqueMethodeeEvent(key6, ID);
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            int ID = 3;
            genetiqueMethodeeEvent(pictureBox2, ID);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int ID = 4;
            genetiqueMethodeeEvent(pictureBox1, ID);
        }
    }
}
