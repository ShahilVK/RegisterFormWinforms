


using System;
using System.Drawing;

namespace RegisterFormWinforms
{
    partial class SalaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFetchSalary = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSearchEntryNo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbSearchMonths = new System.Windows.Forms.ComboBox();
            this.btnGetSalary = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtShowTotalSalary = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEntryNo = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtBasicPay = new System.Windows.Forms.TextBox();
            this.txtHRA = new System.Windows.Forms.TextBox();
            this.txtConveyance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIncentive = new System.Windows.Forms.TextBox();
            this.txtExpenses = new System.Windows.Forms.TextBox();
            this.txtMessExpenses = new System.Windows.Forms.TextBox();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.txtWorkingDays = new System.Windows.Forms.TextBox();
            this.txtPresentDays = new System.Windows.Forms.TextBox();
            this.txtLWP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearchIcon = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelFetchSalary.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFetchSalary
            // 
            this.panelFetchSalary.BackColor = System.Drawing.Color.White;
            this.panelFetchSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFetchSalary.Controls.Add(this.label17);
            this.panelFetchSalary.Controls.Add(this.txtSearchEntryNo);
            this.panelFetchSalary.Controls.Add(this.label18);
            this.panelFetchSalary.Controls.Add(this.cmbSearchMonths);
            this.panelFetchSalary.Controls.Add(this.btnGetSalary);
            this.panelFetchSalary.Controls.Add(this.label19);
            this.panelFetchSalary.Controls.Add(this.txtShowTotalSalary);
            this.panelFetchSalary.Location = new System.Drawing.Point(50, 520);
            this.panelFetchSalary.Name = "panelFetchSalary";
            this.panelFetchSalary.Size = new System.Drawing.Size(370, 115);
            this.panelFetchSalary.TabIndex = 50;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label17.Location = new System.Drawing.Point(15, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 21);
            this.label17.TabIndex = 41;
            this.label17.Text = "Emp ID:";
            // 
            // txtSearchEntryNo
            // 
            this.txtSearchEntryNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchEntryNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchEntryNo.Location = new System.Drawing.Point(85, 17);
            this.txtSearchEntryNo.Name = "txtSearchEntryNo";
            this.txtSearchEntryNo.Size = new System.Drawing.Size(80, 30);
            this.txtSearchEntryNo.TabIndex = 43;
            this.txtSearchEntryNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchEntryNo_KeyDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label18.Location = new System.Drawing.Point(175, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 21);
            this.label18.TabIndex = 42;
            this.label18.Text = "Month:";
            // 
            // cmbSearchMonths
            // 
            this.cmbSearchMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchMonths.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSearchMonths.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSearchMonths.FormattingEnabled = true;
            this.cmbSearchMonths.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbSearchMonths.Location = new System.Drawing.Point(240, 17);
            this.cmbSearchMonths.Name = "cmbSearchMonths";
            this.cmbSearchMonths.Size = new System.Drawing.Size(110, 31);
            this.cmbSearchMonths.TabIndex = 44;
            this.cmbSearchMonths.Enter += new System.EventHandler(this.cmbSearchMonths_Enter);
            this.cmbSearchMonths.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSearchMonths_KeyDown);
            // 
            // btnGetSalary
            // 
            this.btnGetSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnGetSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetSalary.FlatAppearance.BorderSize = 0;
            this.btnGetSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGetSalary.ForeColor = System.Drawing.Color.White;
            this.btnGetSalary.Location = new System.Drawing.Point(15, 68);
            this.btnGetSalary.Name = "btnGetSalary";
            this.btnGetSalary.Size = new System.Drawing.Size(100, 32);
            this.btnGetSalary.TabIndex = 45;
            this.btnGetSalary.Text = "Get Salary";
            this.btnGetSalary.UseVisualStyleBackColor = false;
            this.btnGetSalary.Click += new System.EventHandler(this.btnGetSalary_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label19.Location = new System.Drawing.Point(135, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 21);
            this.label19.TabIndex = 46;
            this.label19.Text = "Fetched:";
            // 
            // txtShowTotalSalary
            // 
            this.txtShowTotalSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtShowTotalSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShowTotalSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtShowTotalSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.txtShowTotalSalary.Location = new System.Drawing.Point(215, 69);
            this.txtShowTotalSalary.Name = "txtShowTotalSalary";
            this.txtShowTotalSalary.ReadOnly = true;
            this.txtShowTotalSalary.Size = new System.Drawing.Size(135, 30);
            this.txtShowTotalSalary.TabIndex = 47;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(850, 80);
            this.panelHeader.TabIndex = 40;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(35, 15);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(370, 50);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Salary Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(50, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entry No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(450, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // txtEntryNo
            // 
            this.txtEntryNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntryNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEntryNo.Location = new System.Drawing.Point(170, 112);
            this.txtEntryNo.Name = "txtEntryNo";
            this.txtEntryNo.Size = new System.Drawing.Size(200, 30);
            this.txtEntryNo.TabIndex = 2;
            // 
            // dtDate
            // 
            this.dtDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtDate.Location = new System.Drawing.Point(580, 112);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 30);
            this.dtDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(50, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(50, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Salary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(50, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Basic Pay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(50, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "HRA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label7.Location = new System.Drawing.Point(50, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Conveyance:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(170, 172);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 30);
            this.txtName.TabIndex = 9;
            // 
            // txtSalary
            // 
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSalary.Location = new System.Drawing.Point(170, 232);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(200, 30);
            this.txtSalary.TabIndex = 10;
            // 
            // txtBasicPay
            // 
            this.txtBasicPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtBasicPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBasicPay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBasicPay.Location = new System.Drawing.Point(170, 292);
            this.txtBasicPay.Name = "txtBasicPay";
            this.txtBasicPay.ReadOnly = true;
            this.txtBasicPay.Size = new System.Drawing.Size(200, 30);
            this.txtBasicPay.TabIndex = 11;
            // 
            // txtHRA
            // 
            this.txtHRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtHRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHRA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHRA.Location = new System.Drawing.Point(170, 352);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.ReadOnly = true;
            this.txtHRA.Size = new System.Drawing.Size(200, 30);
            this.txtHRA.TabIndex = 12;
            // 
            // txtConveyance
            // 
            this.txtConveyance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtConveyance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConveyance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConveyance.Location = new System.Drawing.Point(170, 412);
            this.txtConveyance.Name = "txtConveyance";
            this.txtConveyance.ReadOnly = true;
            this.txtConveyance.Size = new System.Drawing.Size(200, 30);
            this.txtConveyance.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label8.Location = new System.Drawing.Point(450, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Incentive:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label9.Location = new System.Drawing.Point(450, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Expenses:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label10.Location = new System.Drawing.Point(450, 535);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mess Expenses:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label11.Location = new System.Drawing.Point(450, 595);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "Advance:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label12.Location = new System.Drawing.Point(450, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "Working Days:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label13.Location = new System.Drawing.Point(450, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 21);
            this.label13.TabIndex = 19;
            this.label13.Text = "Present Days:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label14.Location = new System.Drawing.Point(450, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 21);
            this.label14.TabIndex = 20;
            this.label14.Text = "LWP:";
            // 
            // txtIncentive
            // 
            this.txtIncentive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIncentive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIncentive.Location = new System.Drawing.Point(580, 412);
            this.txtIncentive.Name = "txtIncentive";
            this.txtIncentive.Size = new System.Drawing.Size(200, 30);
            this.txtIncentive.TabIndex = 21;
            this.txtIncentive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIncentive_KeyDown);
            // 
            // txtExpenses
            // 
            this.txtExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpenses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtExpenses.Location = new System.Drawing.Point(580, 472);
            this.txtExpenses.Name = "txtExpenses";
            this.txtExpenses.Size = new System.Drawing.Size(200, 30);
            this.txtExpenses.TabIndex = 22;
            this.txtExpenses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExpenses_KeyDown);
            // 
            // txtMessExpenses
            // 
            this.txtMessExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessExpenses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMessExpenses.Location = new System.Drawing.Point(580, 532);
            this.txtMessExpenses.Name = "txtMessExpenses";
            this.txtMessExpenses.Size = new System.Drawing.Size(200, 30);
            this.txtMessExpenses.TabIndex = 23;
            this.txtMessExpenses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessExpenses_KeyDown);
            // 
            // txtAdvance
            // 
            this.txtAdvance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdvance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAdvance.Location = new System.Drawing.Point(580, 592);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(200, 30);
            this.txtAdvance.TabIndex = 24;
            this.txtAdvance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdvance_KeyDown);
            // 
            // txtWorkingDays
            // 
            this.txtWorkingDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWorkingDays.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtWorkingDays.Location = new System.Drawing.Point(580, 232);
            this.txtWorkingDays.Name = "txtWorkingDays";
            this.txtWorkingDays.Size = new System.Drawing.Size(200, 30);
            this.txtWorkingDays.TabIndex = 25;
            this.txtWorkingDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorkingDays_KeyDown);
            // 
            // txtPresentDays
            // 
            this.txtPresentDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPresentDays.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPresentDays.Location = new System.Drawing.Point(580, 292);
            this.txtPresentDays.Name = "txtPresentDays";
            this.txtPresentDays.Size = new System.Drawing.Size(200, 30);
            this.txtPresentDays.TabIndex = 26;
            this.txtPresentDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPresentDays_KeyDown);
            // 
            // txtLWP
            // 
            this.txtLWP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLWP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLWP.Location = new System.Drawing.Point(580, 352);
            this.txtLWP.Name = "txtLWP";
            this.txtLWP.Size = new System.Drawing.Size(200, 30);
            this.txtLWP.TabIndex = 27;
            //// 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label15.Location = new System.Drawing.Point(450, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 21);
            this.label15.TabIndex = 28;
            this.label15.Text = "Month:";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(580, 172);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(200, 31);
            this.cmbMonth.TabIndex = 29;
            this.cmbMonth.Enter += new System.EventHandler(this.cmbMonth_Enter);
            this.cmbMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMonth_KeyDown);
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTotalSalary.Location = new System.Drawing.Point(170, 472);
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.ReadOnly = true;
            this.txtTotalSalary.Size = new System.Drawing.Size(200, 30);
            this.txtTotalSalary.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label16.Location = new System.Drawing.Point(50, 475);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 21);
            this.label16.TabIndex = 31;
            this.label16.Text = "Total Salary:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(170, 660);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 42);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(310, 660);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 42);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(450, 660);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 42);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(590, 660);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 42);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearchIcon
            // 
            this.btnSearchIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSearchIcon.Location = new System.Drawing.Point(740, 665);
            this.btnSearchIcon.Name = "btnSearchIcon";
            this.btnSearchIcon.Size = new System.Drawing.Size(40, 35);
            this.btnSearchIcon.TabIndex = 51;
            this.btnSearchIcon.Text = "🔍";
            this.btnSearchIcon.UseVisualStyleBackColor = true;
            this.btnSearchIcon.Click += new System.EventHandler(this.btnSearchIcon_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(720, 695);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 42);
            this.btnNext.TabIndex = 52;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(850, 753);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSearchIcon);
            this.Controls.Add(this.panelFetchSalary);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTotalSalary);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtLWP);
            this.Controls.Add(this.txtPresentDays);
            this.Controls.Add(this.txtWorkingDays);
            this.Controls.Add(this.txtAdvance);
            this.Controls.Add(this.txtMessExpenses);
            this.Controls.Add(this.txtExpenses);
            this.Controls.Add(this.txtIncentive);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtConveyance);
            this.Controls.Add(this.txtHRA);
            this.Controls.Add(this.txtBasicPay);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.txtEntryNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Name = "SalaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Management";
            this.Load += new System.EventHandler(this.SalaryForm_Load);
            this.panelFetchSalary.ResumeLayout(false);
            this.panelFetchSalary.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelFetchSalary;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEntryNo;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtBasicPay;
        private System.Windows.Forms.TextBox txtHRA;
        private System.Windows.Forms.TextBox txtConveyance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIncentive;
        private System.Windows.Forms.TextBox txtExpenses;
        private System.Windows.Forms.TextBox txtMessExpenses;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.TextBox txtWorkingDays;
        private System.Windows.Forms.TextBox txtPresentDays;
        private System.Windows.Forms.TextBox txtLWP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSearchEntryNo;
        private System.Windows.Forms.ComboBox cmbSearchMonths;
        private System.Windows.Forms.Button btnGetSalary;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtShowTotalSalary;
        private System.Windows.Forms.Button btnSearchIcon;
        private System.Windows.Forms.Button btnNext;
    }
}