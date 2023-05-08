using Barfer.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barfer.Vista
{
    public partial class Reportes : Form
    {
        public List<Venta> venta = new List<Venta>();
        public Reportes()
        {
            InitializeComponent();

        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            foreach (var row in venta)
            {
                MessageBox.Show(row.Cliente.ToString());
                dataGridView1.Rows.Add(row.Cliente, row.Alimento, row.Cantidad, row.PrecioTotal, row.Fecha, row.Estado);
            }
        }
    }
}
