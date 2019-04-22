using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02myCalc
{
    public partial class Calculator : Form
    {
        double num1, num2, answer;
        string opChosen;
        Random generator;
        int redValue, greenValue, blueValue;
        string lastKeyPressed="start";


        bool redRising, greenRising, blueRising;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            generator = new Random();
            MorphingColorTimer.Enabled = false;
            redRising = true;
            greenRising = false;
            blueRising = true;
            redValue = generator.Next(256);
            greenValue = generator.Next(256);
            blueValue = generator.Next(256);
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
            this.BackColor = Color.FromArgb(redValue, greenValue, blueValue);

        }

        private void CE_Click(object sender, EventArgs e)
        {
            lastKeyPressed = "operator";
            if (lblCalculation.Text != "")
            {
                num1 = Convert.ToDouble(lblCalculation.Text);
                opChosen = "^";
                lblCalculation.Text = "";
                lblOP.Text += "^";
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (lblCalculation.Text == "0")
            {
                lblOP.Text = "";
                lblCalculation.Text = "";
            }
            if (lastKeyPressed != "equals")
            {
                lblCalculation.Text += "1";
                lblOP.Text += "1";
            }
            else
            {
                lblCalculation.Text = "1";
                lblOP.Text = "1";
            }
        }

        private void BackArrow_MouseEnter(object sender, EventArgs e)
        {
            BackArrow.BackColor = Color.Silver;
        }

        private void BackArrow_MouseLeave(object sender, EventArgs e)
        {
            BackArrow.BackColor = Color.LightGray;
        }

        private void Exponent_MouseEnter(object sender, EventArgs e)
        {
            Exponent.BackColor = Color.Silver;
        }

        private void Exponent_MouseLeave(object sender, EventArgs e)
        {
            Exponent.BackColor = Color.LightGray;
        }

        private void C_Click(object sender, EventArgs e)
        {
            lblOP.Text = "";
            lblCalculation.Text = "";
        }

        private void C_MouseEnter(object sender, EventArgs e)
        {
            C.BackColor = Color.Silver;
        }

        private void C_MouseLeave(object sender, EventArgs e)
        {
            C.BackColor = Color.LightGray;
        }

        private void plusminus_MouseEnter(object sender, EventArgs e)
        {
            plusminus.BackColor = Color.Silver;
        }

        private void plusminus_MouseLeave(object sender, EventArgs e)
        {
            plusminus.BackColor = Color.LightGray;
        }

        private void Squareroot_MouseEnter(object sender, EventArgs e)
        {
            Squareroot.BackColor = Color.Silver;
        }

        private void Squareroot_MouseLeave(object sender, EventArgs e)
        {
            Squareroot.BackColor = Color.LightGray;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (lblCalculation.Text == "0")
            {
                lblOP.Text = "";
                lblCalculation.Text = "";
            }
            if (lastKeyPressed != "equals")
            {
                lblCalculation.Text += "7";
                lblOP.Text += "7";
            }
            else
            {
                lblCalculation.Text = "7";
                lblOP.Text = "7";
            }
            
            lastKeyPressed = "digit";
        }

        private void seven_MouseEnter(object sender, EventArgs e)
        {
            seven.BackColor = Color.Silver;
        }

        private void seven_MouseLeave(object sender, EventArgs e)
        {
            seven.BackColor = Color.LightGray;
        }

        private void eight_MouseEnter(object sender, EventArgs e)
        {
            eight.BackColor = Color.Silver;
        }

        private void eight_MouseLeave(object sender, EventArgs e)
        {
            eight.BackColor = Color.LightGray;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (lblCalculation.Text == "0")
            {
                lblOP.Text = "";
                lblCalculation.Text = "";
            }
            if (lastKeyPressed != "equals")
            {
                lblCalculation.Text += "9";
                lblOP.Text += "9";
            }
            else
            {
                lblCalculation.Text = "9";
                lblOP.Text = "9";
            }
        }

        private void nine_MouseEnter(object sender, EventArgs e)
        {
            nine.BackColor = Color.Silver;
        }

        private void nine_MouseLeave(object sender, EventArgs e)
        {
            nine.BackColor = Color.LightGray;
        }

        private void divide_MouseEnter(object sender, EventArgs e)
        {
            divide.BackColor = Color.Silver;
        }

        private void divide_MouseLeave(object sender, EventArgs e)
        {
            divide.BackColor = Color.LightGray;
        }

        private void percent_MouseEnter(object sender, EventArgs e)
        {
            percent.BackColor = Color.Silver;
        }

        private void percent_MouseLeave(object sender, EventArgs e)
        {
            percent.BackColor = Color.LightGray;
        }

        private void four_MouseEnter(object sender, EventArgs e)
        {
            four.BackColor = Color.Silver;
        }

        private void four_MouseLeave(object sender, EventArgs e)
        {
            four.BackColor = Color.LightGray;
        }

        private void five_MouseEnter(object sender, EventArgs e)
        {
            five.BackColor = Color.Silver;
        }

        private void five_MouseLeave(object sender, EventArgs e)
        {
            five.BackColor = Color.LightGray;
        }

        private void six_MouseEnter(object sender, EventArgs e)
        {
            six.BackColor = Color.Silver;
        }

        private void six_MouseLeave(object sender, EventArgs e)
        {
            six.BackColor = Color.LightGray;
        }

        private void multiply_MouseEnter(object sender, EventArgs e)
        {
            multiply.BackColor = Color.Silver;
        }

        private void multiply_MouseLeave(object sender, EventArgs e)
        {
            multiply.BackColor = Color.LightGray;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Silver;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightGray;
        }

        private void one_MouseEnter(object sender, EventArgs e)
        {
            one.BackColor = Color.Silver;
        }

        private void one_MouseLeave(object sender, EventArgs e)
        {
            one.BackColor = Color.LightGray;
        }

        private void two_MouseEnter(object sender, EventArgs e)
        {
            two.BackColor = Color.Silver;
        }

        private void two_MouseLeave(object sender, EventArgs e)
        {
            two.BackColor = Color.LightGray;
        }

        private void three_MouseEnter(object sender, EventArgs e)
        {
            three.BackColor = Color.Silver;
        }

        private void three_MouseLeave(object sender, EventArgs e)
        {
            three.BackColor = Color.LightGray;
        }

        private void minus_MouseEnter(object sender, EventArgs e)
        {
            minus.BackColor = Color.Silver;
        }

        private void minus_MouseLeave(object sender, EventArgs e)
        {
            minus.BackColor = Color.LightGray;
        }

        private void equals_MouseEnter(object sender, EventArgs e)
        {
            equals.BackColor = Color.Silver;
        }

        private void equals_MouseLeave(object sender, EventArgs e)
        {
            equals.BackColor = Color.LightGray;
        }

        private void zero_MouseEnter(object sender, EventArgs e)
        {
            zero.BackColor = Color.Silver;
        }

        private void zero_MouseLeave(object sender, EventArgs e)
        {
            zero.BackColor = Color.LightGray;
        }

        private void decimalpoint_MouseEnter(object sender, EventArgs e)
        {
            decimalpoint.BackColor = Color.Silver;
        }

        private void decimalpoint_MouseLeave(object sender, EventArgs e)
        {
            decimalpoint.BackColor = Color.LightGray;
        }

        private void plus_MouseEnter(object sender, EventArgs e)
        {
            plus.BackColor = Color.Silver;
        }

        private void plus_MouseLeave(object sender, EventArgs e)
        {
            plus.BackColor = Color.LightGray;
        }

        private void zero_Click(object sender, EventArgs e)
        {
          
           
            if (lastKeyPressed != "equals")
            {
                if (lblCalculation.Text != "0")
                {
                    lblCalculation.Text += "0";
                    lblOP.Text += "0";
                }
             
               
                
            }
            else
            {
                lblCalculation.Text = "0";
                lblOP.Text = "0";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (lblCalculation.Text == "0")
            {
                lblOP.Text = "";
                lblCalculation.Text = "";
            }
            if (lastKeyPressed != "equals")
            {
                lblCalculation.Text += "2";
                lblOP.Text += "2";
            }
            else
            {
                lblCalculation.Text = "2";
                lblOP.Text = "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (lblCalculation.Text == "0")
            {
                lblOP.Text = "";
                lblCalculation.Text = "";
            }
            if (lastKeyPressed != "equals")
            {
                lblCalculation.Text += "3";
                lblOP.Text += "3";
            }
            else
            {
                lblCalculation.Text = "3";
                lblOP.Text = "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (lblCalculation.Text == "0")
            {
                lblOP.Text = "";
                lblCalculation.Text = "";
            }
            if (lastKeyPressed != "equals")
            {
                lblCalculation.Text += "4";
                lblOP.Text += "4";
            }
            else
            {
                lblCalculation.Text = "4";
                lblOP.Text = "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (lblCalculation.Text == "0")
            {
                lblOP.Text = "";
                lblCalculation.Text = "";
            }
            if (lastKeyPressed != "equals")
            {
                lblCalculation.Text += "5";
                lblOP.Text += "5";
            }
            else
            {
                lblCalculation.Text = "5";
                lblOP.Text = "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (lblCalculation.Text == "0")
            {
                lblOP.Text = "";
                lblCalculation.Text = "";
            }
            if (lastKeyPressed != "equals")
            {
                lblCalculation.Text += "6";
                lblOP.Text += "6";
            }
            else
            {
                lblCalculation.Text = "6";
                lblOP.Text = "6";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (lblCalculation.Text == "0")
            {
                lblOP.Text = "";
                lblCalculation.Text = "";
            }
            if (lastKeyPressed != "equals")
            {
                lblCalculation.Text += "8";
                lblOP.Text += "8";
            }
            else
            {
                lblCalculation.Text = "8";
                lblOP.Text = "8";
            }
        }

        private void decimalpoint_Click(object sender, EventArgs e)
        {
            if (!lblCalculation.Text.Contains(".") && lastKeyPressed != "equals")
            {
                lblCalculation.Text += ".";
                lblOP.Text += ".";

            }
            else
            {
                lblCalculation.Text = "0.";
                lblOP.Text = "0.";
            }
            lastKeyPressed = "decimalPoint";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            lastKeyPressed = "operator";
            if (lblCalculation.Text != "")
            {
                num1 = Convert.ToDouble(lblCalculation.Text);
                opChosen = "+";
                lblCalculation.Text = "";
                lblOP.Text += "+";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            lastKeyPressed = "operator";
            if (lblCalculation.Text != "")
            {
                num1 = Convert.ToDouble(lblCalculation.Text);
                opChosen = "-";
                lblCalculation.Text = "";
                lblOP.Text += "-";
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            lastKeyPressed = "operator";
            if (lblCalculation.Text != "")
            {
                num1 = Convert.ToDouble(lblCalculation.Text);
                opChosen = "*";
                lblCalculation.Text = "";
                lblOP.Text += "*";
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            lastKeyPressed = "operator";
            if (lblCalculation.Text != "")
            {
                num1 = Convert.ToDouble(lblCalculation.Text);
                opChosen = "/";
                lblCalculation.Text = "";
                lblOP.Text += "/";
            }
        }

        private void BackArrow_Click(object sender, EventArgs e)
        {
            lastKeyPressed = "operator";
            if (lblOP.Text.Length>0)
            {
                lblOP.Text = lblOP.Text.Substring(0, lblOP.Text.Length - 1);
            }
            if (lblCalculation.Text.Length>0)
            {
                lblCalculation.Text = lblCalculation.Text.Substring(0, lblCalculation.Text.Length - 1);
            }
        }
        private void equals_Click(object sender, EventArgs e)
        {
            lastKeyPressed = "equals";
            double answer;
            num2 = Convert.ToDouble(lblCalculation.Text);
            if (opChosen == "+")
            {
                answer = num1 + num2;
                lblCalculation.Text = answer + "";
                lblOP.Text += "=" + answer;
            }
            else if (opChosen == "-")
            {
                answer = num1 - num2;
                lblCalculation.Text = answer + "";
                lblOP.Text += "=" + answer;
            }
            else if (opChosen == "*")
            {
                answer = num1 * num2;
                lblCalculation.Text = answer + "";
                lblOP.Text += "=" + answer;
            }
            else if (opChosen == "/")
            {
                answer = num1 / num2;
                lblCalculation.Text = answer + "";
                lblOP.Text += "=" + answer;
            }
            else if (opChosen == "^")
            {
                answer = Math.Pow(num1, num2);
                lblCalculation.Text = answer + "";
                lblOP.Text += "=" + answer;
            }
           
        }
            

        private void Squareroot_Click(object sender, EventArgs e)
        {
            lastKeyPressed = "operator";
            if (lblCalculation.Text != "")
            {
                num1 = Convert.ToDouble(lblCalculation.Text);
                double temp = num1;
                num1 = Math.Sqrt(num1);
                lblOP.Text = "√" + temp + "=" + num1;
                lblCalculation.Text = num1 + "";
            }
           
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MorphingColorTimer.Enabled = false;
            this.BackColor = Color.DodgerBlue;
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
            blueWaveBox.Enabled = false;
            blueWaveBox.Visible = false;
        }

        private void transparentToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MorphingColorTimer.Enabled = false;
                this.BackColor = Color.LavenderBlush;
                pictureBox1.Enabled = false;
                pictureBox1.Visible = false;
                blueWaveBox.Enabled = false;
                blueWaveBox.Visible = false;
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 MorphingColorTimer.Enabled = false;
                 pictureBox1.Enabled = false;
                 pictureBox1.Visible = false;
                 blueWaveBox.Enabled = false;
                 blueWaveBox.Visible = false;
                 DialogResult result = colorDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.BackColor = colorDialog1.Color;
                    }
        }

      

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
            MorphingColorTimer.Enabled = true;
            blueWaveBox.Enabled = false;
            blueWaveBox.Visible = false;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
            MorphingColorTimer.Enabled = false;
        }


        private void startToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            pictureBox1.Enabled = true;
            MorphingColorTimer.Enabled = false;
            blueWaveBox.Enabled = false;
            blueWaveBox.Visible = false;
        }

        private void stopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Dylan Gasiorowski, using C#  1/12/2017");
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void startToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
            MorphingColorTimer.Enabled = false;
            blueWaveBox.Enabled = true;
            blueWaveBox.Visible = true;
        }

        private void stopToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            blueWaveBox.Enabled = false;
            blueWaveBox.Visible = false;
        }

        private void percent_Click(object sender, EventArgs e)
        {

            lastKeyPressed = "operator";
            if (lblCalculation.Text != "")
            {
                num1 = Convert.ToDouble(lblCalculation.Text);
                
                num1/=100;
                lblOP.Text += "%="+num1+"";
                lblCalculation.Text = num1 + "";
            }
        }

        

        private void MorphingColorTimer_Tick(object sender, EventArgs e)
        {
            if (redRising)
            {
                redValue++;
                if (redValue == 255)
                {
                    redRising = false;

                }
            }
            else
            {

                redValue--;

                if (redValue == 0)
                {
                    redRising = true;
                }
            }

            if (greenRising)
            {
                greenValue++;
                if (greenValue == 255)
                {
                    greenRising = false;

                }
            }
            else
            {
                greenValue--;
                if (greenValue == 0)
                {
                    greenRising = true;
                }
            }

            if (blueRising)
            {
                blueValue++;
                if (blueValue == 255)
                {
                    blueRising = false;

                }
            }
            else
            {
                blueValue--;
                if (blueValue == 0)
                {
                    blueRising = true;
                }
            }

            this.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lastKeyPressed = "operator";
            if (lblCalculation.Text != "")
            {
                num1 = Convert.ToDouble(lblCalculation.Text);
                double temp = num1;
                num1 = 1/num1;
                lblOP.Text = "1/(" + temp + ")="+ num1;
                lblCalculation.Text = num1 + "";
            }
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            lastKeyPressed = "operator";
            double number = Convert.ToDouble(lblCalculation.Text);
            number = number * -1;
            lblCalculation.Text = number + "";
            lblOP.Text = number + "";
        }

    }

}
