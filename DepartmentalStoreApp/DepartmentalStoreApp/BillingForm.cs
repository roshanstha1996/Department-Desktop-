using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DepartmentalStoreApp
{
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
        }

        public int SalesCodeId;
        private void BillingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Billing.SalesCodeTable' table. You can move, or remove it, as needed.
            this.SalesCodeTableTableAdapter.Fill(this.Billing.SalesCodeTable,SalesCodeId);
            // TODO: This line of code loads data into the 'Billing.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.Billing.DataTable1,SalesCodeId);
            // TODO: This line of code loads data into the 'Billing.BillTable' table. You can move, or remove it, as needed.
            this.BillTableTableAdapter.Fill(this.Billing.BillTable,SalesCodeId);

            this.reportViewer1.RefreshReport();
        }
    }
}
