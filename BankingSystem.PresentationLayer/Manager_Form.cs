using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankaprojesiform
{
    public partial class Manager_Form : Form
    {
        private readonly string _connectionString;
        public Manager_Form(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            this.FormClosed += Manager_Form_FormClosed;
        }

        private void Manager_Form_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Manager_Form_Load(object sender, EventArgs e)
        {
            //Uygulamayı tam ekran başlatır
            this.WindowState = FormWindowState.Maximized;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.CenterScreen;

            pStaff.Hide();
            pLog.Hide();
        }

        private void bCreateStaff_Click(object sender, EventArgs e)
        {
            pCreateStaff.Show();

            pDeleteStaff.Hide();
            pUpdateStaff.Hide();
            pSeeAllStaff.Hide();
        }

        private void bUpdateStaff_Click(object sender, EventArgs e)
        {
            pUpdateStaff.Show();

            pCreateStaff.Hide();
            pSeeAllStaff.Hide();
            pDeleteStaff.Hide();
        }

        private void bDeleteStaff_Click(object sender, EventArgs e)
        {
            pDeleteStaff.Show();

            pCreateStaff.Hide();
            pSeeAllStaff.Hide();
            pUpdateStaff.Hide();
        }

        private void bSeeStaff_Click(object sender, EventArgs e)
        {
            pSeeAllStaff.Show();

            pCreateStaff.Hide();
            pDeleteStaff.Hide();
            pUpdateStaff.Hide();
        }

        private void bStaff_Click(object sender, EventArgs e)
        {
            pStaff.Show();

            pCreateStaff.Hide();
            pUpdateStaff.Hide();
            pDeleteStaff.Hide();
            pSeeAllStaff.Hide();

            pLog.Hide();
        }

        private void bLog_Click(object sender, EventArgs e)
        {
            pLog.Show();
            pStaff.Hide();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            CreateAccount_Form form1 = new CreateAccount_Form(_connectionString);
            form1.Show();
            this.Hide();
        }
    }
}
