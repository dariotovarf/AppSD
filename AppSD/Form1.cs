using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.Text.RegularExpressions;

using AppSD.Logica;
using AppSD.Modelo;


namespace AppSD
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            
            InitializeComponent();
            LlenarComboBox();
            LlenarComboBoxTerceros();
            llenarTablaIpc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            LlenarComboBox();
            LlenarComboBoxTerceros();
            llenarTablaIpc();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mostrarDescuentos();
            Console.WriteLine(txtFechaIni);
            
        }

        public void mostrarDescuentos()
        {
            if (ValidarFecha(txtFechaIni.Text) && ValidarFecha(txtFechaFin.Text))
            {
                List<Descuento> lista = DescuentoLogica.Instancia.Listar(txtFechaIni.Text, txtFechaFin.Text, txtIdentificacion.Text);
                if (lista!= null) { 

                dgvDescuentos.DataSource = null;
                dgvDescuentos.DataSource = lista;
                dgvDescuentos.Columns[0].Width = 75;
                dgvDescuentos.Columns[1].Width = 80;
                dgvDescuentos.Columns[2].Width = 300;
                dgvDescuentos.Columns[3].Width = 100;
                dgvDescuentos.Columns[4].Width = 100;
                dgvDescuentos.Columns[3].DefaultCellStyle.Format = "#,#0";
                dgvDescuentos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDescuentos.Columns[4].DefaultCellStyle.Format = "#,#0";
                dgvDescuentos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                else
                {
                    MessageBox.Show("No hay registros en la base de datos", "Error");
                }
            }
            else
            {
                MessageBox.Show("Fechas  no validas", "Error");
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //llena el comboBox del formulario descuentos
        public void LlenarComboBox()
        {
            
            List<Ipc> listaIpc = new List<Ipc>();

            listaIpc = IpcLogica.Instancia.ListarIPC();

            cb.DataSource = null;
            cb.DataSource = listaIpc;
            cb.ValueMember = "Id";
            cb.DisplayMember = "Mes";
            
        }

        //llena el comboBox del formulario descuentos
        public void LlenarComboBoxTerceros()
        {

            List<Ipc> listaIpc = new List<Ipc>();

            listaIpc = IpcLogica.Instancia.ListarIPC();

            cbIpcTerceros.DataSource = null;
            cbIpcTerceros.DataSource = listaIpc;
            cbIpcTerceros.ValueMember = "Id";
            cbIpcTerceros.DisplayMember = "Mes";

        }

        public void mostrarDescuentosIndexados()
        {
            dgvIndexados.DataSource = null;
            dgvIndexados.DataSource = DescuentoLogica.Instancia.ListarIndexado(txtFechaIni.Text, txtFechaFin.Text, txtIdentificacion.Text, cb.SelectedIndex);
            dgvIndexados.Columns[0].Width = 65;
            dgvIndexados.Columns[1].Width = 65;
            dgvIndexados.Columns[2].Width = 250;
            dgvIndexados.Columns[3].Width = 95;
            dgvIndexados.Columns[4].Width = 75;
            dgvIndexados.Columns[5].Width = 75;
            dgvIndexados.Columns[6].Width = 75;
            dgvIndexados.Columns[3].DefaultCellStyle.Format = "#,#0";
            dgvIndexados.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIndexados.Columns[4].DefaultCellStyle.Format = "#,#0";
            dgvIndexados.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIndexados.Columns[5].DefaultCellStyle.Format = "#,#0";
            dgvIndexados.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIndexados.Columns[6].DefaultCellStyle.Format = "#,#0";
            dgvIndexados.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

          
        }

        private void btnIndexar_Click(object sender, EventArgs e)
        {
            if (cb.SelectedIndex==0) {
                MessageBox.Show("Seleccione una opcion", "Error");
            }
            else {
                if (ValidarFecha(txtFechaIni.Text) && ValidarFecha(txtFechaFin.Text))
                {
                   mostrarDescuentosIndexados();
                }
                else
                {
                    MessageBox.Show("Fechas no validas", "Error");
                }
            }
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnReporte_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Reporte Descuentos Sobretasa Deportiva \nConsolidado";
            string fecha = "Fecha Reporte: "+ DateTime.Today.Day+ "/"+DateTime.Today.Month+"/"+DateTime.Today.Year+ "    Periodo: " + txtFechaIni.Text + " hasta " + txtFechaFin.Text;
            printer.SubTitle = fecha;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "---Fin---";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvDescuentos);
        }

        public void GenerarReporteDescuento() {

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Reporte Descuentos Sobretasa Deportiva - Consolidado";
          

            printer.SubTitle = string.Format("Fecha: {0}", DateTime.Now.Date.ToString("d")) + "    Periodo: " + txtFechaIni.Text + " hasta " + txtFechaFin.Text;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "---Fin---";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvDescuentos);
        }

        public void GenerarReporteDescuentoIndexado()
        {

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Reporte Descuentos Sobretasa Deportiva Actualizado \nConsolidado\n Actualizado al mes de agosto de 2022";
            string fecha = "Fecha Reporte: " + DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year + "    Periodo: " + txtFechaIni.Text + " hasta " + txtFechaFin.Text;
            printer.SubTitle = fecha;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "---Fin---";
            printer.FooterSpacing = 15;
            
            
            printer.PrintDataGridView(dgvIndexados);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarReporteDescuentoIndexado();
        }

        public void llenarTablaIpc()
        {

            
            dgvIpc.DataSource = null;
            dgvIpc.DataSource = IpcLogica.Instancia.ListarIPC();
            dgvIpc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvIpc.Columns[0].Width = 50;
            dgvIpc.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvIpc.Columns[1].Width = 150;
            dgvIpc.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvIpc.Columns[2].Width = 150;
            dgvIpc.Columns[2].DefaultCellStyle.Format = "#,#0.00";
            dgvIpc.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        public static bool ValidarFecha(string fecha)
        {

            // This Pattern is use to verify the email
            string strRegex = (@"^\d{4}-(02-(0[1-9]|[12][0-9])|(0[469]|11)-(0[1-9]|[12][0-9]|30)|(0[13578]|1[02])-(0[1-9]|[12][0-9]|3[01]))$");

            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);

            if (re.IsMatch(fecha))
                return (true);
            else
                return (false);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvIpc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarTerceros_Click(object sender, EventArgs e)
        {
            mostrarDescuentosTerceros();
        }

        public void mostrarDescuentosTerceros()
        {
            if (ValidarFecha(fechaIniTerceros.Text) && ValidarFecha(fechaFinTerceros.Text))
            {
                List<Descuento> lista = DescuentoLogica.Instancia.ListarPorTerceros(fechaIniTerceros.Text, fechaFinTerceros.Text);
                if (lista != null)
                {

                    dgvDescuentosTerceros.DataSource = null;
                    dgvDescuentosTerceros.DataSource = lista;
                    dgvDescuentosTerceros.Columns[0].Width = 75;
                    dgvDescuentosTerceros.Columns[1].Width = 80;
                    dgvDescuentosTerceros.Columns[2].Width = 300;
                    dgvDescuentosTerceros.Columns[3].Width = 100;
                    dgvDescuentosTerceros.Columns[4].Width = 100;
                    dgvDescuentosTerceros.Columns[3].DefaultCellStyle.Format = "#,#0";
                    dgvDescuentosTerceros.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvDescuentosTerceros.Columns[4].DefaultCellStyle.Format = "#,#0";
                    dgvDescuentosTerceros.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    
                }
                else
                {

                    MessageBox.Show("No hay registros en la base de datos", "Error");
                }
            }
            else
            {
                MessageBox.Show("Fechas  no validas", "Error");
                
            }

        }

        private void btnPdfTerceros_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Reporte Descuentos Sobretasa Deportiva por Terceros \nConsolidado";
            string fecha = "Fecha Reporte: " + DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year + "    Periodo: " + fechaIniTerceros.Text + " hasta " + fechaFinTerceros.Text;
            printer.SubTitle = fecha;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "---";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvDescuentosTerceros);
        }

        private void btnBuscarTercAct_Click(object sender, EventArgs e)
        {
            if (cbIpcTerceros.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una opcion", "Error");
            }

            else
            {
                if (ValidarFecha(fechaIniTerceros.Text) && ValidarFecha(fechaFinTerceros.Text))
                {
                    
                    mostrarTercerosActualizados();
                    
                }
                else
                {

                    MessageBox.Show("Fechas no validas", "Error");

                }
            }

        }
        public void mostrarTercerosActualizados()
        {


            dgvTercerosAct.DataSource = null;
            dgvTercerosAct.DataSource = DescuentoLogica.Instancia.ListarPorTercerosActualizado(fechaIniTerceros.Text, fechaFinTerceros.Text, cbIpcTerceros.SelectedIndex);
            dgvTercerosAct.Columns[0].Width = 65;
            dgvTercerosAct.Columns[1].Width = 65;
            dgvTercerosAct.Columns[2].Width = 250;
            dgvTercerosAct.Columns[3].Width = 95;
            dgvTercerosAct.Columns[4].Width = 75;
            dgvTercerosAct.Columns[5].Width = 75;
            dgvTercerosAct.Columns[6].Width = 75;
            dgvTercerosAct.Columns[3].DefaultCellStyle.Format = "#,#0";
            dgvTercerosAct.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTercerosAct.Columns[4].DefaultCellStyle.Format = "#,#0";
            dgvTercerosAct.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTercerosAct.Columns[5].DefaultCellStyle.Format = "#,#0";
            dgvTercerosAct.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTercerosAct.Columns[6].DefaultCellStyle.Format = "#,#0";
            dgvTercerosAct.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

           
        }

        private void btnPdfTercAct_Click(object sender, EventArgs e)
        {
            GenerarReporteDescuentoTerceroActualizado();
        }

        public void GenerarReporteDescuentoTerceroActualizado()
        {

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Reporte Descuentos Sobretasa Deportiva por Terceros Actualizado \nConsolidado\n Actualizado al mes de agosto de 2022";
            string fecha = "Fecha Reporte: " + DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year + "    Periodo: " + fechaIniTerceros.Text + " hasta " + fechaFinTerceros.Text;
            printer.SubTitle = fecha;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "---Fin---";
            printer.FooterSpacing = 15;

            printer.PrintDataGridView(dgvTercerosAct);
        }

        private void btnReporteExcel_Click(object sender, EventArgs e)
        {
            if (dgvIndexados!= null)
            {
                ExportarDataGridViewExcel(dgvIndexados);
            }
        }
        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
    }

}
