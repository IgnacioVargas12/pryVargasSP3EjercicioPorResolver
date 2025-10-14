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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            lblDatosRepuesto = new Label();
            lblMarca = new Label();
            lblOrigen = new Label();
            lblNumero = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            mtbNumero = new MaskedTextBox();
            cmbOrigen = new ComboBox();
            mtbPrecio = new MaskedTextBox();
            cmbMarca = new ComboBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            txtDescripcion = new TextBox();
            btnConsultar = new Button();
            SuspendLayout();
            // 
            // lblDatosRepuesto
            // 
            lblDatosRepuesto.BorderStyle = BorderStyle.Fixed3D;
            lblDatosRepuesto.Location = new Point(12, 9);
            lblDatosRepuesto.Name = "lblDatosRepuesto";
            lblDatosRepuesto.Size = new Size(299, 268);
            lblDatosRepuesto.TabIndex = 10;
            lblDatosRepuesto.Text = "Datos del repuesto";
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
            lblPrecio.Location = new Point(25, 203);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Location = new Point(97, 104);
            mtbNumero.Mask = "9999999999999999999";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(196, 23);
            mtbNumero.TabIndex = 6;
            mtbNumero.ValidatingType = typeof(int);
            mtbNumero.MaskInputRejected += mtbNumero_MaskInputRejected;
            mtbNumero.TextChanged += mtbNumero_TextChanged;
            // 
            // cmbOrigen
            // 
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.Enabled = false;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "(N) Nacional", "(I) Importado" });
            cmbOrigen.Location = new Point(97, 71);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(196, 23);
            cmbOrigen.TabIndex = 13;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // mtbPrecio
            // 
            mtbPrecio.Enabled = false;
            mtbPrecio.Location = new Point(97, 203);
            mtbPrecio.Mask = "999999999999999999";
            mtbPrecio.Name = "mtbPrecio";
            mtbPrecio.Size = new Size(115, 23);
            mtbPrecio.TabIndex = 8;
            mtbPrecio.ValidatingType = typeof(int);
            mtbPrecio.TextChanged += mtbPrecio_TextChanged;
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(97, 34);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(196, 23);
            cmbMarca.TabIndex = 9;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Enabled = false;
            btnIngresar.Location = new Point(218, 243);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(137, 243);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(97, 139);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(196, 48);
            txtDescripcion.TabIndex = 7;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(56, 243);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 14;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // frmRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 287);
            Controls.Add(btnConsultar);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegistrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registar";
            Load += frmRegistrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDatosRepuesto;
        private Label lblMarca;
        private Label lblOrigen;
        private Label lblNumero;
        private Label lblDescripcion;
        private Label lblPrecio;
        private MaskedTextBox mtbNumero;
        private ComboBox cmbOrigen;
        private MaskedTextBox mtbPrecio;
        private ComboBox cmbMarca;
        private Button btnIngresar;
        private Button btnCancelar;
        private TextBox txtDescripcion;
        private Button btnConsultar;
    }
}
