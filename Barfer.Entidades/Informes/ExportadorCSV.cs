using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.Informes
{
    public class ExportadorCSV
    {
        public static string GenerarContenidoCSV<T>(List<T> dataList)
        {
            StringBuilder csvContent = new StringBuilder();

            // Construir el encabezado CSV
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                csvContent.Append(property.Name + ",");
            }
            csvContent.AppendLine();

            // Construir los registros CSV
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
