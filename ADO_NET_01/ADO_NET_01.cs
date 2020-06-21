using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_NET_01
{
    public partial class ADO_NET_01 : Form
    {
        public ADO_NET_01()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=ABHIJEET-PC\\SQLEXPRESS; initial catalog=Northwind; integrated security = true;";
            SqlCommand cmd = conn.CreateCommand();

            try
            {
                string query = "select (FirstName+' ' + LastName) as Name from Employees;";
                cmd.CommandText = query;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                listBox1.DisplayMember = "Name";
                listBox1.DataSource = dt;
                reader.Close();
            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
    }
}
