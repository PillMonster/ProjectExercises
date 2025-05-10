using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {

        private int count;
   
        public Form1()
        {
            InitializeComponent();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerTime.Interval = 1000;
            timerTime.Start(); // 啟動計時器
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labHelloWorld.Text = "Hello World!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
            timerCount.Interval = 1000;
            timerCount.Start(); // 啟動計時器
    
        }

        private void timerCount_Tick(object sender, EventArgs e)
        {

            string str = count.ToString();
            labCount.Text = str;

            if (count == 10) { 
                timerCount.Stop();
            }
            count++;

        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string formatted = now.ToString("yyyy/MM/dd HH:mm:ss");
            labTime.Text = formatted;
            //Console.WriteLine(formatted);
        }
    }
}
