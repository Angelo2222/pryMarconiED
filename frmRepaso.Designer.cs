namespace pryMarconiEDpresentacion
{
    partial class frmRepaso
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
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.cmbListar = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEnunciado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListar
            // 
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Location = new System.Drawing.Point(12, 178);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.Size = new System.Drawing.Size(944, 309);
            this.dgvListar.TabIndex = 9;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(860, 7);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(96, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cmbListar
            // 
            this.cmbListar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListar.FormattingEnabled = true;
            this.cmbListar.Items.AddRange(new object[] {
            "Diferencia",
            "Interseccion",
            "Proyeccion Simple",
            "Proyeccion Multiatributo",
            "Seleccion Multiatributo con operador AND",
            "Seleccion Multiatributo con operador OR",
            "Seleccion Multiatributo por Convolucion",
            "Seleccion Simple",
            "Union"});
            this.cmbListar.Location = new System.Drawing.Point(292, 7);
            this.cmbListar.Name = "cmbListar";
            this.cmbListar.Size = new System.Drawing.Size(562, 21);
            this.cmbListar.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(9, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(277, 18);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Operación a realizar en la base de datos:";
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnunciado.Enabled = false;
            this.lblEnunciado.Location = new System.Drawing.Point(12, 48);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(944, 127);
            this.lblEnunciado.TabIndex = 10;
            // 
            // frmRepaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 495);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cmbListar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmRepaso";
            this.Text = "Repaso";
            this.Load += new System.EventHandler(this.frmRepaso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cmbListar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEnunciado;
    }
}