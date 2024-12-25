using BankingSystem.BusinessLayer.Abstract;
using BankingSystem.BusinessLayer.Concrete;
using BankingSystem.DataAccessLayer.Concrete;
using BankingSystem.EntityLayer.Models;
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
        private readonly IStaffService _staffService;

        public CreateAccount_Form(string connectionString)
        {
            _connectionString = connectionString;
            _customerService = new CustomerManager(new CustomerDal(connectionString));
            InitializeComponent();
            this.FormClosed += CreateAccount_Form_FormClosed;
            _staffService = new StaffManager(new StaffDal(connectionString));
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

            // checking if the fields are empty
            if (txtLoginTc.Text == "" || txtLoginPass.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            var counter = 0;
            // checking if the customer is in the database
            var customers = _customerService.TGetAll();
            foreach (var customer in customers)
            {
                if (customer.Customertc == txtLoginTc.Text && customer.Customerpassword == txtLoginPass.Text)
                {
                    counter++;
                    MessageBox.Show("Login Successful");
                    AnaEkran anaEkran = new AnaEkran(_connectionString, tc);
                    this.Hide();
                    anaEkran.Show();
                    break;
                }
            }

            // checking if the user is admin
            if (txtLoginTc.Text == "admin" && txtLoginPass.Text == "123")
            {
                Admin_Form admin = new Admin_Form(_connectionString, tc);
                this.Hide();
                admin.Show();               
                return;
            }

            // checking if the user is admin, manager or pbo
            var staffs = _staffService.TGetAll();
            if (staffs.Any(staffs => staffs.Stafftc == txtLoginTc.Text))
            {
                foreach (var staff in staffs)
                {
                    if (staff.Stafftc == txtLoginTc.Text && staff.Staffpassword == txtLoginPass.Text && staff.Staffposition.ToLower() == "manager")
                    {
                        Manager_Form manager = new Manager_Form(_connectionString, tc);
                        this.Hide();
                        manager.Show();
                        counter++;
                        break;
                    }
                    else if (staff.Stafftc == txtLoginTc.Text && staff.Staffpassword == txtLoginPass.Text && staff.Staffposition.ToLower() == "pbo")
                    {
                        Pbo_form pbo = new Pbo_form(_connectionString, tc);
                        this.Hide();
                        pbo.Show();
                        counter++;
                        break;
                    }
                }
            }            

            if (counter == 0)
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
            _customerService.TCreateCustomer(tCreateTc.Text, tCreateName.Text, tCreateSurname.Text, tCreatePassword.Text, tCreatePhoneNo.Text, tCreateAddress.Text, "24352345");
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
            // changing the password visibility
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
