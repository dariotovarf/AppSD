
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaIni = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDescuentos = new System.Windows.Forms.DataGridView();
            this.dgvIndexados = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.ComboBox();
            this.btnIndexar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.TabControl();
            this.contenDesc = new System.Windows.Forms.TabPage();
            this.contenIpc = new System.Windows.Forms.TabPage();
            this.dgvIpc = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndexados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contenedor.SuspendLayout();
            this.contenDesc.SuspendLayout();
            this.contenIpc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIpc)).BeginInit();
            this.SuspendLayout();
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
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(420, 36);
            this.txtIdentificacion.Mask = "99999999999";
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(111, 20);
            this.txtIdentificacion.TabIndex = 10;
            this.txtIdentificacion.ValidatingType = typeof(int);
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(258, 36);
            this.txtFechaFin.Mask = "0000-00-00";
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(65, 20);
            this.txtFechaFin.TabIndex = 9;
            // 
            // txtFechaIni
            // 
            this.txtFechaIni.Location = new System.Drawing.Point(97, 36);
            this.txtFechaIni.Mask = "####-##-##";
            this.txtFechaIni.Name = "txtFechaIni";
            this.txtFechaIni.Size = new System.Drawing.Size(65, 20);
            this.txtFechaIni.TabIndex = 8;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Identificacion";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicial";
            // 
            // dgvDescuentos
            // 
            this.dgvDescuentos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentos.Location = new System.Drawing.Point(28, 86);
            this.dgvDescuentos.Name = "dgvDescuentos";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDescuentos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDescuentos.Size = new System.Drawing.Size(916, 199);
            this.dgvDescuentos.TabIndex = 1;
            // 
            // dgvIndexados
            // 
            this.dgvIndexados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvIndexados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIndexados.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIndexados.Location = new System.Drawing.Point(28, 416);
            this.dgvIndexados.Name = "dgvIndexados";
            this.dgvIndexados.Size = new System.Drawing.Size(916, 199);
            this.dgvIndexados.TabIndex = 2;
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
            // cb
            // 
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(92, 27);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(174, 21);
            this.cb.TabIndex = 10;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Periodo";
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.contenDesc);
            this.contenedor.Controls.Add(this.contenIpc);
            this.contenedor.Controls.Add(this.tabPage1);
            this.contenedor.Location = new System.Drawing.Point(32, 12);
            this.contenedor.Name = "contenedor";
            this.contenedor.SelectedIndex = 0;
            this.contenedor.Size = new System.Drawing.Size(1005, 662);
            this.contenedor.TabIndex = 5;
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
            this.contenDesc.Text = "Descuentos";
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
            // dgvIpc
            // 
            this.dgvIpc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvIpc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIpc.Location = new System.Drawing.Point(82, 167);
            this.dgvIpc.Name = "dgvIpc";
            this.dgvIpc.Size = new System.Drawing.Size(451, 478);
            this.dgvIpc.TabIndex = 1;
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
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 636);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 685);
            this.Controls.Add(this.contenedor);
            this.Name = "Form1";
            this.Text = "Indexacion Descuentos Sobretasa Deportiva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndexados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contenedor.ResumeLayout(false);
            this.contenDesc.ResumeLayout(false);
            this.contenDesc.PerformLayout();
            this.contenIpc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIpc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDescuentos;
        private System.Windows.Forms.DataGridView dgvIndexados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIndexar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.MaskedTextBox txtFechaFin;
        private System.Windows.Forms.MaskedTextBox txtFechaIni;
        private System.Windows.Forms.MaskedTextBox txtIdentificacion;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl contenedor;
        private System.Windows.Forms.TabPage contenDesc;
        private System.Windows.Forms.TabPage contenIpc;
        private System.Windows.Forms.DataGridView dgvIpc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

