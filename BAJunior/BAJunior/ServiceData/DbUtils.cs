using log4net;
using log4net.Config;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace BAJunior.ServiceData
{
    /// <summary>
    /// Méthodes génériques pour la Base de données (initialisation de connection etc) 
    /// </summary>
    /// 
    class DbUtils
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(DbUtils));
        private SQLiteConnection m_dbConnection;
        private string m_nameDatabase;
        private int m_versionDataBase;
        public DbUtils()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_nameDatabase = "MyDatabaseTest.sqlite";
            m_versionDataBase = 3;
        }
        public DbUtils(string pNameDatabase, int pVersion)
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_nameDatabase = pNameDatabase;
            m_versionDataBase = pVersion;
        }
        public void createDatabase()
        {
            // tester existance fichier
            if (!File.Exists(m_nameDatabase))
            {
                SQLiteConnection.CreateFile(m_nameDatabase);
                _log.Info("Base de données créée");
            }
            else
            {
                _log.Warn("Base de données DEJA créée");
            }
        }
        public void openConnectionDatabase()//pNameDatebase uitliser !!
        {
            m_dbConnection = new SQLiteConnection("Data Source=" + m_nameDatabase + ";Version=" + m_versionDataBase.ToString() + ";");
            m_dbConnection.Open();
            //_log.Info("Ouverture de la connexion à la base de données");
        }
        public void checkConnection()
        {
            //a faire
        }
        public void closeConnectionDatabase()
        {
            m_dbConnection.Close();
            //_log.Info("Fermeture de la connexion à la base de données");
        }
        public int executeQuery(string pSql)
        {
            //string sql = "create table highscores (name varchar(20), score int)";
            int result = -1;//vérif valeur nagatif
            try
            {
                openConnectionDatabase();
                SQLiteCommand command = new SQLiteCommand(pSql, m_dbConnection);
                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                _log.Error("error :" + e.Message);
            }
            finally
            {
                closeConnectionDatabase();
            }
            
            return result;
        }
        public DataTable executeReader(string pSql)
        {
            //string sql = "create table highscores (name varchar(20), score int)";
            DataTable dt = new DataTable();
            try
            {
                openConnectionDatabase();
                SQLiteCommand command = new SQLiteCommand(pSql, m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                
            }
            catch (Exception e)
            {
                _log.Error("error :" + e.Message);
            }
            finally
            {
                closeConnectionDatabase();
            }
            return dt;
        }
        public string executeScalar(string pSql)
        {
            //string sql = "create table highscores (name varchar(20), score int)";
            openConnectionDatabase();
            SQLiteCommand command = new SQLiteCommand(pSql, m_dbConnection);
            object result = command.ExecuteScalar();
            closeConnectionDatabase();
            if (result != null)
            {
                return result.ToString();
            }
            return "";
        }
    }
}
