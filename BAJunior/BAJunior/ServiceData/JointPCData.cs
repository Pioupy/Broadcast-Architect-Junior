using log4net;
using log4net.Config;
using System;
using System.Data;
using System.Collections.Generic;
using BAJunior.Model;

namespace BAJunior.ServiceData
{
    class JointPCData
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(JointPCData));
        private static DbUtils m_dbUtils;
        public JointPCData()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_dbUtils = new DbUtils();
        }
        public void create(JointPC pJointPC)
        {
            string requete = "insert into JointPC (IDParam, IDCommand) values ('" + pJointPC.getIdParam() + "','" + pJointPC.getIdCommand() + "')";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("JointPC has been created.");
                }
                else
                {
                    _log.Warn("JointPC has not been created.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }

        }
        public void update(JointPC pJointPC)
        {
            string requete = "UPDATE JointPC SET IDParam = '" + pJointPC.getIdParam() + "', IDCommand = '" + pJointPC.getIdCommand() + "' WHERE IDJointPC = '" + pJointPC.getId() + "';";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("JointPC has been updated.");
                }
                else
                {
                    _log.Warn("JointPC has not been updated.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public void delete(JointPC pJointPC)
        {
            string requete = "DELETE FROM JointPC WHERE IDJointPC = '" + pJointPC.getId() + "'; ";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("JointPC has been deleted");
                }
                else
                {
                    _log.Warn("JointPC has not been deleted");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public JointPC read(int id)
        {
            JointPC jointPC = null;
            string requete = "SELECT * from JointPC WHERE IDJointPC = '" + id + "' order by IDJointPC asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idJointPC = Convert.ToInt32(r["IDJointPC"]);
                    int idParam = Convert.ToInt32(r["IDParam"]);
                    int idCommand = Convert.ToInt32(r["IDCommand"]);
                    jointPC = new JointPC(idJointPC, idParam, idCommand);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return jointPC;
        }
        public List<JointPC> readAll()
        {
            List<JointPC> jointPCList = new List<JointPC>();
            string requete = "SELECT * from JointPC order by IDJointPC asc";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idJointPC = Convert.ToInt32(r["IDJointPC"]);
                    int idParam = Convert.ToInt32(r["IDParam"]);
                    int idCommand = Convert.ToInt32(r["IDCommand"]);
                    JointPC jointPC = new JointPC(idJointPC, idParam, idCommand);
                    jointPCList.Add(jointPC);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return jointPCList;
        }
    }
}
