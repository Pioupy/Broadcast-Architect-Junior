using log4net;
using log4net.Config;
using System;
using System.Data;
using System.Collections.Generic;
using BAJunior.Model;

namespace BAJunior.ServiceData
{
    class KeyboardData
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(KeyboardData));
        private static DbUtils m_dbUtils;
        public KeyboardData()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_dbUtils = new DbUtils();
        }
        public void create(Keyboard pKeyboard)
        {
            string requete = "insert into Keyboard (Name) values ('" + pKeyboard.getName() + "')";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Keyboard has been created.");
                }
                else
                {
                    _log.Warn("Keyboard has not been created.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }

        }
        public void update(Keyboard pKeyboard)
        {
            string requete = "UPDATE Keyboard SET Name = '" + pKeyboard.getName() + "' WHERE IDKeyboard = '" + pKeyboard.getId() + "';";

            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Keyboard has been updated.");
                }
                else
                {
                    _log.Warn("Keyboard has not been updated.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public void delete(Keyboard pKeyboard)
        {
            string requete = "DELETE FROM Keyboard WHERE IDKeyboard = '" + pKeyboard.getId() + "'; ";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Keyboard has been deleted");
                }
                else
                {
                    _log.Warn("Keyboard has not been deleted");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public Keyboard read(int id)
        {
            Keyboard keyboard = null;
            string requete = "SELECT * from Keyboard WHERE IDKeyboard = '" + id + "' order by IDKeyboard asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idKeyboard = Convert.ToInt32(r["IDKeyboard"]);
                    String name = r["Name"].ToString();
                    keyboard = new Keyboard(idKeyboard, name);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return keyboard;
        }
        public List<Keyboard> readAll()
        {
            List<Keyboard> keyboardList = new List<Keyboard>();
            string requete = "SELECT * from Keyboard order by IDKeyboard asc";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idKeyboard = Convert.ToInt32(r["IDKeyboard"]);
                    String name = r["Name"].ToString();
                    Keyboard keyboard = new Keyboard(idKeyboard, name);
                    keyboardList.Add(keyboard);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return keyboardList;
        }
    }
}
