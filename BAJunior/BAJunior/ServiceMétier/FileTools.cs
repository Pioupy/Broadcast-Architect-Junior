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

        public bool createTextFile(string generalPath, string folder, string txtName, string[] lines)
        {
            bool result = false;
            string path = Path.Combine(generalPath, folder);

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
    }
}
////Exemple test : 
//FileTools test = new FileTools();
//string[] lignes = new string[] { "début", "test", "2", "2,14,6,,h", "fin" };
//test.createTextFile(Properties.Settings.Default.TextFilePath,"testFF","test", lignes);