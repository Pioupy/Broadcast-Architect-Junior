using System;
using System.Collections.Generic;
using System.Data;
using log4net;
using log4net.Config;
using BAJunior.Model;

namespace BAJunior.ServiceData
{
    class CategoryData
    {
        // On définit une variable logger static qui référence l'instance du logger nommé Program
        private static readonly ILog _log = LogManager.GetLogger(typeof(CategoryData));
        private static DbUtils m_dbUtils;
        public CategoryData()
        {
            // On charge la configuration de base qui log dans la console
            BasicConfigurator.Configure();
            m_dbUtils = new DbUtils();
        }
        public void create(Category pCategory)
        {
            string requete = "insert into Category (Name) values ('" + pCategory.getName() + "')";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Category has been created.");
                }
                else
                {
                    _log.Warn("Category has not been created.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }

        }
        public void update(Category pCategory)
        {
            string requete = "UPDATE Category SET Name = '" + pCategory.getName() + "' WHERE IDCategory = '" + pCategory.getId() + "';";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Category has been updated.");
                }
                else
                {
                    _log.Warn("Category has not been updated.");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public void delete(Category pCategory)
        {
            string requete = "DELETE FROM Category WHERE IDCategory = '" + pCategory.getId() + "'; ";
            try
            {
                if (m_dbUtils.executeQuery(requete) > 0)
                {
                    _log.Info("Category has been deleted");
                }
                else
                {
                    _log.Warn("Category has not been deleted");
                }
            }
            catch (Exception fail)
            {
                _log.Error(fail.Message);
            }
        }
        public Category read(int id)
        {
            Category category = null;
            string requete = "SELECT * from Category WHERE IDCategory = '" + id + "' order by IDCategory asc;";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idCategory = Convert.ToInt32(r["IDCategory"]);
                    string name = r["Name"].ToString();
                    category = new Category(idCategory, name);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return category;
        }
        public List<Category> readAll()
        {
            List<Category> categoryList = new List<Category>();
            string requete = "SELECT * from Category order by IDCategory asc";
            try
            {
                DataTable reader = m_dbUtils.executeReader(requete);

                foreach (DataRow r in reader.Rows)
                {
                    int idCategory = Convert.ToInt32(r["IDCategory"]);
                    String name = r["Name"].ToString();
                    Category category = new Category(idCategory, name);
                    categoryList.Add(category);
                }
            }
            catch (Exception fail)
            {
                _log.Error("error :" + fail.Message);
            }
            return categoryList;
        }
    }
}
