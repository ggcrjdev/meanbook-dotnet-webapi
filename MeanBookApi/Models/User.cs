using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeanBookApi.Models
{
    public class User
    {
        public string id { get; set; }
        public string username { get; set; }
        public DateTime loginDate { get; set; }

        public User(string username)
        {
            this.username = username;
            id = username;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            User objAsUser = (obj as User);
            if (id == null && objAsUser.id == null)
            {
                return true;
            }
            else if (id == null)
            {
                return false;
            }
            else
            {
                return id.Equals(objAsUser.id);
            }
        }
        public override int GetHashCode()
        {
            if (id == null)
            {
                return 0;
            }
            return id.GetHashCode();
        }
    }
}
