using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    class Profil
    {
        private int m_idProfil;
        private String m_name;
        private String m_status;
        private int m_idUser;
        private int m_idKeyboard;
        //Default constructor
        public Profil(String name, String status, int isUser, int idKeyboard)
        {
            m_name = name;
            m_status = status;
            m_idUser = isUser;
            m_idKeyboard = idKeyboard;
        }
        //Constructor with ID
        public Profil(int id, String name, String status, int isUser, int idKeyboard)
        {
            m_idProfil = id;
            m_name = name;
            m_status = status;
            m_idUser = isUser;
            m_idKeyboard = idKeyboard;
        }
        // [Getter/Setter] Int m_idProfil
        public int getId()
        {
            return this.m_idProfil;
        }
        public void setId(int id)
        {
            this.m_idProfil = id;
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
        // [Getter/Setter] String m_status
        public String getStatus()
        {
            return this.m_status;
        }
        public void setStatus(String status)
        {
            this.m_status = status;
        }
        // [Getter/Setter] Int m_idUser
        public int getIdUser()
        {
            return this.m_idUser;
        }
        public void setIdUser(int idUser)
        {
            this.m_idUser = idUser;
        }
        // [Getter/Setter] Int m_idKeyboard
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
