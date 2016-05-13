using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    public class Param
    {
        private int m_idParam;
        private String m_name;
        private String m_value;
        private bool m_isUser;
        private int m_idCommand

        //Default constructor
        public Param(String name, String value, bool isUser)
        {
            m_name = name;
            m_value = value;
            m_isUser = isUser;
        }
        //Constructor with ID
        public Param(int id, String name, String value, bool isUser)
        {
            m_idParam = id;
            m_name = name;
            m_value = value;
            m_isUser = isUser;
        }
        // [Getter/Setter] Int m_idUSer
        public int getId()
        {
            return this.m_idParam;
        }
        public void setId(int id)
        {
            this.m_idParam = id;
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
        // [Getter/Setter] Int m_idCommand
        public int getId()
        {
            return this.m_idCommand;
        }
        public void setId(int idCommand)
        {
            this.m_idCommand = idCommand;
        }
    }
}
