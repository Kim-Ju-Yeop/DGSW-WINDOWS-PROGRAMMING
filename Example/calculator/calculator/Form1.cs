using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        StringBuilder previousLabel = new StringBuilder();
        StringBuilder previousLabel2 = new StringBuilder();
        StringBuilder currentSymbol = new StringBuilder();
        StringBuilder endResult = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numberClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (currentSymbol.ToString() == "")
            {
                previousLabel.Append(button.Text);
                label2.Text = previousLabel.ToString();
            }
            else if (currentSymbol.ToString() != "")
            {
                previousLabel2.Append(button.Text);
                label2.Text = previousLabel2.ToString();
            }    
        }

        private void symbolClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "+")
            {
                label1.Text = previousLabel.ToString() + "+";
                label2.Text = "";
                currentSymbol.AppendFormat("+");
            }
            else if (button.Text == "-")
            {
                label1.Text = previousLabel.ToString() + "-";
                label2.Text = "";
                currentSymbol.AppendFormat("-");
            }
            else if (button.Text == "*")
            {
                label1.Text = previousLabel.ToString() + "*";
                label2.Text = "";
                currentSymbol.AppendFormat("*");
            }
            else if (button.Text == "/")
            {
                label1.Text = previousLabel.ToString() + "/";
                label2.Text = "";
                currentSymbol.AppendFormat("/");
            }
            else if (button.Text == "=")
            {
                double result = 0;

                switch (currentSymbol.ToString())
                {
                    case "+":
                        result = double.Parse(previousLabel.ToString()) + double.Parse(previousLabel2.ToString());
                        break;

                    case "-":
                        result = double.Parse(previousLabel.ToString()) - double.Parse(previousLabel2.ToString());
                        break;

                    case "*":
                        result = double.Parse(previousLabel.ToString()) * double.Parse(previousLabel2.ToString());
                        break;

                    case "/":
                        result = double.Parse(previousLabel.ToString()) / double.Parse(previousLabel2.ToString());
                        break;
                }
                label1.Text = previousLabel.ToString() + currentSymbol + previousLabel2.ToString() + " =";
                label2.Text = result.ToString();

                endResult = new StringBuilder(result.ToString());
            }
            else if (button.Text == "C")
            {
                previousLabel.Remove(0, previousLabel.Length);
                previousLabel2.Remove(0, previousLabel2.Length);
                currentSymbol.Remove(0, currentSymbol.Length);

                label1.Text = "";
                label2.Text = "0";
            }
            else
            {
                if (previousLabel.ToString() != "" && previousLabel2.ToString() != ""  && endResult.ToString() != "")
                {
                    endResult = new StringBuilder(endResult.ToString().Substring(0, endResult.Length - 1));

                    if (endResult.ToString() == "")
                    {
                        endResult.Append("0");
                        label2.Text = "0";
                    } 
                    else
                    {
                        label2.Text = endResult.ToString();
                    }
                }
                else if (previousLabel.ToString() != "" && currentSymbol.ToString() == "")
                {
                    previousLabel = new StringBuilder(previousLabel.ToString().Substring(0, previousLabel.Length - 1));
                    
                    if(previousLabel.ToString() == "")
                    {
                        label2.Text = "0";
                    }
                    else
                    {
                        label2.Text = previousLabel.ToString();
                    }
                }
                else if (previousLabel2.ToString() != "" && currentSymbol.ToString() != "")
                {
                    previousLabel2 = new StringBuilder(previousLabel2.ToString().Substring(0, previousLabel2.Length - 1));
                    if (previousLabel2.ToString() == "")
                    {
                        label2.Text = "0";
                    }
                    else
                    {
                        label2.Text = previousLabel2.ToString();
                    }
                }
            }
        }
    }
}
