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
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            dtDate.Value = DateTime.Today;
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;

            AutoFillSalaryBreakup(); 
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
            if (cmbMonth.SelectedIndex == -1)
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

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salary Saved Successfully ✅");

                    ClearForm();
                }
                catch (Exception ex)
                {
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
    }
}