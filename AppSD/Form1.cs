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
            llenarTablaIpc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            LlenarComboBox();
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
                //dgvDescuentos.DataSource = DescuentoLogica.Instancia.Listar(txtFechaIni.Text, txtFechaFin.Text, txtIdentificacion.Text);
                dgvDescuentos.Columns[0].Width = 75;
                dgvDescuentos.Columns[1].Width = 80;
                dgvDescuentos.Columns[2].Width = 300;
                dgvDescuentos.Columns[3].Width = 100;
                dgvDescuentos.Columns[4].Width = 100;
                dgvDescuentos.Columns[3].DefaultCellStyle.Format = "#,#0";
                dgvDescuentos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvDescuentos.Columns[4].DefaultCellStyle.Format = "#,#0";
                dgvDescuentos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Console.WriteLine("Columna");
                //      GenerarReporteDescuento();

              //  MessageBox.Show("Fecha inicial no valida", "Error");
                }
                else
                {

                    MessageBox.Show("No hay registros en la base de datos", "Error");
                }
            }
            else
            {
                MessageBox.Show("Fechas  no validas", "Error");/*
                if (this.ValidarFecha(txtFechaFin.Text))
                {

                    MessageBox.Show("Fecha final no valida", "Error");
                }
                else
                {
                   
                    
                    

                }*/
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void LlenarComboBox()
        {
            
            List<Ipc> listaIpc = new List<Ipc>();

            listaIpc = IpcLogica.Instancia.ListarIPC();

            

            //listaIpc.Insert(0, i);


          //  CbIpc = new ComboBox();
            cb.DataSource = null;
            cb.DataSource = listaIpc;
            cb.ValueMember = "Id";
            cb.DisplayMember = "Mes";

            

            // cbIpc.DataSource = listaIpc;
            /*
            foreach (var i in listaIpc)
            {
                cbIpc.Items.Insert(int.Parse(i.Id.ToString()), i.Mes.ToString());
            }
            */



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

          //  GenerarReporteDescuentoIndexado();
        }

        private void btnIndexar_Click(object sender, EventArgs e)
        {
            if (cb.SelectedIndex==0) {
                MessageBox.Show("Seleccione una opcion", "Error");
            }

            else {
                if (ValidarFecha(txtFechaIni.Text) && ValidarFecha(txtFechaFin.Text))
                {
                    // Show();
                    /*using (formWaiting fwd = new formWaiting(mostrarDescuentosIndexados))
                    {
                        fwd.ShowDialog(this);
                    }*/
                   mostrarDescuentosIndexados();
                   // Hide();
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
            printer.Title = "Reporte Descuentos Sobretasa Deportiva";
            printer.SubTitle = string.Format("Fecha: {0}", DateTime.Now.Date)+"    Periodo: "+txtFechaIni.Text+" hasta "+txtFechaFin.Text;
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
            printer.Title = "Reporte Descuentos Sobretasa Deportiva";
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
            printer.Title = "Reporte Descuentos Sobretasa Deportiva - Indexado";
            printer.SubTitle = string.Format("Fecha: {0}", DateTime.Now.Date) + "    Periodo: " + txtFechaIni.Text + " hasta " + txtFechaFin.Text;
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
    }

}
