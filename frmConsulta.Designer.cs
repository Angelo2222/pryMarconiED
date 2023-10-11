namespace pryMarconiEDpresentacion
{
    partial class frmConsulta
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
            this.txtListar = new System.Windows.Forms.RichTextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtListar
            // 
            this.txtListar.Location = new System.Drawing.Point(16, 24);
            this.txtListar.Name = "txtListar";
            this.txtListar.Size = new System.Drawing.Size(772, 154);
            this.txtListar.TabIndex = 8;
            this.txtListar.Text = "";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(667, 184);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(121, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvListar
            // 
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Location = new System.Drawing.Point(16, 213);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.Size = new System.Drawing.Size(772, 241);
            this.dgvListar.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, -4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(173, 24);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Consulta en SQL:";
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 469);
            this.Controls.Add(this.txtListar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtListar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.Label lblTitulo;
    }
}