using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    class Param
    {
        private String m_name;
        private int m_idSetCommand;
        private int m_idCommand;
        // [Getter/Setter] String m_name
        public String getName()
        {
            return this.m_name;
        }
        public void setName(String name)
        {
            this.m_name = name;
        }
        // [Getter/Setter] String m_idSetCommand
        public int getIdSetCommand()
        {
            return this.m_idSetCommand;
        }
        public void setIdSetCommand(int idSetCommand)
        {
            this.m_idSetCommand = idSetCommand;
        }
        // [Getter/Setter] String m_idCommand
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
