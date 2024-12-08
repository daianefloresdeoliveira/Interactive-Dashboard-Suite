using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

// Name: Flores de Oliveira, Daiane
// Date: 22/07/2023
// Description: Section 3 - Final Project - Money Convertion.

namespace FinalProject
{
    public partial class MoneyExchange : Form
    {

        private DateTime loginTime;
        Regex objMoney;        
        public MoneyExchange()
        {
            InitializeComponent();
            loginTime = DateTime.Now;  // to record the time since form is initialized
        }        

        static string dir = @".\Files\";
        string path = dir + "MoneyConversions.txt";
        FileStream fs = null;

        private void MoneyExchange_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
        private void btn_Convert_Click(object sender, EventArgs e)
        {
            objMoney = new Regex(@"^([0-9]{0,5})$"); 

            if (objMoney.IsMatch(txt_input_user.Text) == true)
            {
                Reset();

                if (btn_CAD.Checked == true)
                {
                   ConvertFromCAD();
                }
                if (btn_USD.Checked == true)
                {
                    ConvertFromUSD();
                }
                if (btn_EUR.Checked == true)
                {
                    ConvertFromEUR();
                }
                if (btn_GBP.Checked == true)
                {
                    ConvertFromGBP();
                }
                if (btn_BRL.Checked == true)
                {
                    ConvertFromBRL();
                }
                if (btn_AUD.Checked == true)
                {
                    ConvertFromAUD();
                }
                if (btn_CNY.Checked == true)
                {
                    ConvertFromCNY();
                }               
            }
            else { MessageBox.Show("Input invalid!"); }
        }        

        private void btn_Read_Display_Click(object sender, EventArgs e)
        {
            // CREATE TXT
            DateTime d = DateTime.Now;
            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs);
                textOut.Write(txt_input_user.Text + " " + "=" + txt_CAD.Text + " ;" + txt_USD.Text + " ;" + txt_GBP.Text + " ;" + txt_EUR.Text + " ;" + txt_BRL.Text + " ;" + txt_AUD.Text + " ;" + txt_CNY.Text +"; " +d.ToShortDateString() +"; " + d.ToShortTimeString()+"\t\t\n\n");
                textOut.Close();
                MessageBox.Show("Operations saved in the text file!");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(dir + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }


            // READ TXT
            string textToPrint = "\n Input, \tCAD, \tUSD, \tGBP, \tEUR, \tBRL, \tAUD, \tCNY, Date ,Time";
            string Input, Cad, Usd, Gbp, Eur, Brl, Aud, Cny;
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader br = new StreamReader(fs);
                while (br.Peek() != -1) //not finding the end of stream
                {
                    Input = br.ReadLine();
                    Cad = br.ReadLine();
                    Usd = br.ReadLine();
                    Gbp = br.ReadLine();
                    Eur = br.ReadLine();
                    Brl = br.ReadLine();
                    Aud = br.ReadLine();
                    Cny = br.ReadLine();
                    textToPrint += "\n" + Input + "\t\t" + Cad + ",\t\t" + Usd + ",\t\t\t" + Gbp + ",\t\t" + Eur + ",\t\t" + Brl + ",\t\t" + Aud + " ,\t\t" + Cny;
                }
                MessageBox.Show(textToPrint);
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            TimeSpan timeConnected = DateTime.Now - loginTime;  // difference from begin to end 
            string tempconnect = $"Do you want to quit this app? You have been here for {timeConnected.Minutes}minutes and {timeConnected.Seconds}seconds";
            string confirm = "Exit";
            DialogResult result = MessageBox.Show(tempconnect, confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }        

        public void ConvertFromCAD()
        {
            double input_money = (Convert.ToDouble(txt_input_user.Text)), cad_value, usd_value, eur_value, gbp_value, brl_value, aud_value, cny_value;
            txt_currency.Text = "CAD = ";
            cad_value = input_money * 1.000; // CAD  
            usd_value = input_money * 0.757; // CAD TO USD   - INTERNET 22/07/2023   https://economia.uol.com.br/cotacoes/
            eur_value = input_money * 0.680; // CAD TO EUR   - INTERNET 22/07/2023
            gbp_value = input_money * 0.588; // CAD TO GBP   - INTERNET 22/07/2023
            brl_value = input_money * 3.617; // CAD TO BRL   - INTERNET 22/07/2023
            aud_value = input_money * 1.124; // CAD TO AUD    - INTERNET 22/07/2023
            cny_value = input_money * 5.438; // CAD TO CNY    - INTERNET 22/07/2023
            txt_CAD.Text = txt_input_user.Text + " " + "CAD";
            txt_USD.Text = Convert.ToString(usd_value) + " " + "USD";
            txt_EUR.Text = Convert.ToString(eur_value) + " " + "EUR";
            txt_GBP.Text = Convert.ToString(gbp_value) + " " + "GBP";
            txt_BRL.Text = Convert.ToString(brl_value) + " " + "BRL";
            txt_AUD.Text = Convert.ToString(aud_value) + " " + "AUD";
            txt_CNY.Text = Convert.ToString(cny_value) + " " + "CNY";                
        }
        public void ConvertFromUSD()
        {
            double input_money = (Convert.ToDouble(txt_input_user.Text)), cad_value, usd_value, eur_value, gbp_value, brl_value, aud_value, cny_value;
            txt_currency.Text = "USD = ";
            cad_value = input_money * 1.322; // USD TO CAD      - INTERNET 22/07/2023
            usd_value = input_money * 1.000; // USD            
            eur_value = input_money * 0.899; // USD TO EUR      - INTERNET 22/07/2023
            gbp_value = input_money * 0.778; // USD TO GBP      - INTERNET 22/07/2023
            brl_value = input_money * 4.781; // USD TO BRL      - INTERNET 22/07/2023
            aud_value = input_money * 1.486; //USD TO AUD       - INTERNET 22/07/2023
            cny_value = input_money * 7.188; //USD TO CNY       - INTERNET 22/07/2023
            txt_USD.Text = txt_input_user.Text + " " + "USD";
            txt_CAD.Text = Convert.ToString(cad_value) + " " + "CAD";
            txt_EUR.Text = Convert.ToString(eur_value) + " " + "EUR";
            txt_GBP.Text = Convert.ToString(gbp_value) + " " + "GBP";
            txt_BRL.Text = Convert.ToString(brl_value) + " " + "BRL";
            txt_AUD.Text = Convert.ToString(aud_value) + " " + "AUD";
            txt_CNY.Text = Convert.ToString(cny_value) + " " + "CNY";
        }
        public void ConvertFromEUR()
        {
            double input_money = (Convert.ToDouble(txt_input_user.Text)), cad_value, usd_value, eur_value, gbp_value, brl_value, aud_value, cny_value;
            txt_currency.Text = "EUR = ";
            cad_value = input_money * 1.471; // EUR TO CAD     - INTERNET 22/07/2023
            usd_value = input_money * 1.113; // EUR TO USD     - INTERNET 22/07/2023
            eur_value = input_money * 1.000; // EUR         
            gbp_value = input_money * 0.865; // EUR TO GBP     - INTERNET 22/07/2023
            brl_value = input_money * 4.780; // EUR TO BRL     - INTERNET 22/07/2023
            aud_value = input_money * 1.653; // EUR TO AUD     - INTERNET 22/07/2023
            cny_value = input_money * 7.997; // EUR TO CNY     - INTERNET 22/07/2023
            txt_EUR.Text = txt_input_user.Text + " " + "EUR";
            txt_CAD.Text = Convert.ToString(cad_value) + " " + "CAD";
            txt_USD.Text = Convert.ToString(usd_value) + " " + "USD";
            txt_GBP.Text = Convert.ToString(gbp_value) + " " + "GBP";
            txt_BRL.Text = Convert.ToString(brl_value) + " " + "BRL";
            txt_AUD.Text = Convert.ToString(aud_value) + " " + "AUD";
            txt_CNY.Text = Convert.ToString(cny_value) + " " + "CNY";
        }
        public void ConvertFromGBP()
        {
            double input_money = (Convert.ToDouble(txt_input_user.Text)), cad_value, usd_value, eur_value, gbp_value, brl_value, aud_value, cny_value;
            txt_currency.Text = "GBP = ";
            cad_value = input_money * 1.700; // GBP TO CAD     - INTERNET 22/07/2023
            usd_value = input_money * 1.286; // GBP TO USD     - INTERNET 22/07/2023
            eur_value = input_money * 1.156; // GBP TO EUR     - INTERNET 22/07/2023
            gbp_value = input_money * 1.000; // GBP 
            brl_value = input_money * 6.148; // GBP TO BRL     - INTERNET 22/07/2023
            aud_value = input_money * 1.911; // GBP TO AUD     - INTERNET 22/07/2023
            cny_value = input_money * 9.244; // GBP TO CNY     - INTERNET 22/07/2023
            txt_GBP.Text = txt_input_user.Text + " " + "GBP";
            txt_CAD.Text = Convert.ToString(cad_value) + " " + "CAD";
            txt_USD.Text = Convert.ToString(usd_value) + " " + "USD";
            txt_EUR.Text = Convert.ToString(eur_value) + " " + "EUR";
            txt_BRL.Text = Convert.ToString(brl_value) + " " + "BRL";
            txt_AUD.Text = Convert.ToString(aud_value) + " " + "AUD";
            txt_CNY.Text = Convert.ToString(cny_value) + " " + "CNY";
        }

        public void ConvertFromBRL()
        {
            double input_money = (Convert.ToDouble(txt_input_user.Text)), cad_value, usd_value, eur_value, gbp_value, brl_value, aud_value, cny_value;
            txt_currency.Text = "BRL = ";
            cad_value = input_money * 0.276; // BRL TO CAD      - INTERNET 22/07/2023
            usd_value = input_money * 0.209; // BRL TO USD      - INTERNET 22/07/2023
            eur_value = input_money * 0.188; // BRL TO EUR      - INTERNET 22/07/2023
            gbp_value = input_money * 0.163; // BRL TO GBP      - INTERNET 22/07/2023
            brl_value = input_money * 1.000; // BRL
            aud_value = input_money * 0.311; // BRL TO AUD      - INTERNET 22/07/2023
            cny_value = input_money * 1.504; // BRL TO CNY      - INTERNET 22/07/2023
            txt_BRL.Text = txt_input_user.Text + " " + "BRL";
            txt_CAD.Text = Convert.ToString(cad_value) + " " + "CAD";
            txt_USD.Text = Convert.ToString(usd_value) + " " + "USD";
            txt_EUR.Text = Convert.ToString(eur_value) + " " + "EUR";
            txt_GBP.Text = Convert.ToString(gbp_value) + " " + "GBP";
            txt_AUD.Text = Convert.ToString(aud_value) + " " + "AUD";
            txt_CNY.Text = Convert.ToString(cny_value) + " " + "CNY";
        }

        public void ConvertFromAUD()
        {
            double input_money = (Convert.ToDouble(txt_input_user.Text)), cad_value, usd_value, eur_value, gbp_value, brl_value, aud_value, cny_value;
            txt_currency.Text = "AUD = ";
            cad_value = input_money * 0.890; // AUD TO CAD      - INTERNET 22/07/2023
            usd_value = input_money * 0.673; // AUD TO USD      - INTERNET 22/07/2023
            eur_value = input_money * 0.605; // AUD TO EUR      - INTERNET 22/07/2023
            gbp_value = input_money * 0.523; // AUD TO GBP      - INTERNET 22/07/2023
            brl_value = input_money * 3.217; // AUD TO BRL      - INTERNET 22/07/2023
            aud_value = input_money * 1.000; // AUD 
            cny_value = input_money * 4.837; // AUD TO CNY      - INTERNET 22/07/2023
            txt_AUD.Text = txt_input_user.Text + " " + "AUD";
            txt_CAD.Text = Convert.ToString(cad_value) + " " + "CAD";
            txt_USD.Text = Convert.ToString(usd_value) + " " + "USD";
            txt_EUR.Text = Convert.ToString(eur_value) + " " + "EUR";
            txt_GBP.Text = Convert.ToString(gbp_value) + " " + "GBP";
            txt_BRL.Text = Convert.ToString(brl_value) + " " + "BRL";
            txt_CNY.Text = Convert.ToString(cny_value) + " " + "CNY";
        }

        public void ConvertFromCNY()
        {
            double input_money = (Convert.ToDouble(txt_input_user.Text)), cad_value, usd_value, eur_value, gbp_value, brl_value, aud_value, cny_value;
            txt_currency.Text = "CNY = ";
            cad_value = input_money * 0.184; // CNY TO CAD    - INTERNET 22/07/2023
            usd_value = input_money * 0.139; // CNY TO USD    - INTERNET 22/07/2023
            eur_value = input_money * 0.125; // CNY TO EUR    - INTERNET 22/07/2023
            gbp_value = input_money * 0.108; // CNY TO GBP    - INTERNET 22/07/2023
            brl_value = input_money * 0.665; // CNY TO BRL    - INTERNET 22/07/2023
            aud_value = input_money * 0.207; // CNY TO AUD    - INTERNET 22/07/2023
            cny_value = input_money * 1.000; // CNY 
            txt_CNY.Text = txt_input_user.Text + " " + "CNY";
            txt_CAD.Text = Convert.ToString(cad_value) + " " + "CAD";
            txt_USD.Text = Convert.ToString(usd_value) + " " + "USD";
            txt_EUR.Text = Convert.ToString(eur_value) + " " + "EUR";
            txt_GBP.Text = Convert.ToString(gbp_value) + " " + "GBP";
            txt_BRL.Text = Convert.ToString(brl_value) + " " + "BRL";
            txt_AUD.Text = Convert.ToString(aud_value) + " " + "AUD";
        }

        public void Reset()
        {
            txt_AUD.Text = "";
            txt_BRL.Text = "";
            txt_CAD.Text = "";
            txt_CNY.Text = "";
            txt_EUR.Text = "";
            txt_GBP.Text = "";
            txt_USD.Text = "";
        }
    } // end class   
}// end namespace

