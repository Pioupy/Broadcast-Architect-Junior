using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    class JointPC
    {
        private int m_idJointPC;
        private String m_btnKeyboard;
        private int m_idProfil;
        private int m_idCommand;

        //Default constructor
        public JointPC(String btnKeyboard, int idProfil, int idCommand)
        {
            m_btnKeyboard = btnKeyboard;
            m_idProfil = idProfil;
            m_idCommand = idCommand;
        }
        //Constructor with ID
        public JointPC(int id, String btnKeyboard, int idProfil, int idCommand)
        {
            m_idJointPC = id;
            m_btnKeyboard = btnKeyboard;
            m_idProfil = idProfil;
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

        // [Getter/Setter] String m_name
        public String getBtnKeyboard()
        {
            return this.m_btnKeyboard;
        }
        public void setBtnKeyboard(String btnKeyboard)
        {
            this.m_btnKeyboard = btnKeyboard;
        }
        // [Getter/Setter] Int m_idProfil
        public int getIdProfil()
        {
            return this.m_idProfil;
        }
        public void setIdProfil(int idProfil)
        {
            this.m_idProfil = idProfil;
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
