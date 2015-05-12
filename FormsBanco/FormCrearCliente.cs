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
    public partial class FormCrearCliente : Form
    {
        public FormCrearCliente()
        {
            InitializeComponent();
            foreach (Cliente obj in Program.clientes)
            {
                lbClientes.Items.Add(obj);
            }
        }

        private void tnCrear_Click(object sender, EventArgs e)
        {
            Cliente nuevocliente = new Cliente();
            nuevocliente.Nombre = tbNombre.Text;
            nuevocliente.Apellido = tbApellido.Text;
            nuevocliente.Dni = tbDni.Text;

            Program.clientes.Add(nuevocliente);

            lbClientes.Items.Add(nuevocliente);
        }

        private void FormCrearCliente_Load(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        }
    }
}
