using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Customer
{

    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString);
        DataSet ds;
        DataTable tbl;
        SqlCommand cmd;
        string sql;
        
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable getCustomerShema()
        {
            tbl = new DataTable();
            /*Customer Id*/
            DataColumn col = new DataColumn();
            col.Caption = "Customer Id";
            col.ColumnName = "CustomerId";
            col.DataType = typeof(System.String);
            tbl.Columns.Add(col);
            /*Company name*/
            col = new DataColumn();
            col.Caption = "Company Name";
            col.ColumnName = "CompanyName";
            col.DataType = typeof(System.String);
            tbl.Columns.Add(col);
            /*Contact Name*/
            col = new DataColumn();
            col.Caption = "Contact Name";
            col.ColumnName = "ContactName";
            col.DataType = typeof(System.String);
            tbl.Columns.Add(col);
            /*Contact Title*/
            col = new DataColumn();
            col.Caption = "Contact Title";
            col.ColumnName = "ContactTitle";
            col.DataType = typeof(System.String);
            tbl.Columns.Add(col);
            /*Contact Name*/
            col = new DataColumn();
            col.Caption = "Address";
            col.ColumnName = "Address";
            col.DataType = typeof(System.String);
            tbl.Columns.Add(col);
            /*Contact Name*/
            col = new DataColumn();
            col.Caption = "City";
            col.ColumnName = "City";
            col.DataType = typeof(System.String);
            tbl.Columns.Add(col);
            /*Contact Name*/
            col = new DataColumn();
            col.Caption = "Region";
            col.ColumnName = "Region";
            col.DataType = typeof(System.String);
            tbl.Columns.Add(col);
            /*Contact Name*/
            col = new DataColumn();
            col.Caption = "Postal Code";
            col.ColumnName = "PostalCode";
            col.DataType = typeof(System.String);
            tbl.Columns.Add(col);
            /*Contact Name*/
            col = new DataColumn();
            col.Caption = "Country";
            col.ColumnName = "Country";
            col.DataType = typeof(System.String);
            tbl.Columns.Add(col);
            /* Phone*/
            col = new DataColumn();
            col.Caption = "Phone";
            col.ColumnName = "Phone";
            col.DataType = typeof(System.String);
            tbl.Columns.Add(col);
            /*Fax*/
            col = new DataColumn();
            col.Caption = "Fax";
            col.ColumnName = "Fax";
            col.DataType = typeof(System.String);
            tbl.Columns.Add(col);
            return tbl;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable customer;
            DataRow row;
            sql = "Select* from Customers";
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection=con;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            customer = getCustomerShema();
            while (rdr.Read())
            {
                row = customer.NewRow();
                row["CustomerId"] = rdr["CustomerId"];
                row["CompanyName"] = rdr["CompanyName"];
                row["ContactName"] = rdr["ContactName"];
                row["ContactTitle"] = rdr["ContactTitle"];
                row["Address"] = rdr["Address"];
                row["City"] = rdr["City"];
                row["Region"] = rdr["Region"];
                row["PostalCode"] = rdr["PostalCode"];
                row["Country"] = rdr["Country"];
                row["Phone"] = rdr["Phone"];
                row["Fax"] = rdr["Fax"];
                customer.Rows.Add(row);
            }

            dataGridView1.DataSource = customer;
        }
    }
}
