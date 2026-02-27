using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RegisterFormWinforms
{
    public partial class SalaryForm : Form
    {
        string conStr = @"Data Source=LAPTOP-7K5MS1L7\SQLEXPRESS;Initial Catalog=RegistrationDB;Integrated Security=True";

        public SalaryForm(string entryNo, string name, string salary)
        {
            InitializeComponent();

            dtDate.MaxDate = DateTime.Today;

            txtEntryNo.Text = entryNo;
            txtName.Text = name;
            txtSalary.Text = salary;

            txtEntryNo.ReadOnly = true;
            txtName.ReadOnly = true;
            txtSalary.ReadOnly = true;

            txtBasicPay.ReadOnly = true;
            txtHRA.ReadOnly = true;
            txtConveyance.ReadOnly = true;

            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbMonth.Items.AddRange(new string[]
            {
                "January","February","March","April","May","June",
                "July","August","September","October","November","December"
            });

            txtIncentive.KeyPress += OnlyNumber_KeyPress;
            txtExpenses.KeyPress += OnlyNumber_KeyPress;
            txtMessExpenses.KeyPress += OnlyNumber_KeyPress;
            txtAdvance.KeyPress += OnlyNumber_KeyPress;

            txtBasicPay.TextChanged += (s, e) => CalculateTotal();
            txtHRA.TextChanged += (s, e) => CalculateTotal();
            txtConveyance.TextChanged += (s, e) => CalculateTotal();
            txtIncentive.TextChanged += (s, e) => CalculateTotal();
            txtExpenses.TextChanged += (s, e) => CalculateTotal();
            txtMessExpenses.TextChanged += (s, e) => CalculateTotal();
            txtAdvance.TextChanged += (s, e) => CalculateTotal();

            txtLWP.ReadOnly = true;
            txtWorkingDays.KeyPress += OnlyNumber_KeyPress;
            txtPresentDays.KeyPress += OnlyNumber_KeyPress;

            txtWorkingDays.TextChanged += (s, e) => CalculateLWP();
            txtPresentDays.TextChanged += (s, e) => CalculateLWP();

            this.Shown += SalaryForm_Shown;


        }


        private void SalaryForm_Load(object sender, EventArgs e)
        {
            dtDate.Value = DateTime.Today;
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;

            AutoFillSalaryBreakup();


            cmbMonth.Items.Insert(0, "Select Month");
            cmbMonth.SelectedIndex = 0;


            cmbSearchMonths.Items.Insert(0, "Select Month");
            cmbSearchMonths.SelectedIndex = 0;


        }

        private void SalaryForm_Shown(object sender, EventArgs e)
        {
            cmbMonth.Focus();
        }

        void AutoFillSalaryBreakup()
        {
            if (decimal.TryParse(txtSalary.Text, out decimal salary))
            {
                decimal basic = salary / 2;
                decimal hra = salary / 4;
                decimal conveyance = salary / 4;

                txtBasicPay.Text = basic.ToString("0.00");
                txtHRA.Text = hra.ToString("0.00");
                txtConveyance.Text = conveyance.ToString("0.00");
            }
        }

        void CalculateLWP()
        {
            int working = 0;
            int present = 0;

            int.TryParse(txtWorkingDays.Text, out working);
            int.TryParse(txtPresentDays.Text, out present);

            int lwp = working - present;

            if (lwp < 0)
                lwp = 0;

            txtLWP.Text = lwp.ToString();
        }

        private void CalculateTotal()
        {
            decimal basic = 0, hra = 0, conv = 0, inc = 0;
            decimal exp = 0, mess = 0, adv = 0;

            decimal.TryParse(txtBasicPay.Text, out basic);
            decimal.TryParse(txtHRA.Text, out hra);
            decimal.TryParse(txtConveyance.Text, out conv);
            decimal.TryParse(txtIncentive.Text, out inc);
            decimal.TryParse(txtExpenses.Text, out exp);
            decimal.TryParse(txtMessExpenses.Text, out mess);
            decimal.TryParse(txtAdvance.Text, out adv);

            decimal total = (basic + hra + conv + inc) - (exp + mess + adv);

            if (total < 0)
                total = 0;

            txtTotalSalary.Text = total.ToString("0.00");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedIndex == 0)
            {
                MessageBox.Show("Select Month");
                return;
            }

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_InsertSalary", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EntryNo", txtEntryNo.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text));
                    cmd.Parameters.AddWithValue("@Basic", Convert.ToDecimal(txtBasicPay.Text));
                    cmd.Parameters.AddWithValue("@HRA", Convert.ToDecimal(txtHRA.Text));
                    cmd.Parameters.AddWithValue("@Conv", Convert.ToDecimal(txtConveyance.Text));
                    cmd.Parameters.AddWithValue("@Inc", string.IsNullOrWhiteSpace(txtIncentive.Text) ? 0 : Convert.ToDecimal(txtIncentive.Text));
                    cmd.Parameters.AddWithValue("@Exp", string.IsNullOrWhiteSpace(txtExpenses.Text) ? 0 : Convert.ToDecimal(txtExpenses.Text));
                    cmd.Parameters.AddWithValue("@Mess", string.IsNullOrWhiteSpace(txtMessExpenses.Text) ? 0 : Convert.ToDecimal(txtMessExpenses.Text));
                    cmd.Parameters.AddWithValue("@Adv", string.IsNullOrWhiteSpace(txtAdvance.Text) ? 0 : Convert.ToDecimal(txtAdvance.Text));
                    cmd.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtTotalSalary.Text));
                    cmd.Parameters.AddWithValue("@Month", cmbMonth.Text);
                    cmd.Parameters.AddWithValue("@Date", dtDate.Value);
                    cmd.Parameters.AddWithValue("@WorkingDays", string.IsNullOrWhiteSpace(txtWorkingDays.Text) ? 0 : Convert.ToInt32(txtWorkingDays.Text));
                    cmd.Parameters.AddWithValue("@PresentDays", string.IsNullOrWhiteSpace(txtPresentDays.Text) ? 0 : Convert.ToInt32(txtPresentDays.Text));
                    cmd.Parameters.AddWithValue("@LWP", string.IsNullOrWhiteSpace(txtLWP.Text) ? 0 : Convert.ToInt32(txtLWP.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salary Saved Successfully ✅");

                    ClearForm();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Salary already added"))
                        MessageBox.Show("⚠ Salary already saved for this month");
                    else
                        MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            txtIncentive.Clear();
            txtExpenses.Clear();
            txtMessExpenses.Clear();
            txtAdvance.Clear();
            txtTotalSalary.Clear();
            txtWorkingDays.Clear();
            txtPresentDays.Clear();
            txtLWP.Clear();

            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            dtDate.Value = DateTime.Today;

            AutoFillSalaryBreakup(); 
        }

        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.')
                e.Handled = true;

            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt.Text.Contains("."))
                e.Handled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtEntryNo.Text == "")
            {
                MessageBox.Show("Select employee first");
                return;
            }

            if (cmbMonth.SelectedIndex == 0)
            {
                MessageBox.Show("Select month to delete salary");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this salary?",
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
                    SqlCommand cmd = new SqlCommand("sp_DeleteSalary", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EntryNo", txtEntryNo.Text);
                    cmd.Parameters.AddWithValue("@Month", cmbMonth.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Salary Deleted Successfully 🗑");
                    ClearForm();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Salary not found"))
                        MessageBox.Show("No salary found for selected month");
                    else
                        MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        private void txtWorkingDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPresentDays.Focus();
            }
        }

        private void txtPresentDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLWP.Focus();
            }
        }

        private void txtLWP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtIncentive.Focus();
            }
        }

        private void txtIncentive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtExpenses.Focus();
            }
        }

        private void txtExpenses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMessExpenses.Focus();
            }
        }

        private void txtMessExpenses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAdvance.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEntryNo.Text == "")
            {
                MessageBox.Show("Select employee first");
                return;
            }

            if (cmbMonth.SelectedIndex == 0)
            {
                MessageBox.Show("Select month");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to update this salary?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_UpdateSalary", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EntryNo", txtEntryNo.Text);
                    cmd.Parameters.AddWithValue("@Month", cmbMonth.Text);
                    cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text));
                    cmd.Parameters.AddWithValue("@Basic", Convert.ToDecimal(txtBasicPay.Text));
                    cmd.Parameters.AddWithValue("@HRA", Convert.ToDecimal(txtHRA.Text));
                    cmd.Parameters.AddWithValue("@Conv", Convert.ToDecimal(txtConveyance.Text));
                    cmd.Parameters.AddWithValue("@Inc", string.IsNullOrWhiteSpace(txtIncentive.Text) ? 0 : Convert.ToDecimal(txtIncentive.Text));
                    cmd.Parameters.AddWithValue("@Exp", string.IsNullOrWhiteSpace(txtExpenses.Text) ? 0 : Convert.ToDecimal(txtExpenses.Text));
                    cmd.Parameters.AddWithValue("@Mess", string.IsNullOrWhiteSpace(txtMessExpenses.Text) ? 0 : Convert.ToDecimal(txtMessExpenses.Text));
                    cmd.Parameters.AddWithValue("@Adv", string.IsNullOrWhiteSpace(txtAdvance.Text) ? 0 : Convert.ToDecimal(txtAdvance.Text));
                    cmd.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtTotalSalary.Text));
                    cmd.Parameters.AddWithValue("@Date", dtDate.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Salary Updated Successfully ✏");
                    ClearForm();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Salary record not found"))
                        MessageBox.Show("Salary record not found to update");
                    else
                        MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtIncentive.Clear();
            txtExpenses.Clear();
            txtMessExpenses.Clear();
            txtAdvance.Clear();
            txtWorkingDays.Clear();
            txtPresentDays.Clear();
            txtLWP.Clear();
            txtSearchEntryNo.Clear();
            cmbMonth.SelectedIndex = 0;
            cmbSearchMonths.SelectedIndex = 0;
            txtShowTotalSalary.Clear();

            dtDate.Value = DateTime.Today;

            AutoFillSalaryBreakup();

            txtWorkingDays.Focus();
        }


       

        private void btnGetSalary_Click(object sender, EventArgs e)
        {
            if (txtSearchEntryNo.Text == "")
            {
                MessageBox.Show("Enter Entry No");
                txtSearchEntryNo.Focus();
                return;
            }

            if (cmbSearchMonths.SelectedIndex == -1)
            {
                MessageBox.Show("Select Month");
                return;
            }

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_GetTotalSalary", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EntryNo", txtSearchEntryNo.Text);
                    cmd.Parameters.AddWithValue("@Month", cmbSearchMonths.Text);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        txtShowTotalSalary.Text = Convert.ToDecimal(result).ToString("0.00");
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Salary not found"))
                    {
                        MessageBox.Show("Salary not found for this month");
                        txtShowTotalSalary.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error : " + ex.Message);
                    }
                }
            }
        }

        private void txtSearchEntryNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbSearchMonths.Focus();
        }

        private void cmbSearchMonths_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGetSalary.Focus();
        }

        private void cmbSearchMonths_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                cmbSearchMonths.DroppedDown = true;
            }));
        }

        private void cmbMonth_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                cmbMonth.DroppedDown = true;
            }));
        }

        private void cmbMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtWorkingDays.Focus();
        }


        private void btnSearchIcon_Click(object sender, EventArgs e)
        {
            Form popup = new Form();
            popup.Width = 300;
            popup.Height = 230;
            popup.Text = "Search Salary";
            popup.StartPosition = FormStartPosition.CenterScreen;
            popup.FormBorderStyle = FormBorderStyle.FixedDialog;
            popup.MaximizeBox = false;
            popup.MinimizeBox = false;

            Label lblEntry = new Label();
            lblEntry.Text = "Entry No";
            lblEntry.Left = 20;
            lblEntry.Top = 20;

            TextBox txtEntry = new TextBox();
            txtEntry.Left = 20;
            txtEntry.Top = 45;
            txtEntry.Width = 240;

            Label lblMonth = new Label();
            lblMonth.Text = "Month";
            lblMonth.Left = 20;
            lblMonth.Top = 80;

            ComboBox cmbMonthPopup = new ComboBox();
            cmbMonthPopup.Left = 20;
            cmbMonthPopup.Top = 105;
            cmbMonthPopup.Width = 240;
            cmbMonthPopup.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbMonthPopup.Items.AddRange(new string[]
            {
        "January","February","March","April","May","June",
        "July","August","September","October","November","December"
            });

            Button btnSearch = new Button();
            btnSearch.Text = "Search";
            btnSearch.Left = 90;
            btnSearch.Top = 150;
            btnSearch.Width = 100;

            popup.Controls.Add(lblEntry);
            popup.Controls.Add(txtEntry);
            popup.Controls.Add(lblMonth);
            popup.Controls.Add(cmbMonthPopup);
            popup.Controls.Add(btnSearch);

            txtEntry.KeyDown += (s, ev) =>
            {
                if (ev.KeyCode == Keys.Enter)
                {
                    cmbMonthPopup.DroppedDown = true;
                    ev.SuppressKeyPress = true;
                    cmbMonthPopup.Focus();
                }
            };

            cmbMonthPopup.KeyDown += (s, ev) =>
            {
                if (ev.KeyCode == Keys.Enter)
                {
                    ev.SuppressKeyPress = true;
                    btnSearch.PerformClick();
                }
            };

            btnSearch.Click += (s, ev) =>
            {
                if (txtEntry.Text == "")
                {
                    MessageBox.Show("Enter Entry No");
                    txtEntry.Focus();
                    return;
                }

                if (cmbMonthPopup.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Month");
                    cmbMonthPopup.Focus();
                    return;
                }

                string entryNo = txtEntry.Text;
                string month = cmbMonthPopup.Text;

                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    try
                    {
                        SqlCommand cmd = new SqlCommand("sp_SearchSalaryByEntryNo", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EntryNo", entryNo);
                        cmd.Parameters.AddWithValue("@Month", month);

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            txtEntryNo.Text = dr["EntryNo"].ToString();
                            txtName.Text = dr["Name"].ToString();
                            txtSalary.Text = dr["Salary"].ToString();
                            txtBasicPay.Text = dr["Basic"].ToString();
                            txtHRA.Text = dr["HRA"].ToString();
                            txtConveyance.Text = dr["Conveyance"].ToString();
                            txtIncentive.Text = dr["Incentive"].ToString();
                            txtExpenses.Text = dr["Expenses"].ToString();
                            txtMessExpenses.Text = dr["Mess"].ToString();
                            txtAdvance.Text = dr["Advance"].ToString();
                            txtTotalSalary.Text = dr["Total"].ToString();
                            cmbMonth.Text = dr["Month"].ToString();

                            if (dr["Date"] != DBNull.Value)
                                dtDate.Value = Convert.ToDateTime(dr["Date"]);

                            txtWorkingDays.Text = dr["WorkingDays"].ToString();
                            txtPresentDays.Text = dr["PresentDays"].ToString();
                            txtLWP.Text = dr["LWP"].ToString();

                            MessageBox.Show("Salary loaded successfully");
                            popup.Close();
                        }
                        else
                        {
                            MessageBox.Show("Salary not found");
                        }

                        dr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            };

            popup.ShowDialog();
        }
    }
}