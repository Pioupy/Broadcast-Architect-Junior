using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using BAJunior.Model;
using log4net;
using log4net.Config;
using BAJunior.View.Forms.user;

namespace BAJunior.ServiceData
{
    class Xml
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(ApplicationData));
        private XmlDocument m_xmlDoc = new XmlDocument();
        private static String m_xmlFile = "C:////Users//Alex.G//Source//Repos//Broadcast-Architect-Junior//BAJunior//BAJunior//bin/Debug//profil_test.xml";
        private U_AddProfil m_addProfil;
        public Xml()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
        }
        public Xml(U_AddProfil addProfil)
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_addProfil = addProfil;
        }
        
        private bool loadXml()
        {
            try
            {
                m_xmlDoc.Load(m_xmlFile);
                return true;
            }
            catch
            {
                _log.Error("XML file has not been charged.");
                return false;
            }
        }
        public List<String> readNameProfil(String  nameClavier)
        {
            // init variable
            List<String> listNameProfil = new List<string>();
            // - Load 
            if (loadXml() == true)
            {
                // Parse - Récupérer les noeud dans defaultProdils
                XmlNodeList nodeKeyboard = m_xmlDoc.SelectNodes("/defaultProfils/keyboard");
                //Lister les noms des keyboards
                foreach (XmlNode node in nodeKeyboard)
                {
                    // Identifier le clavier que l'on cherche
                    String name = node.Attributes.GetNamedItem("name").Value;
                    if (name == nameClavier)
                    {
                        //récupérer les nom des profils associées au clavier.
                        XmlNodeList nodeProfil = node.SelectNodes("profil");
                        foreach (XmlNode nodebis in nodeProfil)
                        {
                            XmlNodeList nodeNameProfil = nodebis.SelectNodes("name");
                            foreach (XmlNode nodebisbis in nodeNameProfil)
                            {
                                listNameProfil.Add(nodebisbis.InnerText);
                            }
                        }
                    }
                }
            }
            //tester son nombre au retour pour savori si on doit l'afficher
            return listNameProfil;
        }
        public void loadProfil(String nameClavier, String nameProfil)
        {
            // init variable
            List<String> listNameProfil = new List<string>();
            List<JointPAC> listJointPAC = new List<JointPAC>();
            List<CommandUser> listCommandUser = new List<CommandUser>();
            List<List<ParamUser>> listParamUser = new List<List<ParamUser>>();
            // init list
            List<String> listNameCommand = new List<string>();
            List<String> listBtnKeyboard = new List<string>();
            List<String> listPicture = new List<string>();
            List<ParamUser> listParam = new List<ParamUser>();
            for (int i = 0; i < m_addProfil.getSizeButtonKeyboard(); i++)
            {
                listCommandUser.Add(null);
                listParamUser.Add(null);
            }
            // - Load 
            if (loadXml() == true)
            {
                
                // Parse - Récupérer les noeud dans defaultProdils
                XmlNodeList nodeKeyboard = m_xmlDoc.SelectNodes("/defaultProfils/keyboard");
                //Lister les noms des keyboards
                foreach (XmlNode node in nodeKeyboard)
                {
                    // Identifier le clavier que l'on cherche
                    String name = node.Attributes.GetNamedItem("name").Value;
                    if (name == nameClavier)
                    {
                        //récupérer les nom des profils associées au clavier.
                        XmlNodeList nodeProfil = node.SelectNodes("profil");
                        foreach (XmlNode nodebis in nodeProfil)
                        {
                            XmlNodeList nodeNameProfil = nodebis.SelectNodes("name");
                            foreach (XmlNode nodebisbis in nodeNameProfil)
                            {
                                //listNameProfil.Add(nodebisbis.InnerText);
                                if (nodebisbis.InnerText == nameProfil)
                                {
                                    //aller dans "boutons"
                                    XmlNodeList nodeBouttons = nodebis.SelectNodes("buttons");
                                    foreach (XmlNode nodeboutons in nodeBouttons)
                                    {
                                        //récuperer les commands
                                        XmlNodeList nodeCommands = nodeboutons.SelectNodes("command");
                                        foreach (XmlNode nodebisCommands in nodeCommands)
                                        {
                                            //récuperer les noms des commands
                                            XmlNodeList nodeNameCommand = nodebisCommands.SelectNodes("commandName");
                                            foreach (XmlNode nodebisNameCommand in nodeNameCommand)
                                            {
                                                //stoker data suivante:
                                                listNameCommand.Add(nodebisNameCommand.InnerText);
                                            }
                                            //récuperer les image des commands
                                            XmlNodeList nodeImage = nodebisCommands.SelectNodes("picture");
                                            foreach (XmlNode nodebisImage in nodeImage)
                                            {
                                                //stoker data suivante:
                                                listPicture.Add(nodebisImage.InnerText);
                                            }
                                            //récuperer les btkkeyboard des commands
                                            XmlNodeList nodeBtnKeyboard = nodebisCommands.SelectNodes("btnkeyboard");
                                            foreach (XmlNode nodebisBtnKeyboard in nodeBtnKeyboard)
                                            {
                                                //stoker data suivante:
                                                listBtnKeyboard.Add(nodebisBtnKeyboard.InnerText);
                                            }
                                            //récuperer les params
                                            XmlNodeList nodeParam = nodebisCommands.SelectNodes("parameter");
                                            foreach (XmlNode nodebisParam in nodeParam)
                                            {
                                                //récuperer les valeurs des  params
                                                
                                                XmlNodeList nodeParamValue = nodebisParam.SelectNodes("valueParameter");
                                                foreach (XmlNode nodebisParamValue in nodeParamValue)
                                                {
                                                    //stoker data suivante:
                                                    String valueParam = nodebisParamValue.InnerText;
                                                    ParamUser paramUser = new ParamUser("defaltValue", valueParam, false, 1);
                                                    listParam.Add(paramUser);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //reucpe value
            for (int i = 0; i < listNameCommand.Count; i++)
            {
                CommandUser commandUser = new CommandUser(listNameCommand[i], listPicture[i], 1);
                //listCommandUser.Add(commandUser);
                listCommandUser[Int32.Parse(listBtnKeyboard[i])] = commandUser;
                List<ParamUser> list = new List<ParamUser>();
                for( int y=0; y<14;y++)
                {
                    list.Insert(y, listParam[y]);
                }
                //listParamUser.Add(list);
                listParamUser[Int32.Parse(listBtnKeyboard[i])] = list;
                listParam.RemoveRange(0, 14);
            }
            //set les value !!!
            m_addProfil.setListCommandUser(listCommandUser);
            m_addProfil.setListParamUser(listParamUser);
        }
    }
}
