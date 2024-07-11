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
    public partial class frmRecordMgmt : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\\169_Tolentino_Francesz_SC\\dbSchoolSupplies.accdb");
        public frmRecordMgmt()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = 
                "INSERT into product(prodID,prodName,quantity,price) "+ 
                "VALUES('"+txtProdID.Text+"' , '"+ txtProdName.Text+"', "+txtQuantity.Text+", "+txtPrice.Text+") ";
            cmd.ExecuteNonQuery();
            grid();
            conn.Close();
        }
        private void btnUpd_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = 
                "UPDATE product "+
                "SET prodName = '"+txtProdName.Text+"', quantity = "+txtQuantity.Text+", price = "+txtPrice.Text+" "+
                "WHERE prodID = '"+txtProdID.Text+"'";
            cmd.ExecuteNonQuery();
            conn.Close();
            grid();
        }

        private void frmRecordMgmt_Load(object sender, EventArgs e)
        {
            grid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = 
                "DELETE FROM product " + 
                "WHERE prodID = '" + txtProdID.Text + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            grid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = " SELECT * FROM product WHERE prodID LIKE '" + txtSearch.Text + "' ";
            OleDbCommand cmd = new OleDbCommand(query,conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDisplay.DataSource = dt;
        }
        void grid()
        {
            String query = "SELECT * FROM product order by prodID asc";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDisplay.DataSource = dt;
        }
        void clear()
        {
            txtProdID.Text = " ";
            txtPrice.Text = " ";
            txtProdName.Text = " ";
            txtQuantity.Text = " ";
            txtSearch.Text = "";
            dgvDisplay.DataSource = null;

        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
