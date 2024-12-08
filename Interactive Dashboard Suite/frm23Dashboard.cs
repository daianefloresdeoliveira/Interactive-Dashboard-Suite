using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Daiane Flores de Oliveira
// Date: 2023/07/10
// Version: 01

namespace FinalProject
{
    public partial class frm23Dashboard : Form
    {
        public frm23Dashboard()
        {
            InitializeComponent();
        }

        private void btn_IpValidator_Click(object sender, EventArgs e)
        {
            IP_Validator obj = new IP_Validator();
            obj.Show();
            
        }

        private void btn_Calculator_Click(object sender, EventArgs e)
        {
            Simple_Calculator objc = new Simple_Calculator();
            objc.Show();
        }

        private void btn_MoneyExchange_Click(object sender, EventArgs e)
        {
            MoneyExchange objm = new MoneyExchange();
            objm.Show();
        }

        private void btn_Temperature_Convert_Click(object sender, EventArgs e)
        {
            Temperature objt = new Temperature();
            objt.Show();
        }

        private void btn_LottoMax_Click(object sender, EventArgs e)
        {
            frmMax objc = new frmMax();
            objc.Show();
        }

        private void btn_Lotto649_Click(object sender, EventArgs e)
        {
            frm649 objc = new frm649();
            objc.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                Application.Exit();
                //this.Close();
            }
            
        }

        private void frm23Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
