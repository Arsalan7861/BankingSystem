namespace BankingSystem.PresentationLayer
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnDeposit = new Button();
            txtCustomerTc = new TextBox();
            txtAmount = new TextBox();
            lblCustomerTc = new Label();
            lblAmount = new Label();
            btnWithdraw = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(286, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(502, 326);
            dataGridView1.TabIndex = 0;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(111, 182);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(94, 29);
            btnDeposit.TabIndex = 1;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // txtCustomerTc
            // 
            txtCustomerTc.Location = new Point(111, 75);
            txtCustomerTc.Name = "txtCustomerTc";
            txtCustomerTc.Size = new Size(125, 27);
            txtCustomerTc.TabIndex = 2;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(111, 126);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 3;
            // 
            // lblCustomerTc
            // 
            lblCustomerTc.AutoSize = true;
            lblCustomerTc.Location = new Point(22, 84);
            lblCustomerTc.Name = "lblCustomerTc";
            lblCustomerTc.Size = new Size(87, 20);
            lblCustomerTc.TabIndex = 4;
            lblCustomerTc.Text = "customerTc:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(44, 133);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(65, 20);
            lblAmount.TabIndex = 5;
            lblAmount.Text = "Amount:";
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(111, 232);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(94, 29);
            btnWithdraw.TabIndex = 6;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnWithdraw);
            Controls.Add(lblAmount);
            Controls.Add(lblCustomerTc);
            Controls.Add(txtAmount);
            Controls.Add(txtCustomerTc);
            Controls.Add(btnDeposit);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDeposit;
        private TextBox txtCustomerTc;
        private TextBox txtAmount;
        private Label lblCustomerTc;
        private Label lblAmount;
        private Button btnWithdraw;
    }
}
