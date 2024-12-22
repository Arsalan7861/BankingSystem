using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace bankaprojesiform
{
    public partial class Admin_Form : Form
    {
        private readonly string _connectionString;
        public Admin_Form(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            this.FormClosed += Admin_Form_FormClosed;
        }

        private void Admin_Form_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            pBranch.Hide();
            pStaff.Hide();
            pClient.Hide();
            pLog.Hide();
            pTransactions.Hide();

            //Uygulamayı tam ekran başlatır
            this.WindowState = FormWindowState.Maximized;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void bGenBranch_Click(object sender, EventArgs e)
        {
            pBranch.Show();
            pCreate_Branch.Hide();
            pUpdateBranch.Hide();
            pSeeAllBranches.Hide();
            pDelBranch.Hide();

            pStaff.Hide();
            pLog.Hide();
            pTransactions.Hide();
            pClient.Hide();
        }


        private void bCreateBranch_Click(object sender, EventArgs e)
        {
            pUpdateBranch.Hide();
            pSeeAllBranches.Hide();
            pDelBranch.Hide();
            pTransactions.Hide();

            pCreate_Branch.Show();
        }



        private void bUpdateBranch_Click(object sender, EventArgs e)
        {
            pCreate_Branch.Hide();
            pSeeAllBranches.Hide();
            pDelBranch.Hide();

            pUpdateBranch.Show();
        }

        private void bSeeBranch_Click(object sender, EventArgs e)
        {
            pCreate_Branch.Hide();
            pUpdateBranch.Hide();
            pDelBranch.Hide();

            pSeeAllBranches.Show();
        }

        private void bDelBranch_Click(object sender, EventArgs e)
        {
            pCreateStaff.Hide();
            pUpdateBranch.Hide();
            pSeeAllBranches.Hide();

            pDelBranch.Show();
        }

        private void bGenStaff_Click(object sender, EventArgs e)
        {
            pStaff.Show();

            pBranch.Hide();
            pLog.Hide();
            pTransactions.Hide();
            pClient.Hide();

            pCreateStaff.Hide();
            pUpdateStaff.Hide();
            pSeeAllStaff.Hide();
            pDeleteStaff.Hide();
        }

        private void bCreateStaff_Click(object sender, EventArgs e)
        {
            pCreateStaff.Show();

            pUpdateStaff.Hide();
            pSeeAllStaff.Hide();
            pDeleteStaff.Hide();
        }

        private void bUpdateStaff_Click(object sender, EventArgs e)
        {
            pUpdateStaff.Show();

            pCreateStaff.Hide();
            pSeeAllStaff.Hide();
            pDeleteStaff.Hide();
        }

        private void bSeeAllStaff_Click(object sender, EventArgs e)
        {
            pSeeAllStaff.Show();

            pCreateStaff.Hide();
            pUpdateStaff.Hide();
            pDeleteStaff.Hide();
        }

        private void bDelStaff_Click(object sender, EventArgs e)
        {
            pDeleteStaff.Show();

            pCreateStaff.Hide();
            pUpdateStaff.Hide();
            pSeeAllStaff.Hide();
        }

        private void bGenClient_Click(object sender, EventArgs e)
        {
            pClient.Show();

            pCreateCustomer.Hide();
            pUpdateCustomer.Hide();
            pSeeAllCustomer.Hide();
            pDeleteCustomer.Hide();

            pBranch.Hide();
            pLog.Hide();
            pTransactions.Hide();
            pStaff.Hide();
        }

        private void bCreateClient_Click(object sender, EventArgs e)
        {
            pCreateCustomer.Show();

            pUpdateCustomer.Hide();
            pSeeAllCustomer.Hide();
            pDeleteCustomer.Hide();
        }

        private void bUpdateClient_Click(object sender, EventArgs e)
        {
            pUpdateCustomer.Show();

            pCreateCustomer.Hide();
            pSeeAllCustomer.Hide();
            pDeleteCustomer.Hide();
        }

        private void bSeeAllClient_Click(object sender, EventArgs e)
        {
            pSeeAllCustomer.Show();

            pCreateCustomer.Hide();
            pUpdateCustomer.Hide();
            pDeleteCustomer.Hide();
        }

        private void bDeleteClient_Click(object sender, EventArgs e)
        {
            pDeleteCustomer.Show();

            pSeeAllCustomer.Hide();
            pCreateCustomer.Hide();
            pUpdateCustomer.Hide();

        }

        private void bLog_Click(object sender, EventArgs e)
        {
            pLog.Show();

            pBranch.Hide();
            pStaff.Hide();
            pClient.Hide();
            pTransactions.Hide();
        }

        private void bGenTransaction_Click(object sender, EventArgs e)
        {
            pTransactions.Show();

            pBranch.Hide();
            pStaff.Hide();
            pClient.Hide();
            pLog.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreateAccount_Form form1 = new CreateAccount_Form(_connectionString);
            form1.Show();
            this.Hide();
        }
    }
}
