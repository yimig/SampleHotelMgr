using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        private string userName, userPwd, note;
        private int role;

        public User(string userName, string userPsw, int role)
        {
            UserName = userName;
            UserPwd = userPsw;
            Role = role;
        }

        public User()
        { }

        public string UserName
        {
            get => userName;
            set => userName = value;
        }

        public string UserPwd
        {
            get => userPwd;
            set => userPwd = Encryption.SHA1(value);
        }

        public string Note
        {
            get
            {
                if (note == null) return "";
                else
                {
                    return note;
                }
            }
            set => note = value;
        }

        public int Role
        {
            get => role;
            set => role = value;
        }
    }
}
