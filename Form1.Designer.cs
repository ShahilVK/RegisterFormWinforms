using System;

namespace RegisterFormWinforms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntryNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtEntryDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rMale = new System.Windows.Forms.RadioButton();
            this.rFemale = new System.Windows.Forms.RadioButton();
            this.cmbBlood = new System.Windows.Forms.ComboBox();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rOther = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entry NO:";
            // 
            // txtEntryNo
            // 
            this.txtEntryNo.Location = new System.Drawing.Point(97, 6);
            this.txtEntryNo.Name = "txtEntryNo";
            this.txtEntryNo.Size = new System.Drawing.Size(100, 22);
            this.txtEntryNo.TabIndex = 1;
            this.txtEntryNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntryNo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(937, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entry Date :";
            // 
            // dtEntryDate
            // 
            this.dtEntryDate.Location = new System.Drawing.Point(1063, 12);
            this.dtEntryDate.Name = "dtEntryDate";
            this.dtEntryDate.Size = new System.Drawing.Size(200, 22);
            this.dtEntryDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(825, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date Of Birth :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(157, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 8;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(556, 78);
            this.txtAge.MaxLength = 2;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 9;
            this.txtAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(940, 74);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(161, 22);
            this.dtDOB.TabIndex = 10;
            this.dtDOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtDOB_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phone No :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(825, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Email :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(157, 138);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 13;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(157, 246);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 14;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(940, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Gender :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(461, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Blood Group :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Qualification :";
            // 
            // rMale
            // 
            this.rMale.AutoSize = true;
            this.rMale.Location = new System.Drawing.Point(157, 316);
            this.rMale.Name = "rMale";
            this.rMale.Size = new System.Drawing.Size(58, 20);
            this.rMale.TabIndex = 19;
            this.rMale.TabStop = true;
            this.rMale.Text = "Male";
            this.rMale.UseVisualStyleBackColor = true;
            this.rMale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rMale_KeyDown);
            // 
            // rFemale
            // 
            this.rFemale.AutoSize = true;
            this.rFemale.Location = new System.Drawing.Point(244, 316);
            this.rFemale.Name = "rFemale";
            this.rFemale.Size = new System.Drawing.Size(74, 20);
            this.rFemale.TabIndex = 20;
            this.rFemale.TabStop = true;
            this.rFemale.Text = "Female";
            this.rFemale.UseVisualStyleBackColor = true;
            this.rFemale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rFemale_KeyDown);
            // 
            // cmbBlood
            // 
            this.cmbBlood.FormattingEnabled = true;
            this.cmbBlood.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.cmbBlood.Location = new System.Drawing.Point(556, 130);
            this.cmbBlood.Name = "cmbBlood";
            this.cmbBlood.Size = new System.Drawing.Size(100, 24);
            this.cmbBlood.TabIndex = 21;
            this.cmbBlood.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBlood_KeyDown);
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(157, 198);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(100, 22);
            this.txtQualification.TabIndex = 22;
            this.txtQualification.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQualification_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(473, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Department :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(473, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Designation :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(825, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Salary :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(524, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Active";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "HR",
            "IT",
            "Sales",
            "Accounts",
            "Admin"});
            this.cmbDepartment.Location = new System.Drawing.Point(601, 227);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 24);
            this.cmbDepartment.TabIndex = 27;
            this.cmbDepartment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDepartment_KeyDown);
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Manager",
            "Developer",
            "Tester",
            "HR Executive",
            "Accountant"});
            this.cmbDesignation.Location = new System.Drawing.Point(601, 277);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(121, 24);
            this.cmbDesignation.TabIndex = 28;
            this.cmbDesignation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDesignation_KeyDown);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(940, 172);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 29;
            this.txtSalary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalary_KeyDown);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(476, 177);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(18, 17);
            this.chkActive.TabIndex = 30;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(343, 558);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(442, 558);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(565, 558);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(688, 558);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1115, 521);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 38;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 379);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 150);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(910, 488);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 40;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(930, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(936, 347);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 42;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1143, 416);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 43;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1062, 416);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(771, 320);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(89, 24);
            this.cmbUsers.TabIndex = 45;
            this.cmbUsers.Text = "Employees";
            this.cmbUsers.DropDown += new System.EventHandler(this.cmbUsers_DropDown);
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(469, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(327, 38);
            this.label16.TabIndex = 46;
            this.label16.Text = "Registration Form";
            // 
            // rOther
            // 
            this.rOther.AutoSize = true;
            this.rOther.Location = new System.Drawing.Point(343, 315);
            this.rOther.Name = "rOther";
            this.rOther.Size = new System.Drawing.Size(60, 20);
            this.rOther.TabIndex = 47;
            this.rOther.TabStop = true;
            this.rOther.Text = "Other";
            this.rOther.UseVisualStyleBackColor = true;
            this.rOther.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rOther_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::RegisterFormWinforms.Properties.Resources.register1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1448, 602);
            this.Controls.Add(this.rOther);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtQualification);
            this.Controls.Add(this.cmbBlood);
            this.Controls.Add(this.rFemale);
            this.Controls.Add(this.rMale);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtEntryDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEntryNo);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntryNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtEntryDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rMale;
        private System.Windows.Forms.RadioButton rFemale;
        private System.Windows.Forms.ComboBox cmbBlood;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rOther;
    }
}

