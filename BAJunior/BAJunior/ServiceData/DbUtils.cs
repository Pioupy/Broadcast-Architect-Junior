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
        public void createDatabase(string pNameDatebase)
        {
            SQLiteConnection.CreateFile(pNameDatebase);
        }
        public void openConnectionDatabase(string pNameDatabase)//pNameDatebase uitliser !!
        {
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
        }
        public void closeConnectionDatabase()
        {
            m_dbConnection.Close();
        }
        public Boolean createTable(string pSql)
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
        public Boolean selectTable(string pSql)
        {
            //string sql = "select * from highscores order by score desc";
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
        public Boolean insertTable(string pSql)
        {
            //string sql = "insert into highscores (name, score) values ('Me', 3000)";
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
        public Boolean updateTable(string pSql)
        {
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
        public Boolean deleteTable(string pSql)
        {
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
