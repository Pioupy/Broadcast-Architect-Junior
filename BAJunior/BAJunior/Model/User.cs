using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    class User
    {
        private String m_login;
        private String m_password;
        private bool m_admin;

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
        public bool isAdmin()
        {
            return this.m_admin;
        }
        public void setAdmin(bool admin)
        {
            this.m_admin = admin;
        }
    }
}
