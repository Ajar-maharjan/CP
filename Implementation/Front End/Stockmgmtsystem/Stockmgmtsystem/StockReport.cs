using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stockmgmtsystem
{
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }

        Liquor liquor;

        private void StockReport_Load(object sender, EventArgs e)
        {
            liquor = new Liquor();
            DgvReport.DataMember = "Liquor";
            DgvReport.DataSource = liquor.CreateReport().Tables["Liquor"];
        }
    }
}
