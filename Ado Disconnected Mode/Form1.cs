using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace Ado_Disconnected_Mode
{
    public partial class Form1 : Form
    {
        private SqlConnection sql;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();

            sql = new SqlConnection(ConfigurationManager.ConnectionStrings["ITI_db"].ConnectionString);
            cmd = new SqlCommand();
            dt = new DataTable();
            adapter = new SqlDataAdapter();

            fillNames();
            fillDepartmentData();
            fillStudentData();
        }

        private void fillStudentData()
        {
            dt.Clear();
            cmd = new SqlCommand("SELECT * FROM STUDENT", sql);
            adapter = new SqlDataAdapter(cmd);

            try
            {
                adapter.Fill(dt);
                dt.Columns["St_Id"].ReadOnly = true;
                GridViewForReadData.DataSource = null;
                GridViewForReadData.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillNames()
        {
            SqlCommand cmd = new SqlCommand("SELECT St_Id, St_Fname + ' ' + St_Lname AS Fullname FROM STUDENT", sql);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                ad.Fill(dt);
                cmbboxNames.DataSource = dt;
                cmbboxNames.DisplayMember = "Fullname";
                cmbboxNames.ValueMember = "St_Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillDepartmentData()
        {
            SqlCommand cmd = new SqlCommand("SELECT Dept_Id, Dept_Name FROM Department", sql);

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dptCmBox.DataSource = dt;
                dptCmBox.DisplayMember = "Dept_Name";
                dptCmBox.ValueMember = "Dept_Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbboxNames.SelectedValue == null) return;
            if (sql.State == ConnectionState.Closed)
                sql.Open();
            int selectedId = Convert.ToInt32(cmbboxNames.SelectedValue);
            var Query = "DELETE FROM Stud_Course WHERE St_Id = @Id";
            SqlCommand cmdDd = new SqlCommand(Query , sql);
            cmdDd.Parameters.AddWithValue("@Id" , selectedId);
            cmdDd.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand("Delete From Student Where St_Id = @Id" , sql);
            cmd.Parameters.AddWithValue("@Id", selectedId);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Deleted Successfully");
                fillStudentData();
            }
            else
            {
                MessageBox.Show("Errorrrr");
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            fillStudentData();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            SqlCommand insCommand = new SqlCommand(
                "INSERT INTO Student (St_Fname, St_Lname, St_Age, Dept_Id, St_Address) VALUES (@FName, @LName, @Age, @DeptId, @Address)",
                sql
            );
            insCommand.Parameters.Add("@FName", SqlDbType.VarChar, 50, "St_Fname");
            insCommand.Parameters.Add("@LName", SqlDbType.VarChar, 50, "St_Lname");
            insCommand.Parameters.Add("@Age", SqlDbType.Int, 0, "St_Age");
            insCommand.Parameters.Add("@DeptId", SqlDbType.Int, 0, "Dept_Id");
            insCommand.Parameters.Add("@Address", SqlDbType.VarChar, 100, "St_Address");

            SqlCommand updCommand = new SqlCommand(
                "UPDATE Student SET St_Fname = @FName, St_Lname = @LName, St_Age = @Age, Dept_Id = @DeptId, St_Address = @Address WHERE St_Id = @St_Id",
                sql
            );
            updCommand.Parameters.Add("@St_Id", SqlDbType.Int, 0, "St_Id");
            updCommand.Parameters.Add("@FName", SqlDbType.VarChar, 50, "St_Fname");
            updCommand.Parameters.Add("@LName", SqlDbType.VarChar, 50, "St_Lname");
            updCommand.Parameters.Add("@Age", SqlDbType.Int, 0, "St_Age");
            updCommand.Parameters.Add("@DeptId", SqlDbType.Int, 0, "Dept_Id");
            updCommand.Parameters.Add("@Address", SqlDbType.VarChar, 100, "St_Address");

            SqlCommand deletCommand = new SqlCommand(
                "DELETE FROM Student WHERE St_Id = @St_Id",
                sql
            );
            deletCommand.Parameters.Add("@St_Id", SqlDbType.Int, 0, "St_Id");

            adapter.InsertCommand = insCommand;
            adapter.UpdateCommand = updCommand;
            adapter.DeleteCommand = deletCommand;

            try
            {
                adapter.Update(dt);
                MessageBox.Show("Sync Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            fillStudentData();
        }

        private void btnIInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFName.Text) ||
                string.IsNullOrWhiteSpace(txtLName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please complete the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow dr = dt.NewRow();
            dr["St_Fname"] = txtFName.Text;
            dr["St_Lname"] = txtLName.Text;
            dr["St_Address"] = txtAddress.Text;
            dr["St_Age"] = Convert.ToInt32(txtNumDown.Value);
            dr["Dept_Id"] = Convert.ToInt32(dptCmBox.SelectedValue);

            dt.Rows.Add(dr);
            GridViewForReadData.DataSource = null;
            GridViewForReadData.DataSource = dt;

            txtFName.Clear();
            txtLName.Clear();
            txtAddress.Clear();
            txtNumDown.Value = 0;
            dptCmBox.SelectedIndex = -1;
            adapter.Update(dt);
            MessageBox.Show("Data Entered into DataTable");
            fillStudentData();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dptCmBox.SelectedValue == null) return;

            int selectedId = Convert.ToInt32(dptCmBox.SelectedValue);
            string query = "UPDATE Student SET St_Fname = @FName, St_Lname = @LName, St_Age = @Age, St_Address = @Address WHERE St_Id = @St_Id";
            SqlCommand cmd = new SqlCommand(query, sql);
            cmd.Parameters.AddWithValue("@FName", txtFName.Text);
            cmd.Parameters.AddWithValue("@LName", txtLName.Text);
            cmd.Parameters.AddWithValue("@Age", txtNumDown.Value);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@St_Id", selectedId);

            try
            {
                sql.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Clear();
                fillStudentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }

        private void btnGetByName_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(cmbboxNames.SelectedValue);

            string query = "SELECT * FROM Student WHERE St_Id = @St_Id";
            SqlCommand command = new SqlCommand(query, sql);
            command.Parameters.AddWithValue("@St_Id", selectedId);

            try
            {
                sql.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridViewForReadData.DataSource = null;
                GridViewForReadData.DataSource = dt;


                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No student found with the selected ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataRow row = dt.Rows[0];
                txtFName.Text = row["St_Fname"].ToString();
                txtLName.Text = row["St_Lname"].ToString();
                txtAddress.Text = row["St_Address"].ToString();
                txtNumDown.Value = Convert.ToInt32(row["St_Age"]);
                dptCmBox.SelectedValue = Convert.ToInt32(row["Dept_Id"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.Close();
            }
        }

        private void cmbboxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}