using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace SetDDC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        //startup
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
            richTextBox1.Text += "Started...";
            richTextBox1.Text += Environment.NewLine + "Choose wisely";


        }



        private void button3_Click(object sender, EventArgs e)
        {
            // set local ddc (removes any ue4 varialbes

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // set shared ddc
            //should prompt for DDC location




        }

        private void button5_Click(object sender, EventArgs e)
        {
            // read variables
            richTextBox1.Text += Environment.NewLine + "Reading Environment Variables...";
            ReadEnv();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // refresh? i dunno
            richTextBox1.Clear();
            richTextBox1.Focus();
            richTextBox1.Text += "Refreshed...";

        }


        // manually open the system properties window so user can edit/check variables
        private void button4_Click(object sender, EventArgs e)
        {
            string strCmdText = ("SystemPropertiesAdvanced.exe");
            System.Diagnostics.Process.Start(strCmdText);

        }





        // Reads back all the current varialbes
        public void ReadEnv ()
        {
            // Initial Load -=- read the current DDC envionroment path if it exists

            IDictionary environmentVariables = System.Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry de in environmentVariables)
            {

                //richTextBox1.Text += Environment.NewLine + "Key: " + de.Key + " Value: " + de.Value;
                string UE4CheckValue = de.Key.ToString();
                if (UE4CheckValue == "UE-SharedDataCachePath")
                {
                    richTextBox1.Text += Environment.NewLine + "Found an Unreal DDC environment:";
                    richTextBox1.Text += Environment.NewLine + "Key: " + de.Key;
                    richTextBox1.Text += Environment.NewLine + "Value: " + de.Value;
                    Console.WriteLine("End of entry");
                }
                else
                {
                    //richTextBox1.Text += Environment.NewLine + "Key: " + de.Key + " Value: " + de.Value;
                    Console.WriteLine("End of entry");
                }

            }
        }


        
    }
    
}
