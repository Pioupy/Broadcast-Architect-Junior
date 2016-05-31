using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAJunior.ServiceData;
using BAJunior.Model;

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

        public bool objectToTxt(Profil profil)
        {
            bool result = false;
            ApplicationData appData = new ApplicationData();
            JointPACData m_JointPacData = new JointPACData();
            List<JointPAC> m_JointPac = m_JointPacData.readByProfilId(profil.getId());
            int tempIdAppli = -1;

            foreach (JointPAC listJoin in m_JointPac)
            {
                if (listJoin.getIdApplication() == tempIdAppli)
                    continue;
                else
                {
                    tempIdAppli = listJoin.getIdApplication();

                    foreach (JointPAC appli in m_JointPac.Where(item => item.getIdApplication() == listJoin.getIdApplication()).OrderBy(item => item.getIdApplication()))
                    {
                        string folder = appData.read(appli.getIdApplication()).getName();
                        int tempbank = -1;

                        if (appli.getBank() == tempbank)
                            continue;
                        else
                        {
                            List<string> lines = new List<string>();
                            tempbank = appli.getBank();

                            foreach (JointPAC banks in m_JointPac.Where(item => item.getIdApplication() == tempIdAppli && item.getBank() == appli.getBank()).OrderBy(item => item.getBtnKeyboard()))
                            {
                                CommandUserData cmdUserData = new CommandUserData();
                                List<ParamUser> ParamU = cmdUserData.readParamByCommand(banks.getIdCommandUser());
                                string line = "";

                                foreach (ParamUser param in ParamU)
                                {
                                    line = line + param.getValue() + ",";
                                }
                                lines.Add(line);

                                //Copier image dans ressource a cote
                                string pathDest = Path.Combine(Properties.Settings.Default.TextFilePath, appData.read(appli.getIdApplication()).getName(),"Ressources");
                                string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + Properties.Settings.Default.DefaultImagePath;
                                path = path.Replace("file:\\", "");
                                path = path + cmdUserData.read(banks.getIdCommandUser()).getPicture();

                                if (!Directory.Exists(pathDest))
                                    Directory.CreateDirectory(pathDest);

                                File.Copy(path, pathDest);
                            }

                            createTextFile(appData.read(appli.getIdApplication()).getName(), tempbank.ToString(), lines.ToArray());
                        }
                    }
                }
            }

            return result;
        }

    }
}
////Exemple test : 
//FileTools test = new FileTools();
//string[] lignes = new string[] { "début", "test", "2", "2,14,6,,h", "fin" };
//test.createTextFile("testFF","test", lignes);