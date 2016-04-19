using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    class SetCommand
    {
        private int m_idSetCommand;
        private String m_name;

        // Default constructor
        public SetCommand(String name)
        {
            m_name = name;
        }
        //Constructor with ID
        public SetCommand(int id, String name)
        {
            m_idSetCommand = id;
            m_name = name;
        }
        // [Getter/Setter] int m_idSetCommand
        public int getId()
        {
            return this.m_idSetCommand;
        }
        public void setId(int id)
        {
            this.m_idSetCommand = id;
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
