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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="") memory = double.Parse(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") memory += double.Parse(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
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
            firstInput = double.Parse(textBox1.Text);
            textBox1.Clear();

            plusPressed = false;
            minusPressed = false;
            multiplyPressed = false;
            dividePressed = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstInput = double.Parse(textBox1.Text);
            textBox1.Clear();

            plusPressed = false;
            minusPressed = false;
            multiplyPressed = true;
            dividePressed = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button14.Text;
        }
        
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstInput = double.Parse(textBox1.Text);
            textBox1.Clear();

            plusPressed = false;
            minusPressed = true;
            multiplyPressed = false;
            dividePressed = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button18.Text;
        }

        private void button19_Click(object sender, EventArgs e)
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

        private void button20_Click(object sender, EventArgs e)
        {
            firstInput = double.Parse(textBox1.Text);
            textBox1.Clear();

            plusPressed = true;
            minusPressed = false;
            multiplyPressed = false;
            dividePressed = false;
        }

    }
}
