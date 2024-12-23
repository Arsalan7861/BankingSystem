﻿using BankingSystem.BusinessLayer.Abstract;
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
    public partial class Pbo_form : Form
    {
        private readonly string _connectionString;
        private readonly ICustomerService _customerService;
        private readonly string _pboTc;
        private readonly IStaffService _staffService;
        public Pbo_form(string connectionString, string tc)
        {
            InitializeComponent();
            _connectionString = connectionString;
            this.FormClosed += Pbo_form_FormClosed;
            _customerService = new CustomerManager(new CustomerDal(connectionString));
            _pboTc = tc;
            _staffService = new StaffManager(new StaffDal(connectionString));
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

            var customers = _customerService.TGetAll();
            dCustomer.DataSource = customers;

            var staffs = _staffService.TGetAll();
            foreach (var staff in staffs)
            {
                cmbCreateStaffTc.Items.Add($"TC: {staff.Stafftc}");
                cmbUpdateCusStaffTc.Items.Add($"TC: {staff.Stafftc}");
            }

            foreach (var customer in customers)
            {
                cUpdateCustomerTc.Items.Add($"TC: {customer.Customertc}");
            }
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

        private void bCreateAccount_Click(object sender, EventArgs e)
        {
            if (tCreateFName.Text == "" || tCreateLName.Text == "" || tCreatePassword.Text == "" || tCreatePhoneNo.Text == "" || tCreateAddress.Text == "" || cmbCreateStaffTc.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            var customerTc = tCreateTc.Text;
            var fname = tCreateFName.Text;
            var lname = tCreateLName.Text;
            var password = tCreatePassword.Text;
            var phone = tCreatePhoneNo.Text;
            var address = tCreateAddress.Text;
            var staffTc = cmbCreateStaffTc.Text.Split(':')[1].Trim();

            var customers = _customerService.TGetAll();
            foreach (var customer in customers)
            {
                if (customer.Customertc == customerTc)
                {
                    MessageBox.Show("Customer already exists.");
                    return;
                }
            }

            _customerService.TCreateCustomer(customerTc, fname, lname, password, phone, address, staffTc);
            MessageBox.Show("Customer Created Successfully.");
            tCreateTc.Text = "";
            tCreateFName.Text = "";
            tCreateLName.Text = "";
            tCreatePassword.Text = "";
            tCreatePhoneNo.Text = "";
            tCreateAddress.Text = "";
            cmbCreateStaffTc.Text = "";
        }

        // Show the selected customer's information in the textboxes
        private void cUpdateCustomerTc_SelectedValueChanged(object sender, EventArgs e)
        {
            var customerTc = cUpdateCustomerTc.Text.Split(':')[1].Trim();
            var customers = _customerService.TGetAll();
            var customer = customers.FirstOrDefault(x => x.Customertc == customerTc);

            tUpdateCusFirstName.Text = customer.Customerfname;
            tUpdateCusLastName.Text = customer.Customerlname;
            tUpdateCusPass.Text = customer.Customerpassword;
            tUpdateCusPhoneNo.Text = customer.Customerphone;
            tUpdateCusAddress.Text = customer.Customeraddress;
            cmbUpdateCusStaffTc.Text = $"TC: {customer.Stafftc}";
        }

        private void bUpdCus_Click(object sender, EventArgs e)
        {
            if (tUpdateCusFirstName.Text == "" || tUpdateCusLastName.Text == "" || tUpdateCusPass.Text == "" || tUpdateCusPhoneNo.Text == "" || tUpdateCusAddress.Text == "" || cmbUpdateCusStaffTc.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            var customerTc = cUpdateCustomerTc.SelectedItem.ToString().Split(':')[1].Trim();
            var fname = tUpdateCusFirstName.Text;
            var lname = tUpdateCusLastName.Text;
            var password = tUpdateCusPass.Text;
            var phone = tUpdateCusPhoneNo.Text;
            var address = tUpdateCusAddress.Text;
            var staffTc = cmbUpdateCusStaffTc.Text.Split(':')[1].Trim();

            _customerService.TUpdateCustomer(customerTc, fname, lname, password, phone, address, staffTc);
            MessageBox.Show("Customer Updated Successfully.");
            tUpdateCusFirstName.Text = "";
            tUpdateCusLastName.Text = "";
            tUpdateCusPass.Text = "";
            tUpdateCusPhoneNo.Text = "";
            tUpdateCusAddress.Text = "";
            cmbUpdateCusStaffTc.Text = "";
        }
    }
}