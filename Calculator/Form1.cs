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
    public partial class Calculator : Form
    {
        double firstInput = 0;
        double secondInput = 0;

        double memory = 0;

        bool plusPressed = false;
        bool minusPressed = false;
        bool multiplyPressed = false;
        bool dividePressed = false; 

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
  

        private void buttonM_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="") memory = double.Parse(textBox1.Text);
        }

        private void buttonMP_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") memory += double.Parse(textBox1.Text);
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
        }


        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button0.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + buttonPoint.Text;
        }


        private void buttonDivide_Click(object sender, EventArgs e)
        {
            firstInput = double.Parse(textBox1.Text);
            textBox1.Clear();

            plusPressed = false;
            minusPressed = false;
            multiplyPressed = false;
            dividePressed = true;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            firstInput = double.Parse(textBox1.Text);
            textBox1.Clear();

            plusPressed = false;
            minusPressed = false;
            multiplyPressed = true;
            dividePressed = false;
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            firstInput = double.Parse(textBox1.Text);
            textBox1.Clear();

            plusPressed = false;
            minusPressed = true;
            multiplyPressed = false;
            dividePressed = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            firstInput = double.Parse(textBox1.Text);
            textBox1.Clear();

            plusPressed = true;
            minusPressed = false;
            multiplyPressed = false;
            dividePressed = false;
        }


        private void buttonResult_Click(object sender, EventArgs e)
        {
            secondInput = double.Parse(textBox1.Text);

            if (plusPressed) firstInput += secondInput;
            else if (minusPressed) firstInput -= secondInput;
            else if (multiplyPressed) firstInput *= secondInput;
            else if (dividePressed) firstInput /= secondInput;

            textBox1.Text = firstInput.ToString();
            firstInput = 0;
            secondInput = 0;
        }
    }
}
