using RegistroAnalisisMedico.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAnalisisMedico.UI.Registros
{
    public partial class rAnalisis : Form
    {
        public rAnalisis()
        {
            InitializeComponent();
        }

      
        private Analisis LlenaClase()
        {
            Analisis anali = new Analisis();
            anali.AnalisisId = Convert.ToInt32(AnalisisIdnumericUpDown.Value);
            anali.Fecha = DateTime.Now;
            anali.Usuario = Convert.ToInt32(UsuariotextBox.Text);
            return anali;
        }

        public bool Validar(int error)
        {
            bool paso = false;

            if (error == 1 && AnalisisIdnumericUpDown.Value == 0)
            {
                errorProvider.SetError(AnalisisIdnumericUpDown, "Llenar ID");
                paso = true;
            }
            if (error == 2 && FechadateTimePicker.Value = DateTime.Now)
            {
                errorProvider.SetError(FechadateTimePicker, "Favor LLenar");
                paso = true;
            }
            if (error == 2 && string.IsNullOrEmpty(UsuariotextBox.Text))
            {
                errorProvider.SetError(UsuariotextBox, "Favor LLenar");
                paso = true;
            }
            return paso;
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            AnalisisIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            UsuariotextBox.Clear();
            errorProvider.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(2))
            {
                MessageBox.Show("Llenar campos", "Llene los campos",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Analisis anali = LlenaClase();

                bool paso = false;


                if (AnalisisIdnumericUpDown.Value == 0)
                {
                    paso = BLL.AnalisisBLL.Guardar(anali);

                }
                else
                {
                    paso = BLL.AnalisisBLL.Modificar(LlenaClase());
                }
                if (paso)
                {
                    MessageBox.Show("Guardado!!", "Se Guardo Correctamente",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AnalisisIdnumericUpDown.Value = 0;
                    FechadateTimePicker.Value = DateTime.Now;
                    UsuariotextBox.Clear();
                    errorProvider.Clear();
                }
                else
                {
                    MessageBox.Show("No se guardo!!", "Intente Guardar de nuevo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("El TipoID esta vacio", "Llene Campo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int id = Convert.ToInt32(AnalisisIdnumericUpDown.Value);

                if (BLL.AnalisisBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado", "Bien hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AnalisisIdnumericUpDown.Value = 0;
                    FechadateTimePicker.Value = DateTime.Now;
                    UsuariotextBox.Clear();
                    errorProvider.Clear();
                }
                else
                {
                    MessageBox.Show("No se puede Eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(AnalisisIdnumericUpDown.Value);
            Analisis anali = BLL.AnalisisBLL.Buscar(id);



            if (anali != null)
            {
                AnalisisIdnumericUpDown.Value = anali.AnalisisId;
                FechadateTimePicker.Value = anali.Fecha;
                UsuariotextBox.Text = anali.Usuario;

            }
            else
            {
                MessageBox.Show("No se encontro", "Intente Buscar de nuevo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
