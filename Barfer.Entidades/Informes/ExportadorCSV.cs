using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.Informes
{
    public class ExportadorCSV
    {
        /// <summary>
        /// Genera el contenido de un archivo CSV a partir de una lista de objetos.
        /// </summary>
        /// <typeparam name="T">El tipo de los objetos en la lista.</typeparam>
        /// <param name="dataList">La lista de objetos para generar el contenido CSV.</param>
        /// <returns>Una cadena que representa el contenido del archivo CSV generado.</returns>
        public static string GenerarContenidoCSV<T>(List<T> dataList)
        {
            StringBuilder csvContent = new StringBuilder();


            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                csvContent.Append(property.Name + ",");
            }
            csvContent.AppendLine();


            foreach (var data in dataList)
            {
                foreach (var property in properties)
                {
                    var value = property.GetValue(data);
                    csvContent.Append(value + ",");
                }
                csvContent.AppendLine();
            }

            return csvContent.ToString();
        }
       
    }
}
