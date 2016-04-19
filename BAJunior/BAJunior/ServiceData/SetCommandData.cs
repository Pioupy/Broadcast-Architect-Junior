using System;
using System.Collections.Generic;
using System.Linq;
using log4net;
using log4net.Config;
using System;
using System.Data;
using System.Collections.Generic;
using BAJunior.Model;

namespace BAJunior.ServiceData
{
    class SetCommandData
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(SetCommandData));
        private static DbUtils m_dbUtils;
        public SetCommandData()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_dbUtils = new DbUtils();
        }
        public void create(SetCommand pSetCommand)
        {
            string requete = "insert into SetCommand (Name) values ('" + pSetCommand.getName() + "')";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("SetCommand has been created.");
                }
                else
                {
                    _log.Warn("SetCommand has not been created.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }

        }
        public void update(SetCommand pSetCommand)
        {
            string requete = "UPDATE SetCommand SET Name = '" + pSetCommand.getName() + "';";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("SetCommand has been updated.");
                }
                else
                {
                    _log.Warn("SetCommand has not been updated.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public void delete(SetCommand pSetCommand)
        {
            string requete = "DELETE FROM SetCommand WHERE IDSetCommand = '" + pSetCommand.getId() + "'; ";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("SetCommand has been deleted");
                }
                else
                {
                    _log.Warn("SetCommand has not been deleted");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public SetCommand read(int id)
        {
            SetCommand setCommand = null;
            string requete = "SELECT * from SetCommand WHERE IDSetCommand = '" + id + "' order by IDSetCommand asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idSetCommand = Convert.ToInt32(r["IDSetCommand"]);
                    string name = r["Name"].ToString();
                    setCommand = new SetCommand(idSetCommand, name);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return setCommand;
        }
        public List<SetCommand> readAll()
        {
            List<SetCommand> setCommandList = new List<SetCommand>();
            string requete = "SELECT * from SetCommand order by IDSetCommand asc";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idSetCommand = Convert.ToInt32(r["IDSetCommand"]);
                    string name = r["Name"].ToString();
                    SetCommand setCommand = new SetCommand(idSetCommand, name);
                    setCommandList.Add(setCommand);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return setCommandList;
        }
    }
}
