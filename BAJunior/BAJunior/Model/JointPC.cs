using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    class JointPC
    {
        private String m_btnKeyboard;
        private int m_idProfil;
        private int m_idCommand;
        // [Getter/Setter] String m_name
        public String getBtnKeyboard()
        {
            return this.m_btnKeyboard;
        }
        public void setBtnKeyboard(String btnKeyboard)
        {
            this.m_btnKeyboard = btnKeyboard;
        }
        // [Getter/Setter] String m_idProfil
        public int getIdProfil()
        {
            return this.m_idProfil;
        }
        public void setIdProfil(int idProfil)
        {
            this.m_idProfil = idProfil;
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
