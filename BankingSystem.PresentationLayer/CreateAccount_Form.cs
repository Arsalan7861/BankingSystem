using BankingSystem.BusinessLayer.Abstract;
using BankingSystem.BusinessLayer.Concrete;
using BankingSystem.DataAccessLayer.Concrete;
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
    public partial class CreateAccount_Form : Form
    {
        private readonly ICustomerService _customerService;
        private readonly string _connectionString;

        public CreateAccount_Form(string connectionString)
        {
            _connectionString = connectionString;
            _customerService = new CustomerManager(new CustomerDal(connectionString));
            InitializeComponent();
            this.FormClosed += CreateAccount_Form_FormClosed;
        }

        private void CreateAccount_Form_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Uygulamayı tam ekran başlatır
            this.WindowState = FormWindowState.Maximized;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.CenterScreen;

            pLogIn.Show();
            pRegister.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var tc = txtLoginTc.Text;// sending tc to anaekran

            if (txtLoginTc.Text == "" || txtLoginPass.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            var customers = _customerService.TGetAll();

            foreach (var customer in customers)
            {
                if (customer.Customertc == txtLoginTc.Text && customer.Customerpassword == txtLoginPass.Text)
                {
                    MessageBox.Show("Login Successful");
                    AnaEkran anaEkran = new AnaEkran(_connectionString, tc);
                    this.Hide();
                    anaEkran.Show();
                    break;                    
                }
            }
            if (txtLoginTc.Text.Equals("admin") && txtLoginPass.Text.Equals("123"))
            {
                Admin_Form admin = new Admin_Form(_connectionString);
                this.Hide();
                admin.Show();


            }
            else if (txtLoginTc.Text.Equals("manager") && txtLoginPass.Text.Equals("123"))
            {
                Manager_Form manager = new Manager_Form(_connectionString);
                this.Hide();
                manager.Show();

            }
            else if (txtLoginTc.Text.Equals("pbo") && txtLoginPass.Text.Equals("123"))
            {
                Pbo_form pbo = new Pbo_form(_connectionString);
                this.Hide();
                pbo.Show();

            }
            else
            {
                MessageBox.Show("Invalid TC or Password!");
                txtLoginTc.Text = "";
                txtLoginPass.Text = "";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            pLogIn.Hide();
            pRegister.Show();
        }

        private void bCreateAccount_Click(object sender, EventArgs e)
        {
            if (tCreateTc.Text == "" || tCreateName.Text == "" || tCreateSurname.Text == "" || tCreatePassword.Text == "" || tCreatePhoneNo.Text == "" || tCreateAddress.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            _customerService.TcreateCustomer(tCreateTc.Text, tCreateName.Text, tCreateSurname.Text, tCreatePassword.Text, tCreatePhoneNo.Text, tCreateAddress.Text, "3452");
            MessageBox.Show("Account Created Successfully");

            pRegister.Hide();
            pLogIn.Show();
        }

        private void bReturnLogIn_Click(object sender, EventArgs e)
        {
            pRegister.Hide();
            pLogIn.Show();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                txtLoginPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtLoginPass.UseSystemPasswordChar = true;
            }
        }
    }
}
