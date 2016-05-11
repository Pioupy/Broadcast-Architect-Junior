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
        private static readonly ILog _log = LogManager.GetLogger(typeof(CommandData));
        private static DbUtils m_dbUtils;
        public CommandData()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_dbUtils = new DbUtils();
        }
        public void create(Command pCommand)
        {
            string requete = "insert into Command (Name, Picture, IDCategory) values ('" + pCommand.getName() + "','" + pCommand.getPicture() + "','" + pCommand.getIdCategory() + "')";
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
            string requete = "UPDATE Command SET Name = '" + pCommand.getName() + "', Picture = '" + pCommand.getPicture() + "', IDCategory = '" + pCommand.getIdCategory() + "' WHERE IDCommand = '" + pCommand.getId() + "';";
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
            string requete = "DELETE FROM Command WHERE IDCommand = '" + pCommand.getId() + "'; ";
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
                    String name = r["Name"].ToString();
                    String picture = r["Picture"].ToString();
                    int idCategory = Convert.ToInt32(r["IDCategory"]);
                    command = new Command(idCommand, name, picture, idCategory);
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
            string requete = "SELECT * from Command order by IDCommand asc";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idCommand = Convert.ToInt32(r["IDCommand"]);
                    String name = r["Name"].ToString();
                    String picture = r["Picture"].ToString();
                    int idCategory = Convert.ToInt32(r["IDCategory"]);
                    Command command = new Command(idCommand, name, picture, idCategory);
                    commandList.Add(command);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return commandList;
        }
        public List<Param> readParamByCommand(int id)
        {

            List<Param> commandListParam = new List<Param>();
            string requete = "SELECT p.IDParam, p.Name, p.Value, p.IsUser FROM Command c, JointPC jpc, Param p WHERE jpc.IDCommand=c.IDCommand AND jpc.IDParam=p.IDParam AND c.IDCommand=" + id + " order by c.IDCommand asc";
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
                    commandListParam.Add(param);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return commandListParam;
        }
        public Command readByName(string Name)
        {
            Command command = null;
            string requete = "SELECT * from Command WHERE Name = '" + Name + "' order by IDCommand asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idCommand = Convert.ToInt32(r["IDCommand"]);
                    String name = r["Name"].ToString();
                    String picture = r["Picture"].ToString();
                    int idCategory = Convert.ToInt32(r["IDCategory"]);
                    command = new Command(idCommand, name, picture, idCategory);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return command;
        }
    }
}
