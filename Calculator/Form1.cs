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
        String operation = "";
        
        double result = 0;
        bool isOperation = false;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btnNumberClick = (Button)sender;
            if (isOperation)
            {
                txtResult.Text = "";
            }
            isOperation = false;
            txtResult.Text = txtResult.Text + btnNumberClick.Text;


        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            switch (operation)
            {
                case "+":
                    
                    txtResult.Text = (result + double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (result - double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (result * double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (result / double.Parse(txtResult.Text)).ToString();
                    break;


            }
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            result = double.Parse(txtResult.Text);
            txtResult.Text = txtResult.Text + operation;
            isOperation = true;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            result = 0;
            txtResult.Text = "";
            isOperation = false;
        }
    }
}
