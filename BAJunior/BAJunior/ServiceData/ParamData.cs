using log4net;
using log4net.Config;
using System;
using System.Data;
using System.Collections.Generic;
using BAJunior.Model;

namespace BAJunior.ServiceData
{
    class ParamData
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(ParamData));
        private static DbUtils m_dbUtils;
        public ParamData()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_dbUtils = new DbUtils();
        }
        public void create(Param pParam)
        {
            bool isUser = pParam.getIsUser() ? true : false;
            string requete = "insert into Param (Name, Value, IsUser) values ('" + pParam.getName() + "','" + pParam.getValue() + "','" + isUser + "')";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Param has been created.");
                }
                else
                {
                    _log.Warn("Param has not been created.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }

        }
        public void update(Param pParam)
        {
            bool isUser = pParam.getIsUser() ? true : false;
            string requete = "UPDATE Param SET Name = '" + pParam.getName() + "', Value = '" + pParam.getValue() + "', IsUser = '" + isUser + "' WHERE IDParam = '" + pParam.getId() + "';";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Param has been updated.");
                }
                else
                {
                    _log.Warn("Param has not been updated.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public void delete(Param pParam)
        {
            string requete = "DELETE FROM Param WHERE IDParam = '" + pParam.getId() + "'; ";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Param has been deleted");
                }
                else
                {
                    _log.Warn("Param has not been deleted");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public Param read(int id)
        {
            Param param = null;
            string requete = "SELECT * from Param WHERE IDParam = '" + id + "' order by IDParam asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idParam = Convert.ToInt32(r["IDParam"]);
                    String name = r["Name"].ToString();
                    String value = r["Value"].ToString();
                    bool isUser = Convert.ToBoolean(r["IsUser"].ToString());
                    param = new Param(idParam, name, value, isUser);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return param;
        }
        public List<Param> readAll()
        {
            List<Param> paramList = new List<Param>();
            string requete = "SELECT * from Param order by IDParam asc";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idParam = Convert.ToInt32(r["IDParam"]);
                    String name = r["Name"].ToString();
                    String value = r["Value"].ToString();
                    bool isUser = Convert.ToBoolean(r["IsUser"].ToString());
                    Param param = new Param(idParam, name, value, isUser);
                    paramList.Add(param);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return paramList;
        }
    }
}
