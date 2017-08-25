using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operationPerform = "";
        bool isOperationPerform = false;
        bool isDotPerform = false;
        bool isOperationClick = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (isOperationClick == true )
            {
                isOperationClick = false;
                textBox.Clear();
            }
            Button button = (Button)sender;
            textBox.Text = textBox.Text + button.Text; 
           
        }

        

        
        private void operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            isOperationClick = true;
            isDotPerform = false;
            if (isOperationPerform == true && textBox.Text!="")
            {
                if (button.Text == "%" && (operationPerform == "+" || operationPerform == "-"))
                {
                    textBox.Text = (result + Double.Parse(textBox.Text)).ToString();
                    result = Double.Parse(textBox.Text);
                    //result = (((result * (Double.Parse(textBox.Text))) / 100) + result);
                    
                    isOperationPerform = false;
                    
                }
                else
                {
                    switch (operationPerform)
                    {
                        case "+":
                            textBox.Text = (result + Double.Parse(textBox.Text)).ToString();
                            result = Double.Parse(textBox.Text);
                            break;
                        case "-":
                            textBox.Text = (result - Double.Parse(textBox.Text)).ToString();
                            result = Double.Parse(textBox.Text);
                            break;
                        case "*":
                            textBox.Text = (result * Double.Parse(textBox.Text)).ToString();
                            result = Double.Parse(textBox.Text);
                            break;
                        case "/":
                            if (textBox.Text == "0")
                            {
                                textBox.Text = "Error";
                            }
                            else
                            {
                                textBox.Text = (result / Double.Parse(textBox.Text)).ToString();
                                result = Double.Parse(textBox.Text);
                            }
                            break;

                        default:
                            break;

                    }
                    
                    operationPerform = button.Text;
                }
                



            }
            else
            {
               
                operationPerform = button.Text;
                isOperationPerform = true;
          
                result = Double.Parse(textBox.Text);
                
            }

        }

        private void equal_Click(object sender, EventArgs e)
        {
            //if(isOperationPerform == false )
            //{
            //    textBox.Text = result.ToString();
            //}
            isDotPerform = false;
            switch (operationPerform)
            {
                case "+":
                    textBox.Text = (result + Double.Parse(textBox.Text)).ToString();
                    result = Double.Parse(textBox.Text);
                    isOperationPerform = false;
                    break;
                case "-":
                    textBox.Text = (result - Double.Parse(textBox.Text)).ToString();
                    result = Double.Parse(textBox.Text);
                    isOperationPerform = false;
                    break;
                case "*":
                    textBox.Text = (result * Double.Parse(textBox.Text)).ToString();
                    result = Double.Parse(textBox.Text);
                    isOperationPerform = false;
                    break;
                case "/":
                    if (textBox.Text == "0")
                    {
                        textBox.Text = "Error";
                    }
                    else
                    {
                        textBox.Text = (result / Double.Parse(textBox.Text)).ToString();
                        result = Double.Parse(textBox.Text);
                        isOperationPerform = false;
                    }
                    break;
                case "%":
                    textBox.Text = (result / 100).ToString();
                    result = Double.Parse(textBox.Text);
                    isOperationPerform = false;
                    break;
                default:
                    break;
                    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void c_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            result = 0;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (isDotPerform == false && textBox.Text != "")
            {
                textBox.Text = textBox.Text + ".";
                isDotPerform = true;
            }
        }
    }
}
