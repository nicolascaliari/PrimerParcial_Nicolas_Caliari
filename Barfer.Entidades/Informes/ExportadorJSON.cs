
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
        /// <summary>
        /// Serializa una lista de objetos en formato JSON.
        /// </summary>
        /// <typeparam name="T">El tipo de los objetos en la lista.</typeparam>
        /// <param name="dataList">La lista de objetos a serializar.</param>
        /// <returns>Una cadena que representa la lista serializada en formato JSON,
        /// o null si ocurre un error durante la serialización.</returns>
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
