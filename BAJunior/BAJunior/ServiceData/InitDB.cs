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
            // Create tables of Database.
            createDatabaseICAN();
            initTables();
        }
        public void testCreatedByAlex()
        {
            // TODO : Méthode destinée à disparaître après les test.
            TestUnitaireTable testUnitaireTable = new TestUnitaireTable();
            testUnitaireTable.testUser();
            testUnitaireTable.testKeyboard();
            testUnitaireTable.testApplication();
            testUnitaireTable.testCategory();
            testUnitaireTable.testParam();
            testUnitaireTable.testProfil();
            testUnitaireTable.testCommand();
            testUnitaireTable.testJointPAC();
            testUnitaireTable.testJointPC();
        }
        public void createDatabaseICAN()
        {
            //Create Database
            m_dbUtils.createDatabase();
            //Configure ON or OFF foreign key
            // --- TRAVAIL HERE
            //m_dbUtils.stateForeignKey("ON");
        }
        private void initTables()
        {
            //Create all tables
            createTableUser();
            createTableKeyboard();
            createTableApplication();
            createTableCategory();
            createTableParam();
            createTableProfil();
            createTableCommand();
            createTableJointPAC();
            createTableJointPC();
            //Create the user : Admin
            UserData userData = new UserData();
            User userSearch = userData.read(1);// "IDUser = 1" = admin
            if (userSearch == null)
            {
                //Create user 'admin" only if it's the first launch of software
                User adminUser = new User("admin", "admin", true);
                userData.create(adminUser);
            }
        }
        private void createTableUser()
        {
            // Make Query
            string requete = "CREATE TABLE IF NOT EXISTS User (IDUser  INTEGER PRIMARY KEY AUTOINCREMENT, Login varchar(50) UNIQUE, Password varchar(50), IsAdmin boolean not null default 0)";
            // Execute Query and tested her value
            if (m_dbUtils.executeQuery(requete) == 0)
            { // Condition executeNonQuery : retourne nombre de lignes affectées. Comme on créer une table, on affecte 0 ligne.
                _log.Info("The user table thas been created.");
            }
            else
            {
                _log.Info("The user table has not been created.");
            }
        }

        private void createTableProfil()
        {
            string requete = "CREATE TABLE Profil(IDProfil  INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Status varchar(20), IDUser INTEGER, IDKeyboard INTEGER, FOREIGN KEY(IDUser) REFERENCES User(IDUser), FOREIGN KEY(IDKeyboard) REFERENCES Keyboard(IDKeyboard))";
            if (m_dbUtils.executeQuery(requete) == 0)
            { 
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
            {
                _log.Info("The Keyboard table thas been created.");
            }
            else
            {
                _log.Info("The Keyboard table has not been created.");
            }
        }
        private void createTableJointPAC()
        {
            string requete = "CREATE TABLE IF NOT EXISTS JointPAC (IDJointPAC  INTEGER PRIMARY KEY AUTOINCREMENT, BtnKeyboard int, bank int, IDProfil INTEGER, IDApplication INTEGER, IDCommand INTEGER, FOREIGN KEY (IDProfil) REFERENCES Profil(IDProfil), FOREIGN KEY (IDApplication) REFERENCES Application(IDApplication), FOREIGN KEY (IDCommand) REFERENCES Command(IDCommand))";
            if (m_dbUtils.executeQuery(requete) == 0)
            {
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
            {
                _log.Info("The Application table thas been created.");
            }
            else
            {
                _log.Info("The Application table has not been created.");
            }
        }
        private void createTableCommand()
        {
            string requete = "CREATE TABLE IF NOT EXISTS Command (IDCommand  INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(50), Picture varchar(200), IDCategory INTEGER, FOREIGN KEY (IDCategory) REFERENCES Category(IDCategory))";
            if (m_dbUtils.executeQuery(requete) == 0)
            {
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
            {
                _log.Info("The Category table thas been created.");
            }
            else
            {
                _log.Info("The Category table has not been created.");
            }
        }
        private void createTableJointPC()
        {
            string requete = "CREATE TABLE IF NOT EXISTS JointPC (IDJointPC  INTEGER PRIMARY KEY AUTOINCREMENT, IDCommand INTEGER, IDParam INTEGER, FOREIGN KEY (IDCommand) REFERENCES Command(IDCommand), FOREIGN KEY (IDParam) REFERENCES Param(IDParam))";
            if (m_dbUtils.executeQuery(requete) == 0)
            { 
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
            {
                _log.Info("The Param table thas been created.");
            }
            else
            {
                _log.Info("The Param table has not been created.");
            }
        }
    }
}
