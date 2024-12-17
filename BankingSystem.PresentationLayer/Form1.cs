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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            pLogIn.Hide();
            pRegister.Show();
        }

        private void bCreateAccount_Click(object sender, EventArgs e)
        {
            pRegister.Hide();
            pLogIn.Show();
        }

        private void bReturnLogIn_Click(object sender, EventArgs e)
        {
            pRegister.Hide();
            pLogIn.Show();
        }
    }
}
