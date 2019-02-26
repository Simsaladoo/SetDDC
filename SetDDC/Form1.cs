using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Text;
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

        PrivateFontCollection privateFontCollection = new PrivateFontCollection();

        



        public string envName = ("UE-SharedDataCachePath");
        public string envValue = (@"Z:\training\UnrealEngine\GeneralDDC");
        public bool hasENV = false;


        //startup
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
            richTextBox1.Text += "Startup";
            richTextBox1.Text += Environment.NewLine + "Reading environment variables...";
            ReadEnv();

        }



        private void button3_Click(object sender, EventArgs e)
        {
            // set local ddc (removes any ue4 varialbes)
            if (hasENV == true)
            {
                Environment.SetEnvironmentVariable(envName, null, EnvironmentVariableTarget.Machine);
                richTextBox1.Text += Environment.NewLine + "Environment Variable for Unreal Removed!";
            }

            else
            {
                // do nothing
                richTextBox1.Text += Environment.NewLine + "No valid Environment Variables to remove";
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // set shared ddc
            //should prompt for DDC location

            Environment.SetEnvironmentVariable(envName, envValue, EnvironmentVariableTarget.Machine);
            richTextBox1.Text += Environment.NewLine + "UE-SharedDataCachePath Environment Variable set!";
            ReadEnv();





        }

        private void button5_Click(object sender, EventArgs e)
        {
            // read variables
            richTextBox1.Text += Environment.NewLine + "Reading Environment Variables...";
            ReadEnv();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // refresh to clear the text box
            richTextBox1.Clear();
            richTextBox1.Focus();
            richTextBox1.Text += "Refreshing";
            RestartApp();

        }


        // manually open the system properties window so user can edit/check variables
        private void button4_Click(object sender, EventArgs e)
        {
            string strCmdText = ("SystemPropertiesAdvanced.exe");
            System.Diagnostics.Process.Start(strCmdText);

        }





        // Reads back all the current varialbes
        public void ReadEnv()
        {
            // Initial Load -=- read the current DDC envionroment path if it exists

            IDictionary environmentVariables = System.Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry de in environmentVariables)
            {

                //richTextBox1.Text += Environment.NewLine + "Key: " + de.Key + " Value: " + de.Value;
                string UE4CheckValue = de.Key.ToString();
                if (UE4CheckValue == "UE-SharedDataCachePath")
                {
                    richTextBox1.Text += Environment.NewLine + "Key: " + de.Key;
                    richTextBox1.Text += Environment.NewLine + "Value: " + de.Value;
                    Console.WriteLine("End of entry");
                    hasENV = true;
                }
                else
                {
                    //for every other entry that does NOT equal UE-SharedDataCachePath -- do nothing
                }

            }

            if (hasENV == true)
            {
                richTextBox1.Text += Environment.NewLine + "Found an Unreal DDC environment";
            }

            if (hasENV == false)
            {
                richTextBox1.Text += Environment.NewLine + "No Unreal Environment Variables found!";
            }

            Console.WriteLine("Finished Operation");

        }




        public void RestartApp()
        {
            //System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
            //this.Close(); //to turn off current app

            Application.Restart();
            Environment.Exit(0);
        }

    }
    
}
