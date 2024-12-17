namespace bankaprojesiform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pLogIn = new Panel();
            pRegister = new Panel();
            tCreateAddress = new TextBox();
            tCreatePhoneNo = new TextBox();
            tCreateID = new TextBox();
            tCreateSurname = new TextBox();
            tCreateName = new TextBox();
            bCreateAccount = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            bReturnLogIn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pLogIn.SuspendLayout();
            pRegister.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(636, 602);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(673, 364);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century", 30F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(794, 59);
            label1.Name = "label1";
            label1.Size = new Size(371, 60);
            label1.TabIndex = 2;
            label1.Text = "BANKACILIK";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(873, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 26);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(873, 280);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 26);
            textBox2.TabIndex = 4;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(76, 175, 80);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(873, 389);
            button1.Name = "button1";
            button1.Size = new Size(216, 44);
            button1.TabIndex = 5;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(930, 181);
            label2.Name = "label2";
            label2.Size = new Size(110, 18);
            label2.TabIndex = 6;
            label2.Text = "T.C Kimlik No";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(948, 257);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(979, 329);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 8;
            label4.Text = "Create Account";
            label4.Click += label4_Click;
            // 
            // pLogIn
            // 
            pLogIn.Controls.Add(pictureBox1);
            pLogIn.Controls.Add(label1);
            pLogIn.Controls.Add(textBox1);
            pLogIn.Controls.Add(textBox2);
            pLogIn.Controls.Add(button1);
            pLogIn.Controls.Add(label2);
            pLogIn.Controls.Add(label3);
            pLogIn.Controls.Add(label4);
            pLogIn.Dock = DockStyle.Fill;
            pLogIn.Location = new Point(0, 0);
            pLogIn.Name = "pLogIn";
            pLogIn.Size = new Size(1902, 1033);
            pLogIn.TabIndex = 9;
            // 
            // pRegister
            // 
            pRegister.Controls.Add(bReturnLogIn);
            pRegister.Controls.Add(tCreateAddress);
            pRegister.Controls.Add(tCreatePhoneNo);
            pRegister.Controls.Add(tCreateID);
            pRegister.Controls.Add(tCreateSurname);
            pRegister.Controls.Add(tCreateName);
            pRegister.Controls.Add(bCreateAccount);
            pRegister.Controls.Add(label11);
            pRegister.Controls.Add(label10);
            pRegister.Controls.Add(label9);
            pRegister.Controls.Add(label8);
            pRegister.Controls.Add(label7);
            pRegister.Controls.Add(label6);
            pRegister.Controls.Add(label5);
            pRegister.Dock = DockStyle.Fill;
            pRegister.Location = new Point(0, 0);
            pRegister.Name = "pRegister";
            pRegister.Size = new Size(1902, 1033);
            pRegister.TabIndex = 9;
            // 
            // tCreateAddress
            // 
            tCreateAddress.Location = new Point(873, 551);
            tCreateAddress.Name = "tCreateAddress";
            tCreateAddress.Size = new Size(216, 27);
            tCreateAddress.TabIndex = 12;
            // 
            // tCreatePhoneNo
            // 
            tCreatePhoneNo.Location = new Point(873, 472);
            tCreatePhoneNo.Name = "tCreatePhoneNo";
            tCreatePhoneNo.Size = new Size(216, 27);
            tCreatePhoneNo.TabIndex = 11;
            // 
            // tCreateID
            // 
            tCreateID.Location = new Point(873, 402);
            tCreateID.Name = "tCreateID";
            tCreateID.Size = new Size(216, 27);
            tCreateID.TabIndex = 10;
            // 
            // tCreateSurname
            // 
            tCreateSurname.Location = new Point(873, 337);
            tCreateSurname.Name = "tCreateSurname";
            tCreateSurname.Size = new Size(216, 27);
            tCreateSurname.TabIndex = 9;
            // 
            // tCreateName
            // 
            tCreateName.Location = new Point(873, 269);
            tCreateName.Name = "tCreateName";
            tCreateName.Size = new Size(216, 27);
            tCreateName.TabIndex = 8;
            // 
            // bCreateAccount
            // 
            bCreateAccount.Anchor = AnchorStyles.Top;
            bCreateAccount.BackColor = Color.FromArgb(76, 175, 80);
            bCreateAccount.FlatAppearance.BorderSize = 0;
            bCreateAccount.FlatStyle = FlatStyle.Flat;
            bCreateAccount.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bCreateAccount.ForeColor = Color.White;
            bCreateAccount.Location = new Point(873, 742);
            bCreateAccount.Name = "bCreateAccount";
            bCreateAccount.Size = new Size(216, 44);
            bCreateAccount.TabIndex = 7;
            bCreateAccount.Text = "Create Account";
            bCreateAccount.UseVisualStyleBackColor = false;
            bCreateAccount.Click += bCreateAccount_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.Location = new Point(721, 397);
            label11.Name = "label11";
            label11.Size = new Size(81, 29);
            label11.TabIndex = 6;
            label11.Text = "ID No";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.Location = new Point(695, 546);
            label10.Name = "label10";
            label10.Size = new Size(107, 29);
            label10.TabIndex = 5;
            label10.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(615, 467);
            label9.Name = "label9";
            label9.Size = new Size(187, 29);
            label9.TabIndex = 4;
            label9.Text = "Phone Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(683, 332);
            label8.Name = "label8";
            label8.Size = new Size(119, 29);
            label8.TabIndex = 3;
            label8.Text = "Surname";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(720, 267);
            label7.Name = "label7";
            label7.Size = new Size(82, 29);
            label7.TabIndex = 2;
            label7.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 30F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(791, 59);
            label6.Name = "label6";
            label6.Size = new Size(361, 60);
            label6.TabIndex = 1;
            label6.Text = "BANKACILIK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 17F, FontStyle.Underline);
            label5.Location = new Point(824, 147);
            label5.Name = "label5";
            label5.Size = new Size(300, 34);
            label5.TabIndex = 0;
            label5.Text = "CREATE ACCOUNT";
            // 
            // bReturnLogIn
            // 
            bReturnLogIn.BackColor = SystemColors.Menu;
            bReturnLogIn.FlatAppearance.BorderSize = 0;
            bReturnLogIn.FlatStyle = FlatStyle.Flat;
            bReturnLogIn.Location = new Point(3, 3);
            bReturnLogIn.Name = "bReturnLogIn";
            bReturnLogIn.Size = new Size(98, 65);
            bReturnLogIn.TabIndex = 13;
            bReturnLogIn.Text = "<";
            bReturnLogIn.UseVisualStyleBackColor = false;
            bReturnLogIn.Click += bReturnLogIn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pRegister);
            Controls.Add(pLogIn);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Buton1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pLogIn.ResumeLayout(false);
            pLogIn.PerformLayout();
            pRegister.ResumeLayout(false);
            pRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel pLogIn;
        private Panel pRegister;
        private Label label6;
        private Label label5;
        private TextBox tCreateAddress;
        private TextBox tCreatePhoneNo;
        private TextBox tCreateID;
        private TextBox tCreateSurname;
        private TextBox tCreateName;
        private Button bCreateAccount;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button bReturnLogIn;
    }
}