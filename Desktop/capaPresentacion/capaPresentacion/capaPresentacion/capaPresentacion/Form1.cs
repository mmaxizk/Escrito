using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using capaDatos;
using capaLogica;
using Entidades;
namespace capaPresentacion
{
    public partial class Form1 : Form
    {
        private CL_Propiedades logicaPropiedad = new CL_Propiedades();
        private CL_Venta logicaVenta = new CL_Venta();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarPropiedades();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                           string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            // Crear el nuevo objeto propiedad
            Propiedades nuevaPropiedad = new Propiedades
            {
                Tipo = comboBox1.Text,
                Direccion = textBox2.Text,
                MetrosCuadrados = int.Parse(textBox3.Text),
                Precio = int.Parse(textBox4.Text)
            };

            // Insertar la propiedad en la base de datos a través de la capa lógica
            logicaPropiedad.InsertarPropiedad(nuevaPropiedad);
            CargarPropiedades();

            // Limpiar los campos después de insertar
            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarPropiedades();
        }
        private void CargarPropiedades()
        {
            DataTable dt = logicaPropiedad.MostrarTodasLasPropiedades();
            dataGridView1.DataSource = dt;
        }

        public static void ConfigurarDataGridView(DataGridView dataGridView)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar la propiedad?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        logicaPropiedad.EliminarPropiedad(id);
                        CargarPropiedades();
                        MessageBox.Show("Propiedad eliminada exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la propiedad: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una propiedad a eliminar.");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (idPropiedadSeleccionada > 0 && !string.IsNullOrWhiteSpace(comboBox1.Text) &&
                 !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                 !string.IsNullOrWhiteSpace(textBox4.Text))
            {
                Propiedades propiedadActualizada = new Propiedades
                {
                    Id = idPropiedadSeleccionada,
                    Tipo = comboBox1.Text,
                    Direccion = textBox2.Text,
                    MetrosCuadrados = int.Parse(textBox3.Text),
                    Precio = int.Parse(textBox4.Text)
                };

                logicaPropiedad.ActualizarPropiedad(propiedadActualizada);
                CargarPropiedades();

                idPropiedadSeleccionada = 0;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una propiedad y completa todos los campos.");
            }

        }
        private int idElectrodomesticoSeleccionadoVenta;
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Validar que el campo de IVA no esté vacío
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("Por favor, ingresa un valor para el IVA.");
                    return;
                }

                // Obtener los datos de la propiedad seleccionada
                int idPropiedad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                int precio = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["precio"].Value);
                string tipoPropiedad = Convert.ToString(dataGridView1.SelectedRows[0].Cells["tipo"].Value); // Obtener tipo de propiedad

                // Obtener IVA desde el TextBox
                int iva = string.IsNullOrWhiteSpace(textBox6.Text) ? 0 : Convert.ToInt32(textBox6.Text);

                // Realizar la venta aplicando el descuento del 15% si es terreno
                logicaVenta.RealizarVenta(idPropiedad, precio, tipoPropiedad, iva);

                MessageBox.Show("La venta se completo y se genero correctamente el PDF.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una propiedad para la venta.");
            }
        }




        private void button6_Click(object sender, EventArgs e)
        {

        }
        private int idPropiedadSeleccionada;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idPropiedadSeleccionada = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["m2"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["precio"].Value.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}