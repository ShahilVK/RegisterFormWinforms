
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RegisterFormWinforms
{
    public partial class Form1 : Form
    {
        string conStr = @"Data Source=LAPTOP-7K5MS1L7\SQLEXPRESS;Initial Catalog=RegistrationDB;Integrated Security=True";

        int selectedId = 0;
        string imagePath = "";

        public Form1()
        {
            InitializeComponent();

            cmbBlood.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDesignation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsers.DropDownStyle = ComboBoxStyle.DropDownList;

            txtName.Leave += txtName_Leave;
            txtAge.Leave += txtAge_Leave;
            txtPhone.Leave += txtPhone_Leave;
            txtEmail.Leave += txtEmail_Leave;
            txtSalary.Leave += txtSalary_Leave;

            ApplyPremiumUI();
        }

        private void ApplyPremiumUI()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Cursor = Cursors.Hand;

            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246); // Modern Blue
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dataGridView1.DefaultCellStyle.Padding = new Padding(5); // Gives breathing room to text

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42); // Dark Navy
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.RowTemplate.Height = 40;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.Enter += (s, e) => txt.BackColor = Color.FromArgb(241, 245, 249); // Subtle Focus Color
                    txt.Leave += (s, e) => txt.BackColor = Color.White;
                }
                else if (c is ComboBox cmb)
                {
                    cmb.FlatStyle = FlatStyle.Flat;
                    cmb.Enter += (s, e) => cmb.BackColor = Color.FromArgb(241, 245, 249);
                    cmb.Leave += (s, e) => cmb.BackColor = Color.White;
                }
            }

            Button[] allButtons = { btnSave, btnUpdate, btnDelete, btnClear, btnBrowse, btnSearch, btnLoad, btnNext };
            foreach (Button btn in allButtons)
            {
                if (btn != null)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                    btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
                }
            }

            btnSave.BackColor = Color.FromArgb(16, 185, 129);
            btnSave.MouseEnter += (s, e) => btnSave.BackColor = Color.FromArgb(5, 150, 105);
            btnSave.MouseLeave += (s, e) => btnSave.BackColor = Color.FromArgb(16, 185, 129);

            btnUpdate.BackColor = Color.FromArgb(59, 130, 246);
            btnUpdate.MouseEnter += (s, e) => btnUpdate.BackColor = Color.FromArgb(37, 99, 235);
            btnUpdate.MouseLeave += (s, e) => btnUpdate.BackColor = Color.FromArgb(59, 130, 246);

            btnDelete.BackColor = Color.FromArgb(239, 68, 68);
            btnDelete.MouseEnter += (s, e) => btnDelete.BackColor = Color.FromArgb(220, 38, 38);
            btnDelete.MouseLeave += (s, e) => btnDelete.BackColor = Color.FromArgb(239, 68, 68);

            btnClear.BackColor = Color.FromArgb(100, 116, 139);
            btnClear.MouseEnter += (s, e) => btnClear.BackColor = Color.FromArgb(71, 85, 105);
            btnClear.MouseLeave += (s, e) => btnClear.BackColor = Color.FromArgb(100, 116, 139);

            Button[] darkButtons = { btnBrowse, btnSearch, btnLoad, btnNext };
            foreach (Button dBtn in darkButtons)
            {
                if (dBtn != null)
                {
                    dBtn.BackColor = Color.FromArgb(15, 23, 42);
                    dBtn.MouseEnter += (s, e) => dBtn.BackColor = Color.FromArgb(30, 41, 59);
                    dBtn.MouseLeave += (s, e) => dBtn.BackColor = Color.FromArgb(15, 23, 42);
                }
            }

            pictureBox1.BackColor = Color.FromArgb(248, 250, 252);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGrid();
            GenerateEntryNo();
            dtDOB.MaxDate = DateTime.Today;


            btnUpdate.Enabled = false;   
            btnDelete.Enabled = false;
        }

        void LoadEmployeeNames()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                string query = "SELECT Id, Name FROM Employees";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbUsers.DataSource = dt;
                cmbUsers.DisplayMember = "Name";
                cmbUsers.ValueMember = "Id";
            }

            cmbUsers.SelectedIndex = -1;
        }

        void LoadGrid()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    string query = "SELECT * FROM Employees";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    SetRowColors();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void GenerateEntryNo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    string query = "SELECT ISNULL(MAX(CAST(EntryNo AS INT)),0) + 1 FROM Employees";

                    SqlCommand cmd = new SqlCommand(query, con);

                    object result = cmd.ExecuteScalar();

                    int nextNo = 1;

                    if (result != null && result != DBNull.Value)
                    {
                        nextNo = Convert.ToInt32(result);
                    }

                    txtEntryNo.Text = nextNo.ToString("D3");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Entry No: " + ex.Message);
            }
        }

        void SetRowColors()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["IsActive"].Value != DBNull.Value)
                {
                    bool active = Convert.ToBoolean(row.Cells["IsActive"].Value);

                    if (active == true)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;   // Active = Green
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;   // Inactive = Red
                    }
                }
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Name required");
                txtName.Focus();
                return;
            }

            if (name.Length < 3)
            {
                MessageBox.Show("Name minimum 3 characters");
                txtName.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Only letters allowed");
                txtName.Focus();
            }
        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAge.Text))
                return;

            int age = Convert.ToInt32(txtAge.Text);

            if (age < 18 || age > 60)
            {
                MessageBox.Show("Age must be between 18 and 60");
                txtAge.Focus();
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();

            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10}$"))
            {
                MessageBox.Show("Invalid phone number");
                txtPhone.Focus();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Enter email");
                txtEmail.Focus();
                return;
            }

            if (email.Contains(" "))
            {
                MessageBox.Show("Email should not contain spaces");
                txtEmail.Focus();
                return;
            }

            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Only gmail.com allowed");
                txtEmail.Focus();
                return;
            }

            bool valid = System.Text.RegularExpressions.Regex.IsMatch(
                email,
                @"^[a-zA-Z0-9._%+-]+@gmail\.com$"
            );

            if (!valid)
            {
                MessageBox.Show("Invalid Gmail format");
                txtEmail.Focus();
                return;
            }

            if (email.Contains(".."))
            {
                MessageBox.Show("Invalid email format");
                txtEmail.Focus();
                return;
            }

            txtEmail.Text = email;
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                MessageBox.Show("Salary is required");
                txtSalary.Focus();
                return;
            }

            decimal sal;

            if (!decimal.TryParse(txtSalary.Text, out sal))
            {
                MessageBox.Show("Enter valid salary amount");
                txtSalary.Focus();
                return;
            }

            if (sal <= 0)
            {
                MessageBox.Show("Salary must be greater than 0");
                txtSalary.Focus();
                return;
            }

            if (sal > 200000)
            {
                MessageBox.Show("Salary too high");
                txtSalary.Focus();
                return;
            }

            txtSalary.Text = sal.ToString("0.00");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                try
                {
                    string gender = rMale.Checked ? "Male" : "Female";
                    bool active = chkActive.Checked;
                    byte[] imgBytes = null;

                    if (pictureBox1.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        imgBytes = ms.ToArray();
                    }

                    SqlCommand cmd = new SqlCommand("sp_InsertEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EntryNo", txtEntryNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@EntryDate", dtEntryDate.Value);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text.Trim());
                    cmd.Parameters.AddWithValue("@DOB", dtDOB.Value);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Qualification", txtQualification.Text.Trim());
                    cmd.Parameters.AddWithValue("@BloodGroup", cmbBlood.Text);
                    cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text);
                    cmd.Parameters.AddWithValue("@Designation", cmbDesignation.Text);
                    cmd.Parameters.AddWithValue("@Salary", txtSalary.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@IsActive", active);

                    if (imgBytes != null)
                        cmd.Parameters.AddWithValue("@Photo", imgBytes);
                    else
                        cmd.Parameters.AddWithValue("@Photo", DBNull.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Saved Successfully ✅");

                    LoadGrid();
                    GenerateEntryNo();
                    SetRowColors();


                    btnUpdate.Enabled = true;    // enable
                    btnDelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select record from grid");
                return;
            }

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                try
                {
                    string gender = rMale.Checked ? "Male" : "Female";
                    bool active = chkActive.Checked;
                    byte[] imgBytes = null;

                    if (pictureBox1.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        imgBytes = ms.ToArray();
                    }

                    SqlCommand cmd = new SqlCommand("sp_UpdateEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", selectedId);
                    cmd.Parameters.AddWithValue("@EntryNo", txtEntryNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@EntryDate", dtEntryDate.Value);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text.Trim());
                    cmd.Parameters.AddWithValue("@DOB", dtDOB.Value);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Qualification", txtQualification.Text.Trim());
                    cmd.Parameters.AddWithValue("@BloodGroup", cmbBlood.Text);
                    cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text);
                    cmd.Parameters.AddWithValue("@Designation", cmbDesignation.Text);
                    cmd.Parameters.AddWithValue("@Salary", txtSalary.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@IsActive", active);

                    if (imgBytes != null)
                        cmd.Parameters.AddWithValue("@Photo", imgBytes);
                    else
                        cmd.Parameters.AddWithValue("@Photo", DBNull.Value);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("Updated Successfully ✅");
                    else
                        MessageBox.Show("Update Failed");

                    LoadGrid();
                    SetRowColors();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Select employee from grid first");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure want to delete?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_DeleteEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", selectedId);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Deleted Successfully 🗑");
                    else
                        MessageBox.Show("Delete Failed");

                    LoadGrid();
                    GenerateEntryNo();
                    SetRowColors();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c.Name != "txtEntryNo")
                {
                    ((TextBox)c).Clear();
                }
            }

            cmbBlood.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            cmbDesignation.SelectedIndex = -1;

            rMale.Checked = false;
            rFemale.Checked = false;
            rOther.Checked = false;

            chkActive.Checked = true;

            pictureBox1.Image = null;

            dtEntryDate.Value = DateTime.Today;

            if (dtDOB.MaxDate >= DateTime.Today)
                dtDOB.Value = DateTime.Today.AddYears(-18);   
            else
                dtDOB.Value = dtDOB.MaxDate;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            selectedId = Convert.ToInt32(row.Cells["Id"].Value);

            txtEntryNo.Text = row.Cells["EntryNo"].Value?.ToString();
            txtName.Text = row.Cells["Name"].Value?.ToString();
            txtAge.Text = row.Cells["Age"].Value?.ToString();
            txtAddress.Text = row.Cells["Address"].Value?.ToString();
            txtPhone.Text = row.Cells["Phone"].Value?.ToString();
            txtQualification.Text = row.Cells["Qualification"].Value?.ToString();
            txtSalary.Text = row.Cells["Salary"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();

            cmbBlood.Text = row.Cells["BloodGroup"].Value?.ToString();
            cmbDepartment.Text = row.Cells["Department"].Value?.ToString();
            cmbDesignation.Text = row.Cells["Designation"].Value?.ToString();

            if (row.Cells["EntryDate"].Value != DBNull.Value)
                dtEntryDate.Value = Convert.ToDateTime(row.Cells["EntryDate"].Value);

            if (row.Cells["DOB"].Value != DBNull.Value)
                dtDOB.Value = Convert.ToDateTime(row.Cells["DOB"].Value);

            string gender = row.Cells["Gender"].Value?.ToString();
            if (gender == "Male")
                rMale.Checked = true;
            else
                rFemale.Checked = true;

            if (row.Cells["IsActive"].Value != DBNull.Value)
                chkActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);

            if (row.Cells["Photo"].Value != DBNull.Value)
            {
                byte[] img = (byte[])row.Cells["Photo"].Value;
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            else
            {
                pictureBox1.Image = null;
            }

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
                imagePath = op.FileName;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_SearchEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@search", txtSearch.Text.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("No record found");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_SearchEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@search", txtSearch.Text.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch
                {

                }
            }
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedValue == null || cmbUsers.SelectedValue is DataRowView)
                return;

            int empId = Convert.ToInt32(cmbUsers.SelectedValue);

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string query = "SELECT * FROM Employees WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", empId);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    selectedId = Convert.ToInt32(dr["Id"]);

                    txtEntryNo.Text = dr["EntryNo"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtAge.Text = dr["Age"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                    txtPhone.Text = dr["Phone"].ToString();
                    txtQualification.Text = dr["Qualification"].ToString();
                    txtSalary.Text = dr["Salary"].ToString();
                    txtEmail.Text = dr["Email"].ToString();

                    cmbBlood.Text = dr["BloodGroup"].ToString();
                    cmbDepartment.Text = dr["Department"].ToString();
                    cmbDesignation.Text = dr["Designation"].ToString();

                    dtEntryDate.Value = Convert.ToDateTime(dr["EntryDate"]);
                    dtDOB.Value = Convert.ToDateTime(dr["DOB"]);

                    if (dr["Gender"].ToString() == "Male")
                        rMale.Checked = true;
                    else
                        rFemale.Checked = true;

                    chkActive.Checked = Convert.ToBoolean(dr["IsActive"]);

                    if (dr["Photo"] != DBNull.Value)
                    {
                        byte[] img = (byte[])dr["Photo"];
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }

                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    //btnClear.Enabled = false;
                }
                dr.Close();
            }
        }

        private void cmbUsers_MouseClick(object sender, MouseEventArgs e)
        {
            LoadEmployeeNames();
        }

        private void cmbUsers_DropDown(object sender, EventArgs e)
        {
            LoadEmployeeNames();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtSalary.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAge.Focus();
            }
        }

        private void txtAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dtDOB.Focus();
        }

        private void txtEntryNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtName.Focus();
        }

        private void dtDOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                rMale.Focus();
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbDepartment.Focus();
        }

        private void cmbBlood_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPhone.Focus();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtQualification.Focus();
        }

        private void txtQualification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSalary.Focus();
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtEmail.Focus();
        }

        private void cmbDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbDesignation.Focus();
        }

        private void cmbDesignation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBrowse.Focus();
        }

        private void rMale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbBlood.Focus();
        }

        private void rFemale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbBlood.Focus();
        }

        private void rOther_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbBlood.Focus();
        }

        private void txtSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtAddress.Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Select employee first");
                return;
            }

            SalaryForm sf = new SalaryForm(
                txtEntryNo.Text,
                txtName.Text,
                txtSalary.Text
            );

            sf.Show();
        }
    }
}