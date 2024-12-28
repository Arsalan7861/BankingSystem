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
    public partial class Pbo_form : Form
    {
        private readonly string _connectionString;
        private readonly ICustomerService _customerService;
        private readonly string _pboTc;
        public Pbo_form(string connectionString, string tc)
        {
            InitializeComponent();
            _connectionString = connectionString;
            this.FormClosed += Pbo_form_FormClosed;
            _customerService = new CustomerManager(new CustomerDal(connectionString));
            _pboTc = tc;
        }
        // Closes the application when page is closed.
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

            LoadData();
        }
        // Load only cutomers that belongs to the pbo that is signed in. 
        private void LoadData()
        {
            var customers = _customerService.TGetAll().Where(x => x.Stafftc == _pboTc).ToList();
            dCustomer.DataSource = customers;
            dCustomer.ClearSelection(); // Clear the selection of the datagridview

            cUpdateCustomerTc.Items.Clear();
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

        private void bCreateCusAccount_Click(object sender, EventArgs e)
        {
            if (tCreateTc.Text == "" || tCreateFName.Text == "" || tCreateLName.Text == "" || tCreatePassword.Text == "" || tCreatePhoneNo.Text == "" || tCreateAddress.Text == "")
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!tCreateTc.Text.All(char.IsDigit))
            {
                MessageBox.Show("TC must be numeric!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!tCreatePhoneNo.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be numeric!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var customerTc = tCreateTc.Text;
            var fname = tCreateFName.Text;
            var lname = tCreateLName.Text;
            var password = tCreatePassword.Text;
            var phone = tCreatePhoneNo.Text;
            var address = tCreateAddress.Text;

            var customers = _customerService.TGetAll();
            foreach (var customer in customers)
            {
                if (customer.Customertc == customerTc)
                {
                    MessageBox.Show("Customer already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            _customerService.TCreateCustomer(customerTc, fname, lname, password, phone, address, _pboTc);
            MessageBox.Show("Customer Created Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tCreateTc.Text = "";
            tCreateFName.Text = "";
            tCreateLName.Text = "";
            tCreatePassword.Text = "";
            tCreatePhoneNo.Text = "";
            tCreateAddress.Text = "";

            LoadData();
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
        }

        private void bUpdCus_Click(object sender, EventArgs e)
        {
            if (tUpdateCusFirstName.Text == "" || tUpdateCusLastName.Text == "" || tUpdateCusPass.Text == "" || tUpdateCusPhoneNo.Text == "" || tUpdateCusAddress.Text == "")
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!tUpdateCusPhoneNo.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be numeric!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var customerTc = cUpdateCustomerTc.SelectedItem.ToString().Split(':')[1].Trim();
            var fname = tUpdateCusFirstName.Text;
            var lname = tUpdateCusLastName.Text;
            var password = tUpdateCusPass.Text;
            var phone = tUpdateCusPhoneNo.Text;
            var address = tUpdateCusAddress.Text;

            _customerService.TUpdateCustomer(customerTc, fname, lname, password, phone, address, _pboTc);
            MessageBox.Show("Customer Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tUpdateCusFirstName.Text = "";
            tUpdateCusLastName.Text = "";
            tUpdateCusPass.Text = "";
            tUpdateCusPhoneNo.Text = "";
            tUpdateCusAddress.Text = "";

            LoadData();
        }

        private void bSearchCustomer_Click(object sender, EventArgs e)
        {
            var tc = tSearchCustomer.Text;
            var customers = _customerService.TSearchCustomer(tc).Where(x => x.Stafftc == _pboTc).ToList();
            dCustomer.DataSource = customers;
            dCustomer.ClearSelection();
        }
    }
}
