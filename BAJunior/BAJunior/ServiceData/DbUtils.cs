using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.ServiceData
{
    /// <summary>
    /// Méthodes génériques pour la Base de données (initialisation de connection etc) 
    /// </summary>
    class DbUtils
    {
        string nameDatabase = "MyDatabase.sqlite";
        private SQLiteConnection m_dbConnection;
        public void CreateDatabase(string pNameDatebase)
        {
            SQLiteConnection.CreateFile(pNameDatebase);
        }
        public void OpenConnectionDatabase(string pNameDatabase)//pNameDatebase uitliser !!
        {
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
        }
        public void CloseConnectionDatabase()
        {
            m_dbConnection.Close();
        }
        public Boolean ExecuteQuery(string pSql)
        {
            //string sql = "create table highscores (name varchar(20), score int)";
            SQLiteCommand command = new SQLiteCommand(pSql, m_dbConnection);
            int row = command.ExecuteNonQuery();
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
