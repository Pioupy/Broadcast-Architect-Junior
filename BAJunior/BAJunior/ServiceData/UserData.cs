using log4net;
using log4net.Config;
using System;
using System.Data;
using System.Collections.Generic;
using BAJunior.Model;

namespace BAJunior.ServiceData
{
    class UserData
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(UserData));
        private static DbUtils m_dbUtils;
        public UserData()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_dbUtils = new DbUtils();
        }
        public void create(User pUser)
        {
            bool isAdmin = pUser.getIsAdmin() ? true : false;
            string requete = "insert into User (Login, Password, IsAdmin) values ('" + pUser.getLogin() + "','" + pUser.getPassword() + "','" + isAdmin + "')";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("User has been created.");
                }
                else
                {
                    _log.Warn("User has not been created.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }

        }
        public void update(User pUser)
        {
            bool isAdmin = pUser.getIsAdmin() ? true : false;
            string requete = "UPDATE User SET Login = '" + pUser.getLogin() + "', Password = '" + pUser.getPassword() + "', IsAdmin = '" + isAdmin + "' WHERE IDUser = '" + pUser.getId() + "';";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("User has been updated.");
                }
                else
                {
                    _log.Warn("User has not been updated.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public void delete(User pUser)
        {
            string requete = "DELETE FROM User WHERE IDUser = '" + pUser.getId() + "'; ";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("User has been deleted");
                }
                else
                {
                    _log.Warn("User has not been deleted");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public User read(int id)
        {
            User user = null;
            string requete = "SELECT * from User WHERE IDUser = '" + id + "' order by IDUser asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idUser = Convert.ToInt32(r["IDUser"]);
                    string userName = r["Login"].ToString();
                    string password = r["Password"].ToString();
                    bool isAdmin = Convert.ToBoolean(r["IsAdmin"].ToString());
                    user = new User(idUser, userName, password, isAdmin);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return user;
        }
        public List<User> readAll()
        {
            List<User> userList = new List<User>();
            string requete = "SELECT * from User order by IDUser asc";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idUser = Convert.ToInt32(r["IDUser"]);
                    string userName = r["Login"].ToString();
                    string password = r["Password"].ToString();
                    bool isAdmin = Convert.ToBoolean(r["IsAdmin"].ToString());
                    User user = new User(idUser, userName, password, isAdmin);
                    userList.Add(user);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return userList;
        }
        public User readByName(String name)
        {
            User user = null;
            string requete = "SELECT * from User WHERE Login = '" + name + "' order by IDUser asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idUser = Convert.ToInt32(r["IDUser"]);
                    string userName = r["Login"].ToString();
                    string password = r["Password"].ToString();
                    bool isAdmin = Convert.ToBoolean(r["IsAdmin"].ToString());
                    user = new User(idUser, userName, password, isAdmin);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return user;
        }
    }
}
