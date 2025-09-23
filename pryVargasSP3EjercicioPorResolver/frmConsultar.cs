using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace pryVargasSP3EjercicioPorResolver
{
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
        }

        //Declaración variables
        int Indice = 0;
        string MarcaSeleccionada = "";
        string OrigenSeleccionado = "";

        //se utilizara para acumular los valores y mostrarlos
        string Resultado = "";


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Limpio controles
            cmbMarca.SelectedIndex = -1;
            chkImportado.Checked = false;
            chkImportado.Enabled = false;
            chkNacional.Checked = false;
            chkNacional.Enabled = false;
            cmbMarca.Focus();
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedIndex >= 0)
            {
                chkNacional.Enabled = true;
                chkImportado.Enabled = true;
            }
        }

        private void chkNacional_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNacional.Checked == true)
            {
                OrigenSeleccionado = "(N) Nacional"; //Otorgamos valor a la variable OrigenSeleccionado
                btnConsultar.Enabled = true;
            }
            else
            {
                btnConsultar.Enabled = false;
            }
        }

        private void chkImportado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImportado.Checked == true)
            {
                btnConsultar.Enabled = true;
                OrigenSeleccionado = "(I) Importado";
            }
            else
            {
                btnConsultar.Enabled = false;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Resultado = ""; //Limpiamos la variable para no acumular
            
            //otorgamos valor a la variable MarcaSeleccionada
            MarcaSeleccionada = cmbMarca.Text;

            while (Indice < frmRegistrar.indice) //Recorremos el vector hasta donde se esté lleno
            {
                //Verificamos que coincidan tanto marca como origen
                if (frmRegistrar.vecMarca[Indice] == MarcaSeleccionada && frmRegistrar.vecOrigen[Indice] == OrigenSeleccionado)
                {
                    Resultado += "Número: " + frmRegistrar.vecNumero[Indice] + Environment.NewLine;
                    Resultado += "Descripción: " + frmRegistrar.vecDescripcion[Indice] + Environment.NewLine;
                    Resultado += "Precio: $" + frmRegistrar.vecPrecio[Indice] + Environment.NewLine;
                    Resultado += "---------------------------" + Environment.NewLine;
                }
                Indice++;
            }
            if (Resultado == "")
            {
                Resultado = "No se encontraron repuestos con estos criterios.";
            }
            //Muestro los resultados de la bùsqueda
            txtResultado.Text = Resultado;

            //Limpio controles
            cmbMarca.SelectedIndex = -1;
            chkImportado.Checked = false;
            chkImportado.Enabled = false;
            chkNacional.Checked = false;
            chkNacional.Enabled = false;
            Indice = 0;
            cmbMarca.Focus();
        }

        
    }
}
