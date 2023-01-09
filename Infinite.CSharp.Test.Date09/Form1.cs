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

namespace Infinite.CSharp.Test.Date09
{
    public partial class Form1 : Form
    {
        private SqlConnection conobj = null;
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnGetData_Click(object sender, EventArgs e)
        {
            conobj = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwindcon"].ConnectionString);
            da = new SqlDataAdapter("select * from Customer", conobj);
            ds = new DataSet();
            da.Fill(ds, "Customer");
            DataColumn[] dc = new DataColumn[1];
            dc[0] = ds.Tables["Customer"].Columns["city"];
            ds.Tables["Customer"].PrimaryKey = dc;
            DataRow dr = ds.Tables["customer"].Rows.Find(TxtCustomerCity.Text);
            if (dr != null)          
                {
                DataTable ds = new DataTable();
                da.Fill(ds);
                Grid1.DataSource = ds;
                }
                else
                {
                    LblMessage.Text = "No Records";
                }
            }
        }
    }


       