using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using калькуляторчик.Classes;

namespace калькуляторчик
{
    public partial class Form1 : Form
    {
        static TextBox _textBox;
        public static TextBox TextBox { get=> _textBox; set => _textBox = value; }
        static Label _memory;
        public static Label Memory { get=> _memory; set => _memory = value; }

        static Double _value = 0;
        public static Double Value { get=>_value; set => _value = value; }

        String operation = "";
        Boolean operation_pressed = false;
        public Form1() { 
            InitializeComponent();
            InitVariables();
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            operation = bt.Text;
            _value = Double.Parse(result.Text);
            operation_pressed = true;
            memory.Text = $"{_value} {operation}";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button bt=(Button)sender;
            operation = bt.Text;
            Clavisha2.OperationClick(operation);
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((_textBox.Text == "0") || (operation_pressed))
                _textBox.Clear();
            
            operation_pressed = false;
            Button bt=(Button)sender; 

            if(_textBox.Text.StartsWith("0") && bt.Text != ",")
            {
                if(_textBox.Text.Length > 1 && _textBox.Text[1] != ',')
                {
                    _textBox.Text = _textBox.Text.Remove(0, 1);
                }
            }

            _textBox.Text += bt.Text;

            if(_textBox.Text == ",")
            {
                _textBox.Text = "0,";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            _textBox.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Clavisha.OperationClick(operation);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            _textBox.Clear();
            _value = 0;
        }

        void InitVariables()
        {
            _textBox = result;
            _memory = memory;
        }

    }
}
