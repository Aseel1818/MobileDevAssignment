using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile3Assinment.Model
{
    
        public enum Role
        {

            Role1,
            Role2,
            Role3

        }

        public class StaffUser
        {

            public Role role { get; set; }


            public string Name { get; set; }
            public int Age { get; set; }
            public int Id { get; set; }

            public static string ToString(Role value)
            {
                return value.ToString();
            }


            public override string ToString()
            {
                return "Staff User: " + Name + " " + Age + " " + Id + " " + ToString(Role.Role1) + "    " + ToString(Role.Role2) + "    " + ToString(Role.Role3);
            }

            public override bool Equals(Object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;
                StaffUser staffuser = (StaffUser)obj;
                return Age.Equals(staffuser.Age) && Name.Equals(staffuser.Name) && Id.Equals(staffuser.Id) && role.Equals(staffuser.role);
            }


        }




    }

