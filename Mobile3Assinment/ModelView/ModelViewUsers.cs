using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobile3Assinment.Model;
using Mobile3Assinment.View;


namespace Mobile3Assinment.ModelView
{

    public class InvalidDataException : Exception
    {
        public InvalidDataException(string message) : base(message)
        {
        }
    }

    public class DuplicateIdException : Exception
    {
        public DuplicateIdException(string message) : base(message)
        {
        }
    }


    public class DeleteNotFoundUserException : Exception
        {
            public DeleteNotFoundUserException(string message) : base(message)
            {
            }
        }

    public class UpdateNotFoundUserException : Exception
    {
        public UpdateNotFoundUserException(string message) : base(message)
        {
        }
    }

    public static class  ModelViewUsers
    {

       
        /// Method to Delete object from observable collection


        public static ObservableCollection<AdminUser> admin = new ObservableCollection<AdminUser>();
        public static ObservableCollection<StaffUser> staffs = new ObservableCollection<StaffUser>();
        public static ObservableCollection<Users> user = new ObservableCollection<Users>();


        public static void DeleteObject<T>(this ObservableCollection<T> collection, Func<T, bool> match )
        {
            ViewUser viewuser = new ViewUser();
            viewuser.onDelete = Updateview;
            for (int i = 0; i <= collection.Count - 1; i++)
            {
                if (match(collection[i]))

                {

                    collection.Remove(collection[i]);
                    
                    break;
                }
                else
                {
                    throw new DeleteNotFoundUserException("try to delete a user that is not found");
                }
            }
        }

        private static void Updateview(Users userrs)
        {
            throw new NotImplementedException();
        }




        /// Method to Add admin object to  observable collection

        public static bool AddAdmin(int id, string name, int age, List<StaffUser> staff)
        {
            if (id.GetType() != typeof(int) || name.GetType() != typeof(string) || age.GetType() != typeof(int) || staff.GetType() != typeof(List<StaffUser>))
            {
                throw new InvalidDataException("enter invald data ");


            }
            else
            {

                if (admin.Any(u => u.Id == id))
                {
                    throw new DuplicateIdException(" try to add a new user with a duplicate id");
                }
                else
                {
                    admin.Add(new AdminUser { Id = id, Name = name, Age = age, staffUser = staff });

            return true;

                    
                }
            }
        }




        public static bool Addstaff(int id, string name, int age, Enum role1)
        {
            if (id.GetType() != typeof(int) || name.GetType() != typeof(string) || age.GetType() != typeof(int) || role1.GetType() != typeof(Enum))
            {
                throw new InvalidDataException("enter invald data ");


            }
            else
            {

                if (staffs.Any(u => u.Id == id))
                {
                    throw new DuplicateIdException(" try to add a new user with a duplicate id");
                }
                else
                {
                    staffs.Add(new StaffUser { Id = id, Name = name, Age = age, role = (Role)role1 });


                    return true;
                }
            }
        }


        public static bool AddUser(int id, string name, int age)
        {
            Users user1=new Users();

            ViewUser viewuser = new ViewUser();

            viewuser.onUpdate = Updateview;

            if (id.GetType() != typeof(int) || name.GetType() != typeof(string) || age.GetType() != typeof(int))
            {
                throw new InvalidDataException("enter invald data ");


            }
            else
            {
                if (user.Any(u => u.Id == id))
                {
                    throw new DuplicateIdException(" try to add a new user with a duplicate id");
                }
                else
                {
                    user.Add(new Users { Id = id, Name = name, Age = age });


                    return true;
                }
            }
        }
        /// Method to update object of  observable collection

        public static void UpdateObject<T>(this ObservableCollection<T> collection, Func<T, bool> match, T newItem)
        {
            ViewUser viewuser = new ViewUser();
            viewuser.onUpdate= Updateview;

            for (int i = 0; i <= collection.Count - 1; i++)
            {
                if (match(collection[i]))
                {
                    collection[i] = newItem;
                    break;
                }
                else
                {

                    throw new UpdateNotFoundUserException("try to update a user that is not found ");
                }

                
            }
        }


      
    }
}
