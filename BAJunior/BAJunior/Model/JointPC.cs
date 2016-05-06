using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    public class JointPC
    {
        private int m_idJointPC;
        private int m_idParam;
        private int m_idCommand;

        //Default constructor
        public JointPC(int idParam, int idCommand)
        {
            m_idParam = idParam;
            m_idCommand = idCommand;
        }
        //Constructor with ID
        public JointPC(int id, int idParam, int idCommand)
        {
            m_idJointPC = id;
            m_idParam = idParam;
            m_idCommand = idCommand;
        }
        // [Getter/Setter] Int m_idJointPC
        public int getId()
        {
            return this.m_idJointPC;
        }
        public void setId(int id)
        {
            this.m_idJointPC = id;
        }
        // [Getter/Setter] Int m_idParam
        public int getIdParam()
        {
            return this.m_idParam;
        }
        public void setIdParam(int idParam)
        {
            this.m_idParam = idParam;
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
