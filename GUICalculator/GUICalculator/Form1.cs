using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        

        //Creating two variables that will be used to hold the data and be modified
        double totalOne = 0; 
        double totalTwo = 0;
        
        //Creating boolean so that the output knows what it should with 
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;

        private void btnOne_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }//Adds the corresponding number

        private void btnTwo_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }//Adds the corresponding number

        private void btnThree_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }//Adds the corresponding number

        private void btnFour_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }//Adds the corresponding number

        private void btnFive_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }//Adds the corresponding number

        private void btnSix_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }//Adds the corresponding number

        private void btnSeven_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }//Adds the corresponding number

        private void btnEight_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }//Adds the corresponding number

        private void btnNine_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }//Adds the corresponding number

        private void btnZero_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }//Adds the corresponding number

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            String decimalCheck = txtDisplay.Text.ToString();

            if (string.IsNullOrEmpty(decimalCheck))
            {
                if (decimalCheck.Contains('.'))
                {

                }
                else
                {
                    txtDisplay.Text = txtDisplay.Text + "0" +  btnDecimal.Text;
                }
            }

            else
            {
                if (decimalCheck.Contains('.'))
                {

                }
                else
                {
                    txtDisplay.Text = txtDisplay.Text + btnDecimal.Text;
                }//Checks if the data already is decimal, if so it doesnt allow another decimal
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = null;

            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;

            totalOne = 0.0;
            totalTwo = 0.0;
            //Clears all the data in the calculator
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            String numCheck = txtDisplay.Text.ToString();

            if (string.IsNullOrEmpty(numCheck))
            {
                MessageBox.Show("Please input correct data");
                txtDisplay.Text = "0";
            }//Checks to see if null

            else
            {
                if (plusButtonClicked == true)
                {
                    totalTwo = CalcArithmetic.Arithmetic.Add(totalOne, double.Parse(txtDisplay.Text));
                    //Uses Arithmetic refrence to call method, simplifies data
                }
                else if (minusButtonClicked == true)
                {
                    totalTwo = CalcArithmetic.Arithmetic.Sub(totalOne, double.Parse(txtDisplay.Text));
                    //Uses Arithmetic refrence to call method, simplifies data
                }
                else if (divideButtonClicked == true)
                {
                    totalTwo = CalcArithmetic.Arithmetic.Div(totalOne, double.Parse(txtDisplay.Text));
                    //Uses Arithmetic refrence to call method, simplifies data
                }
                else if (multiplyButtonClicked == true)
                {
                    totalTwo = CalcArithmetic.Arithmetic.Mult(totalOne, double.Parse(txtDisplay.Text));
                    //Uses Arithmetic refrence to call method, simplifies data
                }
                txtDisplay.Text = totalTwo.ToString();
                totalOne = 0;
            }//Uses the corresponding equation on the second set of data
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            String numCheck = txtDisplay.Text.ToString();
            try
            {
                if (totalTwo != null || String.IsNullOrEmpty(numCheck))
                {
                    totalOne += double.Parse(txtDisplay.Text);
                }//Check if total 2 is null or data is null, if not the data continues
                else
                {
                    totalOne = CalcArithmetic.Arithmetic.Add(totalOne, totalTwo);
                }//If total 2 is not empty then it adds it to 1 and continues
            }
            catch (Exception)
            {

                throw;
            }
            txtDisplay.Clear();
            plusButtonClicked = true;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
            //Checks the appropriate boolean for use of output
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            String numCheck = txtDisplay.Text.ToString();
            try
            {
                if (totalTwo != null || String.IsNullOrEmpty(numCheck))
                {
                    totalOne += double.Parse(txtDisplay.Text);
                }//Check if total 2 is null or data is null, if not the data continues
                else
                {
                    totalOne = CalcArithmetic.Arithmetic.Add(totalOne, totalTwo);
                }//If total 2 is not empty then it adds it to 1 and continues
            }
            catch (Exception)
            {

                throw;
            }
            txtDisplay.Clear();
            plusButtonClicked = false;
            minusButtonClicked = true;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }//Checks the appropriate boolean for use of output

        private void btnBack_Click(object sender, EventArgs e)
        {
            String numCheck = txtDisplay.Text.ToString();

            if (string.IsNullOrEmpty(numCheck))
            {

            }

            else
            {
                numCheck = numCheck.Remove(numCheck.Length - 1);
            }

            txtDisplay.Text = numCheck;
        }//Takes away the last character from txtDisplay.Text

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            String numCheck = txtDisplay.Text.ToString();

            double squareRT = 0;

            if (string.IsNullOrEmpty(numCheck))
            {
                MessageBox.Show("Please input correct data");
                txtDisplay.Text = "0";
            }//Check if data is null or empty, if so sets to 0
            else
            {
                squareRT = double.Parse(txtDisplay.Text);
                squareRT = CalcAlgebraic.Algebraic.SQRT(squareRT);
                txtDisplay.Text = squareRT.ToString();
            }//Sends the txtDisplay.Text through the refrence where it outputs the square root
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            String numCheck = txtDisplay.Text.ToString();
            try
            {
                if (totalTwo != null || String.IsNullOrEmpty(numCheck))
                {
                    totalOne += double.Parse(txtDisplay.Text);
                }//Check if total 2 is null or data is null, if not the data continues
                else
                {
                    totalOne = CalcArithmetic.Arithmetic.Add(totalOne, totalTwo);
                }//If total 2 is not empty then it adds it to 1 and continues
            }
            catch (Exception)
            {

                throw;
            }
            txtDisplay.Clear();
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = true;
            multiplyButtonClicked = false;
        }//Checks the appropriate boolean for use of output

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            String numCheck = txtDisplay.Text.ToString();
            try
            {
                if (totalTwo != null || String.IsNullOrEmpty(numCheck))
                {
                    totalOne += double.Parse(txtDisplay.Text);
                }//Check if total 2 is null or data is null, if not the data continues
                else
                {
                    totalOne = CalcArithmetic.Arithmetic.Add(totalOne, totalTwo);
                }//If total 2 is not empty then it adds it to 1 and continues
            }
            catch (Exception)
            {

                throw;
            }
            txtDisplay.Clear();
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = true;
        }//Checks the appropriate boolean for use of output

        private void btnInverse_Click(object sender, EventArgs e)
        {
            String numCheck = txtDisplay.Text.ToString();

            double inverse = 0;
            if (string.IsNullOrEmpty(numCheck))
            {
                MessageBox.Show("Please Input Data");
                txtDisplay.Text = "0";
            }//Check if data is null or empty, if so sets to 0
            else
            {
                inverse = double.Parse(txtDisplay.Text);
                inverse = CalcAlgebraic.Algebraic.INV(inverse);
            }//Sends the txtDisplay.Text through the refrence where it outputs the inverse
            

            txtDisplay.Clear();

            txtDisplay.Text = inverse.ToString();

        }

        private void btnCubeRT_Click(object sender, EventArgs e)
        {
            String numCheck = txtDisplay.Text.ToString();

            double cubeRT = 0;
            if (string.IsNullOrEmpty(numCheck))
            {
                MessageBox.Show("Please Input Data");
                txtDisplay.Text = "0";
            }//Check if data is null or empty, if so sets to 0
            else
            {
                cubeRT = double.Parse(txtDisplay.Text);
                cubeRT = CalcAlgebraic.Algebraic.CBRT(double.Parse(txtDisplay.Text));
            }//Sends the txtDisplay.Text through the refrence where it outputs the cube root
            

            txtDisplay.Clear();

            txtDisplay.Text = cubeRT.ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            String numCheck = txtDisplay.Text.ToString();

            double numTan = double.Parse(txtDisplay.Text);

            if (string.IsNullOrEmpty(numCheck))
            {
                MessageBox.Show("Please Input Data");
                txtDisplay.Text = "0";
            }//Check if data is null or empty, if so sets to 0
            else
            {
                if (numTan == 90)
                {
                    MessageBox.Show("Invalid");
                }//Check if data is null or 90
                else
                {
                    
                }//Sends the data through the algebraic refrence where it uses math to get Tan
            }

            numTan = CalcTrigonometric.Trigonometric.TAN(double.Parse(txtDisplay.Text));

            txtDisplay.Clear();

            txtDisplay.Text = numTan.ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            String numCheck = txtDisplay.Text.ToString();

            double numCos = double.Parse(txtDisplay.Text);

            if (string.IsNullOrEmpty(numCheck))
            {
                MessageBox.Show("Please Input Data");
                txtDisplay.Text = "0";
            }//Check if data is null or empty, if so sets to 0
            else
            {
                
                numCos = double.Parse(txtDisplay.Text);
            }//Sends the data through the algebraic refrence where it uses math to get Cos            

            numCos = CalcTrigonometric.Trigonometric.COS(double.Parse(txtDisplay.Text));

            txtDisplay.Clear();

            txtDisplay.Text = numCos.ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            String numCheck = txtDisplay.Text.ToString();

            double numSin = double.Parse(txtDisplay.Text);
            if (string.IsNullOrEmpty(numCheck))
            {
                MessageBox.Show("Please Input Data");
                txtDisplay.Text = "0";
            }//Check if data is null or empty, if so sets to 0
            else
            {
                numSin = double.Parse(txtDisplay.Text);
                
            }//Sends the data through the algebraic refrence where it uses math to get Sin

            numSin = CalcTrigonometric.Trigonometric.SIN(double.Parse(txtDisplay.Text));

            txtDisplay.Clear();

            txtDisplay.Text = numSin.ToString();
        }
    }
}
