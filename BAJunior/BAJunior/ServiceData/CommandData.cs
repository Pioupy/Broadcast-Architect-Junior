using log4net;
using log4net.Config;
using System;
using System.Data;
using System.Collections.Generic;
using BAJunior.Model;

namespace BAJunior.ServiceData
{
    class CommandData
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(UserData));
        private static DbUtils m_dbUtils;
        public CommandData()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_dbUtils = new DbUtils();
        }
        public void create(Command pCommand)
        {
            string requete = "insert into Command (Name) values ('" + pCommand.getName() + "')";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Command has been created.");
                }
                else
                {
                    _log.Warn("Command has not been created.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }

        }
        public void update(Command pCommand)
        {
            string requete = "UPDATE Command SET Name = '" + pCommand.getName() + "' WHERE IDCommand = '" + pCommand.getId() + "';";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Command has been updated.");
                }
                else
                {
                    _log.Warn("Command has not been updated.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public void delete(Command pCommand)
        {
            string requete = "DELETE FROM Command WHERE IDCommand = '" + pUpCommandser.getId() + "'; ";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Command has been deleted");
                }
                else
                {
                    _log.Warn("Command has not been deleted");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public Command read(int id)
        {
            Command command = null;
            string requete = "SELECT * from Command WHERE IDCommand = '" + id + "' order by IDCommand asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idCommand = Convert.ToInt32(r["IDCommand"]);
                    string name = r["Name"].ToString();
                    command = new Command(idCommand, name);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return command;
        }
        public List<Command> readAll()
        {
            List<Command> commandList = new List<Command>();
            string requete = "SELECT * from Command order by IDUser asc";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idCommand = Convert.ToInt32(r["IDCommand"]);
                    string name = r["Name"].ToString();
                    Command command = new Command(idCommand, name);
                    commandList.Add(command);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return commandList;
        }
    }
}
