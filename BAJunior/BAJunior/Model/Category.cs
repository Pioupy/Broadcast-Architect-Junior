using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    public class Category
    {
        private int m_idCategory;
        private String m_name;

        //Default constructor
        public Category(String name)
        {
            m_name = name;
        }
        //Constructor with ID
        public Category(int id, String name)
        {
            m_idCategory = id;
            m_name = name;
        }
        // [Getter/Setter] Int m_idCategory
        public int getId()
        {
            return this.m_idCategory;
        }
        public void setId(int id)
        {
            this.m_idCategory = id;
        }
        // [Getter/Setter] String m_name
        public String getName()
        {
            return this.m_name;
        }
        public void setName(String name)
        {
            this.m_name = name;
        }
    }
}
