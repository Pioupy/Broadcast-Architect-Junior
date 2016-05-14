using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    class ParamUser
    {
        private int m_idParamUser;
        private String m_name;
        private String m_value;
        private bool m_isUser;
        private int m_idCommandUser;

        //Default constructor
        public ParamUser(String name, String value, bool isUser, int idCommand)
        {
            m_name = name;
            m_value = value;
            m_isUser = isUser;
            m_idCommandUser = idCommand;
        }
        //Constructor with ID
        public ParamUser(int id, String name, String value, bool isUser, int idCommand)
        {
            m_idParamUser = id;
            m_name = name;
            m_value = value;
            m_isUser = isUser;
            m_idCommandUser = idCommand;
        }
        // [Getter/Setter] Int m_idUSer
        public int getId()
        {
            return this.m_idParamUser;
        }
        public void setId(int id)
        {
            this.m_idParamUser = id;
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
        // [Getter/Setter] String m_value
        public String getValue()
        {
            return this.m_value;
        }
        public void setValue(String value)
        {
            this.m_value = value;
        }
        // [Getter/Setter] Boolean m_isUser
        public bool getIsUser()
        {
            return this.m_isUser;
        }
        public void setIsUser(bool isUser)
        {
            this.m_isUser = isUser;
        }
        // [Getter/Setter] Int m_idCommandUser
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
