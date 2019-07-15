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
        Bill bill;

        private void StockReport_Load(object sender, EventArgs e)
        {
            liquor = new Liquor();
            bill = new Bill();
            DgvReport.DataMember = "Liquor";
            DgvReport.DataSource = liquor.CreateReport().Tables["Liquor"];
            LblTotal.Text = bill.TotalEarning();
        }
    }
}
