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
            pUpdateStaff = new Panel();
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
            bCreateBranch = new Button();
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
            pSeeAllStaff = new Panel();
            dSeeAllStaf = new DataGridView();
            label31 = new Label();
            pDeleteStaff = new Panel();
            cDelSelStaff = new ComboBox();
            label33 = new Label();
            bDStaff = new Button();
            label32 = new Label();
            pStaffBar = new Panel();
            bSeeStaff = new Button();
            bDeleteStaff = new Button();
            bUpdateStaff = new Button();
            bCreateStaff = new Button();
            pLog = new Panel();
            label51 = new Label();
            dLog = new DataGridView();
            pSolBar.SuspendLayout();
            pStaff.SuspendLayout();
            pUpdateStaff.SuspendLayout();
            pCreateStaff.SuspendLayout();
            pSeeAllStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dSeeAllStaf).BeginInit();
            pDeleteStaff.SuspendLayout();
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
            bLogOut.Location = new Point(3, 969);
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
            pStaff.Controls.Add(pUpdateStaff);
            pStaff.Controls.Add(pCreateStaff);
            pStaff.Controls.Add(pSeeAllStaff);
            pStaff.Controls.Add(pDeleteStaff);
            pStaff.Controls.Add(pStaffBar);
            pStaff.Location = new Point(187, 1);
            pStaff.Name = "pStaff";
            pStaff.Size = new Size(1716, 1030);
            pStaff.TabIndex = 1;
            // 
            // pUpdateStaff
            // 
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
            // bUStaff
            // 
            bUStaff.BackColor = Color.FromArgb(76, 175, 80);
            bUStaff.FlatAppearance.BorderSize = 0;
            bUStaff.FlatStyle = FlatStyle.Flat;
            bUStaff.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bUStaff.ForeColor = Color.White;
            bUStaff.Location = new Point(652, 791);
            bUStaff.Name = "bUStaff";
            bUStaff.Size = new Size(208, 49);
            bUStaff.TabIndex = 30;
            bUStaff.Text = "UPDATE STAFF";
            bUStaff.UseVisualStyleBackColor = false;
            // 
            // cUpdStaffPos
            // 
            cUpdStaffPos.FormattingEnabled = true;
            cUpdStaffPos.Items.AddRange(new object[] { "Manager", "Teller", "Pbo" });
            cUpdStaffPos.Location = new Point(666, 532);
            cUpdStaffPos.Name = "cUpdStaffPos";
            cUpdStaffPos.Size = new Size(200, 28);
            cUpdStaffPos.TabIndex = 29;
            // 
            // tUpdStaffAddress
            // 
            tUpdStaffAddress.Location = new Point(666, 634);
            tUpdStaffAddress.Name = "tUpdStaffAddress";
            tUpdStaffAddress.Size = new Size(200, 27);
            tUpdStaffAddress.TabIndex = 28;
            // 
            // tUpdStaffPhoneNo
            // 
            tUpdStaffPhoneNo.Location = new Point(666, 584);
            tUpdStaffPhoneNo.Name = "tUpdStaffPhoneNo";
            tUpdStaffPhoneNo.Size = new Size(200, 27);
            tUpdStaffPhoneNo.TabIndex = 27;
            // 
            // tUpdStaffLName
            // 
            tUpdStaffLName.Location = new Point(666, 478);
            tUpdStaffLName.Name = "tUpdStaffLName";
            tUpdStaffLName.Size = new Size(200, 27);
            tUpdStaffLName.TabIndex = 26;
            // 
            // tUpdStaffFirstName
            // 
            tUpdStaffFirstName.Location = new Point(666, 427);
            tUpdStaffFirstName.Name = "tUpdStaffFirstName";
            tUpdStaffFirstName.Size = new Size(200, 27);
            tUpdStaffFirstName.TabIndex = 25;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label26.Location = new Point(489, 636);
            label26.Name = "label26";
            label26.Size = new Size(135, 23);
            label26.TabIndex = 24;
            label26.Text = "Staff Address";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label27.Location = new Point(473, 588);
            label27.Name = "label27";
            label27.Size = new Size(151, 23);
            label27.TabIndex = 23;
            label27.Text = "Staff Phone No";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label28.Location = new Point(485, 537);
            label28.Name = "label28";
            label28.Size = new Size(136, 23);
            label28.TabIndex = 22;
            label28.Text = "Staff Position";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label29.Location = new Point(460, 482);
            label29.Name = "label29";
            label29.Size = new Size(164, 23);
            label29.TabIndex = 21;
            label29.Text = "Staff Last Name";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label30.Location = new Point(460, 427);
            label30.Name = "label30";
            label30.Size = new Size(168, 23);
            label30.TabIndex = 20;
            label30.Text = "Staff First Name";
            // 
            // cUpdateStaffSel
            // 
            cUpdateStaffSel.FormattingEnabled = true;
            cUpdateStaffSel.Location = new Point(667, 330);
            cUpdateStaffSel.Name = "cUpdateStaffSel";
            cUpdateStaffSel.Size = new Size(201, 28);
            cUpdateStaffSel.TabIndex = 5;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label25.Location = new Point(495, 326);
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
            pCreateStaff.Controls.Add(bCreateBranch);
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
            // bCreateBranch
            // 
            bCreateBranch.BackColor = Color.FromArgb(76, 175, 80);
            bCreateBranch.FlatAppearance.BorderSize = 0;
            bCreateBranch.FlatStyle = FlatStyle.Flat;
            bCreateBranch.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bCreateBranch.ForeColor = Color.White;
            bCreateBranch.Location = new Point(627, 656);
            bCreateBranch.Name = "bCreateBranch";
            bCreateBranch.Size = new Size(248, 49);
            bCreateBranch.TabIndex = 19;
            bCreateBranch.Text = "CREATE BRANCH";
            bCreateBranch.UseVisualStyleBackColor = false;
            // 
            // cCreateStaffPos
            // 
            cCreateStaffPos.FormattingEnabled = true;
            cCreateStaffPos.Items.AddRange(new object[] { "Manager", "Teller", "Pbo" });
            cCreateStaffPos.Location = new Point(658, 423);
            cCreateStaffPos.Name = "cCreateStaffPos";
            cCreateStaffPos.Size = new Size(200, 28);
            cCreateStaffPos.TabIndex = 10;
            // 
            // tCreateStaffAddress
            // 
            tCreateStaffAddress.Location = new Point(658, 525);
            tCreateStaffAddress.Name = "tCreateStaffAddress";
            tCreateStaffAddress.Size = new Size(200, 27);
            tCreateStaffAddress.TabIndex = 9;
            // 
            // tCreateStaffPhoneNo
            // 
            tCreateStaffPhoneNo.Location = new Point(658, 475);
            tCreateStaffPhoneNo.Name = "tCreateStaffPhoneNo";
            tCreateStaffPhoneNo.Size = new Size(200, 27);
            tCreateStaffPhoneNo.TabIndex = 8;
            // 
            // tCreateStaffLName
            // 
            tCreateStaffLName.Location = new Point(658, 369);
            tCreateStaffLName.Name = "tCreateStaffLName";
            tCreateStaffLName.Size = new Size(200, 27);
            tCreateStaffLName.TabIndex = 7;
            // 
            // tCreateStaffFName
            // 
            tCreateStaffFName.Location = new Point(658, 318);
            tCreateStaffFName.Name = "tCreateStaffFName";
            tCreateStaffFName.Size = new Size(200, 27);
            tCreateStaffFName.TabIndex = 6;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label22.Location = new Point(481, 527);
            label22.Name = "label22";
            label22.Size = new Size(135, 23);
            label22.TabIndex = 5;
            label22.Text = "Staff Address";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label21.Location = new Point(465, 479);
            label21.Name = "label21";
            label21.Size = new Size(151, 23);
            label21.TabIndex = 4;
            label21.Text = "Staff Phone No";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label20.Location = new Point(477, 428);
            label20.Name = "label20";
            label20.Size = new Size(136, 23);
            label20.TabIndex = 3;
            label20.Text = "Staff Position";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label19.Location = new Point(452, 373);
            label19.Name = "label19";
            label19.Size = new Size(164, 23);
            label19.TabIndex = 2;
            label19.Text = "Staff Last Name";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label18.Location = new Point(452, 318);
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
            // pSeeAllStaff
            // 
            pSeeAllStaff.Controls.Add(dSeeAllStaf);
            pSeeAllStaff.Controls.Add(label31);
            pSeeAllStaff.Location = new Point(201, 0);
            pSeeAllStaff.Name = "pSeeAllStaff";
            pSeeAllStaff.Size = new Size(1506, 1021);
            pSeeAllStaff.TabIndex = 35;
            // 
            // dSeeAllStaf
            // 
            dSeeAllStaf.BackgroundColor = Color.White;
            dSeeAllStaf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dSeeAllStaf.Location = new Point(236, 345);
            dSeeAllStaf.Name = "dSeeAllStaf";
            dSeeAllStaf.RowHeadersWidth = 51;
            dSeeAllStaf.Size = new Size(1119, 502);
            dSeeAllStaf.TabIndex = 32;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Century", 19.8000011F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label31.Location = new Point(713, 221);
            label31.Name = "label31";
            label31.Size = new Size(212, 40);
            label31.TabIndex = 31;
            label31.Text = "See All Staff";
            // 
            // pDeleteStaff
            // 
            pDeleteStaff.Controls.Add(cDelSelStaff);
            pDeleteStaff.Controls.Add(label33);
            pDeleteStaff.Controls.Add(bDStaff);
            pDeleteStaff.Controls.Add(label32);
            pDeleteStaff.Location = new Point(198, 3);
            pDeleteStaff.Name = "pDeleteStaff";
            pDeleteStaff.Size = new Size(1512, 1017);
            pDeleteStaff.TabIndex = 34;
            // 
            // cDelSelStaff
            // 
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
            label33.Size = new Size(385, 23);
            label33.TabIndex = 33;
            label33.Text = "Select staff which do you want to delete ";
            // 
            // bDStaff
            // 
            bDStaff.BackColor = Color.FromArgb(76, 175, 80);
            bDStaff.FlatAppearance.BorderSize = 0;
            bDStaff.FlatStyle = FlatStyle.Flat;
            bDStaff.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bDStaff.ForeColor = Color.Red;
            bDStaff.Location = new Point(662, 515);
            bDStaff.Name = "bDStaff";
            bDStaff.Size = new Size(208, 49);
            bDStaff.TabIndex = 32;
            bDStaff.Text = "Delete Staff";
            bDStaff.UseVisualStyleBackColor = false;
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
            pLog.Controls.Add(label51);
            pLog.Controls.Add(dLog);
            pLog.Location = new Point(190, 0);
            pLog.Name = "pLog";
            pLog.Size = new Size(1704, 1024);
            pLog.TabIndex = 43;
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("Century", 19.8000011F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label51.Location = new Point(873, 199);
            label51.Name = "label51";
            label51.Size = new Size(92, 40);
            label51.TabIndex = 39;
            label51.Text = "LOG";
            // 
            // dLog
            // 
            dLog.AllowUserToAddRows = false;
            dLog.AllowUserToDeleteRows = false;
            dLog.BackgroundColor = Color.White;
            dLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dLog.Location = new Point(348, 299);
            dLog.Name = "dLog";
            dLog.ReadOnly = true;
            dLog.RowHeadersWidth = 51;
            dLog.Size = new Size(1115, 610);
            dLog.TabIndex = 40;
            // 
            // Manager_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pLog);
            Controls.Add(pStaff);
            Controls.Add(pSolBar);
            Name = "Manager_Form";
            Text = "Manager_Form";
            Load += Manager_Form_Load;
            pSolBar.ResumeLayout(false);
            pSolBar.PerformLayout();
            pStaff.ResumeLayout(false);
            pUpdateStaff.ResumeLayout(false);
            pUpdateStaff.PerformLayout();
            pCreateStaff.ResumeLayout(false);
            pCreateStaff.PerformLayout();
            pSeeAllStaff.ResumeLayout(false);
            pSeeAllStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dSeeAllStaf).EndInit();
            pDeleteStaff.ResumeLayout(false);
            pDeleteStaff.PerformLayout();
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
        private Button bCreateBranch;
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
        private Button bDStaff;
        private Label label32;
        private Panel pSeeAllStaff;
        private DataGridView dSeeAllStaf;
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
    }
}