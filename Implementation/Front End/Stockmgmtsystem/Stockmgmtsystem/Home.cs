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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Load += new EventHandler(Home_Load);
            panelcategory.Location = panelmain.Location;
            panelliquor.Location = panelmain.Location;
        }

        Login login = new Login();

        private void BtnCreatebill_Click(object sender, EventArgs e)
        {
            CreateBill createbill = new CreateBill();
            createbill.Show();
        }

        private void BtnAddlcust_Click(object sender, EventArgs e)
        {
            AddLoyalCustomer addloyalcustomer = new AddLoyalCustomer();
            addloyalcustomer.Show();
        }

        private void BtnDellcust_Click(object sender, EventArgs e)
        {
            DeleteLoyalCustomer deleteloyalcustomer = new DeleteLoyalCustomer();
            deleteloyalcustomer.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.ShowDialog();
        }

        private void setDefaultDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDefaultDiscount setdefaultdiscount = new SetDefaultDiscount();
            setdefaultdiscount.ShowDialog();
        }

        private void createStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockReport stockreport = new StockReport();
            stockreport.ShowDialog();
        }

        private void changePinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePin changepin = new ChangePin();
            changepin.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnAddcategory_Click(object sender, EventArgs e)
        {
            AddCategory addcategory = new AddCategory();
            addcategory.Show();
        }

        private void BtnViewcategory_Click(object sender, EventArgs e)
        {
            ViewCategory viewcategory = new ViewCategory();
            viewcategory.Show();
        }

        private void BtnEditcategory_Click(object sender, EventArgs e)
        {
            EditCategory editcategory = new EditCategory();
            editcategory.Show();
        }

        private void btnAddliquor_Click(object sender, EventArgs e)
        {
            AddLiquor addliquor = new AddLiquor();
            addliquor.Show();
        }

        private void BtnViewliquor_Click(object sender, EventArgs e)
        {
            ViewLiquor viewliquor = new ViewLiquor();
            viewliquor.Show();
        }

        private void BtnEditlqiquor_Click(object sender, EventArgs e)
        {
            EditLiquor editliquor = new EditLiquor();
            editliquor.Show();
        }

        private void BtnRestock_Click(object sender, EventArgs e)
        {
            RestockLiquor restockliquor = new RestockLiquor();
            restockliquor.Show();
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            hidePanels();
            panelmain.Visible = true;
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            hidePanels();
            panelcategory.Visible = true;
        }

        private void BtnLiquor_Click(object sender, EventArgs e)
        {
            hidePanels();
            panelliquor.Visible = true;
            Loadstockstatus();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            hidePanels();
            panelmain.Visible = true;
        }

        public void hidePanels()
        {
            panelmain.Visible = false;
            panelcategory.Visible = false;
            panelliquor.Visible = false;
        }

        private void Loadstockstatus()
        {
            Liquor liquor = new Liquor();
            DgvStockStatus.DataSource = liquor.NotifyStockStatus().Tables["Liquor"];
        }

        private void BtnRefreshStockStatus_Click(object sender, EventArgs e)
        {
            Loadstockstatus();
        }
    }
}
