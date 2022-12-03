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
        private const double RADIANI = 0.0174533;
        private Double result = 0;
        private String operation = "";
        private bool isOperation = false;

        public Form1() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {

        }

        private void onNumClick(object sender, EventArgs e) 
        {
            Button buttonPressed = (Button)sender;
            if (textBox.Text == "0" || isOperation)
                textBox.Clear();
            isOperation = false;
            if (buttonPressed.Text == ",")
            {
                if (!textBox.Text.Contains(","))
                    textBox.Text = textBox.Text + buttonPressed.Text;
            }
            else
                textBox.Text = textBox.Text + buttonPressed.Text;
        }

        private void onBackspaceClick(object sender, EventArgs e) 
        {
            if (textBox.Text.Length == 1)
            {
                textBox.Text = "0";
                return;
            }
            textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1,1);
        }

        private void onSimpleOperation(object sender, EventArgs e) 
        {
            Button buttonPressed = (Button)sender;
            if (result != 0)
            {
                if (operation != "%")
                    butEquals.PerformClick();
            }
            else
                result = Double.Parse(textBox.Text);
            if (buttonPressed.Text == " ")
                operation = "^";
            else
                operation = buttonPressed.Text;
            isOperation = true;
            label.Text = result + " " + operation;
        }
        private void butCE_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void butC_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            result = 0;
            label.Text = "";
        }

        private void butEquals_Click(object sender, EventArgs e)
        {
            Double aux;
            if (textBox.Text.StartsWith("-"))
            {
                String temp = textBox.Text.Remove(0, 1);
                aux = Double.Parse(temp);
                aux = System.Math.Abs(aux) * (-1);
            }
            else
            {
                aux = Double.Parse(textBox.Text);
            }
                
            switch (operation) 
            {
                case "+": 
                    result += aux;
                    break;
                case "-":
                    result -= aux;
                    break;
                case "*":
                    result *= aux;
                    break;
                case "/":
                    result /= aux;
                    break;
                case "%":
                    result = (result / 100) * aux;
                    break;
                case "^":
                    result = Math.Pow(result, aux);
                    break;
                default:
                    break;
            }
            label.Text = "";
            textBox.Text = result.ToString();
        }

        private void buttonPlusMin_Click(object sender, EventArgs e)
        {
            String temp = "-" + textBox.Text;
            textBox.Clear();
            textBox.Text = temp;
        }

        private void butDiv1_Click(object sender, EventArgs e)
        {
            Double aux = Double.Parse(textBox.Text);
            result = 1.0 / aux;
            textBox.Text = result.ToString();
        }

        private void butLn_Click(object sender, EventArgs e)
        {
            Double aux = Double.Parse(textBox.Text);
            result = Math.Log(aux);
            textBox.Text = result.ToString();
        }

        private void butSqrt_Click(object sender, EventArgs e)
        {
            Double aux = Double.Parse(textBox.Text);
            result = Math.Sqrt(aux);
            textBox.Text = result.ToString();
        }

        private void butFact_Click(object sender, EventArgs e)
        {
            Double aux = Double.Parse(textBox.Text);
            double temp = 1;
            while (aux != 1)
            {
                temp *= aux;
                aux--;
            }
            result = temp;
            textBox.Text = result.ToString();
        }

        private void butPow2_Click(object sender, EventArgs e)
        {
            Double aux = Double.Parse(textBox.Text);
            result = Math.Pow(2, aux);
            textBox.Text = result.ToString();
        }

        private void butEPow_Click(object sender, EventArgs e)
        {
            Double aux = Double.Parse(textBox.Text);
            result = Math.Exp(aux);
            textBox.Text = result.ToString();
        }

        private void butSin_Click(object sender, EventArgs e)
        {
            Double aux = Double.Parse(textBox.Text);
            aux = aux * RADIANI;
            result = Math.Sin(aux);
            textBox.Text = result.ToString();
        }

        private void butCos_Click(object sender, EventArgs e)
        {
            Double aux = Double.Parse(textBox.Text);
            aux = aux * RADIANI;
            result = Math.Cos(aux);
            textBox.Text = result.ToString();
        }

        private void butTan_Click(object sender, EventArgs e)
        {
            Double aux = Double.Parse(textBox.Text);
            aux = aux * RADIANI;
            result = Math.Tan(aux);
            textBox.Text = result.ToString();
        }

        private void butCTG_Click(object sender, EventArgs e)
        {
            Double aux = Double.Parse(textBox.Text);
            aux = aux * RADIANI;
            result = 1.0 / Math.Tan(aux);
            textBox.Text = result.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Basic Calculator" +
                "@Andrei-Nicolae Calutiu" +
                "ULB Sibiu");
        }
    }
}
