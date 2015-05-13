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
            InitializeComponent();
            foreach (Cuenta obj in Program.Cuentas)
            {
                lbCuentas.Items.Add(obj);
            }

            foreach (Cliente obj in Program.clientes )
            {
                cbClientes.Items.Add(obj);
            }

            cbTipoMoneda.Items.Add(TipoMoneda.Soles);
            cbTipoMoneda.Items.Add(TipoMoneda.Dolares);
            
        }

        private void FormCrearCuenta_Load(object sender, EventArgs e)
        {
            

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Cuenta nuevacuenta = new Cuenta();
            nuevacuenta._moneda = (TipoMoneda)cbTipoMoneda.SelectedItem;
            nuevacuenta._NumeroCuenta = Int32.Parse(tbNumeroCuenta.Text);

            Program.Cuentas.Add(nuevacuenta);

            lbCuentas.Items.Add(nuevacuenta);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

    }
}
