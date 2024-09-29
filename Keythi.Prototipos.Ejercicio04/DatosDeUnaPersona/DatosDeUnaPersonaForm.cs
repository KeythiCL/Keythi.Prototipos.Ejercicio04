using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Keythi.Prototipos.Ejercicio04.DatosDeUnaPersona
{
    public partial class DatosDeUnaPersonaForm : Form
    {
        private DatosDeUnaPersonaModelo modelo = new();

        public DatosDeUnaPersonaForm()
        {
            InitializeComponent();

            listViewPersona.Items.Clear();

            // Recorrer la lista de personas predefinidas
            foreach (var persona in modelo.Personas)
            {
                // Crear un nuevo elemento para el ListView
                ListViewItem item = new ListViewItem(persona.Documento.ToString());
                item.SubItems.Add(persona.Nombre);
                item.SubItems.Add(persona.Apellido);
                item.SubItems.Add(persona.TipoNumero.ToString());
                item.SubItems.Add(persona.CodigoPais.ToString());
                item.SubItems.Add(persona.CodigoArea.ToString());
                item.SubItems.Add(persona.NumeroTel.ToString());

                // Agregar el elemento al ListView
                listViewPersona.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e) // NUEVO INGRESO
        {
            DeseleccionarElementoListView();
            LimpiarFormulario();
            grupoColumnasPersonas.Enabled = false;
            grupoAñadirElemento.Enabled = true;
        }

        private void DatosDeUnaPersonaForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            var persona = new Persona();

            if (!int.TryParse(TxtDocumento.Text, out int documento))
            {
                MessageBox.Show("El documento no es numérico");
                return;
            }

            if (!int.TryParse(TxtCodPais.Text, out int codigoPais))
            {
                MessageBox.Show("El codigo no es numerico");
                return;
            }

            if (!int.TryParse(TxtCodArea.Text, out int codigoArea))
            {
                MessageBox.Show("El codigo no es numerico");
                return;
            }

            if (!int.TryParse(TxtNumTel.Text, out int numeroTel))
            {
                MessageBox.Show("El numero no es  numerico");
            }

            if (!Enum.TryParse<TiposNumero>(ComboBoxTiposTel.Text, out TiposNumero tipoNumero))
            {
                MessageBox.Show("Por favor seleccione una de las opciones");
            }


            persona.Documento = documento;
            persona.Nombre = TxtNombre.Text;
            persona.Apellido = TxtApellido.Text;
            persona.TipoNumero = tipoNumero;
            persona.CodigoPais = codigoPais;
            persona.CodigoArea = codigoArea;
            persona.NumeroTel = numeroTel;

            var Error = modelo.IngresarDatos(persona);
            if (Error == null)
            {
                MessageBox.Show("Datos ingresados correctamente");

                // Actualizar el ListView con la nueva persona
                ListViewItem item = new ListViewItem(persona.Documento.ToString());
                item.SubItems.Add(persona.Nombre);
                item.SubItems.Add(persona.Apellido);
                item.SubItems.Add(persona.TipoNumero.ToString());
                item.SubItems.Add(persona.CodigoPais.ToString());
                item.SubItems.Add(persona.CodigoArea.ToString());
                item.SubItems.Add(persona.NumeroTel.ToString());

                // Agregar la fila al ListView
                listViewPersona.Items.Add(item);

                // Limpiar los campos del formulario
                LimpiarFormulario();
                DeseleccionarElementoListView();
            }
            else
            {
                MessageBox.Show(Error);
            }
        }

        private void LimpiarFormulario()
        {
            TxtDocumento.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtCodPais.Clear();
            TxtCodArea.Clear();
            TxtNumTel.Clear();
            ComboBoxTiposTel.SelectedIndex = -1; // Reiniciar el ComboBox
        }

        private void botonFinalizar_Click(object sender, EventArgs e)
        {
            grupoColumnasPersonas.Enabled = true;
        }

        private void botonEliminarPersona_Click(object sender, EventArgs e)
        {
            if (listViewPersona.SelectedItems.Count > 0)
            {
                // Eliminar el elemento seleccionado
                listViewPersona.Items.Remove(listViewPersona.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un elemento para eliminar.");
            }

            LimpiarFormulario();
        }

        private void listViewPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPersona.SelectedItems.Count > 0)
            {
                var selectedItem = listViewPersona.SelectedItems[0];
                TxtDocumento.Text = selectedItem.SubItems[0].Text;
                TxtNombre.Text = selectedItem.SubItems[1].Text;
                TxtApellido.Text = selectedItem.SubItems[2].Text;
                ComboBoxTiposTel.SelectedItem = selectedItem.SubItems[3].Text;
                TxtCodPais.Text = selectedItem.SubItems[4].Text;
                TxtCodArea.Text = selectedItem.SubItems[5].Text;
                TxtNumTel.Text = selectedItem.SubItems[6].Text;
            }
        }

        private void botonModificarPersona_Click(object sender, EventArgs e)
        {
            if (listViewPersona.SelectedItems.Count > 0)
            {
                var selectedItem = listViewPersona.SelectedItems[0];

                // Validar los datos ingresados
                if (!int.TryParse(TxtDocumento.Text, out int documento) ||
                    !int.TryParse(TxtCodPais.Text, out int codigoPais) ||
                    !int.TryParse(TxtCodArea.Text, out int codigoArea) ||
                    !int.TryParse(TxtNumTel.Text, out int numeroTel))
                {
                    MessageBox.Show("Por favor, asegúrate de que todos los campos numéricos estén correctos.");
                    return;
                }

                // Modificar el objeto Persona en la lista
                var persona = modelo.Personas.First(p => p.Documento == int.Parse(selectedItem.SubItems[0].Text));
                persona.Documento = documento;
                persona.Nombre = TxtNombre.Text;
                persona.Apellido = TxtApellido.Text;
                persona.TipoNumero = (TiposNumero)Enum.Parse(typeof(TiposNumero), ComboBoxTiposTel.SelectedItem.ToString());
                persona.CodigoPais = codigoPais;
                persona.CodigoArea = codigoArea;
                persona.NumeroTel = numeroTel;

                // Actualizar el ListView
                selectedItem.SubItems[0].Text = persona.Documento.ToString();
                selectedItem.SubItems[1].Text = persona.Nombre;
                selectedItem.SubItems[2].Text = persona.Apellido;
                selectedItem.SubItems[3].Text = persona.TipoNumero.ToString();
                selectedItem.SubItems[4].Text = persona.CodigoPais.ToString();
                selectedItem.SubItems[5].Text = persona.CodigoArea.ToString();
                selectedItem.SubItems[6].Text = persona.NumeroTel.ToString();

                MessageBox.Show("Datos modificados correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un elemento para modificar.");
            }

            grupoAñadirElemento.Enabled = false;
            LimpiarFormulario();
        }

        private void DeseleccionarElementoListView()
        {
            // Deseleccionar el elemento en el ListView
            foreach (ListViewItem item in listViewPersona.SelectedItems)
            {
                item.Selected = false; // Desmarca el elemento seleccionado
            }
        }

    }
}
