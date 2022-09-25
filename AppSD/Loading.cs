using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void pbLoading_Click(object sender, EventArgs e)
        {
            pbLoading.Load("loading_img2.gif");
            pbLoading.Location = new Point(500,500);
        }

        private void pbLoading_Load(object sender, EventArgs e)
        {
            pbLoading.Load("loading_img2.gif");
            pbLoading.Location = new Point(500,500);
        }
    }
}
