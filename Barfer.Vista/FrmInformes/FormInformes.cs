using Barfer.Entidades;
using DocumentFormat.OpenXml.Drawing;
using Nancy.Json;
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
using static Barfer.Entidades.Informes.ExportadorJSON;
using static Barfer.Entidades.Informes.ExportadorCSV;

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
            List<Venta> ventas = Venta.ventas;
            string contenidoCSV = GenerarContenidoCSV(ventas);
            DescargarArchivoCSV(contenidoCSV);
        }

        private void btnDescargarJson_Click(object sender, EventArgs e)
        {
            List<Venta> dataList = Venta.ventas;
            string json = SerializarListaToJson(dataList);
            DescargarJson(json);
        }

        private void DescargarJson(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Archivos JSON (*.json)|*.json";
                        saveFileDialog.FileName = "ventas.json";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;

                            File.WriteAllText(filePath, jsonData);

                            MessageBox.Show("Archivo JSON guardado exitosamente.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al descargar los datos como JSON: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("No se pudo obtener el JSON serializado.");
            }
        }


        public void DescargarArchivoCSV(string contenidoCSV)
        {
            if (!string.IsNullOrEmpty(contenidoCSV))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
                    saveFileDialog.FileName = "datos.csv";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        File.WriteAllText(filePath, contenidoCSV);

                        MessageBox.Show("Archivo CSV guardado exitosamente.");
                    }
                }
            }
            else
            {
                Console.WriteLine("No se pudo obtener el contenido del archivo CSV.");
            }
        }






    }
}
