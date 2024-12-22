namespace bankaprojesiform
{
    partial class Pbo_form
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
            panel1 = new Panel();
            bLogOut = new Button();
            bCustomer = new Button();
            label2 = new Label();
            label1 = new Label();
            pCustomer = new Panel();
            pCreateCustomer = new Panel();
            cmbCreateStaffTc = new ComboBox();
            label4 = new Label();
            tCreatePassword = new TextBox();
            label3 = new Label();
            tCreateAddress = new TextBox();
            tCreatePhoneNo = new TextBox();
            tCreateTc = new TextBox();
            tCreateLName = new TextBox();
            tCreateFName = new TextBox();
            bCreateAccount = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            pUpdateCustomer = new Panel();
            label6 = new Label();
            cmbUpdateCusStaffTc = new ComboBox();
            label42 = new Label();
            tUpdateCusPass = new TextBox();
            label43 = new Label();
            bUpdCus = new Button();
            tUpdateCusAddress = new TextBox();
            label44 = new Label();
            tUpdateCusPhoneNo = new TextBox();
            label45 = new Label();
            tUpdateCusLastName = new TextBox();
            label46 = new Label();
            tUpdateCusFirstName = new TextBox();
            label47 = new Label();
            cUpdateCustomerTc = new ComboBox();
            label36 = new Label();
            pSeeAllCustomer = new Panel();
            dCustomer = new DataGridView();
            label48 = new Label();
            pCustomerSolBar = new Panel();
            button2 = new Button();
            button1 = new Button();
            bCreateCustomer = new Button();
            panel1.SuspendLayout();
            pCustomer.SuspendLayout();
            pCreateCustomer.SuspendLayout();
            pUpdateCustomer.SuspendLayout();
            pSeeAllCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dCustomer).BeginInit();
            pCustomerSolBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(bLogOut);
            panel1.Controls.Add(bCustomer);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 1029);
            panel1.TabIndex = 0;
            // 
            // bLogOut
            // 
            bLogOut.FlatAppearance.BorderSize = 0;
            bLogOut.FlatStyle = FlatStyle.Flat;
            bLogOut.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bLogOut.Location = new Point(0, 979);
            bLogOut.Name = "bLogOut";
            bLogOut.Size = new Size(161, 50);
            bLogOut.TabIndex = 5;
            bLogOut.Text = "Log Out";
            bLogOut.UseVisualStyleBackColor = true;
            bLogOut.Click += bLogOut_Click;
            // 
            // bCustomer
            // 
            bCustomer.FlatAppearance.BorderSize = 0;
            bCustomer.FlatStyle = FlatStyle.Flat;
            bCustomer.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bCustomer.Location = new Point(3, 401);
            bCustomer.Name = "bCustomer";
            bCustomer.Size = new Size(149, 45);
            bCustomer.TabIndex = 2;
            bCustomer.Text = "Customer";
            bCustomer.UseVisualStyleBackColor = true;
            bCustomer.Click += bCustomer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F);
            label2.Location = new Point(48, 74);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 1;
            label2.Text = "PBO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(10, 27);
            label1.Name = "label1";
            label1.Size = new Size(139, 29);
            label1.TabIndex = 0;
            label1.Text = "Bankacılık";
            // 
            // pCustomer
            // 
            pCustomer.Controls.Add(pSeeAllCustomer);
            pCustomer.Controls.Add(pCreateCustomer);
            pCustomer.Controls.Add(pUpdateCustomer);
            pCustomer.Controls.Add(pCustomerSolBar);
            pCustomer.Location = new Point(160, 0);
            pCustomer.Name = "pCustomer";
            pCustomer.Size = new Size(1738, 1029);
            pCustomer.TabIndex = 1;
            // 
            // pCreateCustomer
            // 
            pCreateCustomer.Controls.Add(cmbCreateStaffTc);
            pCreateCustomer.Controls.Add(label4);
            pCreateCustomer.Controls.Add(tCreatePassword);
            pCreateCustomer.Controls.Add(label3);
            pCreateCustomer.Controls.Add(tCreateAddress);
            pCreateCustomer.Controls.Add(tCreatePhoneNo);
            pCreateCustomer.Controls.Add(tCreateTc);
            pCreateCustomer.Controls.Add(tCreateLName);
            pCreateCustomer.Controls.Add(tCreateFName);
            pCreateCustomer.Controls.Add(bCreateAccount);
            pCreateCustomer.Controls.Add(label11);
            pCreateCustomer.Controls.Add(label10);
            pCreateCustomer.Controls.Add(label9);
            pCreateCustomer.Controls.Add(label8);
            pCreateCustomer.Controls.Add(label7);
            pCreateCustomer.Controls.Add(label5);
            pCreateCustomer.Location = new Point(167, 3);
            pCreateCustomer.Name = "pCreateCustomer";
            pCreateCustomer.Size = new Size(1574, 1023);
            pCreateCustomer.TabIndex = 4;
            // 
            // cmbCreateStaffTc
            // 
            cmbCreateStaffTc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCreateStaffTc.FormattingEnabled = true;
            cmbCreateStaffTc.Location = new Point(756, 636);
            cmbCreateStaffTc.Name = "cmbCreateStaffTc";
            cmbCreateStaffTc.Size = new Size(213, 28);
            cmbCreateStaffTc.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(596, 637);
            label4.Name = "label4";
            label4.Size = new Size(111, 29);
            label4.TabIndex = 27;
            label4.Text = "Staff TC";
            // 
            // tCreatePassword
            // 
            tCreatePassword.Location = new Point(756, 578);
            tCreatePassword.Name = "tCreatePassword";
            tCreatePassword.Size = new Size(213, 27);
            tCreatePassword.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(583, 579);
            label3.Name = "label3";
            label3.Size = new Size(124, 29);
            label3.TabIndex = 25;
            label3.Text = "Password";
            // 
            // tCreateAddress
            // 
            tCreateAddress.Location = new Point(756, 520);
            tCreateAddress.Name = "tCreateAddress";
            tCreateAddress.Size = new Size(213, 27);
            tCreateAddress.TabIndex = 24;
            // 
            // tCreatePhoneNo
            // 
            tCreatePhoneNo.Location = new Point(756, 462);
            tCreatePhoneNo.Name = "tCreatePhoneNo";
            tCreatePhoneNo.Size = new Size(213, 27);
            tCreatePhoneNo.TabIndex = 23;
            // 
            // tCreateTc
            // 
            tCreateTc.Location = new Point(756, 404);
            tCreateTc.Name = "tCreateTc";
            tCreateTc.Size = new Size(213, 27);
            tCreateTc.TabIndex = 22;
            // 
            // tCreateLName
            // 
            tCreateLName.Location = new Point(756, 346);
            tCreateLName.Name = "tCreateLName";
            tCreateLName.Size = new Size(213, 27);
            tCreateLName.TabIndex = 21;
            // 
            // tCreateFName
            // 
            tCreateFName.Location = new Point(756, 288);
            tCreateFName.Name = "tCreateFName";
            tCreateFName.Size = new Size(213, 27);
            tCreateFName.TabIndex = 20;
            // 
            // bCreateAccount
            // 
            bCreateAccount.Anchor = AnchorStyles.Top;
            bCreateAccount.BackColor = Color.FromArgb(76, 175, 80);
            bCreateAccount.FlatAppearance.BorderSize = 0;
            bCreateAccount.FlatStyle = FlatStyle.Flat;
            bCreateAccount.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bCreateAccount.ForeColor = Color.White;
            bCreateAccount.Location = new Point(694, 758);
            bCreateAccount.Name = "bCreateAccount";
            bCreateAccount.Size = new Size(216, 44);
            bCreateAccount.TabIndex = 19;
            bCreateAccount.Text = "Create Account";
            bCreateAccount.UseVisualStyleBackColor = false;
            bCreateAccount.Click += bCreateAccount_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.Location = new Point(620, 405);
            label11.Name = "label11";
            label11.Size = new Size(87, 29);
            label11.TabIndex = 18;
            label11.Text = "TC No";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.Location = new Point(600, 521);
            label10.Name = "label10";
            label10.Size = new Size(107, 29);
            label10.TabIndex = 17;
            label10.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(520, 463);
            label9.Name = "label9";
            label9.Size = new Size(187, 29);
            label9.TabIndex = 16;
            label9.Text = "Phone Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(565, 346);
            label8.Name = "label8";
            label8.Size = new Size(142, 29);
            label8.TabIndex = 15;
            label8.Text = "Last Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(560, 288);
            label7.Name = "label7";
            label7.Size = new Size(147, 29);
            label7.TabIndex = 14;
            label7.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 17F, FontStyle.Underline);
            label5.Location = new Point(648, 182);
            label5.Name = "label5";
            label5.Size = new Size(321, 34);
            label5.TabIndex = 13;
            label5.Text = "CREATE CUSTOMER";
            // 
            // pUpdateCustomer
            // 
            pUpdateCustomer.Controls.Add(label6);
            pUpdateCustomer.Controls.Add(cmbUpdateCusStaffTc);
            pUpdateCustomer.Controls.Add(label42);
            pUpdateCustomer.Controls.Add(tUpdateCusPass);
            pUpdateCustomer.Controls.Add(label43);
            pUpdateCustomer.Controls.Add(bUpdCus);
            pUpdateCustomer.Controls.Add(tUpdateCusAddress);
            pUpdateCustomer.Controls.Add(label44);
            pUpdateCustomer.Controls.Add(tUpdateCusPhoneNo);
            pUpdateCustomer.Controls.Add(label45);
            pUpdateCustomer.Controls.Add(tUpdateCusLastName);
            pUpdateCustomer.Controls.Add(label46);
            pUpdateCustomer.Controls.Add(tUpdateCusFirstName);
            pUpdateCustomer.Controls.Add(label47);
            pUpdateCustomer.Controls.Add(cUpdateCustomerTc);
            pUpdateCustomer.Controls.Add(label36);
            pUpdateCustomer.Location = new Point(164, 0);
            pUpdateCustomer.Name = "pUpdateCustomer";
            pUpdateCustomer.Size = new Size(1574, 1024);
            pUpdateCustomer.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F);
            label6.Location = new Point(607, 691);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 61;
            label6.Text = "Staff TC";
            // 
            // cmbUpdateCusStaffTc
            // 
            cmbUpdateCusStaffTc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdateCusStaffTc.FormattingEnabled = true;
            cmbUpdateCusStaffTc.Location = new Point(744, 686);
            cmbUpdateCusStaffTc.Name = "cmbUpdateCusStaffTc";
            cmbUpdateCusStaffTc.Size = new Size(267, 28);
            cmbUpdateCusStaffTc.TabIndex = 60;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Century", 12F);
            label42.Location = new Point(477, 317);
            label42.Name = "label42";
            label42.Size = new Size(227, 23);
            label42.TabIndex = 59;
            label42.Text = "Select Customer TC No";
            // 
            // tUpdateCusPass
            // 
            tUpdateCusPass.Location = new Point(744, 629);
            tUpdateCusPass.Name = "tUpdateCusPass";
            tUpdateCusPass.Size = new Size(267, 27);
            tUpdateCusPass.TabIndex = 58;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Century", 12F);
            label43.Location = new Point(502, 633);
            label43.Name = "label43";
            label43.Size = new Size(194, 23);
            label43.TabIndex = 57;
            label43.Text = "Customer Password";
            // 
            // bUpdCus
            // 
            bUpdCus.BackColor = Color.FromArgb(76, 175, 80);
            bUpdCus.FlatAppearance.BorderSize = 0;
            bUpdCus.FlatStyle = FlatStyle.Flat;
            bUpdCus.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bUpdCus.ForeColor = Color.White;
            bUpdCus.Location = new Point(676, 761);
            bUpdCus.Name = "bUpdCus";
            bUpdCus.Size = new Size(208, 49);
            bUpdCus.TabIndex = 56;
            bUpdCus.Text = "Update Customer";
            bUpdCus.UseVisualStyleBackColor = false;
            bUpdCus.Click += bUpdCus_Click;
            // 
            // tUpdateCusAddress
            // 
            tUpdateCusAddress.Location = new Point(744, 573);
            tUpdateCusAddress.Name = "tUpdateCusAddress";
            tUpdateCusAddress.Size = new Size(267, 27);
            tUpdateCusAddress.TabIndex = 55;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Century", 12F);
            label44.Location = new Point(517, 573);
            label44.Name = "label44";
            label44.Size = new Size(179, 23);
            label44.TabIndex = 54;
            label44.Text = "Customer Address";
            // 
            // tUpdateCusPhoneNo
            // 
            tUpdateCusPhoneNo.Location = new Point(744, 510);
            tUpdateCusPhoneNo.Name = "tUpdateCusPhoneNo";
            tUpdateCusPhoneNo.Size = new Size(267, 27);
            tUpdateCusPhoneNo.TabIndex = 53;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Century", 12F);
            label45.Location = new Point(501, 510);
            label45.Name = "label45";
            label45.Size = new Size(195, 23);
            label45.TabIndex = 52;
            label45.Text = "Customer Phone No";
            // 
            // tUpdateCusLastName
            // 
            tUpdateCusLastName.Location = new Point(744, 449);
            tUpdateCusLastName.Name = "tUpdateCusLastName";
            tUpdateCusLastName.Size = new Size(267, 27);
            tUpdateCusLastName.TabIndex = 51;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new Font("Century", 12F);
            label46.Location = new Point(491, 449);
            label46.Name = "label46";
            label46.Size = new Size(208, 23);
            label46.TabIndex = 50;
            label46.Text = "Customer Last Name";
            // 
            // tUpdateCusFirstName
            // 
            tUpdateCusFirstName.Location = new Point(744, 386);
            tUpdateCusFirstName.Name = "tUpdateCusFirstName";
            tUpdateCusFirstName.Size = new Size(267, 27);
            tUpdateCusFirstName.TabIndex = 49;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Century", 12F);
            label47.Location = new Point(490, 386);
            label47.Name = "label47";
            label47.Size = new Size(212, 23);
            label47.TabIndex = 48;
            label47.Text = "Customer First Name";
            // 
            // cUpdateCustomerTc
            // 
            cUpdateCustomerTc.DropDownStyle = ComboBoxStyle.DropDownList;
            cUpdateCustomerTc.FormattingEnabled = true;
            cUpdateCustomerTc.Location = new Point(744, 317);
            cUpdateCustomerTc.Name = "cUpdateCustomerTc";
            cUpdateCustomerTc.Size = new Size(267, 28);
            cUpdateCustomerTc.TabIndex = 39;
            cUpdateCustomerTc.SelectedValueChanged += cUpdateCustomerTc_SelectedValueChanged;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Century", 19.8000011F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label36.Location = new Point(591, 236);
            label36.Name = "label36";
            label36.Size = new Size(381, 40);
            label36.TabIndex = 37;
            label36.Text = "UPDATE CUSTOMER";
            // 
            // pSeeAllCustomer
            // 
            pSeeAllCustomer.Controls.Add(dCustomer);
            pSeeAllCustomer.Controls.Add(label48);
            pSeeAllCustomer.Location = new Point(164, 0);
            pSeeAllCustomer.Name = "pSeeAllCustomer";
            pSeeAllCustomer.Size = new Size(1574, 1025);
            pSeeAllCustomer.TabIndex = 61;
            // 
            // dCustomer
            // 
            dCustomer.AllowUserToAddRows = false;
            dCustomer.AllowUserToDeleteRows = false;
            dCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dCustomer.BackgroundColor = Color.White;
            dCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dCustomer.Location = new Point(191, 291);
            dCustomer.Name = "dCustomer";
            dCustomer.ReadOnly = true;
            dCustomer.RowHeadersWidth = 51;
            dCustomer.Size = new Size(1144, 580);
            dCustomer.TabIndex = 39;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Font = new Font("Century", 19.8000011F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label48.Location = new Point(566, 178);
            label48.Name = "label48";
            label48.Size = new Size(382, 40);
            label48.TabIndex = 38;
            label48.Text = "SEE ALL CUSTOMER";
            // 
            // pCustomerSolBar
            // 
            pCustomerSolBar.BackColor = Color.FromArgb(224, 224, 224);
            pCustomerSolBar.Controls.Add(button2);
            pCustomerSolBar.Controls.Add(button1);
            pCustomerSolBar.Controls.Add(bCreateCustomer);
            pCustomerSolBar.Location = new Point(0, 0);
            pCustomerSolBar.Name = "pCustomerSolBar";
            pCustomerSolBar.Size = new Size(161, 1032);
            pCustomerSolBar.TabIndex = 3;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(3, 556);
            button2.Name = "button2";
            button2.Size = new Size(155, 68);
            button2.TabIndex = 4;
            button2.Text = "See All Customer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(3, 482);
            button1.Name = "button1";
            button1.Size = new Size(155, 68);
            button1.TabIndex = 3;
            button1.Text = "Update Customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bCreateCustomer
            // 
            bCreateCustomer.FlatAppearance.BorderSize = 0;
            bCreateCustomer.FlatStyle = FlatStyle.Flat;
            bCreateCustomer.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bCreateCustomer.Location = new Point(3, 401);
            bCreateCustomer.Name = "bCreateCustomer";
            bCreateCustomer.Size = new Size(155, 68);
            bCreateCustomer.TabIndex = 2;
            bCreateCustomer.Text = "Create Customer";
            bCreateCustomer.UseVisualStyleBackColor = true;
            bCreateCustomer.Click += bCreateCustomer_Click;
            // 
            // Pbo_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pCustomer);
            Controls.Add(panel1);
            Name = "Pbo_form";
            Text = "Pbo_form";
            Load += Pbo_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pCustomer.ResumeLayout(false);
            pCreateCustomer.ResumeLayout(false);
            pCreateCustomer.PerformLayout();
            pUpdateCustomer.ResumeLayout(false);
            pUpdateCustomer.PerformLayout();
            pSeeAllCustomer.ResumeLayout(false);
            pSeeAllCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dCustomer).EndInit();
            pCustomerSolBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bCustomer;
        private Label label2;
        private Label label1;
        private Panel pCustomer;
        private Panel pCustomerSolBar;
        private Button bCreateCustomer;
        private Button button2;
        private Button button1;
        private Panel pCreateCustomer;
        private TextBox tCreateAddress;
        private TextBox tCreatePhoneNo;
        private TextBox tCreateTc;
        private TextBox tCreateLName;
        private TextBox tCreateFName;
        private Button bCreateAccount;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Panel pUpdateCustomer;
        private Label label42;
        private TextBox tUpdateCusPass;
        private Label label43;
        private Button bUpdCus;
        private TextBox tUpdateCusAddress;
        private Label label44;
        private TextBox tUpdateCusPhoneNo;
        private Label label45;
        private TextBox tUpdateCusLastName;
        private Label label46;
        private TextBox tUpdateCusFirstName;
        private Label label47;
        private ComboBox cUpdateCustomerTc;
        private Label label36;
        private Panel pSeeAllCustomer;
        private DataGridView dCustomer;
        private Label label48;
        private Button bLogOut;
        private Label label4;
        private TextBox tCreatePassword;
        private Label label3;
        private ComboBox cmbCreateStaffTc;
        private Label label6;
        private ComboBox cmbUpdateCusStaffTc;
    }
}