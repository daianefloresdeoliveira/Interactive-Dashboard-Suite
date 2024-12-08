using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
//Name: Flores de Oliveira, Daiane
//Date: 17/07/2023
//Description: Section 2 - Final Project - Lotto MAX

namespace FinalProject
{
    public partial class frmMax : Form
    {
        DialogResult iExit;
        
        public frmMax()
        {
            InitializeComponent();
        }

        static string dir = @".\Files\";
        string path = dir + "LottoNbrs.txt";
        FileStream fs = null;

        private void frmMax_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        private void btn_createNumbers_Click(object sender, EventArgs e)
        {
            Random random = new Random();
                        
            
            string randomNumbersExtra = "";
            string randomNumbersMax = "";


            //EXTRA NUMBERS
            int[] arrayExtra = new int[7];
            for (int i = 0; i < arrayExtra.Length; i++)
            {
                randomNumbersExtra = randomNumbersExtra + random.Next(0, 9);
                Label7digits.Text = randomNumbersExtra;
            }


            // LOTOMAX
            int[] numbers = new int[8];
            string bonus = "";

            for (int i = 0; i < 7; i++)
            {
                bool alreadyExist = false;
                do
                {
                    numbers[i] = random.Next(1, 51); //1-50

                    for (int x = 0; x < i; x++)
                    {
                        if (numbers[x] == numbers[i])
                            alreadyExist = true;
                    }

                    numbers[7] = random.Next(1, 51);   // generate bonus number (1-50)

                    for (int y = 0; y < 1; y++)           // verify bonus number
                    {
                        if (numbers[7] == numbers[i])
                            alreadyExist = true;
                    }

                } while (alreadyExist);

                randomNumbersMax = randomNumbersMax + Convert.ToString(numbers[i]) + "     ";

                //numbers[7] = random.Next(1, 50);

                bonus = " " + Convert.ToString(numbers[7]);               

            }

            Label7numbers.Text = randomNumbersMax;  // 7 numbers
            label3.Text = bonus; // for the bonus number

        }

        private void btn_Read_Display_Click(object sender, EventArgs e)
        {
            // CREATE TXT
            DateTime d = DateTime.Now;

            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs);
                textOut.Write("MAX, " + " " + d.ToShortDateString() + " " + d.ToShortTimeString() + ",    " + Label7numbers.Text + " " + "Bonus" + " " + label3.Text + "  " + "Extra" + Label7digits.Text + "\n");
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
            string textToPrint = "MAX, \tDate, \tTime, \tUnique Numbers, \tBonus, \tExtra \n";
            string Max, Dated, DateT, Gen_numbers, Extratxt, Extra_num, bonus;
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader br = new StreamReader(fs);
                while (br.Peek() != -1) //not finding the end of stream
                {
                    Max = br.ReadLine();
                    Dated = br.ReadLine();                    
                    DateT = br.ReadLine();                    
                    Gen_numbers = br.ReadLine();                    
                    Extratxt = br.ReadLine();                    
                    Extra_num = br.ReadLine();                    
                    bonus = br.ReadLine();                    
                    textToPrint += Max + "\t\t" + Dated + ",\t\t" + DateT + ",\t\t" + Gen_numbers + ",\t" + bonus + "  " + Extratxt + ",  \t\t" + Extra_num + "\n";
                }
                MessageBox.Show(textToPrint);
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }

        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            iExit = MessageBox.Show("Do you want to quit this application?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Close();
            }
        }       
    }//end class
}// end namespace



   
