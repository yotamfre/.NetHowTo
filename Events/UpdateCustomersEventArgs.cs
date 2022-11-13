using HowTo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowTo.Events
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
