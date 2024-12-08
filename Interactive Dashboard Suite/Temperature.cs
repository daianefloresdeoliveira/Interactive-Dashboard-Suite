using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

// Name: Flores de Oliveira, Daiane
// Date: 25/07/2023
// Description: Section 3 - Final Project - Temperature Conversion.

namespace FinalProject
{
    public partial class Temperature : Form
    {
        private DateTime loginTime;
        static string dir = @".\Files\";
        string path = dir + " TempConversions.txt";
        FileStream fs = null;
        Regex ObjTemp;

        public Temperature()
        {
            InitializeComponent();
            loginTime = DateTime.Now;  // to record the time since form is initialized
        }        
        private void btn_Convert_Click(object sender, EventArgs e)
        {

            double celsius=0, fahrenheit=0;
            ObjTemp = new Regex(@"^-?\d+(\.\d+)?$");
            
            if (ObjTemp.IsMatch(textBox1.Text) == true)
            {
            if (radio_C_F.Checked == true)//rb1.Checked   for convertion celsius to fahrenheit
                {
                    radio_F_C.Checked = false;
                    textBox1.ForeColor = Color.Black;
                    textBox1.ReadOnly = false;
                    label_TempTo.Text = "C";
                    textBox2.ReadOnly = true;
                    label_TempConv.Text = "F";
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Regular);
                    celsius = ((Convert.ToDouble(textBox1.Text) * 1.8)) + 32;
                    textBox2.Text = (celsius.ToString()); 
                    Messages();
                }
                else if (radio_F_C.Checked == true)//rb2.Checked      for convertion fahrenheit to celsius
                {
                    radio_C_F.Checked = false;
                    textBox1.ForeColor = Color.Black;
                    textBox1.ReadOnly = false;
                    label_TempTo.Text = "F";
                    textBox2.ReadOnly = true;
                    label_TempConv.Text = "C";
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Regular);
                    fahrenheit = ((Convert.ToDouble(textBox1.Text) - 32) / 1.8);
                    textBox2.Text = (fahrenheit.ToString());
                    Messages();
                }

                // CREATE TXT
                DateTime d = DateTime.Now;

                try
                {
                    fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                    StreamWriter textOut = new StreamWriter(fs);
                    textOut.Write(textBox1.Text + " " + label_TempTo.Text + "=" + textBox2.Text + "   " + label_TempConv.Text + "   ,\t" + d.ToShortDateString() + "    " + d.ToShortTimeString() +"\t"+ text_msn.Text+"\n");
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
            }             
        }

        private void btn_ReadFile_Click(object sender, EventArgs e)
        {  
            // READ TXT
            string textToPrint = "Temperatures,\t Date ,\t\tTime ,\t\t Messages\n";
            string input, tempConvert, messages;
            
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader br = new StreamReader(fs);
                while (br.Peek() != -1) //not finding the end of stream
                {
                    input = br.ReadLine();
                    tempConvert = br.ReadLine();
                    messages = br.ReadLine();
                    textToPrint += input + "\t\t" + tempConvert + ", " + messages+"\n";
                }
                MessageBox.Show(textToPrint);
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }

        public void Messages()
        {
            if(radio_C_F.Checked == true)
            {
                if (textBox1.Text == "100")
                {
                    text_msn.Text = "";
                    textBox1.ForeColor = Color.Red;
                    text_msn.Text = "Water Boils";
                    

                }
                else if (textBox1.Text == "40")
                {
                    text_msn.Text = "";
                    textBox1.ForeColor = Color.Red;
                    text_msn.Text = "Hot Bath";
                   
                }
                else if (textBox1.Text == "37")
                {
                    text_msn.Text = "";
                    textBox1.ForeColor = Color.DarkOrange;
                    text_msn.Text = "Body temperature";
                    
                }
                else if (textBox1.Text == "30")
                {
                    text_msn.Text = "";
                    textBox1.ForeColor = Color.DarkOrange;
                    text_msn.Text = "Beach weather";
                }
                else if (textBox1.Text == "21")
                {
                    text_msn.Text = "";
                    textBox1.ForeColor = Color.Green;
                    text_msn.Text = "Room temperature";
                }
                else if (textBox1.Text == "10")
                {
                    text_msn.Text = "";
                    textBox1.ForeColor = Color.Blue;
                    text_msn.Text = "Cool Day";
                }
                else if (textBox1.Text == "0")
                {
                    text_msn.Text = "";
                    textBox1.ForeColor = Color.Blue;
                    text_msn.Text = "Freezing point of water";
                }
                else if (textBox1.Text == "-18")
                {
                    text_msn.Text = "";
                    textBox1.ForeColor = Color.Black;
                    textBox2.Text = "0";
                    text_msn.Text = "Very Cold Day";
                }
                else if (textBox1.Text == "-40")
                {
                    text_msn.Text = "";
                    textBox1.ForeColor = Color.Black;
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Bold);
                    text_msn.Text = "Extremely Cold Day - (and the same number!)";
                }
                else
                {
                    text_msn.Text = "";
                    if (Convert.ToDouble(textBox1.Text)>= 40)
                    {
                        textBox1.ForeColor = Color.Red;
                        textBox2.ForeColor = Color.Red;                        
                    }
                    else if (Convert.ToDouble(textBox1.Text) >= 28 && Convert.ToDouble(textBox1.Text) < 40)
                    {
                        textBox1.ForeColor = Color.DarkOrange;
                        textBox2.ForeColor= Color.DarkOrange;                        
                    }
                    else if (Convert.ToDouble(textBox1.Text) >= 11 && Convert.ToDouble(textBox1.Text) < 28)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox2.ForeColor = Color.Green;                       
                    }
                    else if (Convert.ToDouble(textBox1.Text) >= 0 && Convert.ToDouble(textBox1.Text) < 11)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox2.ForeColor = Color.Blue;                        
                    }
                    else
                    {
                        Clear();
                        textBox1.ForeColor = Color.Black;
                        textBox2.ForeColor = Color.Black;                        
                        text_msn.Text = "";
                    }                   
                }
            }
            if(radio_F_C.Checked == true) 
            {
                if (textBox1.Text == "212")
                {
                    text_msn.Text = "";
                    textBox1.ForeColor = Color.Red;
                    text_msn.Text = "Water Boils";
                    
                }
                else if (textBox1.Text == "104")
                {
                    text_msn.Text = "";
                    textBox1.ForeColor = Color.Red;
                    text_msn.Text = "Hot Bath";
                }
                else if (textBox1.Text == "98.6")
                {
                    text_msn.Text = ""; 
                    textBox1.ForeColor = Color.DarkOrange;
                    text_msn.Text = "Body temperature";
                }
                else if (textBox1.Text == "86")
                {
                    text_msn.Text = ""; 
                    textBox1.ForeColor = Color.DarkOrange;
                    text_msn.Text = "Beach weather";
                }
                else if (textBox1.Text == "70")
                {
                    text_msn.Text = ""; 
                    textBox1.ForeColor = Color.Green;
                    text_msn.Text = "Room temperature";
                }
                else if (textBox1.Text == "50")
                {
                    text_msn.Text = ""; 
                    textBox1.ForeColor = Color.Blue;
                    text_msn.Text = "Cool Day";
                }
                else if (textBox1.Text == "32")
                {
                    text_msn.Text = ""; 
                    textBox1.ForeColor = Color.Blue;
                    text_msn.Text = "Freezing point of water";
                }
                else if (textBox1.Text == "0")
                {
                    text_msn.Text = "";
                    textBox1.ForeColor = Color.Black;
                    text_msn.Text = "Very Cold Day";
                }
                else if (textBox1.Text == "-40")
                {
                    text_msn.Text = ""; textBox1.ForeColor = Color.Black;
                    textBox2.ForeColor = Color.Black;
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Bold);
                    text_msn.Text = "Extremely Cold Day - (and the same number!)";
                }
                else
                {
                    text_msn.Text = "";
                    if (Convert.ToDouble(textBox1.Text) >= 104)
                    {
                        textBox1.ForeColor = Color.Red;
                        textBox2.ForeColor = Color.Red;                        
                    }
                    else if (Convert.ToDouble(textBox1.Text) >= 82.4 && Convert.ToDouble(textBox1.Text) < 104)
                    {
                        textBox1.ForeColor = Color.DarkOrange;
                        textBox2.ForeColor = Color.DarkOrange;                        
                    }
                    else if (Convert.ToDouble(textBox1.Text) >= 51.8 && Convert.ToDouble(textBox1.Text) < 82.4)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox2.ForeColor = Color.Green;                        
                    }
                    else if (Convert.ToDouble(textBox1.Text) >= 32 && Convert.ToDouble(textBox1.Text) < 51.8)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox2.ForeColor = Color.Blue;                        
                    }
                    else
                    {
                        Clear();
                        textBox1.ForeColor = Color.Black;
                        textBox2.ForeColor = Color.Black;
                        text_msn.Text = "";
                    }
                }
            }
        }

        public void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            text_msn.Text = "";
            textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
            textBox2.Font = new Font(textBox2.Font, FontStyle.Regular);
        }

        private void Temperature_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
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
    }// end class

}// end namespace
