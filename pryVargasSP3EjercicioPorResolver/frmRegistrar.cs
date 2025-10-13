namespace pryVargasSP3EjercicioPorResolver
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        //Declaraci�n variables
        public static int indice = 0;
        string Marca = "";
        string Origen = "";
        int Numero = 0;
        string Descripcion = "";
        float Precio = 0;

        //Declaraci�n Struct
        public struct datoRepuesto
        {
            public string marca;
            public string origen;
            public int numero;
            public string descripcion;
            public float precio;
        }

        //Declaraci�n array principal
        public static datoRepuesto[] vecRepuesto = new datoRepuesto[100];


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
            if (indice >= vecRepuesto.Length)
            {
                MessageBox.Show("El array se encuentra lleno, no se puede grabar m�s datos.", "Array lleno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIngresar.Enabled = false; //Deshabilitamos el btnIngresar para no agregar ning�n dato nuevo
                return; //detiene el el procedimiento para que no grabe ning�n dato
            }

            //Validar que no haya un n�mero repetido en el array
            int i = 0;
            bool existe = false;

            while (i < indice && existe == false)   // recorre solo hasta la cantidad cargada y mientras existe sea falso
            {
                if (vecRepuesto[i].numero == Numero)
                {
                    existe = true;
                }
                i++;
            }

            if (existe == true) //Validamos si sale del while por repetir n�mero o no 
            {
                MessageBox.Show("Ya existe un repuesto con ese n�mero.", "N�mero repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Grabamos los datos
                vecRepuesto[indice].marca = Marca;
                vecRepuesto[indice].origen = Origen;
                vecRepuesto[indice].numero = Numero;
                vecRepuesto[indice].descripcion = Descripcion;
                vecRepuesto[indice].precio = Precio;

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
            //Validamos para habilitar txtDescripci�n
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
            cmbMarca.Focus();
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

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            //Cargamos items en el cmbMarca
            cmbMarca.Items.Add("(P) Peugeot");
            cmbMarca.Items.Add("(F) Fiat");
            cmbMarca.Items.Add("(R) Renault");

        }
    }
}
