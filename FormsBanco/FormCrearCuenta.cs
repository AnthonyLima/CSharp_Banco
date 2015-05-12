using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesBancoCSharp;

namespace FormsBanco
{
    public partial class FormCrearCuenta : Form
    {
        public FormCrearCuenta()
        {
            foreach (Cliente obj in Program.clientes)
            {
                cbClientes.Items.Add(obj);
            }

            InitializeComponent();
            cbTipoMoneda.Items.Add("Soles");
            cbTipoMoneda.Items.Add("Dolares");
            
        }

        private void FormCrearCuenta_Load(object sender, EventArgs e)
        {

        }

    }
}
