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
    public partial class Pbo_form : Form
    {
        private readonly string _connectionString;
        public Pbo_form(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            this.FormClosed += Pbo_form_FormClosed;
        }

        private void Pbo_form_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Pbo_form_Load(object sender, EventArgs e)
        {
            //Uygulamayı tam ekran başlatır
            this.WindowState = FormWindowState.Maximized;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.CenterScreen;

            pCustomer.Hide();
        }

        private void bCreateCustomer_Click(object sender, EventArgs e)
        {
            pCreateCustomer.Show();
        }

        private void bCustomer_Click(object sender, EventArgs e)
        {
            pCustomer.Show();

            pCreateCustomer.Hide();
            pSeeAllCustomer.Hide();
            pUpdateCustomer.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pUpdateCustomer.Show();

            pCreateCustomer.Hide();
            pSeeAllCustomer.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pSeeAllCustomer.Show();

            pCreateCustomer.Hide();
            pUpdateCustomer.Hide();

        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            CreateAccount_Form form1 = new CreateAccount_Form(_connectionString);
            form1.Show();
            this.Hide();
        }
    }
}
