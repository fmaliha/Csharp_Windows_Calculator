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
    public partial class Calculator : Form
    {

        double number1;
        double number2;
        int plusbuttoncounter = 0;
        int minbuttoncounter = 0;
        int divbuttoncounter = 0;
        int mulbuttoncounter = 0;
        int clickcounter = 0;



        public Calculator()
        {
            InitializeComponent();

            transparent();
            

        }

       


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mulbutton_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(resultTextBox.Text);
            resultTextBox.Text = "";
            mulbuttoncounter++;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            clickcounter++;
            if (clickcounter == 1)
            {
                resultTextBox.Text = "1";
            }
            else
            {
                resultTextBox.Text += "1";//
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(resultTextBox.Text);
            resultTextBox.Text = "";
            minbuttoncounter++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickcounter++;
            if (clickcounter == 1)
            {
                resultTextBox.Text = "2";
            }
            else
            {
                resultTextBox.Text += "2";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            clickcounter++;
            if (clickcounter == 1)
            {
                resultTextBox.Text = "7";
            }
            else
            {
                resultTextBox.Text += "7";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            clickcounter++;
            if (clickcounter == 1)
            {
                resultTextBox.Text = "8";
            }
            else
            {
                resultTextBox.Text += "8";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            clickcounter++;
            if (clickcounter == 1)
            {
                resultTextBox.Text = "9";
            }
            else
            {
                resultTextBox.Text += "9";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textbox_result_TextChanged(object sender, EventArgs e)
        {

        }





        private void plusbutton_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(resultTextBox.Text);
            resultTextBox.Text = "";
            plusbuttoncounter++;

            

        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            number2 = double.Parse(resultTextBox.Text);
            resultTextBox.Text = ""+(number1+number2); 

            if(plusbuttoncounter == 1)
            {
                resultTextBox.Text = "" + (number1 + number2);
                plusbuttoncounter = 0;

            }

            else if(minbuttoncounter == 1)
            {
                resultTextBox.Text = "" + (number1 - number2);
                minbuttoncounter = 0;

            }

            else if(mulbuttoncounter== 1)
            {
                resultTextBox.Text = "" + (number1 * number2);
                mulbuttoncounter = 0;
            }

            else if(divbuttoncounter == 1)
            {
                if(number2 == 0)
                {
                    MessageBox.Show("denominetor cant be Zero");
                }

                else
                {
                    resultTextBox.Text = "" + (number1 / number2);
                    divbuttoncounter = 0;

                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void divbutton_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(resultTextBox.Text);
            resultTextBox.Text = "";
            divbuttoncounter++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickcounter++;
            if (clickcounter == 1)
            {
                resultTextBox.Text = "3";
            }
            else
            {
                resultTextBox.Text += "3";
            }

        }

        private void button0_Click(object sender, EventArgs e)
        {
            clickcounter++;
            if (clickcounter == 1)
            {
                resultTextBox.Text = "0";
            }
            else
            {
                resultTextBox.Text += "0";
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            clickcounter++;
            if (clickcounter == 1)
            {
                resultTextBox.Text = "4";
            }
            else
            {
                resultTextBox.Text += "4";
            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            clickcounter++;
            if (clickcounter == 1)
            {
                resultTextBox.Text = "5";
            }
            else
            {
                resultTextBox.Text += "5";
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            clickcounter++;
            if (clickcounter == 1)
            {
                resultTextBox.Text = "6";
            }
            else
            {
                resultTextBox.Text += "6";
            }

        }

        private void pointbutton_Click(object sender, EventArgs e)
        {

        }

        private void root_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(resultTextBox.Text);
            resultTextBox.Text = "" + Math.Sqrt(number1);
        }

        private void plusminbutton_Click(object sender, EventArgs e)
        {

        }

        private void DEL_button_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text.Substring(0, resultTextBox.Text.Length - 1);
        }


        private void Si_button_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";


        }
        private void onebyex_Click(object sender, EventArgs e)
        {

        }

        private void percentage_Click(object sender, EventArgs e)
        {

        }

        private void ex_sqr_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(resultTextBox.Text);
            resultTextBox.Text = ""+(number1 * number1);
        }

        public void transparent()
        {
            plusbutton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            plusbutton.FlatAppearance.BorderSize = 0;

            divbutton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            divbutton.FlatAppearance.BorderSize = 0;

            mulbutton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            mulbutton.FlatAppearance.BorderSize = 0;

            minusbutton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            minusbutton.FlatAppearance.BorderSize = 0;

            equal_button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            equal_button.FlatAppearance.BorderSize = 0;


            plusminbutton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            plusminbutton.FlatAppearance.BorderSize = 0;

            button0.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button0.FlatAppearance.BorderSize = 0;

            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button1.FlatAppearance.BorderSize = 0;

            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button2.FlatAppearance.BorderSize = 0;

            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button3.FlatAppearance.BorderSize = 0;

            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button4.FlatAppearance.BorderSize = 0;

            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button5.FlatAppearance.BorderSize = 0;

            button6.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button6.FlatAppearance.BorderSize = 0;

            button7.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button7.FlatAppearance.BorderSize = 0;

            button8.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button8.FlatAppearance.BorderSize = 0;

            button9.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button9.FlatAppearance.BorderSize = 0;

            button10.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button10.FlatAppearance.BorderSize = 0;

            C_button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            C_button.FlatAppearance.BorderSize = 0;

            DEL_button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            DEL_button.FlatAppearance.BorderSize = 0;

            pointbutton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            pointbutton.FlatAppearance.BorderSize = 0;

            percentage.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            percentage.FlatAppearance.BorderSize = 0;

            root.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            root.FlatAppearance.BorderSize = 0;

            ex_sqr.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            ex_sqr.FlatAppearance.BorderSize = 0;

            onebyex.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            onebyex.FlatAppearance.BorderSize = 0;

            MC_button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            MC_button.FlatAppearance.BorderSize = 0;

            MR_button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            MR_button.FlatAppearance.BorderSize = 0;

            Mplus_button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            Mplus_button.FlatAppearance.BorderSize = 0;

        
            Mmin_button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            Mmin_button.FlatAppearance.BorderSize = 0;

        
            MS_button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            MS_button.FlatAppearance.BorderSize = 0;

            M_button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            M_button.FlatAppearance.BorderSize = 0;




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void C_button_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
        }
    }

}
