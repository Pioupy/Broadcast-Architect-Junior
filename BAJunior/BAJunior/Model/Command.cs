using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    class Command
    {
        private int m_idCommand;
        private String m_name;
        private String m_picture;
        private int m_idCategory;

        //Default constructor
        public Command(String name, String picture, int idCategory)
        {
            m_name = name;
            m_picture = picture;
            m_idCategory = idCategory;
        }
        //Constructor with ID
        public Command(int id, String name, String picture, int idCategory)
        {
            m_idCommand = id;
            m_name = name;
            m_picture = picture;
            m_idCategory = idCategory;
        }
        // [Getter/Setter] Int m_idCommand
        public int getId()
        {
            return this.m_idCommand;
        }
        public void setId(int id)
        {
            this.m_idCommand = id;
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
        // [Getter/Setter] String m_picture
        public String getPicture()
        {
            return this.m_picture;
        }
        public void setPicture(String picture)
        {
            this.m_picture = picture;
        }
        // [Getter/Setter] Int m_idCategory
        public int getIdCategory()
        {
            return this.m_idCategory;
        }
        public void setIdCategory(int idCategory)
        {
            this.m_idCategory = idCategory;
        }
    }
}
