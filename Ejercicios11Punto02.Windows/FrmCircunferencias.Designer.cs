namespace Ejercicios11Punto02.Windows
{
    partial class FrmCircunferencias
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmnPunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnRadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnBorde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnRelleno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnSuperficie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFiltrar = new System.Windows.Forms.ToolStripDropDownButton();
            this.cuadrante1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadrante2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadrante3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadrante4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOrdenar = new System.Windows.Forms.ToolStripDropDownButton();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distanciaAlOrigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 483);
            this.panel1.TabIndex = 7;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnPunto,
            this.cmnRadio,
            this.cmnBorde,
            this.cmnRelleno,
            this.cmnPerimetro,
            this.cmnSuperficie});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(855, 483);
            this.dgvDatos.TabIndex = 0;
            // 
            // cmnPunto
            // 
            this.cmnPunto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnPunto.HeaderText = "Punto";
            this.cmnPunto.Name = "cmnPunto";
            this.cmnPunto.ReadOnly = true;
            // 
            // cmnRadio
            // 
            this.cmnRadio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnRadio.HeaderText = "Radio";
            this.cmnRadio.Name = "cmnRadio";
            this.cmnRadio.ReadOnly = true;
            // 
            // cmnBorde
            // 
            this.cmnBorde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnBorde.HeaderText = "Borde";
            this.cmnBorde.Name = "cmnBorde";
            this.cmnBorde.ReadOnly = true;
            // 
            // cmnRelleno
            // 
            this.cmnRelleno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnRelleno.HeaderText = "Relleno";
            this.cmnRelleno.Name = "cmnRelleno";
            this.cmnRelleno.ReadOnly = true;
            // 
            // cmnPerimetro
            // 
            this.cmnPerimetro.HeaderText = "Perímetro";
            this.cmnPerimetro.Name = "cmnPerimetro";
            this.cmnPerimetro.ReadOnly = true;
            // 
            // cmnSuperficie
            // 
            this.cmnSuperficie.HeaderText = "Superficie";
            this.cmnSuperficie.Name = "cmnSuperficie";
            this.cmnSuperficie.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBorrar,
            this.tsbEditar,
            this.toolStripSeparator1,
            this.tsbFiltrar,
            this.tsbRefrescar,
            this.toolStripSeparator2,
            this.tsbOrdenar,
            this.toolStripSeparator3,
            this.tsbSalir,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(855, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(46, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(43, 22);
            this.tsbBorrar.Text = "Borrar";
            this.tsbBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbEditar
            // 
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(41, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFiltrar
            // 
            this.tsbFiltrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuadrante1ToolStripMenuItem,
            this.cuadrante2ToolStripMenuItem,
            this.cuadrante3ToolStripMenuItem,
            this.cuadrante4ToolStripMenuItem});
            this.tsbFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFiltrar.Name = "tsbFiltrar";
            this.tsbFiltrar.Size = new System.Drawing.Size(50, 22);
            this.tsbFiltrar.Text = "Filtrar";
            this.tsbFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cuadrante1ToolStripMenuItem
            // 
            this.cuadrante1ToolStripMenuItem.Name = "cuadrante1ToolStripMenuItem";
            this.cuadrante1ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.cuadrante1ToolStripMenuItem.Text = "Cuadrante 1";
            // 
            // cuadrante2ToolStripMenuItem
            // 
            this.cuadrante2ToolStripMenuItem.Name = "cuadrante2ToolStripMenuItem";
            this.cuadrante2ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.cuadrante2ToolStripMenuItem.Text = "Cuadrante 2";
            // 
            // cuadrante3ToolStripMenuItem
            // 
            this.cuadrante3ToolStripMenuItem.Name = "cuadrante3ToolStripMenuItem";
            this.cuadrante3ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.cuadrante3ToolStripMenuItem.Text = "Cuadrante 3";
            // 
            // cuadrante4ToolStripMenuItem
            // 
            this.cuadrante4ToolStripMenuItem.Name = "cuadrante4ToolStripMenuItem";
            this.cuadrante4ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.cuadrante4ToolStripMenuItem.Text = "Cuadrante 4";
            // 
            // tsbRefrescar
            // 
            this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrescar.Name = "tsbRefrescar";
            this.tsbRefrescar.Size = new System.Drawing.Size(59, 22);
            this.tsbRefrescar.Text = "Refrescar";
            this.tsbRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbOrdenar
            // 
            this.tsbOrdenar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.yToolStripMenuItem,
            this.distanciaAlOrigenToolStripMenuItem,
            this.cuadranteToolStripMenuItem});
            this.tsbOrdenar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrdenar.Name = "tsbOrdenar";
            this.tsbOrdenar.Size = new System.Drawing.Size(63, 22);
            this.tsbOrdenar.Text = "Ordenar";
            this.tsbOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.xToolStripMenuItem.Text = "X";
            // 
            // yToolStripMenuItem
            // 
            this.yToolStripMenuItem.Name = "yToolStripMenuItem";
            this.yToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.yToolStripMenuItem.Text = "Y";
            // 
            // distanciaAlOrigenToolStripMenuItem
            // 
            this.distanciaAlOrigenToolStripMenuItem.Name = "distanciaAlOrigenToolStripMenuItem";
            this.distanciaAlOrigenToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.distanciaAlOrigenToolStripMenuItem.Text = "Distancia al Origen";
            // 
            // cuadranteToolStripMenuItem
            // 
            this.cuadranteToolStripMenuItem.Name = "cuadranteToolStripMenuItem";
            this.cuadranteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.cuadranteToolStripMenuItem.Text = "Cuadrante";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSalir
            // 
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(33, 22);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // FrmCircunferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmCircunferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circunferencias";
            this.Load += new System.EventHandler(this.FrmCircunferencias_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnPunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnRadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnBorde;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnRelleno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnPerimetro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnSuperficie;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsbFiltrar;
        private System.Windows.Forms.ToolStripMenuItem cuadrante1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadrante2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadrante3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadrante4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbRefrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsbOrdenar;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distanciaAlOrigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

