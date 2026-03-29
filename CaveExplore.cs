using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CaveExplorerTracker
{
    public partial class CaveExplore : Form
    {
        // This list stores all Cave objects created by the user.
        private List<Cave> caveList = new List<Cave>();

        public CaveExplore()
        {
            InitializeComponent();

            // Set up the form when it opens.
            SetUpDangerLevelComboBox();
            SetUpListBox();
        }

        // Adds the danger level choices to the combo box.
        private void SetUpDangerLevelComboBox()
        {
            dangerLevelComboBox.Items.Add("Low");
            dangerLevelComboBox.Items.Add("Medium");
            dangerLevelComboBox.Items.Add("High");
            dangerLevelComboBox.Items.Add("Extreme");

            // Select the first option by default.
            dangerLevelComboBox.SelectedIndex = 0;
        }

        // Sets up the list box display.
        private void SetUpListBox()
        {
            cavesListBox.HorizontalScrollbar = true;
        }

        // Runs when the Add Cave button is clicked.
        // It reads the input, checks for errors, creates a Cave object,
        // and shows it in the list box.
        private void addCaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the text entered by the user and remove extra spaces.
                string caveName = caveNameTextBox.Text.Trim();
                string location = locationTextBox.Text.Trim();

                // Make sure the cave name was entered.
                if (string.IsNullOrWhiteSpace(caveName))
                {
                    MessageBox.Show("Please enter a cave name.");
                    caveNameTextBox.Focus();
                    return;
                }

                // Make sure the location was entered.
                if (string.IsNullOrWhiteSpace(location))
                {
                    MessageBox.Show("Please enter a location.");
                    locationTextBox.Focus();
                    return;
                }

                // Convert the depth and length into whole numbers.
                int depthInFeet = int.Parse(depthTextBox.Text);
                int lengthInFeet = int.Parse(lengthTextBox.Text);

                // Make sure depth is not negative.
                if (depthInFeet < 0)
                {
                    MessageBox.Show("Depth cannot be negative.");
                    depthTextBox.Focus();
                    return;
                }

                // Make sure length is not negative.
                if (lengthInFeet < 0)
                {
                    MessageBox.Show("Length cannot be negative.");
                    lengthTextBox.Focus();
                    return;
                }

                // Get the explored checkbox value.
                bool isExplored = exploredCheckBox.Checked;

                // Get the selected danger level.
                string dangerLevel = dangerLevelComboBox.SelectedItem.ToString();

                // Create a new Cave object with the user's input.
                Cave newCave = new Cave(caveName, location, depthInFeet, lengthInFeet, isExplored, dangerLevel);

                // Add the cave object to the list.
                caveList.Add(newCave);

                // Show the cave summary in the list box.
                cavesListBox.Items.Add(newCave.GetCaveSummary());

                // Let the user know it worked.
                MessageBox.Show("Cave added successfully!");

                // Clear the input boxes for the next entry.
                ClearInputs();
            }
            catch (FormatException)
            {
                // Runs if the user types something that is not a whole number.
                MessageBox.Show("Depth and Length must be whole numbers.");
            }
            catch (Exception ex)
            {
                // Catches any other unexpected error.
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        // Runs when the Clear button is clicked.
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        // Clears all input controls and places the cursor back
        // in the cave name text box.
        private void ClearInputs()
        {
            caveNameTextBox.Text = "";
            locationTextBox.Text = "";
            depthTextBox.Text = "";
            lengthTextBox.Text = "";
            exploredCheckBox.Checked = false;
            dangerLevelComboBox.SelectedIndex = 0;
            caveNameTextBox.Focus();
        }

        // Runs when the sample data button is clicked.
        // This creates 5 example Cave objects for testing or demo use.
        private void loadSampleDataButton_Click(object sender, EventArgs e)
        {
            // Clear old data first.
            caveList.Clear();
            cavesListBox.Items.Clear();

            // Create 5 sample cave objects.
            Cave cave1 = new Cave("Crystal Hollow", "Kentucky", 450, 1200, true, "Medium");
            Cave cave2 = new Cave("Shadow Drop Cavern", "Texas", 980, 2100, false, "High");
            Cave cave3 = new Cave("Echo Rift Cave", "Colorado", 700, 1800, true, "Low");
            Cave cave4 = new Cave("Blackstone Pit", "New Mexico", 1500, 2500, false, "Extreme");
            Cave cave5 = new Cave("Silver Lake Cavern", "Tennessee", 620, 1600, true, "Medium");

            // Add the sample caves to the list.
            caveList.Add(cave1);
            caveList.Add(cave2);
            caveList.Add(cave3);
            caveList.Add(cave4);
            caveList.Add(cave5);

            // Display each cave in the list box.
            foreach (Cave cave in caveList)
            {
                cavesListBox.Items.Add(cave.GetCaveSummary());
            }

            // Show a message when the sample data is loaded.
            MessageBox.Show("5 sample cave objects loaded.");
        }
    }
}