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
//Name: Flores de Oliveira, Daiane
//Date: 17/07/2023
//Description: Section 2 - Final Project - Lotto 649

namespace FinalProject
{
    public partial class frm649 : Form
    {
        DialogResult iExit;
        
        public frm649()
        {
            InitializeComponent();
        }

        static string dir = @".\Files\";
        string path = dir + "LottoNbrs.txt";
        FileStream fs = null;

        private void frm649_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        private void btn_createNumbers_Click(object sender, EventArgs e)
        {
            Random random = new Random();


            string randomNumbersExtra = "";
            string randomNumbersLotto = "";


            //EXTRA NUMBERS
            int[] arrayExtra = new int[7];
            for (int i = 0; i < arrayExtra.Length; i++)
            {
                randomNumbersExtra = randomNumbersExtra + random.Next(0, 9);
                Label_7digits.Text = randomNumbersExtra;
            }

            // LOTO649
            int[] numbers = new int[7];
            string bonus="";

            for (int i = 0; i < 6; i++)
            {
                bool alreadyExist = false;
                do
                {
                    numbers[i] = random.Next(1, 50); //1-49

                    for (int x = 0; x < i; x++)
                    {
                        if (numbers[x] == numbers[i])
                            alreadyExist = true;
                    }

                    numbers[6] = random.Next(1, 50);   // generate bonus number (1-49)

                    for(int y = 0; y<1; y++)           // verify bonus number
                    {
                        if (numbers[6] == numbers[i])
                            alreadyExist = true;
                    }

                } while (alreadyExist);

                randomNumbersLotto = randomNumbersLotto + Convert.ToString(numbers[i]) + "      ";

                //numbers[6] = random.Next(1, 50);

               bonus = " " + Convert.ToString(numbers[6]);

            }

            Label_6numbers.Text = randomNumbersLotto; // 6 numbers
            label2.Text =  bonus; // for the bonus numbers     
        }
        
        private void btn_Read_Display_Click(object sender, EventArgs e)
        {
            // CREATE TXT
            DateTime d = DateTime.Now;
                        
            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs);
                textOut.Write("LOTTO, " + " " + d.ToShortDateString() + " " + d.ToShortTimeString()+ ",    " + Label_6numbers.Text + "  " + "Bonus" +" "+ label2.Text + "  " + "Extra" + Label_7digits.Text + "\n");
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
            string textToPrint = "Lotto, \tDate, \tTime, \tUnique Numbers, \tBonus, \tExtra \n";
            string Lotto, Dated, DateT, Gen_numbers, Extratxt, Extra_num, bonus; 
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader br = new StreamReader(fs);
                while (br.Peek() != -1) //not finding the end of stream
                {
                    Lotto = br.ReadLine();
                    Dated = br.ReadLine();
                    DateT = br.ReadLine();
                    Gen_numbers = br.ReadLine();
                    Extratxt = br.ReadLine();
                    Extra_num = br.ReadLine();
                    bonus = br.ReadLine();
                    textToPrint += "\n"+ Lotto + "\t\t" + Dated + ",\t\t" + DateT + ",\t\t" + Gen_numbers +",\t\t" + "Bonus" + bonus + "  " + Extratxt + ",  \t\t" + Extra_num + "\n";
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
    }// end class
} // end namespace
