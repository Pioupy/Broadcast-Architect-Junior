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
            string requete = "insert into Param (Name, IDSetCommand, IDCommand) values ('" + pParam.getName() + "','" + pParam.getIdSetCommand() + "','" + pParam.getIdCommand() + "')";
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
            string requete = "UPDATE Param SET Name = '" + pParam.getName() + "', IDSetCommand = '" + pParam.getIdSetCommand() + "', IDCommand = '" + pParam.getIdCommand() + "' WHERE IDParam = '" + pParam.getId() + "';";
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
                    int idProfil = Convert.ToInt32(r["IDProfil"]);
                    string name = r["Name"].ToString();
                    int idSetCommand = Convert.ToInt32(r["IDSetCommand"]);
                    int idCommand = Convert.ToInt32(r["IDCommand"]);
                    param = new Param(idProfil, name, idSetCommand, idCommand);
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
                    int idProfil = Convert.ToInt32(r["IDProfil"]);
                    string name = r["Name"].ToString();
                    int idSetCommand = Convert.ToInt32(r["IDSetCommand"]);
                    int idCommand = Convert.ToInt32(r["IDCommand"]);
                    Param param = new Param(idProfil, name, idSetCommand, idCommand);
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
