using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// Name: Daiane Flores de Oliveira
// Date: 2023/07/10
// Version: 1.1

namespace FinalProject
{
    public partial class IP_Validator : Form
    {
        public IP_Validator()
        {
            InitializeComponent();
        }

        Regex obj, obj2;
        static string dir = @".\Files\"; // global variable       
        //static string dirPath = @"C:\Files\";
        //static string dirPath1 = @".\Files\";  // aqui salva dentro da pasta solucao - dentro bin 
        // string path = dirPath1 + "ProductsB.txt";
        //static string dirPath2 = @"..\Files\"; // aqui salva dentro da pasta solucao
        // string path = dirPath2 + "ProductsB.txt";
        string path4 = dir + "Binary4.txt";
        string path6 = dir + "Binary6.txt";

        FileStream fs = null;

        private void btn_ValidateIP_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            try 
            {

                //obj = new Regex(@"^((([0-2]{1}[0-5]{2})([0-9]{3})([0-9]{3})).){3}([0-2]{3})([0-9]{3})([0-9]{1})$");  
                //obj = new Regex("^(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");   
                obj = new Regex("(([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])");
                if (obj.IsMatch(txt_v4.Text) == true)
                {
                    MessageBox.Show(this.txt_v4.Text + "\nThe IP is correct!");
                    try
                    {
                        fs = new FileStream(path4, FileMode.Append, FileAccess.Write);

                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(txt_v4.Text);
                        bw.Write(d.ToShortDateString() + " " + d.ToShortTimeString());
                        //bw.Write(txt_v6.Text);
                        //bw.Write(d.ToShortDateString() + " " + d.ToShortTimeString());
                        bw.Close();
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show(path4 + " not found.", "File Not Found");
                    }
                    catch (DirectoryNotFoundException)
                    {
                        MessageBox.Show(dir + " not found.", "Directory Not Found");
                    }
                    catch (IOException ex)
                    { MessageBox.Show(ex.Message, "IOException"); }
                    finally { if (fs != null) fs.Close(); }
                }
                else
                {
                    MessageBox.Show(this.txt_v4.Text + "\nThe IP must have 4 bytes\n integer number between 0 to 255 \nseparated by a dot(255.255.255.255)");
                }          
            }catch (Exception ex) { MessageBox.Show("Error - Try again!"); txt_v4.Focus(); }

            try 
             {
                obj2 = new Regex("((([0-9a-fA-F]){1,4})\\:){7}([0-9a-fA-F]){1,4}");
                //obj2 = new Regex("^(([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))$");
                if (obj2.IsMatch(txt_v6.Text) == true)
                {
                    MessageBox.Show(this.txt_v6.Text + "\nThe IP is correct!");
                    try
                    {
                        fs = new FileStream(path6, FileMode.Append, FileAccess.Write);

                        BinaryWriter bw = new BinaryWriter(fs);
                        //bw.Write(txt_v4.Text);
                        //bw.Write(d.ToShortDateString() + " " + d.ToShortTimeString());
                        bw.Write(txt_v6.Text);
                        bw.Write(d.ToShortDateString() + " " + d.ToShortTimeString());
                        bw.Close();
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show(path6 + " not found.", "File Not Found");
                    }
                    catch (DirectoryNotFoundException)
                    {
                        MessageBox.Show(dir + " not found.", "Directory Not Found");
                    }
                    catch (IOException ex)
                    { MessageBox.Show(ex.Message, "IOException"); }
                    finally { if (fs != null) fs.Close(); }
                }
                else
                {
                    MessageBox.Show(this.txt_v6.Text + "\nThe IP must have 8 bytes\n integer number between 0 to 9 or letters A to F \nseparated by a colon\n(0000:0000:0000:0000:0000:0000:0000:0000) to \n (ffff:ffff:ffff:ffff:ffff:ffff:ffff:ffff)");
                }
            } catch (Exception  ex2) { MessageBox.Show("Error - Try again!"); txt_v6.Focus(); }


           
            

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_v4.Text = " ";
            txt_v4.ReadOnly = false;
            txt_v4.Focus();
            txt_v6.Text = " ";
            txt_v6.ReadOnly = false;
        }

        private void btn_Read_Display_Click(object sender, EventArgs e)
        {
            string textToPrint = "\tIPv4   \t\t\t\tDate\n";
            string IP, DateT;
            try
            {
                fs = new FileStream(path4, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                while (br.PeekChar() != -1) // not finding the end os stream
                {
                    IP = br.ReadString();
                    DateT = br.ReadString();

                    //if (IP.Length < 12)
                    {
                        textToPrint += IP + "\t\t\t\t" + DateT + "\n";
                    }
                    //else
                    //{
                    //    textToPrint += IP + " \t\t\t" + DateT + "\n";
                    //}
                }
                MessageBox.Show(textToPrint);
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }

            finally { if (fs != null) fs.Close(); }

            textToPrint = "\tIPv6   \t\t\t\tDate\n";

            try
            {
                fs = new FileStream(path6, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                while (br.PeekChar() != -1) // not finding the end os stream
                {
                    IP = br.ReadString();
                    DateT = br.ReadString();

                    //if (IP.Length < 12)
                    {
                        textToPrint += IP + "\t\t\t" + DateT + "\n";
                    }
                    //else
                    //{
                    //    textToPrint += IP + " \t\t\t" + DateT + "\n";
                    //}
                }
                MessageBox.Show(textToPrint);
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }

            finally { if (fs != null) fs.Close(); }
        }

        private void btn_ExitValidator_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit 'IP Validator'?", "Exit", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                this.Close();
            }

        }
                
        private void label_Date_Click(object sender, EventArgs e)
        {
            //DateTime date = DateTime.Now;
            //string Date = date.ToShortDateString();
            // label_Date.Text = Date.ToString();
            // label_Date.Text = Date.ToString();

            
        }

        private void IP_Validator_Load(object sender, EventArgs e)
        {

            //var finaldate = new DateTime(2021, 3, 20, 10, 45, 10);
            //CultureInfo idioma = new CultureInfo("en-US");
            //label_Date.Text = finaldate.ToString("dddd, dd MMMM yyyy", idioma);

            label_Date.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label_Date.Text = DateTime.Today.ToLongDateString();  
            //timer1.Start();
        }

    }
}//end namespace
