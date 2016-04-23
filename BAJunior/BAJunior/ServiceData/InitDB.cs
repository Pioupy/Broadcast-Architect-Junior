using System;
using System.Collections.Generic;
using System.Windows.Forms;
using log4net;
using log4net.Config;
using BAJunior.Model;

namespace BAJunior.ServiceData
{
    class InitDB
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(InitDB));
        private static DbUtils m_dbUtils;
        public InitDB()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_dbUtils = new DbUtils();
            // APPELER TOUTES LES M2THODE §§§§§§§§§§F!!!!!!!!!!!!!!!!!!!!
            //initTable();
        }
        public void testCreatedByAlex(bool testCreateDataBase, bool testCreateTable, bool test)
        {
            if (testCreateDataBase == true)
            {
                createDatabaseICAN();
            }
            if (testCreateTable == true)
            {
                initTables();
            }
            if (test == true)
            {
                testUser();
            }
        }
        private void testUser()
        {
            //Initiation Variable : 
            UserData userData = new UserData();
            User userOne = new User("admin", "admin", true);
            User userTwo = new User("user", "user", false);
            // insert valeur 
            userData.create(userOne);
            userData.create(userTwo);
            // read values 
            userOne = userData.read(1);
            userTwo = userData.read(2);
            //MessageBox.Show("User One :" + userReadOne.getLogin());
            //MessageBox.Show("User two :" + userReadTwo.getLogin());
            //Console.WriteLine("User One :" + userReadOne.getLogin());
            //Console.WriteLine("User two :" + userReadTwo.getLogin());
            // update values 
            userOne.setLogin("administrateur");
            userData.update(userOne);
            // read values
            List<User> result = userData.readAll();
            for (int i = 0; i < result.Count; i++)
            {
                //Console.WriteLine("User " + i + " : " + result[i].getLogin());
                //MessageBox.Show("User " + i + " : " + result[i].getLogin());
            }
            // delete values
            userData.delete(userTwo);
            // read value
            List<User> resultAll = userData.readAll();
            for (int i = 0; i < result.Count; i++)
            {
                //Console.WriteLine("User " + i + " : " + resultAll[i].getLogin());
                //MessageBox.Show("User " + i + " : " + resultAll[i].getLogin());
            }
        }
        public void createDatabaseICAN()
        {//REVOIR CELA !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            m_dbUtils.createDatabase();
        }
        private void initTables()
        {//REVOIR CELA !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            createTableUser();
            /*
            createTableKeyboard();
            createTableApplication();
            createTableCategory();
            createTableParam();
            createTableProfil();
            createTableCommand();
            createTableJointPAC();
            createTableJointPC();
            */
        }
        private void createTableUser()
        {// IDUSer est un int aussi non ? 
            string requete = "CREATE TABLE IF NOT EXISTS User (IDUser  INTEGER PRIMARY KEY AUTOINCREMENT, Login varchar(50) UNIQUE, Password varchar(50), IsAdmin boolean not null default 0)";
            if (m_dbUtils.executeQuery(requete) == 0)
            { // Condition executeNonQuery : retourne nombre de lignes affectées. Comme on créer une table, on affecte 0 ligne.
                _log.Info("The user table thas been created.");
            }
            else
            {
                _log.Info("The user table has not been created.");
            }
            //	AJOUT DE ADMIN!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //m_dbUtils.
        }

        private void createTableProfil()
        {
            string requete = "CREATE TABLE IF NOT EXISTS Profil (IDProfil  INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Status varchar(20), FOREIGN KEY (IDUser) REFERENCES User(IDUser), FOREIGN KEY (IDKeyboard) REFERENCES Keyboard(IDKeyboard))";
            if (m_dbUtils.executeQuery(requete) == 0)
            { // revir condition
                _log.Info("The Profil table thas been created.");
            }
            else
            {
                _log.Info("The Profil table has not been created.");
            }
        }
        private void createTableKeyboard()
        {
            string requete = "CREATE TABLE IF NOT EXISTS Keyboard (IDKeyboard  INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50))";
            if (m_dbUtils.executeQuery(requete) == 0)
            { // revir condition
                _log.Info("The Keyboard table thas been created.");
            }
            else
            {
                _log.Info("The Keyboard table has not been created.");
            }
        }
        private void createTableJointPAC()
        {
            string requete = "CREATE TABLE IF NOT EXISTS JointPAC (IDJointPAC  INTEGER PRIMARY KEY AUTOINCREMENT, BtnKeyboard int, bank int, FOREIGN KEY (IDProfil) REFERENCES Profil(IDProfil), FOREIGN KEY (IDApplication) REFERENCES Application(IDApplication), FOREIGN KEY (IDCommand) REFERENCES Command(IDCommand))";
            if (m_dbUtils.executeQuery(requete) == 0)
            { // revir condition
                _log.Info("The JointPAC table thas been created.");
            }
            else
            {
                _log.Info("The JointPAC table has not been created.");
            }
        }
        private void createTableApplication()
        {
            string requete = "CREATE TABLE IF NOT EXISTS Application (IDApplication  INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50) UNIQUE, Link varchar(200))";
            if (m_dbUtils.executeQuery(requete) == 0)
            { // revir condition
                _log.Info("The Application table thas been created.");
            }
            else
            {
                _log.Info("The Application table has not been created.");
            }
        }
        private void createTableCommand()
        {
            string requete = "CREATE TABLE IF NOT EXISTS Command (IDCommand  INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Picture varchar(200), FOREIGN KEY (IDCategory) REFERENCES Category(IDCategory))";
            if (m_dbUtils.executeQuery(requete) == 0)
            { // revir condition
                _log.Info("The Command table thas been created.");
            }
            else
            {
                _log.Info("The Command table has not been created.");
            }
        }
        private void createTableCategory()
        {
            string requete = "CREATE TABLE IF NOT EXISTS Category (IDCategory  INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50))";
            if (m_dbUtils.executeQuery(requete) == 0)
            { // revir condition
                _log.Info("The Category table thas been created.");
            }
            else
            {
                _log.Info("The Category table has not been created.");
            }
        }
        private void createTableJointPC()
        {
            string requete = "CREATE TABLE IF NOT EXISTS User (IDJointPC  INTEGER PRIMARY KEY AUTOINCREMENT, FOREIGN KEY (IDCommand) REFERENCES Command(IDCommand), FOREIGN KEY (IDParam) REFERENCES Param(IDParam))";
            if (m_dbUtils.executeQuery(requete) == 0)
            { // revir condition
                _log.Info("The JointPC table thas been created.");
            }
            else
            {
                _log.Info("The JointPC table has not been created.");
            }
        }

        private void createTableParam()
        {
            string requete = "CREATE TABLE IF NOT EXISTS Param (IDParam  INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Value varchar(50), IsUser boolean not null default 0)";
            if (m_dbUtils.executeQuery(requete) == 0)
            { // revir condition
                _log.Info("The Param table thas been created.");
            }
            else
            {
                _log.Info("The Param table has not been created.");
            }
        }
    }
}
