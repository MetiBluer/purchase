using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Code_Tolentino_Francesz_Inv
{
    public partial class frmMain : Form
    {
        double quantity,totalPrice;
        string prod, price;

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\\169_Tolentino_Francesz_SC\\dbSchoolSupplies.accdb");
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            grid();

        }

        private void btnPurchh_Click(object sender, EventArgs e)
        {
            prod = dgvProducts.SelectedCells[1].Value.ToString();
            price = dgvProducts.SelectedCells[3].Value.ToString();
            totalPrice = double.Parse(txtQuantity.Text) * double.Parse(price);
            quantity = double.Parse(txtQuantity.Text);
            frmPurch purch = new frmPurch(quantity,prod,price,totalPrice);
            purch.ShowDialog();

        }
        void grid()
        {
            String query = "SELECT * FROM product order by prodID asc";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProducts.DataSource = dt;
        }
        private void btnRecord_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvProducts.SelectedCells[0].Value.ToString()+ dgvProducts.SelectedCells[1].Value.ToString());
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            frmRecordMgmt frm = new frmRecordMgmt();
            frm.ShowDialog();
           
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
