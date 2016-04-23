using System;
using System.Collections.Generic;
using System.Data;
using log4net;
using log4net.Config;
using BAJunior.Model;

namespace BAJunior.ServiceData
{
    class JointPACData
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(JointPACData));
        private static DbUtils m_dbUtils;
        public JointPACData()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_dbUtils = new DbUtils();
        }
        public void create(JointPAC pJointPAC)
        {
            string requete = "insert into JointPAC (BtnKeyboard, Bank, IDProfil, IDApplication, IDCommand) values ('" + pJointPAC.getBtnKeyboard() + "','" + pJointPAC.getBank() + "','" + pJointPAC.getIdProfil() + "','" + pJointPAC.getIdApplication() + "','" + pJointPAC.getIdCommand() + "')";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("JointPAC has been created.");
                }
                else
                {
                    _log.Warn("JointPAC has not been created.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }

        }
        public void update(JointPAC pJointPAC)
        {
            string requete = "UPDATE JointPAC SET BtnKeyboard = '" + pJointPAC.getBtnKeyboard() + "', Bank = '" + pJointPAC.getBank() + "', IDProfil = '" + pJointPAC.getIdProfil() + "', IDApplication = '" + pJointPAC.getIdApplication() + "', IDCommand = '" + pJointPAC.getIdCommand() + "' WHERE IDJointPAC = '" + pJointPAC.getId() + "';";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("JointPAC has been updated.");
                }
                else
                {
                    _log.Warn("JointPAC has not been updated.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public void delete(JointPAC pJointPAC)
        {
            string requete = "DELETE FROM JointPAC WHERE IDJointPAC = '" + pJointPAC.getId() + "'; ";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("JointPAC has been deleted");
                }
                else
                {
                    _log.Warn("JointPAC has not been deleted");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public JointPAC read(int id)
        {
            JointPAC jointPAC = null;
            string requete = "SELECT * from JointPAC WHERE IDJointPAC = '" + id + "' order by IDJointPAC asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idJointPAC = Convert.ToInt32(r["IDJointPAC"]);
                    int btnKeyboard = Convert.ToInt32(r["BtnKeyboard"]);
                    int bank = Convert.ToInt32(r["Bank"]);
                    int idProfil = Convert.ToInt32(r["IDProfil"]);
                    int idApplication = Convert.ToInt32(r["IDApplication"]);
                    int idCommand = Convert.ToInt32(r["IDCommand"]);
                    jointPAC = new JointPAC(idJointPAC, btnKeyboard, bank, idProfil, idApplication, idCommand);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return jointPAC;
        }
        public List<JointPAC> readAll()
        {
            List<JointPAC> jointPACList = new List<JointPAC>();
            string requete = "SELECT * from JointPAC order by IDJointPAC asc";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idJointPAC = Convert.ToInt32(r["IDJointPAC"]);
                    int btnKeyboard = Convert.ToInt32(r["BtnKeyboard"]);
                    int bank = Convert.ToInt32(r["Bank"]);
                    int idProfil = Convert.ToInt32(r["IDProfil"]);
                    int idApplication = Convert.ToInt32(r["IDApplication"]);
                    int idCommand = Convert.ToInt32(r["IDCommand"]);
                    JointPAC jointPAC = new JointPAC(idJointPAC, btnKeyboard, bank, idProfil, idApplication, idCommand);
                    jointPACList.Add(jointPAC);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return jointPACList;
        }
    }
}
