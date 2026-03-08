using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace UtilityApp
{
    public partial class frmAssert : Form
    {
        public frmAssert()
        {
            InitializeComponent();
        }

        // boolean function 1: check if character name is valid
        private bool IsValidCharacterName(string name)
        {
            // check if name is null or empty
            if (string.IsNullOrEmpty(name))
                return false;

            // check if name length is between 3 and 20 characters
            return name.Length >= 3 && name.Length <= 20;
        }

        // boolean function 2: is health in valid range?
        private bool IsHealthInRange(string healthInput)
        {
            // grab the health input and parse it as an integer
            if (int.TryParse(healthInput, out int health))
            {
                // check if health is between 1 and 100
                return health >= 1 && health <= 100;
            }
            // if parsing fails (input is not valid), return false
            return false;
        }

        private void btnAssert_Click(object sender, EventArgs e)
        {
            try
            {
                // grab the inputs from the text boxes
                // ended up using null coalescing operator here to ensure we don't pass null values
                // i tried to not use these but the program would crash with invalid inputs outside of debug mode
                // later, i found out that the issue was due to the order of my syntax-- not because i didn't use null coalescing operators
                // initially, i called Debug.Assert before validating the inputs, which caused the program to silently crash with no error output when invalid inputs were entered
                string gamerTag = txtName.Text?.Trim() ?? string.Empty;
                string health = txtHealth.Text?.Trim() ?? string.Empty;

                // assign our bool functions to variables to use for both assertions and validation messages
                bool nameIsValid = IsValidCharacterName(gamerTag);
                bool healthIsValid = IsHealthInRange(health);

                // if both validations pass, show success message
                if (nameIsValid && healthIsValid)
                {
                    MessageBox.Show($"Both assertions passed!\n\nCharacter Name: {gamerTag}\nHealth: {health}", 
                        "Success");
                }
                else
                {
                    // if either validation fails, show an error message with details
                    string errorMessage = "Assertion failures:\n\n";

                    // build the error message based on which validations failed
                    if (!nameIsValid)
                        errorMessage += $"Name must be 3-20 characters (current: {gamerTag.Length})\n";
                    if (!healthIsValid)
                        errorMessage += $"Health must be 1-100 (current: '{health}')\n";

                    // show the error message to the user
                    MessageBox.Show(errorMessage, "Validation Failed");
                }

                // put debug.asserts at the end or you will get silent crashes outside of debug mode!
                // ask me how i know, lol

                // assert 1: character name should be between 3 and 20 characters
                Debug.Assert(nameIsValid, 
                    $"ASSERT FAILED: Character name must be between 3 and 20 characters. Current: '{gamerTag}' (Length: {gamerTag.Length})");

                // assert 2: health should be a valid integer between 1 and 100
                Debug.Assert(healthIsValid, 
                    $"ASSERT FAILED: Health must be between 1 and 100. Current input: '{health}'");
            }
            // catch any unexpected exceptions and show the user an error message
            catch (Exception ex)
            {
                // print the exception details to message box for the user
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }
    }
}
