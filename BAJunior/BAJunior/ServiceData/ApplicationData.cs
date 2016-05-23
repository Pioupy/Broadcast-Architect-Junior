using System;
using System.Collections.Generic;
using System.Data;
using log4net;
using log4net.Config;
using BAJunior.Model;

namespace BAJunior.ServiceData
{
    class ApplicationData
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(ApplicationData));
        private static DbUtils m_dbUtils;
        public ApplicationData()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_dbUtils = new DbUtils();
        }
        public void create(Application pApplication)
        {
            string requete = "insert into Application (Name, Link) values ('" + pApplication.getName() + "','" + pApplication.getLink() + "')";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Application has been created.");
                }
                else
                {
                    _log.Warn("Application has not been created.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }

        }
        public void update(Application pApplication)
        {
            string requete = "UPDATE Application SET Name = '" + pApplication.getName() + "', Link = '" + pApplication.getLink() + "' WHERE IDApplication = '" + pApplication.getId() + "';";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Application has been updated.");
                }
                else
                {
                    _log.Warn("Application has not been updated.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public void delete(Application pApplication)
        {
            string requete = "DELETE FROM Application WHERE IDApplication = '" + pApplication.getId() + "'; ";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Application has been deleted");
                }
                else
                {
                    _log.Warn("Application has not been deleted");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public Application read(int id)
        {
            Application application = null;
            string requete = "SELECT * from Application WHERE IDApplication = '" + id + "' order by IDApplication asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idApplication = Convert.ToInt32(r["IDApplication"]);
                    String name = r["Name"].ToString();
                    String link = r["Link"].ToString();
                    application = new Application(idApplication, name, link);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return application;
        }
        public List<Application> readAll()
        {
            List<Application> applicationList = new List<Application>();
            string requete = "SELECT * from Application order by IDApplication asc";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idApplication = Convert.ToInt32(r["IDApplication"]);
                    String name = r["Name"].ToString();
                    String link = r["Link"].ToString();
                    Application application = new Application(idApplication, name, link);
                    applicationList.Add(application);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return applicationList;
        }
        public Application readByName(String nameApplication)
        {
            Application application = null;
            string requete = "SELECT * from Application WHERE Name = '" + nameApplication + "' order by IDApplication asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idApplication = Convert.ToInt32(r["IDApplication"]);
                    String name = r["Name"].ToString();
                    String link = r["Link"].ToString();
                    application = new Application(idApplication, name, link);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return application;
        }
    }
}
