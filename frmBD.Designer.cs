namespace pryMarconiEDpresentacion
{
    partial class frmBD
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDif = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConvolucin = new System.Windows.Forms.Button();
            this.btnSelecMulti = new System.Windows.Forms.Button();
            this.btnSelecSimplee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProMulti = new System.Windows.Forms.Button();
            this.btnProSimple = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDif);
            this.groupBox3.Controls.Add(this.btnInterseccion);
            this.groupBox3.Controls.Add(this.btnUnion);
            this.groupBox3.Location = new System.Drawing.Point(541, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 113);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones Algebraicas";
            // 
            // btnDif
            // 
            this.btnDif.Location = new System.Drawing.Point(6, 77);
            this.btnDif.Name = "btnDif";
            this.btnDif.Size = new System.Drawing.Size(235, 23);
            this.btnDif.TabIndex = 2;
            this.btnDif.Text = "Diferencia";
            this.btnDif.UseVisualStyleBackColor = true;
            this.btnDif.Click += new System.EventHandler(this.btnDif_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(7, 49);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(235, 23);
            this.btnInterseccion.TabIndex = 1;
            this.btnInterseccion.Text = "Interseccion";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(6, 19);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(235, 23);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConvolucin);
            this.groupBox2.Controls.Add(this.btnSelecMulti);
            this.groupBox2.Controls.Add(this.btnSelecSimplee);
            this.groupBox2.Location = new System.Drawing.Point(288, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 113);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones de Seleccion - WHERE";
            // 
            // btnConvolucin
            // 
            this.btnConvolucin.Location = new System.Drawing.Point(6, 77);
            this.btnConvolucin.Name = "btnConvolucin";
            this.btnConvolucin.Size = new System.Drawing.Size(235, 23);
            this.btnConvolucin.TabIndex = 2;
            this.btnConvolucin.Text = "Selección por convolución";
            this.btnConvolucin.UseVisualStyleBackColor = true;
            this.btnConvolucin.Click += new System.EventHandler(this.btnConvolucin_Click);
            // 
            // btnSelecMulti
            // 
            this.btnSelecMulti.Location = new System.Drawing.Point(6, 48);
            this.btnSelecMulti.Name = "btnSelecMulti";
            this.btnSelecMulti.Size = new System.Drawing.Size(235, 23);
            this.btnSelecMulti.TabIndex = 1;
            this.btnSelecMulti.Text = "Seleccion multiatributo";
            this.btnSelecMulti.UseVisualStyleBackColor = true;
            this.btnSelecMulti.Click += new System.EventHandler(this.btnSelecMulti_Click);
            // 
            // btnSelecSimplee
            // 
            this.btnSelecSimplee.Location = new System.Drawing.Point(6, 19);
            this.btnSelecSimplee.Name = "btnSelecSimplee";
            this.btnSelecSimplee.Size = new System.Drawing.Size(235, 23);
            this.btnSelecSimplee.TabIndex = 0;
            this.btnSelecSimplee.Text = "Seleccion simple";
            this.btnSelecSimplee.UseVisualStyleBackColor = true;
            this.btnSelecSimplee.Click += new System.EventHandler(this.btnSelecSimplee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJuntar);
            this.groupBox1.Controls.Add(this.btnProMulti);
            this.groupBox1.Controls.Add(this.btnProSimple);
            this.groupBox1.Location = new System.Drawing.Point(12, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de Proyeccion - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(6, 77);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(235, 23);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnProMulti
            // 
            this.btnProMulti.Location = new System.Drawing.Point(6, 48);
            this.btnProMulti.Name = "btnProMulti";
            this.btnProMulti.Size = new System.Drawing.Size(235, 23);
            this.btnProMulti.TabIndex = 1;
            this.btnProMulti.Text = "Proyeccion multiatributo";
            this.btnProMulti.UseVisualStyleBackColor = true;
            this.btnProMulti.Click += new System.EventHandler(this.btnProMulti_Click);
            // 
            // btnProSimple
            // 
            this.btnProSimple.Location = new System.Drawing.Point(6, 19);
            this.btnProSimple.Name = "btnProSimple";
            this.btnProSimple.Size = new System.Drawing.Size(235, 23);
            this.btnProSimple.TabIndex = 0;
            this.btnProSimple.Text = "Proyeccion simple";
            this.btnProSimple.UseVisualStyleBackColor = true;
            this.btnProSimple.Click += new System.EventHandler(this.btnProSimple_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AccessibleDescription = "d";
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(776, 294);
            this.dgvDatos.TabIndex = 4;
            // 
            // frmBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 443);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frmBD";
            this.Text = "Base de Datos";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDif;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConvolucin;
        private System.Windows.Forms.Button btnSelecMulti;
        private System.Windows.Forms.Button btnSelecSimplee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProMulti;
        private System.Windows.Forms.Button btnProSimple;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}