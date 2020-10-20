namespace TareaPilas
{
    partial class Form1
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.dtgDatosEmpleado = new System.Windows.Forms.DataGridView();
            this.gboEmpresa = new System.Windows.Forms.GroupBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.rad20k = new System.Windows.Forms.RadioButton();
            this.dtpFechaAperturaEmpresa = new System.Windows.Forms.Label();
            this.rad15k = new System.Windows.Forms.RadioButton();
            this.dtmFechaApertura = new System.Windows.Forms.DateTimePicker();
            this.lblRank = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.cboRank = new System.Windows.Forms.ComboBox();
            this.chkSeguro = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNoEmpleados = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.txtNumEmpleados = new System.Windows.Forms.TextBox();
            this.btnAgregarDatos = new System.Windows.Forms.Button();
            this.btnUltEmpresa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosEmpleado)).BeginInit();
            this.gboEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(689, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(152, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar Empresa";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(689, 88);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(152, 22);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar Cualquier Empresa";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(689, 144);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(152, 20);
            this.btnVaciar.TabIndex = 19;
            this.btnVaciar.Text = "Vaciar Lista de Empresas";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // dtgDatosEmpleado
            // 
            this.dtgDatosEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosEmpleado.Location = new System.Drawing.Point(12, 178);
            this.dtgDatosEmpleado.Name = "dtgDatosEmpleado";
            this.dtgDatosEmpleado.Size = new System.Drawing.Size(829, 219);
            this.dtgDatosEmpleado.TabIndex = 17;
            // 
            // gboEmpresa
            // 
            this.gboEmpresa.Controls.Add(this.btnCargarImagen);
            this.gboEmpresa.Controls.Add(this.rad20k);
            this.gboEmpresa.Controls.Add(this.dtpFechaAperturaEmpresa);
            this.gboEmpresa.Controls.Add(this.rad15k);
            this.gboEmpresa.Controls.Add(this.dtmFechaApertura);
            this.gboEmpresa.Controls.Add(this.lblRank);
            this.gboEmpresa.Controls.Add(this.picFoto);
            this.gboEmpresa.Controls.Add(this.cboRank);
            this.gboEmpresa.Controls.Add(this.chkSeguro);
            this.gboEmpresa.Controls.Add(this.label1);
            this.gboEmpresa.Controls.Add(this.lblNoEmpleados);
            this.gboEmpresa.Controls.Add(this.txtNombreEmpresa);
            this.gboEmpresa.Controls.Add(this.lblNombreEmpresa);
            this.gboEmpresa.Controls.Add(this.txtNumEmpleados);
            this.gboEmpresa.Location = new System.Drawing.Point(12, 9);
            this.gboEmpresa.Name = "gboEmpresa";
            this.gboEmpresa.Size = new System.Drawing.Size(671, 163);
            this.gboEmpresa.TabIndex = 16;
            this.gboEmpresa.TabStop = false;
            this.gboEmpresa.Text = "Empresa";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(540, 135);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(116, 23);
            this.btnCargarImagen.TabIndex = 15;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // rad20k
            // 
            this.rad20k.AutoSize = true;
            this.rad20k.Location = new System.Drawing.Point(421, 61);
            this.rad20k.Name = "rad20k";
            this.rad20k.Size = new System.Drawing.Size(64, 17);
            this.rad20k.TabIndex = 14;
            this.rad20k.Text = "$20,000";
            this.rad20k.UseVisualStyleBackColor = true;
            // 
            // dtpFechaAperturaEmpresa
            // 
            this.dtpFechaAperturaEmpresa.AutoSize = true;
            this.dtpFechaAperturaEmpresa.Location = new System.Drawing.Point(20, 126);
            this.dtpFechaAperturaEmpresa.Name = "dtpFechaAperturaEmpresa";
            this.dtpFechaAperturaEmpresa.Size = new System.Drawing.Size(168, 13);
            this.dtpFechaAperturaEmpresa.TabIndex = 9;
            this.dtpFechaAperturaEmpresa.Text = "Fecha de Apertura de la Empresa:";
            // 
            // rad15k
            // 
            this.rad15k.AutoSize = true;
            this.rad15k.Checked = true;
            this.rad15k.Location = new System.Drawing.Point(421, 38);
            this.rad15k.Name = "rad15k";
            this.rad15k.Size = new System.Drawing.Size(64, 17);
            this.rad15k.TabIndex = 13;
            this.rad15k.TabStop = true;
            this.rad15k.Text = "$15,000";
            this.rad15k.UseVisualStyleBackColor = true;
            // 
            // dtmFechaApertura
            // 
            this.dtmFechaApertura.Location = new System.Drawing.Point(191, 122);
            this.dtmFechaApertura.Name = "dtmFechaApertura";
            this.dtmFechaApertura.Size = new System.Drawing.Size(200, 20);
            this.dtmFechaApertura.TabIndex = 8;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(6, 88);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(155, 13);
            this.lblRank.TabIndex = 7;
            this.lblRank.Text = "Rank de Calidad en Facebook:";
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(540, 19);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(116, 111);
            this.picFoto.TabIndex = 7;
            this.picFoto.TabStop = false;
            // 
            // cboRank
            // 
            this.cboRank.FormattingEnabled = true;
            this.cboRank.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cboRank.Location = new System.Drawing.Point(167, 85);
            this.cboRank.Name = "cboRank";
            this.cboRank.Size = new System.Drawing.Size(121, 21);
            this.cboRank.TabIndex = 6;
            // 
            // chkSeguro
            // 
            this.chkSeguro.AutoSize = true;
            this.chkSeguro.Location = new System.Drawing.Point(404, 84);
            this.chkSeguro.Name = "chkSeguro";
            this.chkSeguro.Size = new System.Drawing.Size(130, 17);
            this.chkSeguro.TabIndex = 6;
            this.chkSeguro.Text = "¿Cuenta con Seguro?";
            this.chkSeguro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sueldo de Empleados\r\n";
            // 
            // lblNoEmpleados
            // 
            this.lblNoEmpleados.AutoSize = true;
            this.lblNoEmpleados.Location = new System.Drawing.Point(55, 56);
            this.lblNoEmpleados.Name = "lblNoEmpleados";
            this.lblNoEmpleados.Size = new System.Drawing.Size(82, 13);
            this.lblNoEmpleados.TabIndex = 4;
            this.lblNoEmpleados.Text = "No. Empleados:";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(143, 25);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(197, 20);
            this.txtNombreEmpresa.TabIndex = 0;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(20, 28);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(117, 13);
            this.lblNombreEmpresa.TabIndex = 1;
            this.lblNombreEmpresa.Text = "Nombre de la Empresa:";
            // 
            // txtNumEmpleados
            // 
            this.txtNumEmpleados.Location = new System.Drawing.Point(143, 53);
            this.txtNumEmpleados.Name = "txtNumEmpleados";
            this.txtNumEmpleados.Size = new System.Drawing.Size(100, 20);
            this.txtNumEmpleados.TabIndex = 2;
            // 
            // btnAgregarDatos
            // 
            this.btnAgregarDatos.Location = new System.Drawing.Point(689, 9);
            this.btnAgregarDatos.Name = "btnAgregarDatos";
            this.btnAgregarDatos.Size = new System.Drawing.Size(152, 43);
            this.btnAgregarDatos.TabIndex = 18;
            this.btnAgregarDatos.Text = "Agregar Datos de la Empresa";
            this.btnAgregarDatos.UseVisualStyleBackColor = true;
            this.btnAgregarDatos.Click += new System.EventHandler(this.btnAgregarDatos_Click);
            // 
            // btnUltEmpresa
            // 
            this.btnUltEmpresa.Location = new System.Drawing.Point(689, 116);
            this.btnUltEmpresa.Name = "btnUltEmpresa";
            this.btnUltEmpresa.Size = new System.Drawing.Size(152, 23);
            this.btnUltEmpresa.TabIndex = 22;
            this.btnUltEmpresa.Text = "Eliminar Última Empresa";
            this.btnUltEmpresa.UseVisualStyleBackColor = true;
            this.btnUltEmpresa.Click += new System.EventHandler(this.btnUltEmpresa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 410);
            this.Controls.Add(this.btnUltEmpresa);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.dtgDatosEmpleado);
            this.Controls.Add(this.gboEmpresa);
            this.Controls.Add(this.btnAgregarDatos);
            this.Name = "Form1";
            this.Text = "Empresa Organizadora de Eventos Sociales";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosEmpleado)).EndInit();
            this.gboEmpresa.ResumeLayout(false);
            this.gboEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.DataGridView dtgDatosEmpleado;
        private System.Windows.Forms.GroupBox gboEmpresa;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.RadioButton rad20k;
        private System.Windows.Forms.Label dtpFechaAperturaEmpresa;
        private System.Windows.Forms.RadioButton rad15k;
        private System.Windows.Forms.DateTimePicker dtmFechaApertura;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.ComboBox cboRank;
        private System.Windows.Forms.CheckBox chkSeguro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNoEmpleados;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.TextBox txtNumEmpleados;
        private System.Windows.Forms.Button btnAgregarDatos;
        private System.Windows.Forms.Button btnUltEmpresa;
    }
}

