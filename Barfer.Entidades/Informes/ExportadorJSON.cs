
using Nancy.Json;
using CsvHelper;
using System.IO;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.Informes
{
    public class ExportadorJSON
    {

        public static string SerializarListaToJson<T>(List<T> dataList)
        {
            try
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string jsonData = serializer.Serialize(dataList);
                return jsonData;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al serializar los datos a JSON: " + ex.Message);
                return null;
            }
        }

    }
}
