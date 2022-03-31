using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile3Assinment.Model
{
    

        public class AdminUser
        {


            public string Name { get; set; }
            public int Id { get; set; }
            public int Age { get; set; }
            public List<StaffUser> staffUser = new List<StaffUser>();




            public override string ToString()
            {
                return "Admin User: " + Name + " " + Age + " " + Id + " " + staffUser;
            }


            public override bool Equals(Object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;
                AdminUser adminuser = (AdminUser)obj;
                return Age.Equals(adminuser.Age) && Name.Equals(adminuser.Name) && Id.Equals(adminuser.Id) && staffUser.Equals(adminuser.staffUser);
            }

        }



    }

