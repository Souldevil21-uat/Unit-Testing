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

            // Run internal tests when the program starts
            RunAssertTests();
        }

        /*
         Program: Boolean Function Assertion Tester
         Purpose: Demonstrates unit testing using Debug.Assert() on two
                  Boolean-returning functions that use textbox input.
         Author: Student
         */

        // Function 1
        // Checks if the first number entered is greater than the second number
        // Returns true if value1 > value2, otherwise false
        private bool IsFirstNumberGreater(int value1, int value2)
        {
            return value1 > value2;
        }

        // Function 2
        // Checks if the first number falls within the range 10–50
        // Returns true if inside the range, otherwise false
        private bool IsNumberInRange(int value)
        {
            return value >= 10 && value <= 50;
        }

        // Button click event for greater comparison
        private void btnCheckGreater_Click(object sender, EventArgs e)
        {
            int num1, num2;

            // Prevent program crash from invalid input
            if (int.TryParse(txtValue1.Text, out num1) && int.TryParse(txtValue2.Text, out num2))
            {
                bool result = IsFirstNumberGreater(num1, num2);
                lblResult.Text = "Result: " + result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        // Button click event for range check
        private void btnCheckRange_Click(object sender, EventArgs e)
        {
            int num;

            if (int.TryParse(txtValue1.Text, out num))
            {
                bool result = IsNumberInRange(num);
                lblResult.Text = "Result: " + result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        // Assert testing method
        // Verifies the Boolean functions behave correctly
        private void RunAssertTests()
        {
            Debug.Assert(IsFirstNumberGreater(10, 5) == true, "Test Failed: 10 should be greater than 5");
            Debug.Assert(IsFirstNumberGreater(3, 8) == false, "Test Failed: 3 should not be greater than 8");

            Debug.Assert(IsNumberInRange(25) == true, "Test Failed: 25 should be in range");
            Debug.Assert(IsNumberInRange(5) == false, "Test Failed: 5 should be outside range");
        }
    }
}
