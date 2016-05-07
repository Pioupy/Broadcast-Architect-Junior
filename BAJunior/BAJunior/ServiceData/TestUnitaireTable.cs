using System.Collections.Generic;
using System.Windows.Forms;
using log4net;
using log4net.Config;
using BAJunior.Model;
using System.Security.Cryptography;
using System.Text;
using BAJunior.Controller;

namespace BAJunior.ServiceData
{
    //TODO : CLASSE AMENER A DISPARAITRE APRES LES TESTS !!!!!!!!!!!!!!!!!!!!!!
    class TestUnitaireTable
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(TestUnitaireTable));
        private static DbUtils m_dbUtils;
        private bool seeMessage = false;
        public TestUnitaireTable()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_dbUtils = new DbUtils();
        }
        /* #####################################################
           #               Début méthode test !!!              #
           #####################################################*/
        public void testProfil()
        {
            //Initiation Variable : 
            ProfilData profilData = new ProfilData();
            Profil profilOne = new Profil("testProfil1", "actif", 1, 1);
            //Erreur devrait survenir :
            Profil profilTwo = new Profil("testProfil2", "passif", 2, 2);
            // insert valeur 
            profilData.create(profilOne);
            profilData.create(profilTwo);
            // read values 
            profilOne = profilData.read(1);
            profilTwo = profilData.read(2);
            if (seeMessage == true)
            {
                MessageBox.Show("Profil One :" + profilOne.getName());
                MessageBox.Show("Profil two :" + profilTwo.getName());
            }
            // update values 
            profilOne.setName("testProfilUpdate");
            profilData.update(profilOne);
            // read values
            if (seeMessage == true)
            {
                List<Profil> result = profilData.readAll();
                for (int i = 0; i < result.Count; i++)
                {
                    MessageBox.Show("Profil " + i + " : " + result[i].getName());
                }
            }
            // delete values
            profilData.delete(profilTwo);
            // read value
            if (seeMessage == true)
            {
                List<Profil> resultAll = profilData.readAll();
                for (int i = 0; i < resultAll.Count; i++)
                {
                    MessageBox.Show("Profil " + i + " : " + resultAll[i].getName());
                }
            }
        }
        /* #####################################################
           #                Fin méthode test !!!               #
           #####################################################*/
        public void testUser()
        {
            //Initiation Variable : 
            UserData userData = new UserData();
            User userOne = new User("test1", "test1", false);
            User userTwo = new User("test2", "test2", true);
            // insert valeur 
            userData.create(userOne);
            userData.create(userTwo);
            // read values 
            //userOne = userData.read(1);
            userOne = userData.readByName("admin");
            userTwo = userData.read(2);
            if (seeMessage == true)
            {
                
                MessageBox.Show("User One :" + userOne.getLogin());
                MessageBox.Show("User two :" + userTwo.getLogin());
            }
            // update values 
            userOne.setLogin("administrateur");
            userData.update(userOne);
            // read values
            if (seeMessage == true)
            {
                List<User> result = userData.readAll();
                for (int i = 0; i < result.Count; i++)
                {
                    MessageBox.Show("User " + i + " : " + result[i].getLogin());
                }
            }
            // delete values
            userData.delete(userTwo);
            // read value
            if (seeMessage == true)
            {
                List<User> resultAll = userData.readAll();
                for (int i = 0; i < resultAll.Count; i++)
                {
                    MessageBox.Show("User " + i + " : " + resultAll[i].getLogin());
                }
            }
        }
        public void testKeyboard()
        {
            //Initiation Variable : 
            KeyboardData keyboardData = new KeyboardData();
            Keyboard keyboardOne = new Keyboard("testKeyboard1");
            Keyboard keyboardTwo = new Keyboard("testkeyboard2");
            // insert valeur 
            keyboardData.create(keyboardOne);
            keyboardData.create(keyboardTwo);
            // read values 
            keyboardOne = keyboardData.read(1);
            keyboardTwo = keyboardData.read(2);
            if (seeMessage == true)
            {
                MessageBox.Show("Keyboard One :" + keyboardOne.getName());
                MessageBox.Show("Keyboard two :" + keyboardTwo.getName());
            }
            // update values 
            keyboardOne.setName("testKeyboardUpdate");
            keyboardData.update(keyboardOne);
            // read values
            if (seeMessage == true)
            {
                List<Keyboard> result = keyboardData.readAll();
                for (int i = 0; i < result.Count; i++)
                {
                    MessageBox.Show("Keyboard " + i + " : " + result[i].getName());
                }
            }
            // delete values
            keyboardData.delete(keyboardTwo);
            // read value
            if (seeMessage == true)
            {
                List<Keyboard> resultAll = keyboardData.readAll();
                for (int i = 0; i < resultAll.Count; i++)
                {
                    MessageBox.Show("Keyboard " + i + " : " + resultAll[i].getName());
                }
            }
        }
        public void testApplication()
        {
            //Initiation Variable : 
            ApplicationData applicationData = new ApplicationData();
            Model.Application applicationOne = new Model.Application("testApplication1","link1");
            Model.Application applicationTwo = new Model.Application("testApplication2","link2");
            // insert valeur 
            applicationData.create(applicationOne);
            applicationData.create(applicationTwo);
            // read values 
            applicationOne = applicationData.read(1);
            applicationTwo = applicationData.read(2);
            if (seeMessage == true)
            {
                MessageBox.Show("Application One :" + applicationOne.getName());
                MessageBox.Show("Application two :" + applicationTwo.getName());
            }
            // update values 
            applicationOne.setName("testApplicationUpdate");
            applicationData.update(applicationOne);
            // read values
            if (seeMessage == true)
            {
                List<Model.Application> result = applicationData.readAll();
                for (int i = 0; i < result.Count; i++)
                {
                    MessageBox.Show("Application " + i + " : " + result[i].getName());
                }
            }
            // delete values
            applicationData.delete(applicationTwo);
            // read value
            if (seeMessage == true)
            {
                List<Model.Application> resultAll = applicationData.readAll();
                for (int i = 0; i < resultAll.Count; i++)
                {
                    MessageBox.Show("Application " + i + " : " + resultAll[i].getName());
                }
            }
        }
        public void testCategory()
        {
            //Initiation Variable : 
            CategoryData categoryData = new CategoryData();
            Category categoryOne = new Category("testCategory1");
            Category categoryTwo = new Category("testCategory2");
            // insert valeur 
            categoryData.create(categoryOne);
            categoryData.create(categoryTwo);
            // read values 
            categoryOne = categoryData.read(1);
            categoryTwo = categoryData.read(2);
            if (seeMessage == true)
            {
                MessageBox.Show("Category One :" + categoryOne.getName());
                MessageBox.Show("Category two :" + categoryTwo.getName());
            }
            // update values 
            categoryOne.setName("testCategoryUpdate");
            categoryData.update(categoryOne);
            // read values
            if (seeMessage == true)
            {
                List<Category> result = categoryData.readAll();
                for (int i = 0; i < result.Count; i++)
                {
                    MessageBox.Show("Category " + i + " : " + result[i].getName());
                }
            }
            // delete values
            categoryData.delete(categoryTwo);
            // read value
            if (seeMessage == true)
            {
                List<Category> resultAll = categoryData.readAll();
                for (int i = 0; i < resultAll.Count; i++)
                {
                    MessageBox.Show("Category " + i + " : " + resultAll[i].getName());
                }
            }
        }
        public void testParam()
        {
            //Initiation Variable : 
            ParamData paramData = new ParamData();
            Param paramOne = new Param("testParam1","test1",true);
            Param paramTwo = new Param("testParam2", "test2", false);
            // insert valeur 
            paramData.create(paramOne);
            paramData.create(paramTwo);
            // read values 
            paramOne = paramData.read(1);
            paramTwo = paramData.read(2);
            if (seeMessage == true)
            {
                MessageBox.Show("Param One :" + paramOne.getName());
                MessageBox.Show("Param two :" + paramTwo.getName());
            }
            // update values 
            paramOne.setName("testParamUpdate");
            paramData.update(paramOne);
            // read values
            if (seeMessage == true )
            {
                List<Param> result = paramData.readAll();
                for (int i = 0; i < result.Count; i++)
                {
                    MessageBox.Show("Param " + i + " : " + result[i].getName());
                }
            }
            // delete values
            paramData.delete(paramTwo);
            // read value
            if (seeMessage == true)
            {
                List<Param> resultAll = paramData.readAll();
                for (int i = 0; i < resultAll.Count; i++)
                {
                    MessageBox.Show("Param " + i + " : " + resultAll[i].getName());
                }
            }
        }
        public void testCommand()
        {
            //Initiation Variable : 
            CommandData commandData = new CommandData();
            Command commandOne = new Command("testCommand1","test1",1);
            Command commandTwo = new Command("testCommand2", "test2", 1);
            // insert valeur 
            commandData.create(commandOne);
            commandData.create(commandTwo);
            // read values 
            commandOne = commandData.read(1);
            commandTwo = commandData.read(2);
            if (seeMessage == true)
            {
                MessageBox.Show("Command One :" + commandOne.getName());
                MessageBox.Show("Command two :" + commandTwo.getName());
            }
            // update values 
            commandOne.setName("testCommandUpdae");
            commandData.update(commandOne);
            // read values
            if (seeMessage == true)
            {
                List<Command> result = commandData.readAll();
                for (int i = 0; i < result.Count; i++)
                {
                    MessageBox.Show("Command " + i + " : " + result[i].getName());
                }
            }
            // delete values
            commandData.delete(commandTwo);
            // read value
            if (seeMessage == true)
            {
                List<Command> resultAll = commandData.readAll();
                for (int i = 0; i < resultAll.Count; i++)
                {
                    MessageBox.Show("Command " + i + " : " + resultAll[i].getName());
                }
            }
        }
        public void testJointPAC()
        {
            //Initiation Variable : 
            JointPACData jointPACData = new JointPACData();
            JointPAC jointPACOne = new JointPAC(1,1,1,1,1);
            JointPAC jointPACTwo = new JointPAC(2,2,2,2,2);
            // insert valeur 
            jointPACData.create(jointPACOne);
            jointPACData.create(jointPACTwo);
            // read values 
            jointPACOne = jointPACData.read(1);
            jointPACTwo = jointPACData.read(2);
            if (seeMessage == true)
            {
                MessageBox.Show("JointPAC One :" + jointPACOne.getBtnKeyboard().ToString());
                MessageBox.Show("JointPAC two :" + jointPACTwo.getBtnKeyboard().ToString());
            }
            // update values 
            jointPACOne.setBtnKeyboard(10);
            jointPACData.update(jointPACOne);
            // read values
            if (seeMessage == true)
            {
                List<JointPAC> result = jointPACData.readAll();
                for (int i = 0; i < result.Count; i++)
                {
                    MessageBox.Show("JointPAC " + i + " : " + result[i].getBtnKeyboard().ToString());
                }
            }
            // delete values
            jointPACData.delete(jointPACTwo);
            // read value
            if (seeMessage == true)
            {
                List<JointPAC> resultAll = jointPACData.readAll();
                for (int i = 0; i < resultAll.Count; i++)
                {
                    MessageBox.Show("JointPAC " + i + " : " + resultAll[i].getBtnKeyboard().ToString());
                }
            }
        }
        public void testJointPC()
        {
            //Initiation Variable : 
            JointPCData jointPCData = new JointPCData();
            JointPC jointPCOne = new JointPC(1,1);
            JointPC jointPCTwo = new JointPC(2,2);
            // insert valeur 
            jointPCData.create(jointPCOne);
            jointPCData.create(jointPCTwo);
            // read values 
            jointPCOne = jointPCData.read(1);
            jointPCTwo = jointPCData.read(2);
            if (seeMessage == true)
            {
                MessageBox.Show("JointPC One :" + jointPCOne.getIdCommand().ToString());
                MessageBox.Show("JointPC two :" + jointPCTwo.getIdCommand().ToString());
            }
            // update values 
            jointPCOne.setIdCommand(10);
            jointPCData.update(jointPCOne);
            // read values
            if (seeMessage == true)
            {
                List<JointPC> result = jointPCData.readAll();
                for (int i = 0; i < result.Count; i++)
                {
                    MessageBox.Show("JointPC " + i + " : " + result[i].getIdCommand().ToString());
                }
            }
            // delete values
            jointPCData.delete(jointPCTwo);
            // read value
            if (seeMessage == true)
            {
                List<JointPC> resultAll = jointPCData.readAll();
                for (int i = 0; i < resultAll.Count; i++)
                {
                    MessageBox.Show("JointPC " + i + " : " + resultAll[i].getIdCommand().ToString());
                }
            }
        }
        //########################################### test v2 #############################################
        public void testUserV2()
        {
            //Initiation Variable : 
            CtrlConnection con = new CtrlConnection();
            UserData userData = new UserData();
            User userOne = new User("agoget", con.ConvertSHA256("agoget"), true);
            User userTwo = new User("cyurekli", con.ConvertSHA256("cyurekli"), false);
            User userThreee = new User("esicsic", con.ConvertSHA256("esicsic"), false);
            User userFour = new User("mctailleux", con.ConvertSHA256("mctailleux"), false);
            // insert valeur 
            userData.create(userOne);
            userData.create(userTwo);
            userData.create(userThreee);
            userData.create(userFour);

        }
        public void testKeyboardV2()
        {
            //Initiation Variable : 
            KeyboardData keyboardData = new KeyboardData();
            Keyboard keyboardOne = new Keyboard("Intellipad");
            Keyboard keyboardTwo = new Keyboard("keyboardTest");
            // insert valeur 
            keyboardData.create(keyboardOne);
            keyboardData.create(keyboardTwo);
            
        }
        public void testApplicationV2()
        {
            //Initiation Variable : 
            ApplicationData applicationData = new ApplicationData();
            Model.Application applicationOne = new Model.Application("Firefox", "C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe");
            Model.Application applicationTwo = new Model.Application("Internet Explorer", "C:\\Program Files (x86)\\Internet Explorer\\iexplore.exe");
            Model.Application applicationThree = new Model.Application("Google Chrome", "C:\\Program Files (x86)\\Google Chrome\\googlechrome.exe");
            // insert valeur 
            applicationData.create(applicationOne);
            applicationData.create(applicationTwo);
            applicationData.create(applicationThree);

        }
        public void testCategoryV2()
        {
            //Initiation Variable : 
            CategoryData categoryData = new CategoryData();
            Category categoryOne = new Category("Category1");
            Category categoryTwo = new Category("Category2");
            Category categoryThree = new Category("Category1");
            Category categoryFour = new Category("Category2");
            // insert valeur 
            categoryData.create(categoryOne);
            categoryData.create(categoryTwo);
            categoryData.create(categoryThree);
            categoryData.create(categoryFour);
        }
    }
}
