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
        private List<PictureBox> m_pictureBox = new List<PictureBox>();

        private U_AddProfil m_addProfil;
        public K_Intellipad()
        {
            InitializeComponent();
            m_pictureBox.InsertRange(m_pictureBox.Count, new List<PictureBox> { key1, key2, key3, key4, key5, key6, key7, key8, key9, key10, key11, key12, key13, key14, key15, key16, key17, key18, key19, key20, key21, key22, key23, key24, key25, key26, key27, key28 });
        }
        public K_Intellipad(U_AddProfil addProfil)
        {
            InitializeComponent();
            m_addProfil = addProfil;

            m_pictureBox.InsertRange(m_pictureBox.Count, new List<PictureBox> { key1, key2, key3, key4, key5, key6, key7, key8, key9, key10, key11, key12, key13, key14, key15, key16, key17, key18, key19, key20, key21, key22, key23, key24, key25, key26, key27, key28 });
        }
        private void key1_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("effectuer vos tests avec keyboardtest");
        }

        public void setPicture1(string[] image)
        {
            string pathImage = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + Properties.Settings.Default.DefaultImagePath;
            pathImage = pathImage.Replace("file:\\", "");

            int i = 0;
            foreach(PictureBox img in m_pictureBox)
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
