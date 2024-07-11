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
    public partial class frmPurch : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\169_Tolentino_Francesz_SC\dbSchoolSupplies.accdb");

        double quant,total_price;
        string prod,price;

        public frmPurch(double _quantity,string _prod,string _price,double _totPrice)
        {
            quant = _quantity;
            prod = _prod;
            price = _price;
            total_price = _totPrice;     
            InitializeComponent();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = 
                "INSERT INTO Customer(custID,fname,lname) "+
                "VALUES('"+txtCusID.Text+"','"+txtFname.Text+"', '"+txtLname.Text+"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Purchased!");
            conn.Close();
        }

        private void frmPurch_Load(object sender, EventArgs e)
        {
            lblTotPrice.Text = total_price.ToString();
            lblProd.Text = prod;
            lblQuantity.Text = quant.ToString();
            lblPrice.Text = price;
            
        }

    }
}
