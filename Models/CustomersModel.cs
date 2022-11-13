using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowTo.Models
{
    public class CustomersModel
    {
        public string Customer { get; set; }

        public CustomersModel()
        {

        }

        public CustomersModel(string c)
        {
            Customer = c;
        }

        public static List<CustomersModel> GetCustomers()
        {
            return new List<CustomersModel>
            {
               new CustomersModel("Customer 1"),
               new CustomersModel("Customer 2"),
               new CustomersModel("Customer 3")
            };
        }
    }
}
