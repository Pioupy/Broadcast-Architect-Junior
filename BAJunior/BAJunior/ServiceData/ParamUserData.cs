using log4net;
using log4net.Config;
using System;
using System.Data;
using System.Collections.Generic;
using BAJunior.Model;

namespace BAJunior.ServiceData
{
    public class ParamUserData
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(ParamUserData));
        private static DbUtils m_dbUtils;
        public ParamUserData()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_dbUtils = new DbUtils();
        }
        public void create(ParamUser pParam)
        {
            bool isUser = pParam.getIsUser() ? true : false;
            string requete = "insert into ParamUser (Name, Value, IsUser, IDCommandUser) values ('" + pParam.getName() + "','" + pParam.getValue() + "','" + isUser + "','" + pParam.getIdCommandUser() + "')";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("ParamUser has been created.");
                }
                else
                {
                    _log.Warn("ParamUser has not been created.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }

        }
        public void update(ParamUser pParam)
        {
            bool isUser = pParam.getIsUser() ? true : false;
            string requete = "UPDATE ParamUser SET Name = '" + pParam.getName() + "', Value = '" + pParam.getValue() + "', IsUser = '" + isUser + "', IDCommandUser = '" + pParam.getIdCommandUser() + "' WHERE IDParamUser = '" + pParam.getId() + "';";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("ParamUser has been updated.");
                }
                else
                {
                    _log.Warn("ParamUser has not been updated.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public void delete(ParamUser pParam)
        {
            string requete = "DELETE FROM ParamUser WHERE IDParamUser = '" + pParam.getId() + "'; ";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("ParamUser has been deleted");
                }
                else
                {
                    _log.Warn("ParamUser has not been deleted");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public ParamUser read(int id)
        {
            ParamUser paramUser = null;
            string requete = "SELECT * from ParamUser WHERE IDParamUser = '" + id + "' order by IDParamUser asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idParamUser = Convert.ToInt32(r["IDParamUser"]);
                    String name = r["Name"].ToString();
                    String value = r["Value"].ToString();
                    bool isUser = Convert.ToBoolean(r["IsUser"].ToString());
                    int idCommandUser = Convert.ToInt32(r["IDCommandUser"]);
                    paramUser = new ParamUser(idParamUser, name, value, isUser, idCommandUser);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return paramUser;
        }
        public List<ParamUser> readAll()
        {
            List<ParamUser> paramUserList = new List<ParamUser>();
            string requete = "SELECT * from ParamUser order by IDParamUser asc";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idParamUser = Convert.ToInt32(r["IDParamUser"]);
                    String name = r["Name"].ToString();
                    String value = r["Value"].ToString();
                    bool isUser = Convert.ToBoolean(r["IsUser"].ToString());
                    int idCommandUser = Convert.ToInt32(r["IDCommandUser"]);
                    ParamUser paramUser = new ParamUser(idParamUser, name, value, isUser, idCommandUser);
                    paramUserList.Add(paramUser);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return paramUserList;
        }
        public List<ParamUser> readbyCommand(int id)
        {
            List<ParamUser> paramUserList = new List<ParamUser>();
            string requete = "SELECT * from ParamUser WHERE IDCommandUser=" + id + " order by IDParamUser asc";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idParamUser = Convert.ToInt32(r["IDParamUser"]);
                    String name = r["Name"].ToString();
                    String value = r["Value"].ToString();
                    bool isUser = Convert.ToBoolean(r["IsUser"].ToString());
                    int idCommandUser = Convert.ToInt32(r["IDCommandUser"]);
                    ParamUser paramUser = new ParamUser(idParamUser, name, value, isUser, idCommandUser);
                    paramUserList.Add(paramUser);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return paramUserList;
        }
        public int readLastID()
        {
            int id = 0;
            String requete = "SELECT * from SQLITE_SEQUENCE WHERE name=\"ParamUser\";";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    id = Convert.ToInt32(r["seq"]);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return id;
        }
    }
}
