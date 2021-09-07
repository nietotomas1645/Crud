using Logica;
using Logica.Libreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Form1 : Form
    {
        private LEstudiantes estudiantes;
       // private Librerias librerias;
        public Form1()
        {
            InitializeComponent();
           // librerias = new Librerias();
            var listTextBox = new List<TextBox>();
            listTextBox.Add(txtNombre);
            listTextBox.Add(txtApellido);
            listTextBox.Add(txtDni);
            listTextBox.Add(txtEmail);
            var listLabel = new List<Label>();
            listLabel.Add(label5);
            listLabel.Add(label6);
            listLabel.Add(label7);
            listLabel.Add(label8);
            listLabel.Add(lblPaginas);

            Object[] objetos = { 
                pictureBoxImage,
                Properties.Resources.person_4_icon_icons_com_68900,
                dataGridView1,
                numericUpDown1
            };

            estudiantes = new LEstudiantes(listTextBox,listLabel, objetos);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            estudiantes.Registrar();
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            estudiantes.uploadimage.CargarImagen(pictureBoxImage);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                label5.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label5.ForeColor = Color.Green;
                label5.Text = "Nombre";
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiantes.textboxevent.textKeyPress(e);
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text.Equals(""))
            {
                label6.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label6.ForeColor = Color.Green;
                label6.Text = "Apellido";
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiantes.textboxevent.textKeyPress(e);
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals(""))
            {
                label7.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label7.ForeColor = Color.Green;
                label7.Text = "Dni";
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiantes.textboxevent.numberKeyPress(e);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals(""))
            {
                label8.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label8.ForeColor = Color.Green;
                label8.Text = "Email";
            }
        }

       

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            estudiantes.BuscasEstudiante(txtBuscar.Text);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnaanterior_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Primero");
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Anterior");
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Siguiente");
        }

        private void btnssiguiente_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Ultimo");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
                estudiantes.GetEstudiante();
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
                estudiantes.GetEstudiante();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            estudiantes.Eliminar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estudiantes.Restablecer();
        }
    }
}
