using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    class Command
    {
        private int m_idComand;
        private String m_name;

        //Default constructor
        public Command(String name)
        {
            m_name = name;
        }
        //Constructor with ID
        public Command(int id, String name)
        {
            m_idComand = id;
            m_name = name;
        }
        // [Getter/Setter] Int m_idComand
        public int getId()
        {
            return this.m_idComand;
        }
        public void setId(int id)
        {
            this.m_idComand = id;
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
