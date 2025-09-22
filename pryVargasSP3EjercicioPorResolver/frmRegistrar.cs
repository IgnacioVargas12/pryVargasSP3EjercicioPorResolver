namespace pryVargasSP3EjercicioPorResolver
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        //Declaración variables
        int indice = 0;
        string Marca = "";
        string Origen = "";
        int Numero = 0;
        string Descripcion = "";
        float Precio = 0;

        //Declaración array
        string[] vecRepuestos = new string[100];

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedIndex >= 0)
            {
                cmbOrigen.Enabled = true;
            }
            else
            {
                cmbOrigen.Enabled = false;
            }
        }

        private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbNumero_TextChanged(object sender, EventArgs e)
        {
            if (mtbNumero.Text != "")
            {
                txtDescripcion.Enabled = true;
            }
            else
            {
                txtDescripcion.Enabled = false;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                mtbPrecio.Enabled = true;
            }
            else
            {
                mtbPrecio.Enabled = false;
            }
        }

        private void mtbPrecio_TextChanged(object sender, EventArgs e)
        {
            if (mtbPrecio.Text != "")
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            cmbMarca.SelectedIndex = -1;
            cmbOrigen.Text = "";
            mtbNumero.Text = "";
            txtDescripcion.Text = "";
            mtbPrecio.Text = "";
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedIndex >= 0)
            {
                mtbNumero.Enabled = true;
            }
            else
            {
                mtbNumero.Enabled = false;
            }
        }
    }
}
