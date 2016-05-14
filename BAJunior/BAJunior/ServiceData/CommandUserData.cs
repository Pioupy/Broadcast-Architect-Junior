using log4net;
using log4net.Config;
using System;
using System.Data;
using System.Collections.Generic;
using BAJunior.Model;

namespace BAJunior.ServiceData
{
    class CommandUserData
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(CommandUserData));
        private static DbUtils m_dbUtils;
        public CommandUserData()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_dbUtils = new DbUtils();
        }
        public void create(CommandUser pCommandUser)
        {
            string requete = "insert into CommandUser (Name, Picture, IDCategory) values ('" + pCommandUser.getName() + "','" + pCommandUser.getPicture() + "','" + pCommandUser.getIdCategory() + "')";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("CommandUser has been created.");
                }
                else
                {
                    _log.Warn("CommandUser has not been created.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }

        }
        public void update(CommandUser pCommandUser)
        {
            string requete = "UPDATE CommandUser SET Name = '" + pCommandUser.getName() + "', Picture = '" + pCommandUser.getPicture() + "', IDCategory = '" + pCommandUser.getIdCategory() + "' WHERE IDCommandUser = '" + pCommandUser.getId() + "';";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("CommandUser has been updated.");
                }
                else
                {
                    _log.Warn("CommandUser has not been updated.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public void delete(CommandUser pCommandUser)
        {
            string requete = "DELETE FROM CommandUser WHERE IDCommandUser = '" + pCommandUser.getId() + "'; ";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("CommandUser has been deleted");
                }
                else
                {
                    _log.Warn("CommandUser has not been deleted");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public CommandUser read(int id)
        {
            CommandUser commandUser = null;
            string requete = "SELECT * from CommandUser WHERE IDCommandUser = '" + id + "' order by IDCommandUser asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idCommandUser = Convert.ToInt32(r["IDCommandUser"]);
                    String name = r["Name"].ToString();
                    String picture = r["Picture"].ToString();
                    int idCategory = Convert.ToInt32(r["IDCategory"]);
                    commandUser = new CommandUser(idCommandUser, name, picture, idCategory);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return commandUser;
        }
        public List<CommandUser> readAll()
        {
            List<CommandUser> commandUserList = new List<CommandUser>();
            string requete = "SELECT * from CommandUser order by IDCommand asc";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idCommandUser = Convert.ToInt32(r["IDCommandUser"]);
                    String name = r["Name"].ToString();
                    String picture = r["Picture"].ToString();
                    int idCategory = Convert.ToInt32(r["IDCategory"]);
                    CommandUser commandUser = new CommandUser(idCommandUser, name, picture, idCategory);
                    commandUserList.Add(commandUser);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return commandUserList;
        }
        public List<Param> readParamByCommand(int id)
        {

            List<Param> commandListParam = new List<Param>();
            string requete = "SELECT p.IDParam, p.Name, p.Value, p.IsUser, p.IDCommandUser  FROM CommandUser c, Param p WHERE c.IDCommandUser=p.IDCommandUser AND c.IDCommandUser=" + id + " order by c.IDCommandUser asc";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idParam = Convert.ToInt32(r["IDParam"]);
                    String name = r["Name"].ToString();
                    String value = r["Value"].ToString();
                    bool isUser = Convert.ToBoolean(r["IsUser"].ToString());
                    int idCommand = Convert.ToInt32(r["IDCommandUser"]);
                    Param param = new Param(idParam, name, value, isUser, idCommand);
                    commandListParam.Add(param);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return commandListParam;
        }
        public CommandUser readByName(string Name)
        {
            CommandUser commandUser = null;
            string requete = "SELECT * from CommandUser WHERE Name = '" + Name + "' order by IDCommandUser asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idCommandUser = Convert.ToInt32(r["IDCommandUser"]);
                    String name = r["Name"].ToString();
                    String picture = r["Picture"].ToString();
                    int idCategory = Convert.ToInt32(r["IDCategory"]);
                    commandUser = new CommandUser(idCommandUser, name, picture, idCategory);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return commandUser;
        }
    }
}
