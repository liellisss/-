using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using калькуляторчик;

namespace калькуляторчик.Classes
{
    public class Clavisha
    {
        static public void OperationClick(string _operation)
        {
            Form1.Memory.Text = "";

            switch (_operation)
            {
                case "+":
                    Form1.TextBox.Text = (Form1.Value + Double.Parse(Form1.TextBox.Text)).ToString();
                    break;
                case "-":
                    Form1.TextBox.Text = (Form1.Value - Double.Parse(Form1.TextBox.Text)).ToString();
                    break;
                case "*":
                    Form1.TextBox.Text = (Form1.Value * Double.Parse(Form1.TextBox.Text)).ToString();
                    break;
                case "/":
                    if (Double.Parse(Form1.TextBox.Text) == 0)
                    {
                        MessageBox.Show("На ноль делить плохо!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Form1.TextBox.Text = (Form1.Value / Double.Parse(Form1.TextBox.Text)).ToString();
                    }
                    break;
                case "^":
                    Form1.TextBox.Text = (Math.Pow(Form1.Value, Double.Parse(Form1.TextBox.Text))).ToString();
                    break;
                case "log":
                    Form1.TextBox.Text = (Math.Log(Form1.Value, Double.Parse(Form1.TextBox.Text))).ToString();
                    break;
                default:
                    break;
            }
        }
    }
    public class Clavisha2
    {
        static public void OperationClick(string _operation)
        {

            switch (_operation)
            {
                case "n!":
                    double k = 1;
                    for (int i = 1; i <= Double.Parse(Form1.TextBox.Text); i++)
                        k = k * i;
                    Form1.TextBox.Text = k.ToString();
                    break;
                case "√":
                    Form1.TextBox.Text = (Math.Sqrt(Double.Parse(Form1.TextBox.Text))).ToString();
                    break;
                case "^2":
                    //Console.WriteLine(Form1.Value);
                    Form1.TextBox.Text = (Math.Pow(Double.Parse(Form1.TextBox.Text), 2)).ToString();
                    break;
                case "π":
                    Form1.TextBox.Text = (Math.PI).ToString();
                    break;
                case "1/x":
                    Form1.TextBox.Text = (1 / Double.Parse(Form1.TextBox.Text)).ToString();
                    break;
                case "sin":
                    double angleInDegreesSin = Double.Parse(Form1.TextBox.Text);
                    double angleInRadiansSin = angleInDegreesSin * Math.PI / 180;
                    Form1.TextBox.Text = Math.Sin(angleInRadiansSin).ToString();
                    break;
                case "cos":
                    double angleInDegreesCos = Double.Parse(Form1.TextBox.Text);
                    double angleInRadiansCos = angleInDegreesCos * Math.PI / 180;
                    Form1.TextBox.Text = Math.Cos(angleInRadiansCos).ToString();
                    break;
                case "|x|":
                    Form1.TextBox.Text = Math.Abs(Double.Parse(Form1.TextBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
