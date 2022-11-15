using HowTo.Models;
using System.Collections.Generic;
using System.Data;

namespace HowTo.Processes
{
    public class ExportXML
    {
        public static bool ExportXMLData(DataTable data, string file)
        {
            //Write DataTable as XML
            data.WriteXml(file);

            //Export was successful
            return true;
        }
    }
}
