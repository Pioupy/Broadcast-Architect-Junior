using log4net;
using log4net.Config;
using System;
using System.Data;
using System.Collections.Generic;
using BAJunior.Model;

namespace BAJunior.ServiceData
{
    class ProfilData
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(ProfilData));
        private static DbUtils m_dbUtils;
        public ProfilData()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_dbUtils = new DbUtils();
        }
        public void create(Profil pProfil)
        {
            string requete = "insert into Profil (Name, Status, IDUser, IDKeyboard) values ('" + pProfil.getName() + "','" + pProfil.getStatus() + "','" + pProfil.getIdUser() + "','" + pProfil.getIdKeyboard() + "')";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Profil has been created.");
                }
                else
                {
                    _log.Warn("Profil has not been created.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }

        }
        public void update(Profil pProfil)
        {
            string requete = "UPDATE Profil SET Name = '" + pProfil.getName() + "', Status = '" + pProfil.getStatus() + "', IDUser = '" + pProfil.getIdUser() + "', IDKeyboard = '" + pProfil.getIdKeyboard() + "' WHERE IDProfil = '" + pProfil.getId() + "';";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Profil has been updated.");
                }
                else
                {
                    _log.Warn("Profil has not been updated.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public void delete(Profil pProfil)
        {
            string requete = "DELETE FROM Profil WHERE IDProfil = '" + pProfil.getId() + "'; ";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Profil has been deleted");
                }
                else
                {
                    _log.Warn("Profil has not been deleted");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public Profil read(int id)
        {
            Profil profil = null;
            string requete = "SELECT * from Profil WHERE IDProfil = '" + id + "' order by IDProfil asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idProfil = Convert.ToInt32(r["IDProfil"]);
                    String name = r["Name"].ToString();
                    String status = r["Status"].ToString();
                    int idUser = Convert.ToInt32(r["IDUser"]);
                    int idKeyboard = Convert.ToInt32(r["IDKeyboard"]);
                    profil = new Profil(idProfil, name, status, idUser, idKeyboard);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return profil;
        }
        public List<Profil> readAll()
        {
            List<Profil> profilList = new List<Profil>();
            string requete = "SELECT * from Profil order by IDProfil asc";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idProfil = Convert.ToInt32(r["IDProfil"]);
                    String name = r["Name"].ToString();
                    String status = r["Status"].ToString();
                    int idUser = Convert.ToInt32(r["IDUser"]);
                    int idKeyboard = Convert.ToInt32(r["IDKeyboard"]);
                    Profil profil = new Profil(idProfil, name, status, idUser, idKeyboard);
                    profilList.Add(profil);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return profilList;
        }
        public List<Profil> readByProfilId(int id)
        {
            List<Profil> profilList = new List<Profil>();
            string requete = "SELECT * from Profil WHERE IDProfil = '" + id + "' order by IDProfil asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idProfil = Convert.ToInt32(r["IDProfil"]);
                    String name = r["Name"].ToString();
                    String status = r["Status"].ToString();
                    int idUser = Convert.ToInt32(r["IDUser"]);
                    int idKeyboard = Convert.ToInt32(r["IDKeyboard"]);
                    Profil profil = new Profil(idProfil, name, status, idUser, idKeyboard);
                    profilList.Add(profil);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return profilList;
        }
    }
}
