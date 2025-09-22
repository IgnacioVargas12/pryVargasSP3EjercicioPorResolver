namespace pryVargasSP3EjercicioPorResolver
{
    partial class frmRegistrar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMarca = new Label();
            lblOrigen = new Label();
            lblNumero = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            mtbNumero = new MaskedTextBox();
            txtDescripcion = new TextBox();
            mtbPrecio = new MaskedTextBox();
            cmbMarca = new ComboBox();
            lblDatosRepuesto = new Label();
            btnIngresar = new Button();
            btnCancelar = new Button();
            cmbOrigen = new ComboBox();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(25, 37);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(22, 71);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(22, 104);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Número";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(22, 139);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(25, 170);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Location = new Point(97, 104);
            mtbNumero.Mask = "9999999";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(100, 23);
            mtbNumero.TabIndex = 6;
            mtbNumero.ValidatingType = typeof(int);
            mtbNumero.MaskInputRejected += mtbNumero_MaskInputRejected;
            mtbNumero.TextChanged += mtbNumero_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(97, 139);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 7;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // mtbPrecio
            // 
            mtbPrecio.Enabled = false;
            mtbPrecio.Location = new Point(97, 170);
            mtbPrecio.Mask = "9999999";
            mtbPrecio.Name = "mtbPrecio";
            mtbPrecio.Size = new Size(100, 23);
            mtbPrecio.TabIndex = 8;
            mtbPrecio.ValidatingType = typeof(int);
            mtbPrecio.TextChanged += mtbPrecio_TextChanged;
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "Peugeot", "Fiat", "Renault" });
            cmbMarca.Location = new Point(97, 34);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(121, 23);
            cmbMarca.TabIndex = 9;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // lblDatosRepuesto
            // 
            lblDatosRepuesto.BorderStyle = BorderStyle.Fixed3D;
            lblDatosRepuesto.Location = new Point(12, 9);
            lblDatosRepuesto.Name = "lblDatosRepuesto";
            lblDatosRepuesto.Size = new Size(227, 253);
            lblDatosRepuesto.TabIndex = 10;
            lblDatosRepuesto.Text = "Datos del repuesto";
            // 
            // btnIngresar
            // 
            btnIngresar.Enabled = false;
            btnIngresar.Location = new Point(143, 221);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(62, 221);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbOrigen
            // 
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.Enabled = false;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "(N) Nacional", "(I) Importado" });
            cmbOrigen.Location = new Point(97, 71);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(121, 23);
            cmbOrigen.TabIndex = 13;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // frmRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbOrigen);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(cmbMarca);
            Controls.Add(mtbPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(mtbNumero);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNumero);
            Controls.Add(lblOrigen);
            Controls.Add(lblMarca);
            Controls.Add(lblDatosRepuesto);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmRegistrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarca;
        private Label lblOrigen;
        private Label lblNumero;
        private Label lblDescripcion;
        private Label lblPrecio;
        private MaskedTextBox mtbNumero;
        private TextBox txtDescripcion;
        private MaskedTextBox mtbPrecio;
        private ComboBox cmbMarca;
        private Label lblDatosRepuesto;
        private Button btnIngresar;
        private Button btnCancelar;
        private ComboBox cmbOrigen;
    }
}
