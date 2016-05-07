using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using BAJunior.Model;
using log4net;
using log4net.Config;

namespace BAJunior.ServiceData
{
    class Xml
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(ApplicationData));
        private XmlDocument m_xmlDoc = new XmlDocument();
        private static String m_xmlFile = "C:////Users//Alex.G//Source//Repos//Broadcast-Architect-Junior//BAJunior//BAJunior//bin/Debug//profil_test.xml";
        public Xml()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
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
        public void loadProfil(int idClavier)
        {   
            //load xml

            //parse

            //identifier les profil
        }
    }
}
