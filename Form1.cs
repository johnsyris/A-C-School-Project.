using System;
using System.Windows.Forms;

namespace MyCalc
{
    public partial class Form1 : Form
    {
        double value = 0;
        String operation = "";
        bool operation_pressed = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if((textBox1.Text == "0")||(operation_pressed))
            {
                textBox1.Clear();
            }

            operation_pressed = false;

            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
            label1.Text = "";
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox1.Text);
            operation_pressed = true;
            textBox1.Text = "0";
            label1.Text = value + " " + operation;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            operation_pressed = false;

            switch (operation)
            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    label1.Text = "";
                    break;

                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    label1.Text = "";
                    break;

                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    label1.Text = "";
                    break;

                case "/":
                    if (textBox1.Text != "0")
                    {
                        textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                        label1.Text = "";
                    }
                    else textBox1.Text = "Can't Divide By 0";
                    label1.Text = "";
                    value = 0;
                    break;

                default:
                    break;
            }
            
        }

        
    }
}
