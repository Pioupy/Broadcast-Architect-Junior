using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    class Param
    {
        private int m_idParam;
        private String m_name;
        private int m_idSetCommand;
        private int m_idCommand;
        //Default constructor
        public Param(String name, int idSetCommand, int idCommand)
        {
            m_name = name;
            m_idSetCommand = idSetCommand;
            m_idCommand = idCommand;
        }
        //Constructor with ID
        public Param(int id, String name, int idSetCommand, int idCommand)
        {
            m_idParam = id;
            m_name = name;
            m_idSetCommand = idSetCommand;
            m_idCommand = idCommand;
        }
        // [Getter/Setter] Int m_idParam
        public int getId()
        {
            return this.m_idParam;
        }
        public void setId(int id)
        {
            this.m_idParam = id;
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
        // [Getter/Setter] Int m_idSetCommand
        public int getIdSetCommand()
        {
            return this.m_idSetCommand;
        }
        public void setIdSetCommand(int idSetCommand)
        {
            this.m_idSetCommand = idSetCommand;
        }
        // [Getter/Setter] Int m_idCommand
        public int getIdCommand()
        {
            return this.m_idCommand;
        }
        public void setIdCommand(int idCommand)
        {
            this.m_idCommand = idCommand;
        }
    }
}
