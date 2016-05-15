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
        private U_AddProfil m_addProfil;
        public K_testkeyboard()
        {
            InitializeComponent();
        }
        public K_testkeyboard(U_AddProfil addProfil)
        {
            InitializeComponent();
            m_addProfil = addProfil;
        }
        private void genetiqueMethodeeEvent(PictureBox pictureBox)
        {
            // Récuperer les données
            CommandData commandData = new CommandData();
            Command command = m_addProfil.getCommand();
            //vérie que le command need pas d'ajout de param
            List<Param> listParam = commandData.readParamByCommand(command.getId());
            foreach (Param param in listParam)
            {
                if (param.getIsUser() == true)
                {
                    // this WORKS !!!
                    //appelle de la form 
                    //U_AddParamInAddProfil
                }
            }
            //Charger image
            pictureBox.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\bin\\Debug\\Image\\" + command.getPicture(), true);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;// mettre l'image a la taille de la box
            // Les mysteère de la vie : 
            pictureBox.Invalidate();
            //  je suppose que cette valeur va devoir aller quelque part ? genr liste ?
        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            Point mouseUpLocation = new System.Drawing.Point(e.X, e.Y);
            // Récuperer les données
            CommandData commandData = new CommandData();
            Command command = m_addProfil.getCommand();
            //vérie que le command need pas d'ajout de param
            List<Param> listParam = commandData.readParamByCommand(command.getId());
            List<Param> listParamNeedUser = new List<Param>();
            foreach(Param param in listParam)
            {
                if(param.getIsUser() == true)
                {
                    // this WORKS !!!
                    //MessageBox.Show("les erreur sont : " + param.getName());
                    listParamNeedUser.Add(param);
                }
            }

            // tester listParamNeedUser si vide 
            if(listParamNeedUser.Count != 0)
            {
                //si pas vide appeller for U_AddParamInAddProfil
                U_AddParamInAddProfil addParamInAddProfil = new U_AddParamInAddProfil(listParamNeedUser);
                addParamInAddProfil.ShowDialog();

            }
            //Charger image
            pictureBox3.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\bin\\Debug\\Image\\" + command.getPicture(), true);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;// mettre l'image a la taille de la box
            // Les mysteère de la vie : 
            pictureBox3.Invalidate();
            //  je suppose que cette valeur va devoir aller quelque part ? genre liste ?
            //commanduser et paramuser ?
        }

        private void key1_MouseUp(object sender, MouseEventArgs e)
        {
            genetiqueMethodeeEvent(key1);
        }

        private void key6_MouseUp(object sender, MouseEventArgs e)
        {
            genetiqueMethodeeEvent(key6);
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            genetiqueMethodeeEvent(pictureBox2);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            genetiqueMethodeeEvent(pictureBox1);
        }
    }
}
