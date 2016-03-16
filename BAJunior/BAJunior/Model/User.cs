using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    class User
    {
        private String _login;
        private String _password;
        private bool _admin;

        // [Getter/Setter] String m_login
        public String getLogin() {
            return this._login;
        }
        public void setLogin(String login)
        {
            this._login = login;
        }

        // [Getter/Setter] String m_password
        public String getPassword()
        {
            return this._password;
        }
        public void setPassword(String password)
        {
            this._password = password;
        }

        // [Getter/Setter] Boolean m_admin
        public bool isAdmin() {
            return this._admin;
        }
        public void setAdmin(bool admin) {
            this._admin = admin;
        }
    }
}
