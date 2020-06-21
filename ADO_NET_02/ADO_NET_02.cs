using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_NET_02
{
    public partial class ADO_NET_02 : Form
    {
        private SqlConnection conn = new SqlConnection();
        private string Constring = "Server='ABHIJEET-PC\\SQLEXPRESS'; Database=EmployeeManagement; integrated security=true;";
        private SqlCommand cmd;

        public ADO_NET_02()
        {
            InitializeComponent();
        }

        private void handleException(Exception e)
        {
            string msg = e.Message.ToString();
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string EmpId = tbEmpID.Text;
            string EmpName = tbEmpName.Text;
            string Desig = tbDesig.Text;
            string Qual = tbQual.Text;
            string JoinDt = tbJoinDt.Text;

            if((EmpId=="")||(EmpName=="")||(Desig=="")||(Qual=="")||(JoinDt==""))
            {
                MessageBox.Show("No Values can be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.ConnectionString = Constring;
                cmd = conn.CreateCommand();

                try
                {
                    string query = "insert into Employee values('"
                        + EmpId+"','"+EmpName+"', '"+Desig+"', '"+Qual+"', '"+JoinDt+"');";

                    cmd.CommandText = query;
                    conn.Open();
                    cmd.ExecuteScalar();

                    MessageBox.Show("Employee Details Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    handleException(ex);
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = Constring;
            cmd = conn.CreateCommand();

            tbDesig.Clear();
            tbEmpID.Clear();
            tbEmpName.Clear();
            tbJoinDt.Clear();
            tbQual.Clear();

            try
            {
                string query = "select * from Employee;";
                cmd.CommandText = query;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                cmbEmp.DisplayMember = "EmployeeID";
                cmbEmp.ValueMember = "EmployeeID";
                cmbEmp.DataSource = dt;
                cmbEmp.Text = "Select Employee ID";
                reader.Close();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void ADO_NET_02_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = Constring;
            cmd = conn.CreateCommand();

            try
            {
                string query = "select * from Employee;";
                cmd.CommandText = query;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cmbEmp.DisplayMember = "EmployeeID";
                cmbEmp.ValueMember = "EmployeeID";
                cmbEmp.DataSource = dt;
                cmbEmp.Text = "Select Employee ID";
                reader.Close();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = cmbEmp.SelectedValue.ToString();

            conn.ConnectionString = Constring;
            cmd = conn.CreateCommand();

            try
            {
                string query = "delete from Employee where EmployeeID = '"+id+"'";
                cmd.CommandText = query;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cmbEmp.DisplayMember = "EmployeeID";
                cmbEmp.ValueMember = "EmployeeID";
                cmbEmp.DataSource = dt;
                cmbEmp.Text = "Select Employee ID";
                reader.Close();
                MessageBox.Show("Employee Details of Employee ID: " + id+ " Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            catch(Exception ex)
            {
                handleException(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = cmbEmp.SelectedValue.ToString();

            conn.ConnectionString = Constring;
            cmd = conn.CreateCommand();

            string EmpId = tbEmpID.Text;
            string EmpName = tbEmpName.Text;
            string Desig = tbDesig.Text;
            string Qual = tbQual.Text;
            string JoinDt = tbJoinDt.Text;

            if ((EmpId == "") || (EmpName == "") || (Desig == "") || (Qual == "") || (JoinDt == ""))
            {
                MessageBox.Show("No Values can be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.ConnectionString = Constring;
                cmd = conn.CreateCommand();

                try
                {
                    string query = "update Employee set EmployeeID = '"
                        +EmpId+"',  EmpName = '"+EmpName+"', Designation = '"+Desig
                        +"', Qualification = '"+Qual+"', JoiningDate = '"+JoinDt+
                        "' where EmployeeID = '"+id+"'; ";

                    cmd.CommandText = query;
                    conn.Open();
                    cmd.ExecuteScalar();

                    MessageBox.Show("Employee Details Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    handleException(ex);
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = cmbEmp.SelectedValue.ToString();

            try
            {
                string query = "select * from Employee where EmployeeID = '"+id+"'; ";
                cmd.CommandText = query;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                tbEmpID.Text = reader["EmployeeID"].ToString();
                tbEmpName.Text = reader["EmpName"].ToString();
                tbDesig.Text = reader["Designation"].ToString();
                tbQual.Text = reader["Qualification"].ToString();
                tbJoinDt.Text = reader["JoiningDate"].ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
    }
}
