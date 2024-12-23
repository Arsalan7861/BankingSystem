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
    public partial class Manager_Form : Form
    {
        private readonly string _connectionString;
        private readonly ILogService _logService;
        private readonly IBranchService _branchService;
        private readonly IStaffService _staffService;
        private readonly string _managerTc;
        public Manager_Form(string connectionString, string tc)
        {
            InitializeComponent();
            _connectionString = connectionString;
            this.FormClosed += Manager_Form_FormClosed;
            _managerTc = tc;
            _logService = new LogManager(new LogDal(connectionString));
            _branchService = new BranchManager(new BranchDal(connectionString));
            _staffService = new StaffManager(new StaffDal(connectionString));
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

            var logs = _logService.TGetAll();
            dLog.DataSource = logs;

            // show branches in combo boxes
            var branches = _branchService.TGetAll();
            foreach (var branch in branches)
            {
                cCreateStaffBranchId.Items.Add($"ID: {branch.Branchid}, Name: {branch.Branchname}");
                cUpdStaffBranchId.Items.Add($"ID: {branch.Branchid}, Name: {branch.Branchname}");
            }

            // show staffs in combo boxes
            var staffs = _staffService.TGetAll();
            foreach (var staff in staffs)
            {
                cDelSelStaff.Items.Add($"TC: {staff.Stafftc}");
                cUpdateStaffSel.Items.Add($"TC: {staff.Stafftc}");
            }

            // show staffs in data grid view
            dSeeAllStaff.DataSource = staffs;
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

        private void bCreateBranch_Click(object sender, EventArgs e)
        {
            if (tCreateStaffTc.Text == "" || tCreateStaffFName.Text == "" || tCreateStaffLName.Text == "" || tCreateStaffPassword.Text == "" || tCreateStaffPhoneNo.Text == "" || tCreateStaffAddress.Text == "" || cCreateStaffPos.Text == "" || tCreateStaffEmail.Text == "" || cCreateStaffBranchId.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            var staffs = _staffService.TGetAll();
            foreach (var staff in staffs)
            {
                if (staff.Stafftc == tCreateStaffTc.Text)
                {
                    MessageBox.Show("Staff already exists");
                    return;
                }
            }

            var stafftc = tCreateStaffTc.Text;
            var staffname = tCreateStaffFName.Text;
            var staffsurname = tCreateStaffLName.Text;
            var staffpassword = tCreateStaffPassword.Text;
            var staffbranchid = int.Parse(cCreateStaffBranchId.Text.Split(',')[0].Trim().Split(':')[1].Trim());
            var staffphone = tCreateStaffPhoneNo.Text;
            var staffaddress = tCreateStaffAddress.Text;
            var staffposition = cCreateStaffPos.Text;
            var staffemail = tCreateStaffEmail.Text;

            _staffService.TCreateStaff(stafftc, staffname, staffsurname, staffpassword, staffposition, staffphone, staffbranchid, staffaddress, staffemail);
            MessageBox.Show("Staff created successfully");
            tCreateStaffTc.Text = "";
            tCreateStaffFName.Text = "";
            tCreateStaffLName.Text = "";
            tCreateStaffPassword.Text = "";
            tCreateStaffPhoneNo.Text = "";
            tCreateStaffAddress.Text = "";
            tCreateStaffEmail.Text = "";
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (cDelSelStaff.Text == "")
            {
                MessageBox.Show("Please select a staff!");
                return;
            }

            var staffTc = cDelSelStaff.Text.Split(':')[1].Trim();
            _staffService.TDeleteStaff(staffTc);
            MessageBox.Show("Staff deleted successfully");
        }

        private void cUpdateStaffSel_SelectedValueChanged(object sender, EventArgs e)
        {
            var staffTc = cUpdateStaffSel.Text.Split(':')[1].Trim();
            var staff = _staffService.TGetAll().FirstOrDefault(x => x.Stafftc == staffTc);

            var branch = _branchService.TGetAll().FirstOrDefault(x => x.Branchid == staff.Branchid);

            tUpdStaffFirstName.Text = staff.Stafffname;
            tUpdStaffLName.Text = staff.Stafflname;
            tUpdStaffPassword.Text = staff.Staffpassword;
            tUpdStaffPhoneNo.Text = staff.Staffphone;
            tUpdStaffAddress.Text = staff.Staffaddress;
            cUpdStaffPos.Text = staff.Staffposition;
            tUpdStaffEmail.Text = staff.Staffemail;
            cUpdStaffBranchId.Text = $"ID: {staff.Branchid}, Name: {branch.Branchname}";
        }

        private void bUStaff_Click(object sender, EventArgs e)
        {
            if (cUpdateStaffSel.Text == "" || tUpdStaffFirstName.Text == "" || tUpdStaffLName.Text == "" || tUpdStaffPassword.Text == "" || tUpdStaffPhoneNo.Text == "" || tUpdStaffAddress.Text == "" || cUpdStaffPos.Text == "" || tUpdStaffEmail.Text == "" || cUpdStaffBranchId.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            var tc = cUpdateStaffSel.Text.Split(':')[1].Trim();
            var fname = tUpdStaffFirstName.Text;
            var lname = tUpdStaffLName.Text;
            var password = tUpdStaffPassword.Text;
            var phone = tUpdStaffPhoneNo.Text;
            var address = tUpdStaffAddress.Text;
            var position = cUpdStaffPos.Text;
            var email = tUpdStaffEmail.Text;
            var branchId = int.Parse(cUpdStaffBranchId.Text.Split(',')[0].Trim().Split(':')[1].Trim());

            _staffService.TUpdateStaff(tc, fname, lname, password, position, phone, branchId, address, email);
            MessageBox.Show("Staff updated successfully");
            tUpdStaffFirstName.Text = "";
            tUpdStaffLName.Text = "";
            tUpdStaffPassword.Text = "";
            tUpdStaffPhoneNo.Text = "";
            tUpdStaffAddress.Text = "";
            tUpdStaffEmail.Text = "";
        }
    }
}
