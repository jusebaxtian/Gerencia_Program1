namespace Program2
{
    partial class FrmContarloc
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnBuscarArchivo = new System.Windows.Forms.Button();
            this.BtnCargarTodo = new System.Windows.Forms.Button();
            this.TxtContenedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblsuma = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscarArchivo
            // 
            this.BtnBuscarArchivo.Location = new System.Drawing.Point(152, 440);
            this.BtnBuscarArchivo.Name = "BtnBuscarArchivo";
            this.BtnBuscarArchivo.Size = new System.Drawing.Size(110, 37);
            this.BtnBuscarArchivo.TabIndex = 0;
            this.BtnBuscarArchivo.Text = "&Buscar Archivo";
            this.BtnBuscarArchivo.UseVisualStyleBackColor = true;
            this.BtnBuscarArchivo.Click += new System.EventHandler(this.BtnBuscarArchivo_Click);
            // 
            // BtnCargarTodo
            // 
            this.BtnCargarTodo.Location = new System.Drawing.Point(640, 440);
            this.BtnCargarTodo.Name = "BtnCargarTodo";
            this.BtnCargarTodo.Size = new System.Drawing.Size(110, 37);
            this.BtnCargarTodo.TabIndex = 1;
            this.BtnCargarTodo.Text = "&Cargar";
            this.BtnCargarTodo.UseVisualStyleBackColor = true;
            // 
            // TxtContenedor
            // 
            this.TxtContenedor.Location = new System.Drawing.Point(12, 53);
            this.TxtContenedor.Multiline = true;
            this.TxtContenedor.Name = "TxtContenedor";
            this.TxtContenedor.ReadOnly = true;
            this.TxtContenedor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtContenedor.Size = new System.Drawing.Size(415, 381);
            this.TxtContenedor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contador de LOC ";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(34, 489);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(13, 13);
            this.lblUbicacion.TabIndex = 4;
            this.lblUbicacion.Text = " -";
            // 
            // lblsuma
            // 
            this.lblsuma.AutoSize = true;
            this.lblsuma.Location = new System.Drawing.Point(286, 13);
            this.lblsuma.Name = "lblsuma";
            this.lblsuma.Size = new System.Drawing.Size(35, 13);
            this.lblsuma.TabIndex = 5;
            this.lblsuma.Text = "label2";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre});
            this.dgvDatos.Location = new System.Drawing.Point(460, 53);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(418, 381);
            this.dgvDatos.TabIndex = 6;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // FrmContarloc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(912, 511);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblsuma);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtContenedor);
            this.Controls.Add(this.BtnCargarTodo);
            this.Controls.Add(this.BtnBuscarArchivo);
            this.MaximizeBox = false;
            this.Name = "FrmContarloc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de LOC";
            this.Load += new System.EventHandler(this.FrmContarloc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscarArchivo;
        private System.Windows.Forms.Button BtnCargarTodo;
        private System.Windows.Forms.TextBox TxtContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblsuma;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}

