using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Mobile3Assinment.Model
{


      



        public class Users
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public int Age { get; set; }



            public override string ToString()
            {
                return "User: " + Name + " " + Age + " " + Id;
            }


            public override bool Equals(Object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;
                Users user = (Users)obj;

                return Age.Equals(user.Age) && Name.Equals(user.Name) && Id.Equals(user.Id);
            }

        }

    }


