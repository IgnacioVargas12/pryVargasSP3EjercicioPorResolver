namespace pryVargasSP3EjercicioPorResolver
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        //Declaración variables
        public static int indice = 0;
        string Marca = "";
        string Origen = "";
        int Numero = 0;
        string Descripcion = "";
        float Precio = 0;

        //Declaración array
        //Lo declaramos public static para poder usarlos en el otro formulario
        public static string[] vecMarca = new string[100];
        public static string[] vecOrigen = new string[100];
        public static int[] vecNumero = new int[100];
        public static string[] vecDescripcion = new string[100];
        public static float[] vecPrecio = new float[100];

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Otorgamos valor a las variables
            Marca = cmbMarca.Text;
            Origen = cmbOrigen.Text;
            Numero = Convert.ToInt32(mtbNumero.Text.Trim()); //.Trim borra los espacios que hay
            Descripcion = txtDescripcion.Text;
            Precio = Convert.ToInt32(mtbPrecio.Text.Trim()); //.Trim borra los espacio que hay

            //Grabamos datos en los array

            //Validamos que el array no este lleno
            if (indice >= vecNumero.Length)
            {
                MessageBox.Show("El array se encuentra lleno, no se puede grabar más datos.","Array lleno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIngresar.Enabled = false; //Deshabilitamos el btnIngresar para no agregar ningún dato nuevo
                return; //detiene el el procedimiento para que no grabe ningún dato
            }

            //Validar que no haya un número repetido en el array
            int i = 0;
            bool existe = false;

            while (i < indice && existe == false)   // recorre solo hasta la cantidad cargada y existe sea falso
            {
                if (vecNumero[i] == Numero)
                {
                    existe = true;
                }
                i++;
            }

            if (existe == true) //Validamos si sale del while por repetir número o no 
            {
                MessageBox.Show("Ya existe un repuesto con ese número.", "Número repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Grabamos los datos
                vecMarca[indice] = Marca;
                vecOrigen[indice] = Origen;
                vecNumero[indice] = Numero;
                vecDescripcion[indice] = Descripcion;
                vecPrecio[indice] = Precio;

                indice++;
            }
            LimpiarControles();
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validamos para habilitar cmbOrigen
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
            //Validamos para habilitar txtDescripción
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
            //Validamos para habilitar el mtbPrecio
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
            //Validamos para habilitar el btnIngresar
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
            //Limpiamos los controles
            cmbMarca.SelectedIndex = -1;
            cmbOrigen.SelectedIndex = -1;
            mtbNumero.Text = "";
            txtDescripcion.Text = "";
            mtbPrecio.Text = "";
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validamos para habilitar el mtbNumero
            if (cmbOrigen.SelectedIndex >= 0)
            {
                mtbNumero.Enabled = true;
            }
            else
            {
                mtbNumero.Enabled = false;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Abrimos un nuevo formulario para consultar
            frmConsultar ventanaConsultar = new frmConsultar();

            ventanaConsultar.ShowDialog();
        }
    }
}
