using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    class User
    {
        private int m_idUser;
        private String m_login;
        private String m_password;
        private bool m_admin;

        //Default constructor
        public User(String login, String password, bool isAdmin)
        {
            m_login = login;
            m_password = password;
            m_admin = isAdmin;
        }
        //Constructor with ID
        public User(int id, String login, String password, bool isAdmin)
        {
            m_idUser = id;
            m_login = login;
            m_password = password;
            m_admin = isAdmin;
        }
        // [Getter/Setter] Int m_idUSer
        public int getId()
        {
            return this.m_idUser;
        }
        public void setId(int id)
        {
            this.m_idUser = id;
        }
        // [Getter/Setter] String m_login
        public String getLogin()
        {
            return this.m_login;
        }
        public void setLogin(String login)
        {
            this.m_login = login;
        }
        // [Getter/Setter] String m_password
        public String getPassword()
        {
            return this.m_password;
        }
        public void setPassword(String password)
        {
            this.m_password = password;
        }
        // [Getter/Setter] Boolean m_admin
        public bool getIsAdmin()
        {
            return this.m_admin;
        }
        public void setIsAdmin(bool admin)
        {
            this.m_admin = admin;
        }
    }
}
