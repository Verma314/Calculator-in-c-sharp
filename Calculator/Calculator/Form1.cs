using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        int flag = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "/"; double value = double.Parse(textBox1.Text); flag = 1;

     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            textBox1.AppendText("1");
            if ( flag == 1 )
                textBox2.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            textBox1.AppendText("2");
            if (flag == 1)
                textBox2.AppendText("2");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            textBox1.AppendText("3");
            if (flag == 1)
                textBox2.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            textBox1.AppendText("4");
            if (flag == 1)
                textBox2.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            textBox1.AppendText("5");
            if (flag == 1)
                textBox2.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            textBox1.AppendText("6");
            if (flag == 1)
                textBox2.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            textBox1.AppendText("7");
            if (flag == 1)
                textBox2.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            textBox1.AppendText("8");
            if (flag == 1)
                textBox2.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            textBox1.AppendText("9");
            if (flag == 1)
                textBox2.AppendText("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            textBox1.AppendText("0");
            if (flag == 1)
                textBox2.AppendText("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox1.Text);
            label1.Text = "+";
            flag = 1;
       
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox1.Text);
            label1.Text = "-";
            flag = 1;
       
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "*"; double value = double.Parse(textBox1.Text); flag = 1;
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "%"; double value = double.Parse(textBox1.Text); flag = 1;
     
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "^"; double value = double.Parse(textBox1.Text); flag = 1;
         
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            String op = label1.Text;
            double answer = 0;
            if (op == "+")
                answer = num1 + num2;
            if (op == "-")
                answer = num1 - num2;
            if (op == "*")
                answer = num1 * num2;
            if (op == "/")
                answer = num1 / num2;
            if (op == "%")
                answer = Math.Round(num1) / Math.Round(num2);
            if (op == "^")
                answer = Math.Pow(num1, num2);

            label1.Text = "";
            textBox1.Text = answer.ToString();
            textBox2.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            label1.Text = "sin (" + num1 + ")";

            

            double x =  Math.Sin(num1);
            textBox2.Text = x.ToString();
            

        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = ""; flag = 0;
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (flag == 0)
                textBox1.AppendText(".");
            if (flag == 1)
                textBox2.AppendText(".");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            label1.Text = "cos (" + num1 + ")";



            double x = Math.Cos(num1);
            textBox2.Text = x.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            label1.Text = "tan (" + num1 + ")";



            double x = Math.Tan(num1);
            textBox2.Text = x.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            label1.Text = "sec (" + num1 + ")";



            double x = 1 / Math.Cos(num1);
            textBox2.Text = x.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            label1.Text = "tan (" + num1 + ")";



            double x = 1/ Math.Sin(num1);
            textBox2.Text = x.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            label1.Text = "tan (" + num1 + ")";



            double x =1/ Math.Tan(num1);
            textBox2.Text = x.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {

        }
    }
}
