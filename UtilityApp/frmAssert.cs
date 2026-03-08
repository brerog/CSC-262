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
            if (string.IsNullOrEmpty(name))
                return false;
            
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
                string gamerTag = txtName.Text?.Trim() ?? string.Empty;
                string health = txtHealth.Text?.Trim() ?? string.Empty;

                // test the validation functions
                bool nameIsValid = IsValidCharacterName(gamerTag);
                bool healthIsValid = IsHealthInRange(health);

                // if both validations pass, show success message
                if (nameIsValid && healthIsValid)
                {
                    MessageBox.Show($"✓ Both assertions passed!\n\nCharacter Name: {gamerTag}\nHealth: {health}", 
                        "Success");
                }
                else
                {
                    // if either validation fails, show an error message with details
                    string errorMessage = "Assertion failures:\n\n";
                    if (!nameIsValid)
                        errorMessage += $"• Name must be 3-20 characters (current: {gamerTag.Length})\n";
                    if (!healthIsValid)
                        errorMessage += $"• Health must be 1-100 (current: '{health}')\n";
                    
                    MessageBox.Show(errorMessage, "Validation Failed");
                }

                // assert 1: character name should be between 3 and 20 characters
                Debug.Assert(nameIsValid, 
                    $"ASSERT FAILED: Character name must be between 3 and 20 characters. Current: '{gamerTag}' (Length: {gamerTag.Length})");

                // assert 2: health should be a valid integer between 1 and 100
                Debug.Assert(healthIsValid, 
                    $"ASSERT FAILED: Health must be between 1 and 100. Current input: '{health}'");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }
    }
}
