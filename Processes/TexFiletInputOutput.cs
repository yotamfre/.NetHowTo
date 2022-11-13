using HowTo.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace HowTo.Processes
{
    public static class TexFiletInputOutput
    {
        private static List<CustomersModel> customers;

        public static List<CustomersModel> GetGuardiansData(string file)
        {
            customers = new List<CustomersModel>();
            string line = string.Empty;

            try
            {
                //Check if the file exists
                if (File.Exists(file))
                {
                    //Create a Stream Reader
                    using (StreamReader rdr = new StreamReader(file))
                    {
                        //Read the data in the file
                        while ((line = rdr.ReadLine()) != null)
                        {
                            //Add data to the Customers Model
                            customers.Add(new CustomersModel()
                            {
                                Customer = line
                            });
                        }
                    }
                }
                else
                {
                    throw new Exception("File Not Found!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return customers;
        }
    }
}
