using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jesca_2._0
{
    public partial class Form1 : Form
    {

    
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            this.MaximizeBox = false;

            comboBox1.Items.Add("30 Minutes");
            comboBox1.Items.Add("45 Minutes");
            comboBox1.Items.Add("1 Hour");
            comboBox1.Items.Add("1H and 30Min ");
            comboBox1.Items.Add("1H and 45Min");
            comboBox1.Items.Add("2 Hours");
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/a");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex) {

                case 0:
                    System.Diagnostics.Process.Start("shutdown", "/s /t 1800");                  
                    break;

                case 1:
                    System.Diagnostics.Process.Start("shutdown", "/s /t 2700");
                    break;

                case 2:
                    System.Diagnostics.Process.Start("shutdown", "/s /t 3600");
                    break;

                case 3:
                    System.Diagnostics.Process.Start("shutdown", "/s /t 5400");
                    break;

                case 4:
                    System.Diagnostics.Process.Start("shutdown", "/s /t 6300");
                    break;

                case 5:
                    System.Diagnostics.Process.Start("shutdown", "/s /t 7200");
                    break;

            }
            {


            }



        }
        
        }
    }

         


            
        

     


