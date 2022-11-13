using HowTo.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace HowTo.Processes
{
    public static class TexFiletInputOutput
    {
        private static List<PersonsModel> customers;

        public static List<PersonsModel> GetGuardiansData(string file)
        {
            customers = new List<PersonsModel>();
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
                            customers.Add(new PersonsModel()
                            {
                                Person = line
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
