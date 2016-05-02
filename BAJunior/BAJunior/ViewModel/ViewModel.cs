using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAJunior.Model;

namespace BAJunior.ViewModel
{
    class ViewModel
    {        
        public List<Profil> Profils { get; set; }

        public class Profil
        {
            public string Name { get; set; }

            public string Status { get; set; }

            public List<Keyboard> Keyboard { get; set; }

        }
    }
}
