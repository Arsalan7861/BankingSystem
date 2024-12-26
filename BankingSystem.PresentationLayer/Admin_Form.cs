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
using System.Transactions;
using System.Windows.Forms;
using TransactionManager = BankingSystem.BusinessLayer.Concrete.TransactionManager;

namespace bankaprojesiform
{
    public partial class Admin_Form : Form
    {
        private readonly string _connectionString;
        private readonly IBranchService _branchService;
        private readonly string _adminTc;
        private readonly ITransactionService transactionService;
        private readonly ILogService _logService;
        private readonly IStaffService _staffService;
        private readonly ICustomerService _customerService;
        public Admin_Form(string connectionString, string adminTc)
        {
            InitializeComponent();
            _connectionString = connectionString;
            this.FormClosed += Admin_Form_FormClosed;
            _branchService = new BranchManager(new BranchDal(connectionString));
            _adminTc = adminTc;
            transactionService = new TransactionManager(new TransactionDal(connectionString));
            _logService = new LogManager(new LogDal(connectionString));
            _staffService = new StaffManager(new StaffDal(connectionString));
            _customerService = new CustomerManager(new CustomerDal(connectionString));
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

            LoadData();
        }
        // Load data function
        private void LoadData()
        {
            var branches = _branchService.TGetAll();
            dgvBranches.DataSource = branches; // show branches in data grid view
            dgvBranches.ClearSelection(); // clear selection of data grid view

            // show branches in combo boxes
            cmbUSelectBranch.Items.Clear();
            cmbDSelectBranch.Items.Clear();
            cmbStaffBranch.Items.Clear();
            cmbUSelBranch.Items.Clear();
            cDelSelBranch.Items.Clear();
            foreach (var branch in branches)
            {
                cmbUSelectBranch.Items.Add($"ID: {branch.Branchid}, Name: {branch.Branchname}");
                cmbDSelectBranch.Items.Add($"ID: {branch.Branchid}, Name: {branch.Branchname}");
                cmbStaffBranch.Items.Add($"ID: {branch.Branchid}, Name: {branch.Branchname}");// for staff
                cmbUSelBranch.Items.Add($"ID: {branch.Branchid}, Name: {branch.Branchname}");
                cmbUStaffBranch.Items.Add($"ID: {branch.Branchid}, Name: {branch.Branchname}");
                cDelSelBranch.Items.Add($"ID: {branch.Branchid}, Name: {branch.Branchname}");
            }

            var transactions = transactionService.TGetAll();
            dTransaction.DataSource = transactions;// show transactions in data grid view
            dTransaction.ClearSelection();// clear selection of data grid view

            var logs = _logService.TGetAll();
            dLog.DataSource = logs;// show logs in data grid view
            dLog.ClearSelection();// clear selection of data grid view

            var staffs = _staffService.TGetAll();
            dgvStaffs.DataSource = staffs;// show staffs in data grid view
            dgvStaffs.ClearSelection();// clear selection of data grid view

            // show staffs in combo boxes
            cmbUStaff.Items.Clear();
            cDelSelStaff.Items.Clear();
            foreach (var staff in staffs)
            {
                cmbCusStaffTc.Items.Add($"TC: {staff.Stafftc}");
                cmbUpdateCusStaffTc.Items.Add($"TC: {staff.Stafftc}");
            }

            var customers = _customerService.TGetAll();
            dCustomer.DataSource = customers;// show customers in data grid view
            dCustomer.ClearSelection();// clear selection of data grid view

            // show customers in combo boxes
            cUpdateCustomerTC.Items.Clear();
            cDelCustomer.Items.Clear();
            foreach (var customer in customers)
            {
                cUpdateCustomerTC.Items.Add($"TC: {customer.Customertc}");
                cDelCustomer.Items.Add($"TC: {customer.Customertc}");
            }
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

        private void btnCreateBranch_Click(object sender, EventArgs e)
        {
            if (tBranchCity.Text == "" && tBranchName.Text == "" && tBranchPostCode.Text == "" && tBranchStreet.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            var city = tBranchCity.Text;
            var street = tBranchStreet.Text;
            var postCode = tBranchPostCode.Text;
            var name = tBranchName.Text;

            _branchService.TCreateBranch(city, street, postCode, name);
            MessageBox.Show("Branch Created Successfully.");
            tBranchCity.Text = "";
            tBranchStreet.Text = "";
            tBranchPostCode.Text = "";
            tBranchName.Text = "";

            LoadData();
        }

        // Show selected branch information in the update branch panel
        private void cmbUSelectBranch_SelectedValueChanged(object sender, EventArgs e)
        {
            var branches = _branchService.TGetAll();

            var selectedBranch = branches.FirstOrDefault(x => x.Branchid == Convert.ToInt32(cmbUSelectBranch.Text.Split(',')[0].Trim().Split(':')[1].Trim()));
            if (selectedBranch != null)
            {
                tUBranchCity.Text = selectedBranch.Branchcity;
                tUBranchStreet.Text = selectedBranch.Branchstreet;
                tUBranchPostCode.Text = selectedBranch.Branchpostcode;
                tUBranchName.Text = selectedBranch.Branchname;
            }
        }

        private void bUBranch_Click(object sender, EventArgs e)
        {
            if (tBranchCity.Text == "" && tBranchName.Text == "" && tBranchPostCode.Text == "" && tBranchStreet.Text == "" && cmbUSelectBranch.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            var id = Convert.ToInt32(cmbUSelectBranch.Text.Split(',')[0].Trim().Split(':')[1].Trim());
            var city = tUBranchCity.Text;
            var street = tUBranchStreet.Text;
            var postCode = tUBranchPostCode.Text;
            var name = tUBranchName.Text;
            _branchService.TUpdateBranch(id, city, street, postCode, name);
            MessageBox.Show("Branch Updated Successfully.");
            tUBranchCity.Text = "";
            tUBranchName.Text = "";
            tUBranchPostCode.Text = "";
            tUBranchStreet.Text = "";
            cmbUSelectBranch.Text = "";

            LoadData();
        }

        private void bDeleteBranch_Click(object sender, EventArgs e)
        {
            if (cmbDSelectBranch.Text == "")
            {
                MessageBox.Show("Please select a branch to delete!");
                return;
            }

            var id = Convert.ToInt32(cmbDSelectBranch.Text.Split(',')[0].Trim().Split(':')[1].Trim());
            _branchService.TDeleteBranch(id);
            MessageBox.Show("Branch Deleted Successfully.");
            cmbDSelectBranch.Text = "";

            LoadData();
        }

        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            if (txtStaffTc.Text == "" && txtStaffFName.Text == "" && txtStaffLName.Text == "" && txtStaffPassword.Text == "" && cmbStaffPosition.Text == "" && txtStaffPhoneNo.Text == "" && cmbStaffBranch.Text == "" && txtStaffAddress.Text == "" && txtStaffEmail.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }
            var tc = txtStaffTc.Text;
            var fName = txtStaffFName.Text;
            var lName = txtStaffLName.Text;
            var password = txtStaffPassword.Text;
            var position = cmbStaffPosition.Text;
            var phone = txtStaffPhoneNo.Text;
            var branchId = Convert.ToInt32(cmbStaffBranch.Text.Split(',')[0].Trim().Split(':')[1].Trim());
            var address = txtStaffAddress.Text;
            var email = txtStaffEmail.Text;

            _staffService.TCreateStaff(tc, fName, lName, password, position, phone, branchId, address, email);
            MessageBox.Show("Staff Created Successfully.");
            txtStaffTc.Text = "";
            txtStaffFName.Text = "";
            txtStaffLName.Text = "";
            txtStaffPassword.Text = "";
            cmbStaffPosition.Text = "";
            txtStaffPhoneNo.Text = "";
            cmbStaffBranch.Text = "";
            txtStaffAddress.Text = "";
            txtStaffEmail.Text = "";

            LoadData();
        }

        private void bUStaff_Click(object sender, EventArgs e)
        {
            if (cmbUStaff.Text == "" || txtUStaffFName.Text == "" || txtUStaffLName.Text == "" || txtUStaffPassword.Text == "" || cmbUStaffPosition.Text == "" || txtUStaffPhoneNo.Text == "" || cmbUSelBranch.Text == "" || txtUStaffAddress.Text == "" || txtUStaffEmail.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            var tc = cmbUStaff.Text.Split(':')[1].Trim();
            var fName = txtUStaffFName.Text;
            var lName = txtUStaffLName.Text;
            var password = txtUStaffPassword.Text;
            var position = cmbUStaffPosition.Text;
            var phone = txtUStaffPhoneNo.Text;
            var branchId = Convert.ToInt32(cmbUStaffBranch.Text.Split(',')[0].Trim().Split(':')[1].Trim());
            var address = txtUStaffAddress.Text;
            var email = txtUStaffEmail.Text;

            _staffService.TUpdateStaff(tc, fName, lName, password, position, phone, branchId, address, email);
            MessageBox.Show("Staff Updated Successfully.");
            cmbUStaff.Text = "";
            txtUStaffFName.Text = "";
            txtUStaffLName.Text = "";
            txtUStaffPassword.Text = "";
            cmbUStaffPosition.Text = "";
            txtUStaffPhoneNo.Text = "";
            cmbUSelBranch.Text = "";
            txtUStaffAddress.Text = "";
            txtUStaffEmail.Text = "";

            LoadData();
        }

        private void cmbUBranch_SelectedValueChanged(object sender, EventArgs e)
        {// showing staffs of selected branch
            cmbUStaff.Text = "";
            cmbUStaff.Text = "";
            txtUStaffFName.Text = "";
            txtUStaffLName.Text = "";
            txtUStaffPassword.Text = "";
            cmbUStaffPosition.Text = "";
            txtUStaffPhoneNo.Text = "";
            txtUStaffAddress.Text = "";
            txtUStaffEmail.Text = "";

            var branches = _branchService.TGetAll();
            var branchId = Convert.ToInt32(cmbUSelBranch.Text.Split(',')[0].Trim().Split(':')[1].Trim());
            var selectedBranch = branches.FirstOrDefault(x => x.Branchid == branchId);

            var staffs = _staffService.TGetAll();
            var selectedStaffs = staffs.Where(x => x.Branchid == selectedBranch.Branchid);

            cmbUStaff.Items.Clear();
            foreach (var staff in selectedStaffs)
            {
                cmbUStaff.Items.Add($"TC: {staff.Stafftc}");
            }
        }

        private void cmbUStaff_SelectedValueChanged(object sender, EventArgs e)
        {
            var staffs = _staffService.TGetAll();
            var stafftc = cmbUStaff.Text.Split(':')[1].Trim();
            var selectedStaff = staffs.FirstOrDefault(x => x.Stafftc == stafftc);
            var branch = _branchService.TGetAll().FirstOrDefault(x => x.Branchid == selectedStaff.Branchid);

            if (selectedStaff != null)
            {
                txtUStaffFName.Text = selectedStaff.Stafffname;
                txtUStaffLName.Text = selectedStaff.Stafflname;
                txtUStaffPassword.Text = selectedStaff.Staffpassword;
                cmbUStaffPosition.Text = selectedStaff.Staffposition;
                txtUStaffPhoneNo.Text = selectedStaff.Staffphone;
                txtUStaffAddress.Text = selectedStaff.Staffaddress;
                txtUStaffEmail.Text = selectedStaff.Staffemail;
                cmbUStaffBranch.Text = $"ID: {selectedStaff.Branchid}, Name: {branch.Branchname}";
            }
        }

        private void cDelSelBranch_SelectedValueChanged(object sender, EventArgs e)
        {// showing staffs of selected branch
            cDelSelStaff.Text = "";

            var branches = _branchService.TGetAll();
            var branchId = Convert.ToInt32(cDelSelBranch.Text.Split(',')[0].Trim().Split(':')[1].Trim());
            var selectedBranch = branches.FirstOrDefault(x => x.Branchid == branchId);

            var staffs = _staffService.TGetAll();
            var selectedStaffs = staffs.Where(x => x.Branchid == selectedBranch.Branchid);

            cDelSelStaff.Items.Clear();
            foreach (var staff in selectedStaffs)
            {
                cDelSelStaff.Items.Add($"TC: {staff.Stafftc}");
            }
        }

        private void bDStaff_Click(object sender, EventArgs e)
        {
            if (cDelSelStaff.Text == "")
            {
                MessageBox.Show("Please select a staff to delete!");
                return;
            }

            var staffTc = cDelSelStaff.Text.Split(':')[1].Trim();
            _staffService.TDeleteStaff(staffTc);
            MessageBox.Show("Staff Deleted Successfully.");
            cDelSelStaff.Text = "";
            cDelSelStaff.Items.Clear();
            cDelSelBranch.Text = "";

            LoadData();
        }

        private void bCreateCus_Click(object sender, EventArgs e)
        {
            if (txtCustomerTc.Text == "" && tCusFName.Text == "" && tCusLName.Text == "" && tCusPass.Text == "" && tCusPhoneNo.Text == "" && tCusAddress.Text == "" && cmbCusStaffTc.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            var customers = _customerService.TGetAll();
            if (customers.Any(x => x.Customertc == txtCustomerTc.Text))
            {
                MessageBox.Show("Customer with this TC already exists!");
                return;
            }

            var tc = txtCustomerTc.Text;
            var fname = tCusFName.Text;
            var lname = tCusLName.Text;
            var password = tCusPass.Text;
            var phone = tCusPhoneNo.Text;
            var address = tCusAddress.Text;
            var staffTc = cmbCusStaffTc.Text.Split(':')[1].Trim();

            _customerService.TCreateCustomer(tc, fname, lname, password, phone, address, staffTc);
            MessageBox.Show("Customer Created Successfully.");
            txtCustomerTc.Text = "";
            tCusFName.Text = "";
            tCusLName.Text = "";
            txtStaffTc.Text = "";
            tCusPass.Text = "";
            tCusPhoneNo.Text = "";
            tCusAddress.Text = "";
            cmbCusStaffTc.Text = "";

            LoadData();
        }

        // Show selected customer information in the update customer panel
        private void cUpdateCustomerTC_SelectedValueChanged(object sender, EventArgs e)
        {
            var customers = _customerService.TGetAll();
            var customerTc = cUpdateCustomerTC.Text.Split(':')[1].Trim();
            var selectedCustomer = customers.FirstOrDefault(x => x.Customertc == customerTc);
            if (selectedCustomer != null)
            {
                tUpdateCusFirstName.Text = selectedCustomer.Customerfname;
                tUpdateCusLastName.Text = selectedCustomer.Customerlname;
                tUpdateCusPass.Text = selectedCustomer.Customerpassword;
                tUpdateCusPhoneNo.Text = selectedCustomer.Customerphone;
                tUpdateCusAddress.Text = selectedCustomer.Customeraddress;
                cmbUpdateCusStaffTc.Text = $"TC: {selectedCustomer.Stafftc}";
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (cUpdateCustomerTC.Text == "" && tUpdateCusFirstName.Text == "" && tUpdateCusLastName.Text == "" && tUpdateCusPass.Text == "" && tUpdateCusPhoneNo.Text == "" && tUpdateCusAddress.Text == "" && cmbUpdateCusStaffTc.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            var customerTc = cUpdateCustomerTC.Text.Split(':')[1].Trim();
            var fname = tUpdateCusFirstName.Text;
            var lname = tUpdateCusLastName.Text;
            var password = tUpdateCusPass.Text;
            var phone = tUpdateCusPhoneNo.Text;
            var address = tUpdateCusAddress.Text;
            var staffTc = cmbUpdateCusStaffTc.Text.Split(':')[1].Trim();

            _customerService.TUpdateCustomer(customerTc, fname, lname, password, phone, address, staffTc);
            MessageBox.Show("Customer Updated Successfully.");
            cUpdateCustomerTC.Text = "";
            tUpdateCusFirstName.Text = "";
            tUpdateCusLastName.Text = "";
            tUpdateCusPass.Text = "";
            tUpdateCusPhoneNo.Text = "";
            tUpdateCusAddress.Text = "";
            cmbUpdateCusStaffTc.Text = "";

            LoadData();
        }

        private void bDelCustomer_Click(object sender, EventArgs e)
        {
            if (cDelCustomer.Text == "")
            {
                MessageBox.Show("Please select a customer to delete!");
                return;
            }

            var customerTc = cDelCustomer.Text.Split(':')[1].Trim();

            _customerService.TDeleteCustomer(customerTc);
            MessageBox.Show("Customer Deleted Successfully.");
            cDelCustomer.Text = "";

            LoadData();
        }

        private void bSearchLog_Click(object sender, EventArgs e)
        {
            var tc = tSearchLog.Text;
            var logs = _logService.TSearchLog(tc);
            dLog.DataSource = logs;
            dLog.ClearSelection();
        }

        private void bSearchBranch_Click(object sender, EventArgs e)
        {
            var name = tSearchBranch.Text;
            var branches = _branchService.TSearchBranch(name);
            dgvBranches.DataSource = branches;
            dgvBranches.ClearSelection();
        }

        private void bSearchStaff_Click(object sender, EventArgs e)
        {
            var tc = tSearchStaff.Text;
            var staffs = _staffService.TSearchStaff(tc);
            dgvStaffs.DataSource = staffs;
            dgvStaffs.ClearSelection();
        }

        private void bSearchCustomer_Click(object sender, EventArgs e)
        {
            var tc = tSearchCustomer.Text;
            var customers = _customerService.TSearchCustomer(tc);
            dCustomer.DataSource = customers;
            dCustomer.ClearSelection();
        }

        private void bSearchTransaction_Click(object sender, EventArgs e)
        {
            var tc = tSearchTransaction.Text;
            var transactions = transactionService.TSearchTransaction(tc);
            dTransaction.DataSource = transactions;
            dTransaction.ClearSelection();
        }
    }
}