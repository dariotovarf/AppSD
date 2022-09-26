
namespace AppSD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contenTotalTerceros = new System.Windows.Forms.TabPage();
            this.contenIpc = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvIpc = new System.Windows.Forms.DataGridView();
            this.contenDesc = new System.Windows.Forms.TabPage();
            this.dgvDescuentos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIndexar = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvIndexados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFechaIni = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.txtIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.contenedor = new System.Windows.Forms.TabControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPdfTerceros = new System.Windows.Forms.Button();
            this.fechaFinTerceros = new System.Windows.Forms.MaskedTextBox();
            this.fechaIniTerceros = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarTerceros = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDescuentosTerceros = new System.Windows.Forms.DataGridView();
            this.contenTotalTerceros.SuspendLayout();
            this.contenIpc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIpc)).BeginInit();
            this.contenDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndexados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contenedor.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentosTerceros)).BeginInit();
            this.SuspendLayout();
            // 
            // contenTotalTerceros
            // 
            this.contenTotalTerceros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contenTotalTerceros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contenTotalTerceros.Controls.Add(this.dgvDescuentosTerceros);
            this.contenTotalTerceros.Controls.Add(this.groupBox4);
            this.contenTotalTerceros.Location = new System.Drawing.Point(4, 22);
            this.contenTotalTerceros.Name = "contenTotalTerceros";
            this.contenTotalTerceros.Padding = new System.Windows.Forms.Padding(3);
            this.contenTotalTerceros.Size = new System.Drawing.Size(997, 636);
            this.contenTotalTerceros.TabIndex = 2;
            this.contenTotalTerceros.Text = "Actualizacion por Terceros";
            // 
            // contenIpc
            // 
            this.contenIpc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contenIpc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contenIpc.Controls.Add(this.dgvIpc);
            this.contenIpc.Controls.Add(this.groupBox3);
            this.contenIpc.Location = new System.Drawing.Point(4, 22);
            this.contenIpc.Name = "contenIpc";
            this.contenIpc.Padding = new System.Windows.Forms.Padding(3);
            this.contenIpc.Size = new System.Drawing.Size(997, 636);
            this.contenIpc.TabIndex = 1;
            this.contenIpc.Text = "IPC";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(82, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 72);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IPC";
            // 
            // dgvIpc
            // 
            this.dgvIpc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvIpc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIpc.Location = new System.Drawing.Point(82, 130);
            this.dgvIpc.Name = "dgvIpc";
            this.dgvIpc.Size = new System.Drawing.Size(451, 478);
            this.dgvIpc.TabIndex = 1;
            this.dgvIpc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIpc_CellContentClick);
            // 
            // contenDesc
            // 
            this.contenDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contenDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contenDesc.Controls.Add(this.groupBox1);
            this.contenDesc.Controls.Add(this.dgvIndexados);
            this.contenDesc.Controls.Add(this.label4);
            this.contenDesc.Controls.Add(this.groupBox2);
            this.contenDesc.Controls.Add(this.dgvDescuentos);
            this.contenDesc.Location = new System.Drawing.Point(4, 22);
            this.contenDesc.Name = "contenDesc";
            this.contenDesc.Padding = new System.Windows.Forms.Padding(3);
            this.contenDesc.Size = new System.Drawing.Size(997, 636);
            this.contenDesc.TabIndex = 0;
            this.contenDesc.Text = "Actualizacion General";
            // 
            // dgvDescuentos
            // 
            this.dgvDescuentos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentos.Location = new System.Drawing.Point(28, 86);
            this.dgvDescuentos.Name = "dgvDescuentos";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDescuentos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDescuentos.Size = new System.Drawing.Size(916, 199);
            this.dgvDescuentos.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cb);
            this.groupBox2.Controls.Add(this.btnIndexar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(28, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(910, 68);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametros de Indexacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Periodo";
            // 
            // btnIndexar
            // 
            this.btnIndexar.Location = new System.Drawing.Point(292, 21);
            this.btnIndexar.Name = "btnIndexar";
            this.btnIndexar.Size = new System.Drawing.Size(83, 30);
            this.btnIndexar.TabIndex = 9;
            this.btnIndexar.Text = "Actualizar";
            this.btnIndexar.UseVisualStyleBackColor = true;
            this.btnIndexar.Click += new System.EventHandler(this.btnIndexar_Click);
            // 
            // cb
            // 
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(92, 27);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(174, 21);
            this.cb.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reporte PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descuentos Actualizados";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgvIndexados
            // 
            this.dgvIndexados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvIndexados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIndexados.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIndexados.Location = new System.Drawing.Point(28, 416);
            this.dgvIndexados.Name = "dgvIndexados";
            this.dgvIndexados.Size = new System.Drawing.Size(916, 199);
            this.dgvIndexados.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReporte);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.txtFechaFin);
            this.groupBox1.Controls.Add(this.txtFechaIni);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros de Busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Identificacion";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(546, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 30);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFechaIni
            // 
            this.txtFechaIni.Location = new System.Drawing.Point(97, 36);
            this.txtFechaIni.Mask = "####-##-##";
            this.txtFechaIni.Name = "txtFechaIni";
            this.txtFechaIni.Size = new System.Drawing.Size(65, 20);
            this.txtFechaIni.TabIndex = 8;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(258, 36);
            this.txtFechaFin.Mask = "0000-00-00";
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(65, 20);
            this.txtFechaFin.TabIndex = 9;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(420, 36);
            this.txtIdentificacion.Mask = "99999999999";
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(111, 20);
            this.txtIdentificacion.TabIndex = 10;
            this.txtIdentificacion.ValidatingType = typeof(int);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(733, 30);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(115, 30);
            this.btnReporte.TabIndex = 11;
            this.btnReporte.Text = "Reporte PDF";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.contenDesc);
            this.contenedor.Controls.Add(this.contenIpc);
            this.contenedor.Controls.Add(this.contenTotalTerceros);
            this.contenedor.Location = new System.Drawing.Point(32, 12);
            this.contenedor.Name = "contenedor";
            this.contenedor.SelectedIndex = 0;
            this.contenedor.Size = new System.Drawing.Size(1005, 662);
            this.contenedor.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPdfTerceros);
            this.groupBox4.Controls.Add(this.fechaFinTerceros);
            this.groupBox4.Controls.Add(this.fechaIniTerceros);
            this.groupBox4.Controls.Add(this.btnBuscarTerceros);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(33, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(916, 74);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parametros de Busqueda";
            // 
            // btnPdfTerceros
            // 
            this.btnPdfTerceros.Location = new System.Drawing.Point(557, 28);
            this.btnPdfTerceros.Name = "btnPdfTerceros";
            this.btnPdfTerceros.Size = new System.Drawing.Size(115, 31);
            this.btnPdfTerceros.TabIndex = 11;
            this.btnPdfTerceros.Text = "Reporte PDF";
            this.btnPdfTerceros.UseVisualStyleBackColor = true;
            this.btnPdfTerceros.Click += new System.EventHandler(this.btnPdfTerceros_Click);
            // 
            // fechaFinTerceros
            // 
            this.fechaFinTerceros.Location = new System.Drawing.Point(258, 36);
            this.fechaFinTerceros.Mask = "0000-00-00";
            this.fechaFinTerceros.Name = "fechaFinTerceros";
            this.fechaFinTerceros.Size = new System.Drawing.Size(65, 20);
            this.fechaFinTerceros.TabIndex = 9;
            // 
            // fechaIniTerceros
            // 
            this.fechaIniTerceros.Location = new System.Drawing.Point(97, 36);
            this.fechaIniTerceros.Mask = "####-##-##";
            this.fechaIniTerceros.Name = "fechaIniTerceros";
            this.fechaIniTerceros.Size = new System.Drawing.Size(65, 20);
            this.fechaIniTerceros.TabIndex = 8;
            // 
            // btnBuscarTerceros
            // 
            this.btnBuscarTerceros.Location = new System.Drawing.Point(404, 29);
            this.btnBuscarTerceros.Name = "btnBuscarTerceros";
            this.btnBuscarTerceros.Size = new System.Drawing.Size(83, 30);
            this.btnBuscarTerceros.TabIndex = 6;
            this.btnBuscarTerceros.Text = "Buscar";
            this.btnBuscarTerceros.UseVisualStyleBackColor = true;
            this.btnBuscarTerceros.Click += new System.EventHandler(this.btnBuscarTerceros_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fecha Final";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fecha Inicial";
            // 
            // dgvDescuentosTerceros
            // 
            this.dgvDescuentosTerceros.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDescuentosTerceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentosTerceros.Location = new System.Drawing.Point(33, 86);
            this.dgvDescuentosTerceros.Name = "dgvDescuentosTerceros";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDescuentosTerceros.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDescuentosTerceros.Size = new System.Drawing.Size(916, 199);
            this.dgvDescuentosTerceros.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 685);
            this.Controls.Add(this.contenedor);
            this.Name = "Form1";
            this.Text = "Indexacion Descuentos Sobretasa Deportiva";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.contenTotalTerceros.ResumeLayout(false);
            this.contenIpc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIpc)).EndInit();
            this.contenDesc.ResumeLayout(false);
            this.contenDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndexados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contenedor.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentosTerceros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage contenTotalTerceros;
        private System.Windows.Forms.TabPage contenIpc;
        private System.Windows.Forms.DataGridView dgvIpc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage contenDesc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.MaskedTextBox txtIdentificacion;
        private System.Windows.Forms.MaskedTextBox txtFechaFin;
        private System.Windows.Forms.MaskedTextBox txtFechaIni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIndexados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Button btnIndexar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDescuentos;
        private System.Windows.Forms.TabControl contenedor;
        private System.Windows.Forms.DataGridView dgvDescuentosTerceros;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPdfTerceros;
        private System.Windows.Forms.MaskedTextBox fechaFinTerceros;
        private System.Windows.Forms.MaskedTextBox fechaIniTerceros;
        private System.Windows.Forms.Button btnBuscarTerceros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

