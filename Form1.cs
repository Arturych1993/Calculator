using MaterialSkin.Controls;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //TextBox.Focus();
            TextBox.Text += 0;
        }
        private void btn1_Click_1(object sender, EventArgs e)
        {
            TextBox.Text += 1;
        }
        private void btn2_Click_1(object sender, EventArgs e)
        {
            TextBox.Text +=2;
        }
        private void btn3_Click_1(object sender, EventArgs e)
        {
            TextBox.Text += 3;
        }
        private void btn4_Click_1(object sender, EventArgs e)
        {
            TextBox.Text += 4;
        }
        private void btn5_Click_1(object sender, EventArgs e)
        {
            TextBox.Text += 5;
        }
        private void btn6_Click_1(object sender, EventArgs e)
        {
            TextBox.Text += 6;
        }
        private void btn7_Click_1(object sender, EventArgs e)
        {
            TextBox.Text += 7;
        }
        private void btn8_Click_1(object sender, EventArgs e)
        {
            TextBox.Text += 8;
        }
        private void btn9_Click_1(object sender, EventArgs e)
        {
            TextBox.Text += 9;
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            x = 0; y = 0; z = 0;
            result = 0;
            TextBox.Clear();

        }


        double x = 0.0;
        double y = 0.0;
        int z = 0;
        double result = 0.0;
        double invers;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(TextBox.Text);
            z = 1;
            TextBox.Text = "";
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(TextBox.Text);
            z = 2;
            TextBox.Text = "";
        }
        
        private void btnUmn_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(TextBox.Text);
            z = 3;
            TextBox.Text = "";
        }

        private void btnDelenie_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(TextBox.Text);
            z = 4;
            TextBox.Text = "";
        }

        private void btnProcent_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(TextBox.Text);
            z = 5;
            TextBox.Text = "";
        }

        public void btnResult_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(TextBox.Text);


            if (z == 1)
                result = x + y;
            if (z == 2)
                result = x - y;
            if (z == 3)
                result = x * y;
            if (z == 4)
                result = x / y;
            if (z == 5)
                result = x % y;

            TextBox.Text = "";
            TextBox.Text = Convert.ToString(Math.Ceiling(result));


            //int Operation(int a, int op, int b)
            //{
            //    int result = op switch
            //    {
            //        1 => a + b,
            //        2 => a - b,
            //        3 => a * b,
            //        4 => a / b,
            //        5 => a % b,
            //        _ => 0
            //    };
            //    return result;
            //}

            //int result1 = DoOperation(x, c, y);
            //TextBox.Text += result1;


        }

        private void convertBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (convInTextBox.Text.Length > 0) ConvertCheck();
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "")
            {
                TextBox.Text += "-";
            }
            else if (TextBox.Text == "-")
                TextBox.Text = "";
            else
            {
                invers = Convert.ToDouble(TextBox.Text);
                TextBox.Text = Convert.ToString(-invers);
            }
        }

        private void btnTochka_Click(object sender, EventArgs e)
        {
            //TextBox.Text += ",";
            if (TextBox.Text.IndexOf(',') == -1) TextBox.Text += ",";
                         
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            int lenght = TextBox.Text.Length - 1;
            string text = TextBox.Text;
            TextBox.Clear();
            for (int i = 0; i < lenght; i++)
            {
                TextBox.Text = TextBox.Text + text[i];
            }
        }

        private void convInTextBox_TextChanged(object sender, EventArgs e)
        {
            //((RichTextBox)sender).Text;
            if (convInTextBox.Text.Length > 0) ConvertCheck();
        }

        void ConvertCheck()
        {
         //   bool parse = double.TryParse(char s,); 
            bool test = convInTextBox.Text.Contains(',');

            int i = Convert.ToInt32(convInTextBox.Text);  // «десь мы считываем и конвертируем в числовой целочисленный формат строку в TextBoxТе,
                                                          // которую нам напишет пользователь.
            double d = Convert.ToDouble(convInTextBox.Text);



            if (convertBox1.SelectedIndex == 0)
            {
                convOutTextBox.Text = Convert.ToString(i, 2);   // конвертируем значение нашей переменной i в двоичную систему счислени€
            }
            else if (convertBox1.SelectedIndex == 1)
            {
                convOutTextBox.Text = Convert.ToString(i, 8);   // конвертируем значение нашей переменной i в восьмеричную систему счислени€
            }
            else if (convertBox1.SelectedIndex == 2)
            {
                convOutTextBox.Text = Convert.ToString(i, 10);  // конвертируем значение нашей переменной i в дес€тичную систему счислени€
            }
            else if (convertBox1.SelectedIndex == 3)
            {
                convOutTextBox.Text = Convert.ToString(i, 16);  // конвертируем значение нашей переменной i в шестнадцатиричную систему счислени€
            }

        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
                       
            if (e.KeyChar == '0') e.Handled = false;
            if (e.KeyChar == '1') e.Handled = false;
            if (e.KeyChar == '2') e.Handled = false;
            if (e.KeyChar == '3') e.Handled = false;
            if (e.KeyChar == '4') e.Handled = false;
            if (e.KeyChar == '5') e.Handled = false;
            if (e.KeyChar == '6') e.Handled = false;
            if (e.KeyChar == '7') e.Handled = false;
            if (e.KeyChar == '8') e.Handled = false;
            if (e.KeyChar == '9') e.Handled = false;

            if (e.KeyChar == '9') e.Handled = false;
            if (e.KeyChar == '9') e.Handled = false;
            if (e.KeyChar == '9') e.Handled = false;
            
            if (e.KeyChar == ',') if (TextBox.Text.IndexOf(',') != -1) e.Handled = true;
            
            //if (e.KeyChar >= '0' || e.KeyChar <= '9') e.Handled = true;
            //if (e.KeyChar >= 'a' || e.KeyChar <= 'z') e.Handled = true;
            //if (e.KeyChar >= 'а' || e.KeyChar <= '€') e.Handled = true;




        }

        private void convInTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        //void KeyPressCheck()
        //{
        //    if (e.KeyChar == '1') e.Handled = true;
        //    {

        //    }
        //}


    }

}