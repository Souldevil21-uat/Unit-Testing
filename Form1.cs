using System.Diagnostics;

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Unit_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Function 1:
        // Returns true if the first number is greater than the second number
        private bool IsFirstNumberGreater(int value1, int value2)
        {
            return value1 > value2;
        }

        // Function 2:
        // Returns true if the first number is between 10 and 50 inclusive
        private bool IsNumberInRange(int value)
        {
            return value >= 10 && value <= 50;
        }

        // Checks function 1 using textbox values
        private void btnCheckGreater_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue1.Text, out int num1) &&
                int.TryParse(txtValue2.Text, out int num2))
            {
                bool result = IsFirstNumberGreater(num1, num2);
                lblResult.Text = "Greater Result: " + result;
            }
            else
            {
                MessageBox.Show("Please enter valid whole numbers in both textboxes.");
            }
        }

        // Checks function 2 using textbox 1
        private void btnCheckRange_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue1.Text, out int num))
            {
                bool result = IsNumberInRange(num);
                lblResult.Text = "Range Result: " + result;
            }
            else
            {
                MessageBox.Show("Please enter a valid whole number in the first textbox.");
            }
        }

        // This button shows asserts PASSING
        private void btnRunPassingAsserts_Click(object sender, EventArgs e)
        {
            Debug.Assert(IsFirstNumberGreater(10, 5) == true, "Assert failed: 10 should be greater than 5");
            Debug.Assert(IsNumberInRange(25) == true, "Assert failed: 25 should be in range");

            MessageBox.Show("Passing asserts completed. No assertion errors occurred.");
        }

        // This button shows asserts FAILING
        private void btnRunFailingAsserts_Click(object sender, EventArgs e)
        {
            Debug.Assert(IsFirstNumberGreater(2, 8) == true, "Assert failed: 2 is not greater than 8");
            Debug.Assert(IsNumberInRange(5) == true, "Assert failed: 5 is not in range 10 to 50");

            MessageBox.Show("If you see this without a debugger message, asserts may be disabled.");
        }
    }
}
