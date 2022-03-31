using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobile3Assinment.ModelView;
using Mobile3Assinment.Model;


namespace Mobile3Assinment.View
{
    public class ViewUser
    {

        public delegate void printUserDelegate(Users userrs);
        public delegate void printsatfffDelegate(StaffUser stafff);
        public delegate void printadminDelegate(StaffUser adminnn);

        public printUserDelegate onAdd;

        public printUserDelegate onDelete;

        public printUserDelegate onUpdate;


        public printsatfffDelegate onAddstaff;
        public printadminDelegate onAddadmin;
        private void TestMethod()
        {
            Action<Exception> errorHandler = (ex) =>
            {
            };

            try
            {




            }
            catch (ModelView.InvalidDataException ex) { errorHandler(ex);
                Console.WriteLine("Enter invalid data");
            }
            catch (DuplicateIdException ex) { errorHandler(ex);
                Console.WriteLine("Duplicate Id ");
            }
            catch (DeleteNotFoundUserException ex) { errorHandler(ex);
                Console.WriteLine("Delete a non exist User");
            }
            catch (UpdateNotFoundUserException ex) { errorHandler(ex);
                Console.WriteLine("update a non exist User");
            }

        }


    }

}


