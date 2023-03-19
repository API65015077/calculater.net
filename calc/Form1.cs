using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if((display.Text == "0") || (operation_pressed)) 
            { 
                display.Clear();
                operation_pressed = false;
            }
            Button b = (Button)sender;
            display.Text = display.Text + b.Text;
        }

        private void op_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value  = Double.Parse(display.Text);
            operation_pressed = true;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button20_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    display.Text = (value + Double.Parse(display.Text)).ToString();
                    break;
                case "-":
                    display.Text = (value - Double.Parse(display.Text)).ToString();
                    break;
                case "*":
                    display.Text = (value * Double.Parse(display.Text)).ToString();
                    break;
                case "/":
                    display.Text = (value / Double.Parse(display.Text)).ToString();
                    break;
            }
            operation_pressed = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            display.Clear();
            display.Text = "0";
            value = 0;
        }
    }
}
