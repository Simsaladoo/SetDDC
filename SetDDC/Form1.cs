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

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initial Load -=- read the current DDC envionroment path if it exists
            
            IDictionary environmentVariables = System.Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry de in environmentVariables)
            {
               
                richTextBox1.Text += Environment.NewLine + "Key: " + de.Key + " Value: " + de.Value;

            }

              
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strCmdText = ("SystemPropertiesAdvanced.exe");
            System.Diagnostics.Process.Start(strCmdText);
            
            
        }
    }
    
}
