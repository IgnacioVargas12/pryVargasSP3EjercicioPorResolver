namespace pryVargasSP3EjercicioPorResolver
{
    partial class frmConsultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDatos = new Label();
            lblMarca = new Label();
            lblOrigen = new Label();
            cmbMarca = new ComboBox();
            chkNacional = new CheckBox();
            chkImportado = new CheckBox();
            btnConsultar = new Button();
            btnCancelar = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.BorderStyle = BorderStyle.Fixed3D;
            lblDatos.Location = new Point(12, 9);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(272, 400);
            lblDatos.TabIndex = 0;
            lblDatos.Text = "Datos";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(27, 40);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(27, 65);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 2;
            lblOrigen.Text = "Origen";
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "(P)Peugeot", "(F) Fiat", "(R) Renault" });
            cmbMarca.Location = new Point(84, 35);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(182, 23);
            cmbMarca.TabIndex = 3;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // chkNacional
            // 
            chkNacional.AutoSize = true;
            chkNacional.Enabled = false;
            chkNacional.Location = new Point(84, 64);
            chkNacional.Name = "chkNacional";
            chkNacional.Size = new Size(93, 19);
            chkNacional.TabIndex = 4;
            chkNacional.Text = "(N) Nacional";
            chkNacional.UseVisualStyleBackColor = true;
            chkNacional.CheckedChanged += chkNacional_CheckedChanged;
            // 
            // chkImportado
            // 
            chkImportado.AutoSize = true;
            chkImportado.Enabled = false;
            chkImportado.Location = new Point(84, 89);
            chkImportado.Name = "chkImportado";
            chkImportado.Size = new Size(96, 19);
            chkImportado.TabIndex = 5;
            chkImportado.Text = "(I) Importado";
            chkImportado.UseVisualStyleBackColor = true;
            chkImportado.CheckedChanged += chkImportado_CheckedChanged;
            // 
            // btnConsultar
            // 
            btnConsultar.Enabled = false;
            btnConsultar.Location = new Point(191, 131);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(84, 131);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(27, 186);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(239, 208);
            txtResultado.TabIndex = 8;
            txtResultado.Text = "-------";
            // 
            // frmConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 418);
            Controls.Add(txtResultado);
            Controls.Add(btnCancelar);
            Controls.Add(btnConsultar);
            Controls.Add(chkImportado);
            Controls.Add(chkNacional);
            Controls.Add(cmbMarca);
            Controls.Add(lblOrigen);
            Controls.Add(lblMarca);
            Controls.Add(lblDatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmConsultar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatos;
        private Label lblMarca;
        private Label lblOrigen;
        private ComboBox cmbMarca;
        private CheckBox chkNacional;
        private CheckBox chkImportado;
        private Button btnConsultar;
        private Button btnCancelar;
        private TextBox txtResultado;
    }
}