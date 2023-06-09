using Barfer.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barfer.Vista.FrmInformes
{
    public partial class FormInformes : Form
    {
        public FormInformes()
        {
            InitializeComponent();
        }

        private void btnDescargarCsv_Click(object sender, EventArgs e)
        {
            //ExportarListACSV(Venta.ventasPreparacion);
        }

        private void btnDescargarJson_Click(object sender, EventArgs e)
        {

            ExportarListAJSON(Venta.ventasPreparacion);
        }



        private void ExportarListAJSON(List<Venta> listaVentas) // Reemplaza "Venta" con el nombre de tu clase de datos
        {
            // Convertir la lista de ventas a formato JSON
            string json = JsonConvert.SerializeObject(listaVentas, Formatting.Indented);

            // Guardar el JSON en un archivo temporal
            string rutaArchivo = Path.GetTempFileName();
            File.WriteAllText(rutaArchivo, json);

            // Mostrar el diálogo de guardar archivo y descargar el JSON
            SaveFileDialog guardarDialogo = new SaveFileDialog();
            guardarDialogo.Filter = "Archivos JSON (*.json)|*.json";
            guardarDialogo.FileName = "ventas.json";

            if (guardarDialogo.ShowDialog() == DialogResult.OK)
            {
                File.Copy(rutaArchivo, guardarDialogo.FileName, true);
                File.Delete(rutaArchivo);

                MessageBox.Show("Archivo JSON exportado y descargado correctamente.");
            }
        }



        //private void ExportarListACSV(List<Venta> listaVentas) // Reemplaza "Venta" con el nombre de tu clase de datos
        //{
        //    // Crear una instancia de StringBuilder para construir el contenido del archivo CSV
        //    StringBuilder csvBuilder = new StringBuilder();

        //    // Agregar encabezados de columnas al archivo CSV
        //    var properties = typeof(Venta).GetProperties(); // Obtener las propiedades de la clase Venta

        //    for (int i = 0; i < properties.Length; i++)
        //    {
        //        csvBuilder.Append(properties[i].Name);

        //        if (i < properties.Length - 1)
        //            csvBuilder.Append(",");
        //    }

        //    csvBuilder.AppendLine();

        //    // Agregar filas de datos al archivo CSV
        //    foreach (Venta venta in listaVentas)
        //    {
        //        for (int i = 0; i < properties.Length; i++)
        //        {
        //            csvBuilder.Append(properties[i].GetValue(venta));

        //            if (i < properties.Length - 1)
        //                csvBuilder.Append(",");
        //        }

        //        csvBuilder.AppendLine();
        //    }

        //    // Guardar el contenido del archivo CSV en un archivo temporal
        //    string rutaArchivo = Path.GetTempFileName();
        //    File.WriteAllText(rutaArchivo, csvBuilder.ToString());

        //    // Mostrar el diálogo de guardar archivo y descargar el archivo CSV
        //    SaveFileDialog guardarDialogo = new SaveFileDialog();
        //    guardarDialogo.Filter = "Archivos CSV (*.csv)|*.csv";
        //    guardarDialogo.FileName = "ventas.csv";

        //    if (guardarDialogo.ShowDialog() == DialogResult.OK)
        //    {
        //        File.Copy(rutaArchivo, guardarDialogo.FileName, true);
        //        File.Delete(rutaArchivo);

        //        MessageBox.Show("Archivo CSV exportado y descargado correctamente.");
        //    }
        //}
    }
}
