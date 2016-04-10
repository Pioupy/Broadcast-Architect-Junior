using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    class Profil
    {
        private String m_name;
        private String m_status;
        private int m_idUser;
        private int m_idKeyboard;
        // [Getter/Setter] String m_name
        public String getName()
        {
            return this.m_name;
        }
        public void setName(String name)
        {
            this.m_name = name;
        }
        // [Getter/Setter] String m_status
        public String getStatus()
        {
            return this.m_status;
        }
        public void setStatus(String status)
        {
            this.m_status = status;
        }
        // [Getter/Setter] String m_idUser
        public int getIdUsere()
        {
            return this.m_idUser;
        }
        public void setIdUser(int idUser)
        {
            this.m_idUser = idUser;
        }
        // [Getter/Setter] String m_idKeyboard
        public int getIdKeyboard()
        {
            return this.m_idKeyboard;
        }
        public void setIdKeyboard(int idKeyboard)
        {
            this.m_idKeyboard = idKeyboard;
        }
    }
}
