using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Keyboard___cSharp
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            //txtDisplay.Text = "0";
            //txtMemory.Text = "";
            //txtOperation.Text = "";
            btnClear.PerformClick();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string digit = btn.Text;
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtMemory.Text = "";
            txtOperation.Text = "";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0.";
            }
            else
            {
                if (txtDisplay.Text.Contains(".") == false) txtDisplay.Text += ".";
            }
        }

        private void mathOperation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string mathOp = btn.Text;
            if (txtOperation.Text == "")
            {
                txtMemory.Text = txtDisplay.Text;
                txtOperation.Text = mathOp;
                txtDisplay.Text = "0";
            }
            else
            {
                switch (txtOperation.Text)
                {
                    case "+":
                        txtMemory.Text = Convert.ToString(double.Parse(txtMemory.Text) + double.Parse(txtDisplay.Text));
                        break;
                    case "-":
                        txtMemory.Text = Convert.ToString(double.Parse(txtMemory.Text) - double.Parse(txtDisplay.Text));
                        break;
                    case "X":
                        txtMemory.Text = Convert.ToString(double.Parse(txtMemory.Text) * double.Parse(txtDisplay.Text));
                        break;
                    case "/":
                        txtMemory.Text = Convert.ToString(double.Parse(txtMemory.Text) / double.Parse(txtDisplay.Text));
                        break;
                }
                txtOperation.Text = mathOp;// btn.Text;
                txtDisplay.Text = "0";
            }
            //txtOperation.Text = mathOp;
            //txtDisplay.Text = "0";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (txtOperation.Text)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(double.Parse(txtMemory.Text) + double.Parse(txtDisplay.Text));
                    break;
                case "-":
                    txtDisplay.Text = Convert.ToString(double.Parse(txtMemory.Text) - double.Parse(txtDisplay.Text));
                    break;
                case "X":
                    txtDisplay.Text = Convert.ToString(double.Parse(txtMemory.Text) * double.Parse(txtDisplay.Text));
                    break;
                case "/":
                    txtDisplay.Text = Convert.ToString(double.Parse(txtMemory.Text) / double.Parse(txtDisplay.Text));
                    break;
            }
            txtMemory.Text = "";
            txtOperation.Text = "";
        }

        private void frmCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            Button btn = new Button();
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    btn_Click(btn0, null);
                    break;
                case Keys.NumPad1:
                    btn_Click(btn1, null);
                    break;
                case Keys.NumPad2:
                    btn_Click(btn2, null);
                    break;
                case Keys.NumPad3:
                    btn_Click(btn3, null);
                    break;
                case Keys.NumPad4:
                    btn_Click(btn4, null);
                    break;
                case Keys.NumPad5:
                    btn_Click(btn5, null);
                    break;
                case Keys.NumPad6:
                    btn_Click(btn6, null);
                    break;
                case Keys.NumPad7:
                    btn_Click(btn7, null);
                    break;
                case Keys.NumPad8:
                    btn_Click(btn8, null);
                    break;
                case Keys.NumPad9:
                    btn_Click(btn9, null);
                    break;
                case Keys.Add:
                    btn.Text = "+";
                    mathOperation_Click(btnPlus, null);
                    break;
                case Keys.Subtract:
                    btn.Text = "-";
                    mathOperation_Click(btnMinus, null);
                    break;
                case Keys.Multiply:
                    btn.Text = "*";
                    mathOperation_Click(btnMultiply, null);
                    break;
                case Keys.Divide:
                    btn.Text = "/";
                    mathOperation_Click(btnDivide, null);
                    break;
                case Keys.Decimal:
                    btnDecimal_Click(null, null);
                    break;
                case Keys.OemPeriod:
                    btnDecimal_Click(null, null);
                    break;
                case Keys.Enter:
                    btnEqual_Click(null, null);
                    break;
                case Keys.Back:
                    btnBackspace_Click(null, null);
                    break;
                case Keys.Delete:
                    btnClear_Click(null, null);
                    break;
            }
        }
    }

}
