using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJunior.Model
{
    public class Keyboard
    {
        private int m_idKeyboard;
        private String m_name;

        //Default constructor
        public Keyboard(String name)
        {
            m_name = name;
        }
        //Constructor with ID
        public Keyboard(int id, String name)
        {
            m_idKeyboard = id;
            m_name = name;
        }
        // [Getter/Setter] Int m_idKeyboard
        public int getId()
        {
            return this.m_idKeyboard;
        }
        public void setId(int id)
        {
            this.m_idKeyboard = id;
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
    }
}
