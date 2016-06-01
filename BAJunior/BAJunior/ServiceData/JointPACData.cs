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
            string requete = "insert into JointPAC (BtnKeyboard, Bank, IDProfil, IDApplication, IDCommandUser) values ('" + pJointPAC.getBtnKeyboard() + "','" + pJointPAC.getBank() + "','" + pJointPAC.getIdProfil() + "','" + pJointPAC.getIdApplication() + "','" + pJointPAC.getIdCommandUser() + "')";
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
            string requete = "UPDATE JointPAC SET BtnKeyboard = '" + pJointPAC.getBtnKeyboard() + "', Bank = '" + pJointPAC.getBank() + "', IDProfil = '" + pJointPAC.getIdProfil() + "', IDApplication = '" + pJointPAC.getIdApplication() + "', IDCommandUser = '" + pJointPAC.getIdCommandUser() + "' WHERE IDJointPAC = '" + pJointPAC.getId() + "';";
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
                    int idCommandUser = Convert.ToInt32(r["IDCommandUser"]);
                    jointPAC = new JointPAC(idJointPAC, btnKeyboard, bank, idProfil, idApplication, idCommandUser);
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
                    int idCommandUser = Convert.ToInt32(r["IDCommandUser"]);
                    JointPAC jointPAC = new JointPAC(idJointPAC, btnKeyboard, bank, idProfil, idApplication, idCommandUser);
                    jointPACList.Add(jointPAC);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return jointPACList;
        }
        public List<JointPAC> readByProfilId(int id)
        {
            List<JointPAC> jointPACList = new List<JointPAC>();
            string requete = "SELECT * from JointPAC WHERE IDProfil = '" + id + "' order by IDApplication asc;";
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
                    int idCommandUser = Convert.ToInt32(r["IDCommandUser"]);
                    JointPAC jointPAC = new JointPAC(idJointPAC, btnKeyboard, bank, idProfil, idApplication, idCommandUser);
                    jointPACList.Add(jointPAC);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return jointPACList;
        }
        public List<Model.Application> readAllApplicationByProfil(int id)
        {
            List<Model.Application> jointPACList = new List<Model.Application>();
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
                    int idCommandUser = Convert.ToInt32(r["IDCommandUser"]);
                    JointPAC jointPAC = new JointPAC(idJointPAC, btnKeyboard, bank, idProfil, idApplication, idCommandUser);
                    //jointPACList.Add(jointPAC);
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
