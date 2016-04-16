using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.ServiceMétier
{
    class FileTools
    {
        //  private static readonly ILog _log = LogManager.GetLogger(typeof(string));

        /// <summary>
        /// Create a text file with custom content in custom folder
        /// </summary>
        /// <param name="folder">Folder's name</param>
        /// <param name="txtName">Text file name</param>
        /// <param name="lines">String Table of command</param>
        /// <returns></returns>
        public bool createTextFile(string folder, string txtName, string[] lines)
        {
            bool result = false;
            string path = Path.Combine(Properties.Settings.Default.TextFilePath, folder);

            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                FileStream fs1 = new FileStream(path + "\\" + txtName + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs1);
                writer.Write(Properties.Settings.Default.TextFileHeader + "\r\n");

                foreach (string line in lines)
                {
                    writer.Write(line + "\r\n");
                }
                writer.Close();

              //  _log.Info("File "+ path + "\\" + txtName + ".txt has been created.");
                result = true;
            }
            catch
            {
                //  _log.Warn("File "+ path + "\\" + txtName + ".txt has not been created.");
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Create a image file 
        /// </summary>
        /// <param name="folder">Folder's name</param>
        /// <param name="imageName">Image name</param>
        /// <returns></returns>
        public bool createImageFile(string folder, string imageName) //TODO : rajouter fonction image...
        {
            bool result = false;
            string path = Path.Combine(Properties.Settings.Default.TextFilePath, folder, "Resources");

            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                //  _log.Info("File "+ path + "\\" + txtName + ".txt has been created.");
                result = true;
            }
            catch
            {
                //  _log.Warn("File "+ path + "\\" + txtName + ".txt has not been created.");
                result = false;
            }

            return result;
        }
    }
}
////Exemple test : 
//FileTools test = new FileTools();
//string[] lignes = new string[] { "début", "test", "2", "2,14,6,,h", "fin" };
//test.createTextFile("testFF","test", lignes);