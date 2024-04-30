
namespace Presentacion
{
    partial class frmCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogo));
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.gbxBusquedaAvanzada = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.gbxBusquedaAvanzada.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCatalogo.Location = new System.Drawing.Point(12, 55);
            this.dgvCatalogo.MultiSelect = false;
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(643, 259);
            this.dgvCatalogo.TabIndex = 0;
            this.dgvCatalogo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogo_CellDoubleClick);
            this.dgvCatalogo.SelectionChanged += new System.EventHandler(this.dgvCatalogo_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(685, 55);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(266, 259);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 320);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 320);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(174, 320);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Image = ((System.Drawing.Image)(resources.GetObject("lblBuscar.Image")));
            this.lblBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblBuscar.Location = new System.Drawing.Point(12, 20);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(66, 15);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "      Buscar:";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(84, 20);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(186, 20);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(372, 320);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(283, 13);
            this.lblDetalle.TabIndex = 7;
            this.lblDetalle.Text = "Hacer doble click en el artículo para verlo detalladamente.";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(13, 23);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(185, 23);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Criterio:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(394, 20);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(121, 20);
            this.txtFiltro.TabIndex = 2;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(356, 23);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltro.TabIndex = 12;
            this.lblFiltro.Text = "Filtro:";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(60, 19);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(106, 21);
            this.cboCampo.TabIndex = 0;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(231, 19);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(107, 21);
            this.cboCriterio.TabIndex = 1;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(531, 19);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 3;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // gbxBusquedaAvanzada
            // 
            this.gbxBusquedaAvanzada.Controls.Add(this.cboCriterio);
            this.gbxBusquedaAvanzada.Controls.Add(this.btnFiltro);
            this.gbxBusquedaAvanzada.Controls.Add(this.lblCampo);
            this.gbxBusquedaAvanzada.Controls.Add(this.lblCriterio);
            this.gbxBusquedaAvanzada.Controls.Add(this.cboCampo);
            this.gbxBusquedaAvanzada.Controls.Add(this.lblFiltro);
            this.gbxBusquedaAvanzada.Controls.Add(this.txtFiltro);
            this.gbxBusquedaAvanzada.Location = new System.Drawing.Point(12, 362);
            this.gbxBusquedaAvanzada.Name = "gbxBusquedaAvanzada";
            this.gbxBusquedaAvanzada.Size = new System.Drawing.Size(626, 57);
            this.gbxBusquedaAvanzada.TabIndex = 17;
            this.gbxBusquedaAvanzada.TabStop = false;
            this.gbxBusquedaAvanzada.Text = "Busqueda Avanzada:";
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(963, 428);
            this.Controls.Add(this.gbxBusquedaAvanzada);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvCatalogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(979, 467);
            this.MinimumSize = new System.Drawing.Size(979, 467);
            this.Name = "frmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.gbxBusquedaAvanzada.ResumeLayout(false);
            this.gbxBusquedaAvanzada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.GroupBox gbxBusquedaAvanzada;
    }
}

