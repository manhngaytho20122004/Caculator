using System.Net.Mail;
using System.Security.Cryptography.Pkcs;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Caculator
{
    public partial class Form1 : Form
    {

        private double _firstNumber;
        private double _secondNumber;
        private string _operator;
        private double _result;
        private string _input;
        private bool negative = false;
        public Form1()
        {
            InitializeComponent();
            _input = "";
            _result = 0;
            txtInput.Text = _result.ToString();
        }
        private void TestGit()
        {

        }
        private string Result(double firstNumber, double secondNumber, string opera)
        {
            string result = "";
            switch (opera)
            {
                case "+":
                    result = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    result = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    result = (firstNumber * secondNumber).ToString();
                    break;
                case "÷":
                    if (secondNumber == 0)
                    {
                        result = "Cannot divide by zero";
                    }
                    else
                    {
                        result = (firstNumber / secondNumber).ToString();
                    }
                    break;
                case "%":
                    result = (firstNumber * secondNumber / 100).ToString();
                    break;
                case "1/x":
                    result = (1 / firstNumber).ToString();
                    break;
                case "x^2":
                    result = (_firstNumber * _firstNumber).ToString();
                    break;
                case "Sqrt":
                    result = Math.Sqrt(_firstNumber).ToString();
                    break;
            }
            return result;
        }   
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;


            if (Check_Operator(buttonText))
            {

                if (_operator == "÷" && _secondNumber == 0 && !string.IsNullOrEmpty(_input))
                {
                    txtInput.Text = "Cannot divide by zero";
                    txtHistory.Text = "";

                    _firstNumber = 0;
                    _secondNumber = 0;
                    _operator = "";
                    _input = "";
                    return;
                }
                
                if (!string.IsNullOrEmpty(_operator) )
                {

                    string result = Result(_firstNumber, _secondNumber, _operator);
                    txtInput.Text = result;

                    _firstNumber = double.Parse(result);
                    _secondNumber = 0;
                    _operator = buttonText;
                    _input = "";
                    txtHistory.Text = _firstNumber.ToString() + _operator;
                }
                else
                {

                    if (string.IsNullOrEmpty(_operator))
                    {

                        _firstNumber = double.Parse(txtInput.Text);
                    }

                    _operator = buttonText;
                    _input = "";
                    txtHistory.Text = _firstNumber.ToString() + _operator;
                }
            }
            else
            {
                _input += buttonText;
                txtInput.Text = _input;

                if (string.IsNullOrEmpty(_operator))
                {
                    _firstNumber = double.Parse(_input);
                }
                else
                {
                    _secondNumber = double.Parse(_input);
                }
            }
        }
        private void ButtonResult_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;
            if(buttonText == "x^2")
            {
                _operator = "x^2";
                txtInput.Text = Result(_firstNumber, _secondNumber, _operator);
                txtHistory.Text = _firstNumber + "^2";

                _firstNumber = double.Parse(Result(_firstNumber, _secondNumber, _operator));
                _secondNumber = 0;
                _operator = buttonText;
                _input = "";
                return;
            }
            if(buttonText == "Sqrt")
            {
                _operator = "Sqrt";
                txtInput.Text = Result(_firstNumber, _secondNumber, _operator);
                txtHistory.Text = $"Sqrt( {_firstNumber} )";

                _firstNumber = double.Parse(Result(_firstNumber, _secondNumber, _operator));
                _secondNumber = 0;
                _operator = buttonText;
                _input = "";
                return;
            }
            if (buttonText == "1/x" && _firstNumber != 0)
            {
                _operator = "1/x";
                txtInput.Text = Result(_firstNumber, _secondNumber, _operator);
                txtHistory.Text = "1/" + _firstNumber.ToString();

                _firstNumber = double.Parse(Result(_firstNumber, _secondNumber, _operator));
                _secondNumber = 0;
                _operator = buttonText;
                _input = "";
                return;
            }
            if (buttonText == "1/x" && _firstNumber == 0)
            {
                _operator = "1/x";

                txtInput.Text = "Cannot divide by zero";
                txtHistory.Text = "";
                _firstNumber = 0;
                _secondNumber = 0;
                _operator = "";
                _input = "";
                return;
            }
            if (string.IsNullOrEmpty(_operator))
            {
                txtHistory.Text = txtInput.Text + "=";
                txtInput.Text = txtInput.Text;

                _firstNumber = double.Parse(txtInput.Text);
                _secondNumber = 0;
                _operator = "";
                _input = "";
                return;
            }
            if (string.IsNullOrEmpty(_secondNumber.ToString()) )
            {
                _secondNumber = _firstNumber;
                txtHistory.Text = _firstNumber.ToString() + _operator + _secondNumber + "=";
                string result = Result(_firstNumber, _secondNumber, _operator);
                txtInput.Text = result;
                return;
              
            }
            if (_secondNumber != 0)
            {
                txtHistory.Text = _firstNumber.ToString() + _operator + _secondNumber + "=";
                string result = Result(_firstNumber, _secondNumber, _operator);
                txtInput.Text = result;

                _firstNumber = double.Parse(result);
                _secondNumber = 0;
                _operator = "";
                _input = "";
                return;
            }
            else
            {
                txtHistory.Text = _firstNumber.ToString() + _operator + _secondNumber + "=";
                string result = Result(_firstNumber, _secondNumber, _operator);
                txtInput.Text = result;
            }
         
        }

        private bool Check_Operator(string text)
        {
            if (text == "+" || text == "-" || text == "*" || text == "÷" || text == "%" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            _firstNumber = 0;
            _secondNumber = 0;
            _operator = null;
            _input = "";
            txtInput.Text = "0";
            txtHistory.Text = "";
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_input))
            {
                _input = _input.Substring(0, _input.Length - 1);
                txtInput.Text = _input;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
            {
                return;
            }
            if (negative == false)
            {
                _input = "-" + _input;
                txtInput.Text = _input;
                negative = true;
            }
            else
            {
                _input = _input.Substring(1);
                txtInput.Text = txtInput.Text.Substring(1);
                negative = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
