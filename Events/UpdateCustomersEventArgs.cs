using SetForm1PropertyFromForm2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetForm1PropertyFromForm2.Events
{
    public class UpdateCustomersEventArgs : EventArgs
    {
        //ArrayList
        private List<CustomersModel> customers = new List<CustomersModel>();
        
        public UpdateCustomersEventArgs(List<CustomersModel> c)
        {
            customers = c;
        }

        public List<CustomersModel> GetCustomers
        {
            get
            {
                return customers;
            }
        }

    }
}
