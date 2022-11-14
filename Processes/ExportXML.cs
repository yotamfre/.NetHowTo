using HowTo.Models;
using System.Collections.Generic;
using System.Data;

namespace HowTo.Processes
{
    public class ExportXML
    {
        public static bool ExportXMLData(List<PersonsModel> data, string file)
        {
            //Create DataTable
            DataTable dt = new DataTable();

            //Convert ArrayList to DataTable
            dt = ConvertObjects.ConvertListToDataTable(data);

            //Write DataTable as XML
            dt.WriteXml(file);

            //Export was successful
            return true;
        }
    }
}
