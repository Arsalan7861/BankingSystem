namespace bankaprojesiform
{
    partial class Manager_Form
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
            pSolBar = new Panel();
            bLogOut = new Button();
            bLog = new Button();
            bStaff = new Button();
            label2 = new Label();
            label1 = new Label();
            pStaff = new Panel();
            pSeeAllStaff = new Panel();
            bSearchStaff = new Button();
            tSearchStaff = new TextBox();
            label9 = new Label();
            dSeeAllStaff = new DataGridView();
            label31 = new Label();
            pDeleteStaff = new Panel();
            cDelSelStaff = new ComboBox();
            label33 = new Label();
            btnDeleteStaff = new Button();
            label32 = new Label();
            pUpdateStaff = new Panel();
            tUpdStaffEmail = new TextBox();
            label7 = new Label();
            cUpdStaffBranchId = new ComboBox();
            label8 = new Label();
            tUpdStaffPassword = new TextBox();
            label10 = new Label();
            bUStaff = new Button();
            cUpdStaffPos = new ComboBox();
            tUpdStaffAddress = new TextBox();
            tUpdStaffPhoneNo = new TextBox();
            tUpdStaffLName = new TextBox();
            tUpdStaffFirstName = new TextBox();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            cUpdateStaffSel = new ComboBox();
            label25 = new Label();
            label23 = new Label();
            pCreateStaff = new Panel();
            tCreateStaffEmail = new TextBox();
            label6 = new Label();
            cCreateStaffBranchId = new ComboBox();
            label5 = new Label();
            tCreateStaffTc = new TextBox();
            label4 = new Label();
            tCreateStaffPassword = new TextBox();
            label3 = new Label();
            btnCreateStaff = new Button();
            cCreateStaffPos = new ComboBox();
            tCreateStaffAddress = new TextBox();
            tCreateStaffPhoneNo = new TextBox();
            tCreateStaffLName = new TextBox();
            tCreateStaffFName = new TextBox();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            pStaffBar = new Panel();
            bSeeStaff = new Button();
            bDeleteStaff = new Button();
            bUpdateStaff = new Button();
            bCreateStaff = new Button();
            pLog = new Panel();
            bSearchLog = new Button();
            tSearchLogTc = new TextBox();
            label11 = new Label();
            label51 = new Label();
            dLog = new DataGridView();
            pSolBar.SuspendLayout();
            pStaff.SuspendLayout();
            pSeeAllStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dSeeAllStaff).BeginInit();
            pDeleteStaff.SuspendLayout();
            pUpdateStaff.SuspendLayout();
            pCreateStaff.SuspendLayout();
            pStaffBar.SuspendLayout();
            pLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dLog).BeginInit();
            SuspendLayout();
            // 
            // pSolBar
            // 
            pSolBar.BackColor = Color.FromArgb(224, 224, 224);
            pSolBar.Controls.Add(bLogOut);
            pSolBar.Controls.Add(bLog);
            pSolBar.Controls.Add(bStaff);
            pSolBar.Controls.Add(label2);
            pSolBar.Controls.Add(label1);
            pSolBar.Location = new Point(0, 1);
            pSolBar.Name = "pSolBar";
            pSolBar.Size = new Size(190, 1030);
            pSolBar.TabIndex = 0;
            // 
            // bLogOut
            // 
            bLogOut.FlatAppearance.BorderSize = 0;
            bLogOut.FlatStyle = FlatStyle.Flat;
            bLogOut.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bLogOut.Location = new Point(3, 930);
            bLogOut.Name = "bLogOut";
            bLogOut.Size = new Size(184, 50);
            bLogOut.TabIndex = 4;
            bLogOut.Text = "Log Out";
            bLogOut.UseVisualStyleBackColor = true;
            bLogOut.Click += bLogOut_Click;
            // 
            // bLog
            // 
            bLog.FlatAppearance.BorderSize = 0;
            bLog.FlatStyle = FlatStyle.Flat;
            bLog.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bLog.Location = new Point(3, 442);
            bLog.Name = "bLog";
            bLog.Size = new Size(184, 50);
            bLog.TabIndex = 3;
            bLog.Text = "Log";
            bLog.UseVisualStyleBackColor = true;
            bLog.Click += bLog_Click;
            // 
            // bStaff
            // 
            bStaff.FlatAppearance.BorderSize = 0;
            bStaff.FlatStyle = FlatStyle.Flat;
            bStaff.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bStaff.Location = new Point(3, 386);
            bStaff.Name = "bStaff";
            bStaff.Size = new Size(184, 50);
            bStaff.TabIndex = 2;
            bStaff.Text = "Staff";
            bStaff.UseVisualStyleBackColor = true;
            bStaff.Click += bStaff_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F);
            label2.Location = new Point(46, 67);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 1;
            label2.Text = "Manager";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(139, 29);
            label1.TabIndex = 0;
            label1.Text = "Bankacılık";
            // 
            // pStaff
            // 
            pStaff.Controls.Add(pSeeAllStaff);
            pStaff.Controls.Add(pDeleteStaff);
            pStaff.Controls.Add(pUpdateStaff);
            pStaff.Controls.Add(pCreateStaff);
            pStaff.Controls.Add(pStaffBar);
            pStaff.Location = new Point(187, 1);
            pStaff.Name = "pStaff";
            pStaff.Size = new Size(1716, 1030);
            pStaff.TabIndex = 1;
            // 
            // pSeeAllStaff
            // 
            pSeeAllStaff.Controls.Add(bSearchStaff);
            pSeeAllStaff.Controls.Add(tSearchStaff);
            pSeeAllStaff.Controls.Add(label9);
            pSeeAllStaff.Controls.Add(dSeeAllStaff);
            pSeeAllStaff.Controls.Add(label31);
            pSeeAllStaff.Location = new Point(201, 0);
            pSeeAllStaff.Name = "pSeeAllStaff";
            pSeeAllStaff.Size = new Size(1506, 1021);
            pSeeAllStaff.TabIndex = 35;
            // 
            // bSearchStaff
            // 
            bSearchStaff.FlatStyle = FlatStyle.Flat;
            bSearchStaff.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bSearchStaff.Location = new Point(894, 267);
            bSearchStaff.Name = "bSearchStaff";
            bSearchStaff.Size = new Size(110, 29);
            bSearchStaff.TabIndex = 35;
            bSearchStaff.Text = "Search";
            bSearchStaff.UseVisualStyleBackColor = true;
            bSearchStaff.Click += bSearchStaff_Click;
            // 
            // tSearchStaff
            // 
            tSearchStaff.Location = new Point(659, 269);
            tSearchStaff.Name = "tSearchStaff";
            tSearchStaff.Size = new Size(212, 27);
            tSearchStaff.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(469, 269);
            label9.Name = "label9";
            label9.Size = new Size(188, 29);
            label9.TabIndex = 33;
            label9.Text = "Enter staff TC:";
            // 
            // dSeeAllStaff
            // 
            dSeeAllStaff.AllowUserToAddRows = false;
            dSeeAllStaff.AllowUserToDeleteRows = false;
            dSeeAllStaff.AllowUserToResizeColumns = false;
            dSeeAllStaff.AllowUserToResizeRows = false;
            dSeeAllStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dSeeAllStaff.BackgroundColor = Color.White;
            dSeeAllStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dSeeAllStaff.Location = new Point(86, 345);
            dSeeAllStaff.Name = "dSeeAllStaff";
            dSeeAllStaff.ReadOnly = true;
            dSeeAllStaff.RowHeadersVisible = false;
            dSeeAllStaff.RowHeadersWidth = 51;
            dSeeAllStaff.Size = new Size(1371, 502);
            dSeeAllStaff.TabIndex = 32;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Century", 19.8000011F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label31.Location = new Point(659, 202);
            label31.Name = "label31";
            label31.Size = new Size(212, 40);
            label31.TabIndex = 31;
            label31.Text = "See All Staff";
            // 
            // pDeleteStaff
            // 
            pDeleteStaff.Controls.Add(cDelSelStaff);
            pDeleteStaff.Controls.Add(label33);
            pDeleteStaff.Controls.Add(btnDeleteStaff);
            pDeleteStaff.Controls.Add(label32);
            pDeleteStaff.Location = new Point(198, 3);
            pDeleteStaff.Name = "pDeleteStaff";
            pDeleteStaff.Size = new Size(1512, 1017);
            pDeleteStaff.TabIndex = 34;
            // 
            // cDelSelStaff
            // 
            cDelSelStaff.DropDownStyle = ComboBoxStyle.DropDownList;
            cDelSelStaff.FormattingEnabled = true;
            cDelSelStaff.Location = new Point(753, 323);
            cDelSelStaff.Name = "cDelSelStaff";
            cDelSelStaff.Size = new Size(232, 28);
            cDelSelStaff.TabIndex = 34;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label33.Location = new Point(340, 323);
            label33.Name = "label33";
            label33.Size = new Size(358, 23);
            label33.TabIndex = 33;
            label33.Text = "Select staff which you want to delete ";
            // 
            // btnDeleteStaff
            // 
            btnDeleteStaff.BackColor = Color.FromArgb(76, 175, 80);
            btnDeleteStaff.FlatAppearance.BorderSize = 0;
            btnDeleteStaff.FlatStyle = FlatStyle.Flat;
            btnDeleteStaff.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDeleteStaff.ForeColor = Color.Red;
            btnDeleteStaff.Location = new Point(662, 515);
            btnDeleteStaff.Name = "btnDeleteStaff";
            btnDeleteStaff.Size = new Size(208, 49);
            btnDeleteStaff.TabIndex = 32;
            btnDeleteStaff.Text = "Delete Staff";
            btnDeleteStaff.UseVisualStyleBackColor = false;
            btnDeleteStaff.Click += btnDeleteStaff_Click;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Century", 19.8000011F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label32.Location = new Point(658, 199);
            label32.Name = "label32";
            label32.Size = new Size(202, 40);
            label32.TabIndex = 31;
            label32.Text = "Delete Staff";
            // 
            // pUpdateStaff
            // 
            pUpdateStaff.Controls.Add(tUpdStaffEmail);
            pUpdateStaff.Controls.Add(label7);
            pUpdateStaff.Controls.Add(cUpdStaffBranchId);
            pUpdateStaff.Controls.Add(label8);
            pUpdateStaff.Controls.Add(tUpdStaffPassword);
            pUpdateStaff.Controls.Add(label10);
            pUpdateStaff.Controls.Add(bUStaff);
            pUpdateStaff.Controls.Add(cUpdStaffPos);
            pUpdateStaff.Controls.Add(tUpdStaffAddress);
            pUpdateStaff.Controls.Add(tUpdStaffPhoneNo);
            pUpdateStaff.Controls.Add(tUpdStaffLName);
            pUpdateStaff.Controls.Add(tUpdStaffFirstName);
            pUpdateStaff.Controls.Add(label26);
            pUpdateStaff.Controls.Add(label27);
            pUpdateStaff.Controls.Add(label28);
            pUpdateStaff.Controls.Add(label29);
            pUpdateStaff.Controls.Add(label30);
            pUpdateStaff.Controls.Add(cUpdateStaffSel);
            pUpdateStaff.Controls.Add(label25);
            pUpdateStaff.Controls.Add(label23);
            pUpdateStaff.Location = new Point(193, 0);
            pUpdateStaff.Name = "pUpdateStaff";
            pUpdateStaff.Size = new Size(1517, 1019);
            pUpdateStaff.TabIndex = 33;
            // 
            // tUpdStaffEmail
            // 
            tUpdStaffEmail.Location = new Point(668, 750);
            tUpdStaffEmail.Name = "tUpdStaffEmail";
            tUpdStaffEmail.Size = new Size(200, 27);
            tUpdStaffEmail.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(491, 752);
            label7.Name = "label7";
            label7.Size = new Size(117, 23);
            label7.TabIndex = 47;
            label7.Text = "Staff Email";
            // 
            // cUpdStaffBranchId
            // 
            cUpdStaffBranchId.DropDownStyle = ComboBoxStyle.DropDownList;
            cUpdStaffBranchId.FormattingEnabled = true;
            cUpdStaffBranchId.Location = new Point(668, 803);
            cUpdStaffBranchId.Name = "cUpdStaffBranchId";
            cUpdStaffBranchId.Size = new Size(200, 28);
            cUpdStaffBranchId.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(501, 808);
            label8.Name = "label8";
            label8.Size = new Size(107, 23);
            label8.TabIndex = 45;
            label8.Text = "Branch ID";
            // 
            // tUpdStaffPassword
            // 
            tUpdStaffPassword.Location = new Point(668, 693);
            tUpdStaffPassword.Name = "tUpdStaffPassword";
            tUpdStaffPassword.Size = new Size(200, 27);
            tUpdStaffPassword.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.Location = new Point(458, 695);
            label10.Name = "label10";
            label10.Size = new Size(150, 23);
            label10.TabIndex = 41;
            label10.Text = "Staff Password";
            // 
            // bUStaff
            // 
            bUStaff.BackColor = Color.FromArgb(76, 175, 80);
            bUStaff.FlatAppearance.BorderSize = 0;
            bUStaff.FlatStyle = FlatStyle.Flat;
            bUStaff.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bUStaff.ForeColor = Color.White;
            bUStaff.Location = new Point(652, 886);
            bUStaff.Name = "bUStaff";
            bUStaff.Size = new Size(208, 49);
            bUStaff.TabIndex = 30;
            bUStaff.Text = "UPDATE STAFF";
            bUStaff.UseVisualStyleBackColor = false;
            bUStaff.Click += bUStaff_Click;
            // 
            // cUpdStaffPos
            // 
            cUpdStaffPos.DropDownStyle = ComboBoxStyle.DropDownList;
            cUpdStaffPos.FormattingEnabled = true;
            cUpdStaffPos.Items.AddRange(new object[] { "Pbo" });
            cUpdStaffPos.Location = new Point(668, 532);
            cUpdStaffPos.Name = "cUpdStaffPos";
            cUpdStaffPos.Size = new Size(200, 28);
            cUpdStaffPos.TabIndex = 29;
            // 
            // tUpdStaffAddress
            // 
            tUpdStaffAddress.Location = new Point(668, 634);
            tUpdStaffAddress.Name = "tUpdStaffAddress";
            tUpdStaffAddress.Size = new Size(200, 27);
            tUpdStaffAddress.TabIndex = 28;
            // 
            // tUpdStaffPhoneNo
            // 
            tUpdStaffPhoneNo.Location = new Point(668, 584);
            tUpdStaffPhoneNo.Name = "tUpdStaffPhoneNo";
            tUpdStaffPhoneNo.Size = new Size(200, 27);
            tUpdStaffPhoneNo.TabIndex = 27;
            // 
            // tUpdStaffLName
            // 
            tUpdStaffLName.Location = new Point(668, 478);
            tUpdStaffLName.Name = "tUpdStaffLName";
            tUpdStaffLName.Size = new Size(200, 27);
            tUpdStaffLName.TabIndex = 26;
            // 
            // tUpdStaffFirstName
            // 
            tUpdStaffFirstName.Location = new Point(668, 427);
            tUpdStaffFirstName.Name = "tUpdStaffFirstName";
            tUpdStaffFirstName.Size = new Size(200, 27);
            tUpdStaffFirstName.TabIndex = 25;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label26.Location = new Point(473, 636);
            label26.Name = "label26";
            label26.Size = new Size(135, 23);
            label26.TabIndex = 24;
            label26.Text = "Staff Address";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label27.Location = new Point(457, 588);
            label27.Name = "label27";
            label27.Size = new Size(151, 23);
            label27.TabIndex = 23;
            label27.Text = "Staff Phone No";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label28.Location = new Point(472, 537);
            label28.Name = "label28";
            label28.Size = new Size(136, 23);
            label28.TabIndex = 22;
            label28.Text = "Staff Position";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label29.Location = new Point(444, 482);
            label29.Name = "label29";
            label29.Size = new Size(164, 23);
            label29.TabIndex = 21;
            label29.Text = "Staff Last Name";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label30.Location = new Point(440, 427);
            label30.Name = "label30";
            label30.Size = new Size(168, 23);
            label30.TabIndex = 20;
            label30.Text = "Staff First Name";
            // 
            // cUpdateStaffSel
            // 
            cUpdateStaffSel.DropDownStyle = ComboBoxStyle.DropDownList;
            cUpdateStaffSel.FormattingEnabled = true;
            cUpdateStaffSel.Location = new Point(667, 330);
            cUpdateStaffSel.Name = "cUpdateStaffSel";
            cUpdateStaffSel.Size = new Size(201, 28);
            cUpdateStaffSel.TabIndex = 5;
            cUpdateStaffSel.SelectedValueChanged += cUpdateStaffSel_SelectedValueChanged;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label25.Location = new Point(489, 335);
            label25.Name = "label25";
            label25.Size = new Size(118, 23);
            label25.TabIndex = 4;
            label25.Text = "Select Staff";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Century", 19.8000011F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label23.Location = new Point(652, 220);
            label23.Name = "label23";
            label23.Size = new Size(218, 40);
            label23.TabIndex = 1;
            label23.Text = "Update Staff";
            // 
            // pCreateStaff
            // 
            pCreateStaff.Controls.Add(tCreateStaffEmail);
            pCreateStaff.Controls.Add(label6);
            pCreateStaff.Controls.Add(cCreateStaffBranchId);
            pCreateStaff.Controls.Add(label5);
            pCreateStaff.Controls.Add(tCreateStaffTc);
            pCreateStaff.Controls.Add(label4);
            pCreateStaff.Controls.Add(tCreateStaffPassword);
            pCreateStaff.Controls.Add(label3);
            pCreateStaff.Controls.Add(btnCreateStaff);
            pCreateStaff.Controls.Add(cCreateStaffPos);
            pCreateStaff.Controls.Add(tCreateStaffAddress);
            pCreateStaff.Controls.Add(tCreateStaffPhoneNo);
            pCreateStaff.Controls.Add(tCreateStaffLName);
            pCreateStaff.Controls.Add(tCreateStaffFName);
            pCreateStaff.Controls.Add(label22);
            pCreateStaff.Controls.Add(label21);
            pCreateStaff.Controls.Add(label20);
            pCreateStaff.Controls.Add(label19);
            pCreateStaff.Controls.Add(label18);
            pCreateStaff.Controls.Add(label17);
            pCreateStaff.Location = new Point(202, 4);
            pCreateStaff.Name = "pCreateStaff";
            pCreateStaff.Size = new Size(1508, 1023);
            pCreateStaff.TabIndex = 3;
            // 
            // tCreateStaffEmail
            // 
            tCreateStaffEmail.Location = new Point(658, 679);
            tCreateStaffEmail.Name = "tCreateStaffEmail";
            tCreateStaffEmail.Size = new Size(200, 27);
            tCreateStaffEmail.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(481, 681);
            label6.Name = "label6";
            label6.Size = new Size(117, 23);
            label6.TabIndex = 26;
            label6.Text = "Staff Email";
            // 
            // cCreateStaffBranchId
            // 
            cCreateStaffBranchId.DropDownStyle = ComboBoxStyle.DropDownList;
            cCreateStaffBranchId.FormattingEnabled = true;
            cCreateStaffBranchId.Location = new Point(658, 732);
            cCreateStaffBranchId.Name = "cCreateStaffBranchId";
            cCreateStaffBranchId.Size = new Size(200, 28);
            cCreateStaffBranchId.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(491, 737);
            label5.Name = "label5";
            label5.Size = new Size(107, 23);
            label5.TabIndex = 24;
            label5.Text = "Branch ID";
            // 
            // tCreateStaffTc
            // 
            tCreateStaffTc.Location = new Point(658, 315);
            tCreateStaffTc.Name = "tCreateStaffTc";
            tCreateStaffTc.Size = new Size(200, 27);
            tCreateStaffTc.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(509, 315);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 22;
            label4.Text = "Staff TC";
            // 
            // tCreateStaffPassword
            // 
            tCreateStaffPassword.Location = new Point(658, 622);
            tCreateStaffPassword.Name = "tCreateStaffPassword";
            tCreateStaffPassword.Size = new Size(200, 27);
            tCreateStaffPassword.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(448, 624);
            label3.Name = "label3";
            label3.Size = new Size(150, 23);
            label3.TabIndex = 20;
            label3.Text = "Staff Password";
            // 
            // btnCreateStaff
            // 
            btnCreateStaff.BackColor = Color.FromArgb(76, 175, 80);
            btnCreateStaff.FlatAppearance.BorderSize = 0;
            btnCreateStaff.FlatStyle = FlatStyle.Flat;
            btnCreateStaff.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCreateStaff.ForeColor = Color.White;
            btnCreateStaff.Location = new Point(618, 827);
            btnCreateStaff.Name = "btnCreateStaff";
            btnCreateStaff.Size = new Size(248, 49);
            btnCreateStaff.TabIndex = 19;
            btnCreateStaff.Text = "CREATE BRANCH";
            btnCreateStaff.UseVisualStyleBackColor = false;
            btnCreateStaff.Click += btnCreateStaff_Click;
            // 
            // cCreateStaffPos
            // 
            cCreateStaffPos.DropDownStyle = ComboBoxStyle.DropDownList;
            cCreateStaffPos.FormattingEnabled = true;
            cCreateStaffPos.Items.AddRange(new object[] { "Pbo" });
            cCreateStaffPos.Location = new Point(658, 465);
            cCreateStaffPos.Name = "cCreateStaffPos";
            cCreateStaffPos.Size = new Size(200, 28);
            cCreateStaffPos.TabIndex = 10;
            // 
            // tCreateStaffAddress
            // 
            tCreateStaffAddress.Location = new Point(658, 567);
            tCreateStaffAddress.Name = "tCreateStaffAddress";
            tCreateStaffAddress.Size = new Size(200, 27);
            tCreateStaffAddress.TabIndex = 9;
            // 
            // tCreateStaffPhoneNo
            // 
            tCreateStaffPhoneNo.Location = new Point(658, 517);
            tCreateStaffPhoneNo.Name = "tCreateStaffPhoneNo";
            tCreateStaffPhoneNo.Size = new Size(200, 27);
            tCreateStaffPhoneNo.TabIndex = 8;
            // 
            // tCreateStaffLName
            // 
            tCreateStaffLName.Location = new Point(658, 411);
            tCreateStaffLName.Name = "tCreateStaffLName";
            tCreateStaffLName.Size = new Size(200, 27);
            tCreateStaffLName.TabIndex = 7;
            // 
            // tCreateStaffFName
            // 
            tCreateStaffFName.Location = new Point(658, 360);
            tCreateStaffFName.Name = "tCreateStaffFName";
            tCreateStaffFName.Size = new Size(200, 27);
            tCreateStaffFName.TabIndex = 6;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label22.Location = new Point(463, 569);
            label22.Name = "label22";
            label22.Size = new Size(135, 23);
            label22.TabIndex = 5;
            label22.Text = "Staff Address";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label21.Location = new Point(447, 521);
            label21.Name = "label21";
            label21.Size = new Size(151, 23);
            label21.TabIndex = 4;
            label21.Text = "Staff Phone No";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label20.Location = new Point(462, 470);
            label20.Name = "label20";
            label20.Size = new Size(136, 23);
            label20.TabIndex = 3;
            label20.Text = "Staff Position";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label19.Location = new Point(434, 415);
            label19.Name = "label19";
            label19.Size = new Size(164, 23);
            label19.TabIndex = 2;
            label19.Text = "Staff Last Name";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label18.Location = new Point(430, 360);
            label18.Name = "label18";
            label18.Size = new Size(168, 23);
            label18.TabIndex = 1;
            label18.Text = "Staff First Name";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century", 19.8000011F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label17.Location = new Point(652, 220);
            label17.Name = "label17";
            label17.Size = new Size(207, 40);
            label17.TabIndex = 0;
            label17.Text = "Create Staff";
            // 
            // pStaffBar
            // 
            pStaffBar.BackColor = Color.FromArgb(224, 224, 224);
            pStaffBar.Controls.Add(bSeeStaff);
            pStaffBar.Controls.Add(bDeleteStaff);
            pStaffBar.Controls.Add(bUpdateStaff);
            pStaffBar.Controls.Add(bCreateStaff);
            pStaffBar.Location = new Point(0, 0);
            pStaffBar.Name = "pStaffBar";
            pStaffBar.Size = new Size(196, 1030);
            pStaffBar.TabIndex = 1;
            // 
            // bSeeStaff
            // 
            bSeeStaff.FlatAppearance.BorderSize = 0;
            bSeeStaff.FlatStyle = FlatStyle.Flat;
            bSeeStaff.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bSeeStaff.Location = new Point(3, 554);
            bSeeStaff.Name = "bSeeStaff";
            bSeeStaff.Size = new Size(184, 50);
            bSeeStaff.TabIndex = 5;
            bSeeStaff.Text = "See Staff";
            bSeeStaff.UseVisualStyleBackColor = true;
            bSeeStaff.Click += bSeeStaff_Click;
            // 
            // bDeleteStaff
            // 
            bDeleteStaff.FlatAppearance.BorderSize = 0;
            bDeleteStaff.FlatStyle = FlatStyle.Flat;
            bDeleteStaff.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bDeleteStaff.Location = new Point(3, 498);
            bDeleteStaff.Name = "bDeleteStaff";
            bDeleteStaff.Size = new Size(184, 50);
            bDeleteStaff.TabIndex = 4;
            bDeleteStaff.Text = "Delete Staff";
            bDeleteStaff.UseVisualStyleBackColor = true;
            bDeleteStaff.Click += bDeleteStaff_Click;
            // 
            // bUpdateStaff
            // 
            bUpdateStaff.FlatAppearance.BorderSize = 0;
            bUpdateStaff.FlatStyle = FlatStyle.Flat;
            bUpdateStaff.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bUpdateStaff.Location = new Point(3, 442);
            bUpdateStaff.Name = "bUpdateStaff";
            bUpdateStaff.Size = new Size(184, 50);
            bUpdateStaff.TabIndex = 3;
            bUpdateStaff.Text = "Update Staff";
            bUpdateStaff.UseVisualStyleBackColor = true;
            bUpdateStaff.Click += bUpdateStaff_Click;
            // 
            // bCreateStaff
            // 
            bCreateStaff.FlatAppearance.BorderSize = 0;
            bCreateStaff.FlatStyle = FlatStyle.Flat;
            bCreateStaff.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bCreateStaff.Location = new Point(3, 386);
            bCreateStaff.Name = "bCreateStaff";
            bCreateStaff.Size = new Size(184, 50);
            bCreateStaff.TabIndex = 2;
            bCreateStaff.Text = "Create Staff";
            bCreateStaff.UseVisualStyleBackColor = true;
            bCreateStaff.Click += bCreateStaff_Click;
            // 
            // pLog
            // 
            pLog.Controls.Add(bSearchLog);
            pLog.Controls.Add(tSearchLogTc);
            pLog.Controls.Add(label11);
            pLog.Controls.Add(label51);
            pLog.Controls.Add(dLog);
            pLog.Location = new Point(193, 0);
            pLog.Name = "pLog";
            pLog.Size = new Size(1701, 1024);
            pLog.TabIndex = 43;
            // 
            // bSearchLog
            // 
            bSearchLog.FlatStyle = FlatStyle.Flat;
            bSearchLog.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bSearchLog.Location = new Point(953, 219);
            bSearchLog.Name = "bSearchLog";
            bSearchLog.Size = new Size(94, 29);
            bSearchLog.TabIndex = 43;
            bSearchLog.Text = "Search";
            bSearchLog.UseVisualStyleBackColor = true;
            bSearchLog.Click += bSearchLog_Click;
            // 
            // tSearchLogTc
            // 
            tSearchLogTc.Location = new Point(785, 221);
            tSearchLogTc.Name = "tSearchLogTc";
            tSearchLogTc.Size = new Size(144, 27);
            tSearchLogTc.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.Location = new Point(645, 221);
            label11.Name = "label11";
            label11.Size = new Size(134, 23);
            label11.TabIndex = 41;
            label11.Text = "Enter TC No:";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("Century", 19.8000011F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label51.Location = new Point(814, 163);
            label51.Name = "label51";
            label51.Size = new Size(92, 40);
            label51.TabIndex = 39;
            label51.Text = "LOG";
            // 
            // dLog
            // 
            dLog.AllowUserToAddRows = false;
            dLog.AllowUserToDeleteRows = false;
            dLog.AllowUserToResizeColumns = false;
            dLog.AllowUserToResizeRows = false;
            dLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dLog.BackgroundColor = Color.White;
            dLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dLog.Location = new Point(141, 299);
            dLog.Name = "dLog";
            dLog.ReadOnly = true;
            dLog.RowHeadersVisible = false;
            dLog.RowHeadersWidth = 51;
            dLog.Size = new Size(1438, 610);
            dLog.TabIndex = 40;
            // 
            // Manager_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pStaff);
            Controls.Add(pLog);
            Controls.Add(pSolBar);
            Name = "Manager_Form";
            Text = "Manager_Form";
            Load += Manager_Form_Load;
            pSolBar.ResumeLayout(false);
            pSolBar.PerformLayout();
            pStaff.ResumeLayout(false);
            pSeeAllStaff.ResumeLayout(false);
            pSeeAllStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dSeeAllStaff).EndInit();
            pDeleteStaff.ResumeLayout(false);
            pDeleteStaff.PerformLayout();
            pUpdateStaff.ResumeLayout(false);
            pUpdateStaff.PerformLayout();
            pCreateStaff.ResumeLayout(false);
            pCreateStaff.PerformLayout();
            pStaffBar.ResumeLayout(false);
            pLog.ResumeLayout(false);
            pLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSolBar;
        private Button bStaff;
        private Label label2;
        private Label label1;
        private Button bLog;
        private Panel pStaff;
        private Panel pStaffBar;
        private Button bCreateStaff;
        private Button bSeeStaff;
        private Button bDeleteStaff;
        private Button bUpdateStaff;
        private Panel pCreateStaff;
        private Button btnCreateStaff;
        private ComboBox cCreateStaffPos;
        private TextBox tCreateStaffAddress;
        private TextBox tCreateStaffPhoneNo;
        private TextBox tCreateStaffLName;
        private TextBox tCreateStaffFName;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Panel pDeleteStaff;
        private ComboBox cDelSelStaff;
        private Label label33;
        private Button btnDeleteStaff;
        private Label label32;
        private Panel pSeeAllStaff;
        private DataGridView dSeeAllStaff;
        private Label label31;
        private Panel pUpdateStaff;
        private Button bUStaff;
        private ComboBox cUpdStaffPos;
        private TextBox tUpdStaffAddress;
        private TextBox tUpdStaffPhoneNo;
        private TextBox tUpdStaffLName;
        private TextBox tUpdStaffFirstName;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private ComboBox cUpdateStaffSel;
        private Label label25;
        private Label label23;
        private Panel pLog;
        private Label label51;
        private DataGridView dLog;
        private Button bLogOut;
        private TextBox tCreateStaffTc;
        private Label label4;
        private TextBox tCreateStaffPassword;
        private Label label3;
        private ComboBox cCreateStaffBranchId;
        private Label label5;
        private TextBox tCreateStaffEmail;
        private Label label6;
        private TextBox tUpdStaffEmail;
        private Label label7;
        private ComboBox cUpdStaffBranchId;
        private Label label8;
        private TextBox tUpdStaffPassword;
        private Label label10;
        private Button bSearchStaff;
        private TextBox tSearchStaff;
        private Label label9;
        private Label label11;
        private Button bSearchLog;
        private TextBox tSearchLogTc;
    }
}