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
        //private int fontSize = 20;
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
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            Point mouseUpLocation = new System.Drawing.Point(e.X, e.Y);
            // Récuperer les données
            CommandData commandData = new CommandData();
            Command command = m_addProfil.getCommand();
            //vérie que le command need pas d'ajout de param
            List<Param> listParam = commandData.readParamByCommand(command.getId());
            foreach(Param param in listParam)
            {
                if(param.getIsUser() == true)
                {
                    MessageBox.Show("les erreur sont : " + param.getName());
                    //appelle de la form 
                }
                else
                {
                    // pas sur de devoir faire un truc 
                }
            }
            
            //Charger image
            pictureBox3.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\bin\\Debug\\Image\\" + command.getPicture(), true);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;// mettre l'image a la taille de la box
            // Les mysteère de la vie : 
            pictureBox3.Invalidate();
            //  je suppose que cette valeur va devoir aller quelque part ? genr liste ?
        }
    }
}
