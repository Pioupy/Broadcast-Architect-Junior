using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    public class JointPAC
    {
        private int m_idJointPAC;
        private int m_btnKeyboard;
        private int m_bank;
        private int m_idProfil;
        private int m_idApplication;
        private int m_idCommandUser;

        //Default constructor
        public JointPAC(int btnKeyboard, int bank, int idProfil, int idApplication, int idCommand)
        {
            m_btnKeyboard = btnKeyboard;
            m_bank = bank;
            m_idProfil = idProfil;
            m_idApplication = idApplication;
            m_idCommandUser = idCommand;
        }
        //Constructor with ID
        public JointPAC(int id, int btnKeyboard, int bank, int idProfil, int idApplication, int idCommand)
        {
            m_idJointPAC = id;
            m_btnKeyboard = btnKeyboard;
            m_bank = bank;
            m_idProfil = idProfil;
            m_idApplication = idApplication;
            m_idCommandUser = idCommand;
        }
        // [Getter/Setter] Int m_idJointPEC
        public int getId()
        {
            return this.m_idJointPAC;
        }
        public void setId(int id)
        {
            this.m_idJointPAC = id;
        }
        // [Getter/Setter] Int m_btnKeyboard
        public int getBtnKeyboard()
        {
            return this.m_btnKeyboard;
        }
        public void setBtnKeyboard(int btnKeyboard)
        {
            this.m_btnKeyboard = btnKeyboard;
        }
        // [Getter/Setter] Int m_bank
        public int getBank()
        {
            return this.m_bank;
        }
        public void setBank(int bank)
        {
            this.m_bank = bank;
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
        // [Getter/Setter] Int m_idApplication
        public int getIdApplication()
        {
            return this.m_idApplication;
        }
        public void setIdApplication(int idApplication)
        {
            this.m_idApplication = idApplication;
        }
        // [Getter/Setter] Int m_idCommand
        public int getIdCommandUser()
        {
            return this.m_idCommandUser;
        }
        public void setIdCommandUser(int idCommandUser)
        {
            this.m_idCommandUser = idCommandUser;
        }
    }
}
