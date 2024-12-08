using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//Name: Flores de Oliveira, Daiane
//Date: 17/07/2023
//Description: Section 2 - Final Project - Simple Calculator

namespace FinalProject
{
    public partial class Simple_Calculator : Form
    {
        public Simple_Calculator()
        {
            InitializeComponent();
        }      

        Calc calc = new Calc(0,0,null);
        
        static string dir = @".\Files\";
        string path = dir + "Calculator.txt";
        FileStream fs = null;

        private void Simple_Calculator_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
        private void btn_num1_Click(object sender, EventArgs e)
        {
            if(txt_Operation.Text == "0" && txt_Operation.Text != null)
            {
                txt_Operation.Text = "1";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
            else
            {
                txt_Operation.Text += "1";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                    
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
               
        }
        private void btn_num2_Click(object sender, EventArgs e) 
        {
            
            if (txt_Operation.Text == "0" && txt_Operation.Text != null)
            {
                txt_Operation.Text = "2";
                if (calc.Op != null)
                    {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                    
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
            else
            {
                txt_Operation.Text += "2";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                    
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);

            }
        }
        private void btn_num3_Click(object sender, EventArgs e)
        {
            if (txt_Operation.Text == "0" && txt_Operation.Text != null)
            {
                txt_Operation.Text = "3";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                    
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
            else
            {
                txt_Operation.Text += "3";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                   
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
        }
        private void btn_num4_Click(object sender, EventArgs e)
        {
            if (txt_Operation.Text == "0" && txt_Operation.Text != null)
            {
                txt_Operation.Text = "4";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                   
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
            else
            {
                txt_Operation.Text += "4";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                    
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
        }
        private void btn_num5_Click(object sender, EventArgs e)
        {
            if (txt_Operation.Text == "0" && txt_Operation.Text != null)
            {
                txt_Operation.Text = "5";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                    
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
            else
            {
                txt_Operation.Text += "5";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                    
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
        }
        private void btn_num6_Click(object sender, EventArgs e)
        {
            if (txt_Operation.Text == "0" && txt_Operation.Text != null)
            {
                txt_Operation.Text = "6";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                   
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
            else
            {
                txt_Operation.Text += "6";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                  
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
        }
        private void btn_num7_Click(object sender, EventArgs e)
        {
            if (txt_Operation.Text == "0" && txt_Operation.Text != null)
            {
                txt_Operation.Text = "7";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                    
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
            else
            {
                txt_Operation.Text += "7";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                    
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
        }
        private void btn_num8_Click(object sender, EventArgs e)
        {
            if (txt_Operation.Text == "0" && txt_Operation.Text != null)
            {
                txt_Operation.Text = "8";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                    
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
            else
            {
                txt_Operation.Text += "8";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                    
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
        }
        private void btn_num9_Click(object sender, EventArgs e)
        {
            if (txt_Operation.Text == "0" && txt_Operation.Text != null)
            {
                txt_Operation.Text = "9";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                   
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
            else
            {
                txt_Operation.Text += "9";
                if (calc.Op != null)
                {
                    calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                    
                }
                else
                    calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
            }
        }
        private void btn_num0_Click(object sender, EventArgs e)
        {
            txt_Operation.Text += "0";
            if (calc.Op != null)
            {
                calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);                
            }
            else
                calc.Operand1 = Convert.ToDecimal(txt_Operation.Text);
        }
            
        
        private void btn_EndPoint_Click(object sender, EventArgs e)
        {
            txt_Operation.Text = txt_Operation.Text + ",";
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            txt_Operation.Text = "+";
            calc.Op = txt_Operation.Text; // save the signal +
            txt_Operation.Text = "";           
        }

        private void btn_Subt_Click(object sender, EventArgs e)
        {
            txt_Operation.Text = "-";
            calc.Op = txt_Operation.Text;     // save the signal -
            txt_Operation.Text = "";          
        }

        private void btn_Mul_Click(object sender, EventArgs e)
        {
            txt_Operation.Text = "*";
            calc.Op = txt_Operation.Text;     // save the signal *
            txt_Operation.Text = "";           
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            txt_Operation.Text = "/";
            calc.Op = txt_Operation.Text;
            txt_Operation.Text = "";           
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            bool flag = false;
            
            calc.Operand2 = Convert.ToDecimal(txt_Operation.Text);

            if (calc.Op == "/")
            {
                calc.Equals();
                if (calc.Operand2 == 0 && calc.Result == 99999999999)
                {
                    txt_Operation.Text = "Warning: Operand2 = 0";
                    txt_Result.Text = "Cannot divide by zero";                    
                }
                else
                {
                    //calc.Equals();
                    txt_Operation.Text = Convert.ToString(calc.Operand1) + "/" + Convert.ToString(calc.Operand2);
                    txt_Result.Text = Convert.ToString(calc.Result);
                    flag = true;
                }
            }
            // Equals();
            // decimal result;
            // //decimal operand2;
            //txt_Operation.Text = calc.Equals_Operation();
            if(!flag)
            {
                calc.Equals();                

                if (calc.Op == "+")
                {
                    //     //result = operand1 + operand2;
                    txt_Operation.Text = calc.Operand1 + "+" + calc.Operand2;
                    txt_Result.Text = Convert.ToString(calc.Result);
                }

                if (calc.Op == "-")
                {
                    //     //result = operand1 - operand2;
                    txt_Operation.Text = calc.Operand1 + "-" + calc.Operand2;
                    txt_Result.Text = Convert.ToString(calc.Result);
                }

                if (calc.Op == "*")
                {
                    //     //result = operand1 * operand2;
                    txt_Operation.Text = calc.Operand1 + "*" + calc.Operand2;
                    txt_Result.Text = Convert.ToString(calc.Result);
                }
            }

            try 
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs);
                textOut.Write("\n" + txt_Operation.Text + "=" + txt_Result.Text);
                textOut.Close();
                MessageBox.Show("Operations saved in the text file!");               
            }
            catch    (FileNotFoundException) 
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            calc.Clear();
            txt_Operation.Text = "";
            Focus();
            txt_Result.Text = "";
        }

        private void btn_Ext_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Do you want to quit?", "Please confirm to exit:", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                Close();
            }
        }
    } // end classe
} // end namespace
