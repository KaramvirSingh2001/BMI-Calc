using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIApp
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Procedure to compute the BMI and Display it along with the
        /// BMI Result. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            try
            {
                double bmi = 0;
                String result = "";

                int height = int.Parse(MyHeightTextBox.Text);
                int weight = int.Parse(MyWeightTextBox.Text);

                if (ImperialRadioButton.Checked)
                {
                    bmi = (weight * 703.0) / (height * height);
                }
                else
                {
                    bmi = (1.0 * weight) / (height * height);
                }

                if (bmi < 18.5)
                {
                    result = "BMI Result - Underweight";
                }
                else if (bmi < 24.9)
                {
                    result = "BMI Result - Normal";
                }
                else if (bmi < 29.9)
                {
                    result = "BMI Result - Overweight";
                }
                else
                {
                    result = "BMI Result - Obese";
                }

                BMITextBox.Text = String.Format("{0}", bmi.ToString("F2"));
                BMIResultTextBox.Text = result;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Procedure to backspace to remove last entered digit. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackSpaceButton_Click(object sender, EventArgs e)
        {
            string text = ""; 

            if (HeightRadioButton.Checked)
            {
                text = this.MyHeightTextBox.Text;

                if(text.Length >= 1)
                {
                    this.MyHeightTextBox.Text = text.Substring(0, text.Length - 1);
                }
            }
            else
            {
                text = this.MyWeightTextBox.Text;

                if (text.Length >= 1)
                {
                    this.MyWeightTextBox.Text = text.Substring(0, text.Length - 1);
                }
            }
        }

        /// <summary>
        /// Procedure to append the 0 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (HeightRadioButton.Checked)
            {
                this.MyHeightTextBox.Text += "0";
            }
            else
            {
                this.MyWeightTextBox.Text += "0";
            }
        }

        /// <summary>
        /// Procedure to append the 3 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (HeightRadioButton.Checked)
            {
                this.MyHeightTextBox.Text += "3";
            }
            else
            {
                this.MyWeightTextBox.Text += "3";
            }
        }

        /// <summary>
        /// Procedure to append the 2 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (HeightRadioButton.Checked)
            {
                this.MyHeightTextBox.Text += "2";
            }
            else
            {
                this.MyWeightTextBox.Text += "2";
            }
        }

        /// <summary>
        /// Procedure to append the 1 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneButton_Click(object sender, EventArgs e)
        {
            if (HeightRadioButton.Checked)
            {
                this.MyHeightTextBox.Text += "1";
            }
            else
            {
                this.MyWeightTextBox.Text += "1";
            }
        }

        /// <summary>
        /// Procedure to append the 6 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SixButton_Click(object sender, EventArgs e)
        {
            if (HeightRadioButton.Checked)
            {
                this.MyHeightTextBox.Text += "6";
            }
            else
            {
                this.MyWeightTextBox.Text += "6";
            }
        }

        /// <summary>
        /// Procedure to append the 5 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (HeightRadioButton.Checked)
            {
                this.MyHeightTextBox.Text += "5";
            }
            else
            {
                this.MyWeightTextBox.Text += "5";
            }
        }

        /// <summary>
        /// Procedure to append the 4 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourButton_Click(object sender, EventArgs e)
        {
            if (HeightRadioButton.Checked)
            {
                this.MyHeightTextBox.Text += "4";
            }
            else
            {
                this.MyWeightTextBox.Text += "4";
            }
        }

        /// <summary>
        /// Procedure to append the 9 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NineButton_Click(object sender, EventArgs e)
        {
            if (HeightRadioButton.Checked)
            {
                this.MyHeightTextBox.Text += "9";
            }
            else
            {
                this.MyWeightTextBox.Text += "9";
            }
        }

        /// <summary>
        /// Procedure to append the 8 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EightButton_Click(object sender, EventArgs e)
        {
            if (HeightRadioButton.Checked)
            {
                this.MyHeightTextBox.Text += "8";
            }
            else
            {
                this.MyWeightTextBox.Text += "8";
            }
        }

        /// <summary>
        /// Procedure to append the 7 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SevenButton_Click(object sender, EventArgs e)
        {
            if(HeightRadioButton.Checked)
            {
                this.MyHeightTextBox.Text += "7";
            }
            else
            {
                this.MyWeightTextBox.Text += "7";
            }
        }

        /// <summary>
        /// Procedure to reset the form for the next Calculation. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.MyHeightTextBox.Text = "";
            this.MyWeightTextBox.Text = "";
            this.BMIResultTextBox.Text = "";
            this.BMITextBox.Text = "";
        }
    }
}
