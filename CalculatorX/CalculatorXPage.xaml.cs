using Xamarin.Forms;

namespace CalculatorX
{
    public partial class CalculatorXPage : ContentPage
    {
        //using doubles to get decimal values
        double temp1 = 0;
        double temp2 = 0;
        double result = 0;
        string op = "";
        bool er = false;

        public CalculatorXPage()
        {
            InitializeComponent();
        }
        //event handeler for each button (digits 1-9)
        //Clear, operators, and math is handled in equals


        void Handle_One(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                //since temp1 starts at 0 the first time clicked will give us the original digit
                //the second time through it is multiplied 10 and added by the digit so that it shows the digit twice
                //ex. 1 , 1 * 10 + 1 = 11 so it will show 11  on the label
                temp1 = (temp1 * 10) + 1;
                displayLabel.Text = temp1.ToString();
            }
            else
            {   //since temp2 starts at 0 the first time clicked will give us the original digit
                //the second time through it is multiplied 10 and added by the digit so that it shows the digit twice
                //ex. 1 , 1 * 10 + 1 = 11 so it will show 11  on the label

                temp2 = (temp2 * 10) + 1;
                displayLabel.Text = (temp1 + op + temp2).ToString();


            }
        }
        void Handle_Two(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 2;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
                temp2 = (temp2 * 10) + 2;
                displayLabel.Text = (temp1 + op + temp2).ToString();

            }
        }
        void Handle_Three(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 3;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
                temp2 = (temp2 * 10) + 3;
                displayLabel.Text = (temp1 + op + temp2).ToString();

            }
        }
        void Handle_Four(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 4;
                displayLabel.Text = temp1.ToString();
            }
            else
            {

                temp2 = (temp2 * 10) + 4;
                displayLabel.Text = (temp1 + op + temp2).ToString();

            }
        }
        void Handle_Five(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 5;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
                temp2 = (temp2 * 10) + 5;
                displayLabel.Text = (temp1 + op + temp2).ToString();
            }

        }
        void Handle_Six(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 6;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
                temp2 = (temp2 * 10) + 6;
                displayLabel.Text = (temp1 + op + temp2).ToString();
            }


        }
        void Handle_Seven(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 7;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
                temp2 = (temp2 * 10) + 7;
                displayLabel.Text = (temp1 + op + temp2).ToString();

            }

        }
        void Handle_Eight(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 8;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
                temp2 = (temp2 * 10) + 8;
                displayLabel.Text = (temp1 + op + temp2).ToString();

            }
        }
        void Handle_Nine(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 9;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
                temp2 = (temp2 * 10) + 9;
                displayLabel.Text = (temp1 + op + temp2).ToString();
            }
        }
        void Handle_Zero(object sender, System.EventArgs digit)
        {
            if (op == "")
            {
                temp1 = (temp1 * 10) + 0;
                displayLabel.Text = temp1.ToString();
            }
            else
            {
                temp2 = (temp2 * 10) + 0;
                displayLabel.Text = (temp1 + op + temp2).ToString();


            }
        }
        //--------------------------------------------------------------
        // I just reset everything and displayed the defualt which is 0
        void Handle_Clear(object sender, System.EventArgs args)
        {
            temp1 = 0;
            temp2 = 0;
            result = 0;
            op = "";
            er = false;

            displayLabel.Text = result.ToString();
        }
        //---------------------------------------------------------------
        //will show the inputs followed by the correct operator then
        //it will be stored in a string temp3 and thatswhats displayed
        // ex. (11+) 
        void Handle_Plus(object sender, System.EventArgs args)
        {
            op = "+";

            displayLabel.Text = (temp1 + op).ToString();


        }
        void Handle_Minus(object sender, System.EventArgs args)
        {
            op = "-";

            displayLabel.Text = (temp1 + op).ToString();

        }
        void Handle_Division(object sender, System.EventArgs args)
        {
            op = "/";

            displayLabel.Text = (temp1 + op).ToString();


        }
        void Handle_Multiplication(object sender, System.EventArgs args)
        {
            op = "*";

            displayLabel.Text = (temp1 + op).ToString();

        }


        //----------------------------------------------------------------------------
        //based on which operator is used  it will do the math and display the result.
        //dividing by zero will show an error
        //you can continue using the result as the first number or clear and start over.
        void Handle_Equals(object sender, System.EventArgs args)
        {



            if (op == "+")
            {
                displayLabel.Text = (temp1 + temp2).ToString();
                temp1 = temp1 + temp2;
                temp2 = 0;
            }
            if (op == "-")
            {
                displayLabel.Text = (temp1 - temp2).ToString();
                temp1 = temp1 - temp2;
                temp2 = 0;
            }
            if (op == "*")
            {
                displayLabel.Text = (temp1 * temp2).ToString();
                temp1 = temp1 * temp2;
                temp2 = 0;
            }
            if (op == "/")
            {

                if (temp2 != 0)
                {
                    displayLabel.Text = (temp1 / temp2).ToString();
                    temp1 = temp1 / temp2;
                    temp2 = 0;
                }
                else
                {
                    er = true;
                }
            }

            if (er == true)
            {
                displayLabel.Text = "error";

                temp1 = 0;
                temp2 = 0;
                result = 0;
                op = "";
                er = false;
            }


        }
    }
}
