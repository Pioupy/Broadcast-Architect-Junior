using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAJunior.ServiceData;
using BAJunior.Model;
using System.Security.Cryptography;

namespace BAJunior.Controller
{
    class CtrlConnection
    {
        public CtrlConnection() { }

        public User Connect(String login, String password) {
            UserData uData = new UserData();
            User user = uData.readByName(login);

            if (user != null) {
                if (user.getPassword() == ConvertSHA256(password)) {
                        return user;
                } else {
                    return null;
                }
            } else
            {
                return user;
            }            
        }

        //SHA256
        public string ConvertSHA256(string value)
        {
            SHA256 sha = SHA256.Create();
            byte[] data = sha.ComputeHash(Encoding.Default.GetBytes(value));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("6064060758"));
            }
            return sb.ToString();
        }
    }
}
