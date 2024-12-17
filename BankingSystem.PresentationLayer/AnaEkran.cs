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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            //Uygulamayı tam ekran başlatır
            this.WindowState = FormWindowState.Maximized;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.CenterScreen;

            pOverview_Main.Show();
            pCreateAccount_Main.Hide();
            pSettings.Hide();
            pSupport.Hide();
            pTransactions.Hide();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void bOverView_Click(object sender, EventArgs e)
        {
            pCreateAccount_Main.Hide();
            pSettings.Hide();
            pOverview_Main.Show();
            pTransactions.Hide();
            pSupport.Hide();
        }

        private void bCreateAccount_Click(object sender, EventArgs e)
        {
            pOverview_Main.Hide();
            pSettings.Hide();
            pDemand.Hide();
            pCredit.Hide();
            pCreateAccount_Main.Show();
            pSupport.Hide();
            pTransactions.Hide();
        }

        private void bDemand_Click(object sender, EventArgs e)
        {
            pCredit.Hide();
            pDemand.Show();
        }

        private void bCredit_Click(object sender, EventArgs e)
        {
            pDemand.Hide();
            pCredit.Show();
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            pSettings.Show();
            pOverview_Main.Hide();
            pCreateAccount_Main.Hide();
            pInformation.Hide();
            pChangePass.Hide();
            pSupport.Hide();
            pTransactions.Hide();
        }



        private void bInformation_Click(object sender, EventArgs e)
        {
            pChangePass.Hide();
            pInformation.Show();
        }

        private void bChangePass_Click(object sender, EventArgs e)
        {
            pInformation.Hide();
            pChangePass.Show();
        }

        private void bSupport_Click(object sender, EventArgs e)
        {
            pSupport.Show();
            pSettings.Hide();
            pCreateAccount_Main.Hide();
            pOverview_Main.Hide();
            pTransactions.Hide();
        }

        private void lGoToChangePass_Click(object sender, EventArgs e)
        {
            pSupport.Hide();
            pSettings.Show();
            pChangePass.Show();
            pInformation.Hide();
        }

        private void lGoToInformations_Click(object sender, EventArgs e)
        {
            pSupport.Hide();
            pSettings.Show();
            pChangePass.Hide();
            pInformation.Show();
        }

        private void bTransaction_Click(object sender, EventArgs e)
        {
            pOverview_Main.Hide();
            pCreateAccount_Main.Hide();
            pSettings.Hide();
            pSupport.Hide();
            pTransactions.Show();
        }

        private void lGoToTransactions_Click(object sender, EventArgs e)
        {
            pTransactions.Show();
        }
    }
}
