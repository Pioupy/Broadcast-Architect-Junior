using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    class Application
    {
        private int m_idApplication;
        private String m_name;
        private String m_link;

        //Default constructor
        public Application(String name, String link)
        {
            m_name = name;
            m_link = link;
        }
        //Constructor with ID
        public Application(int id, String name, String link)
        {
            m_idApplication = id;
            m_name = name;
            m_link = link;
        }
        // [Getter/Setter] Int m_idApplication
        public int getId()
        {
            return this.m_idApplication;
        }
        public void setId(int id)
        {
            this.m_idApplication = id;
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
        // [Getter/Setter] String m_link
        public String getLink()
        {
            return this.m_link;
        }
        public void setLink(String link)
        {
            this.m_link = link;
        }
    }
}
