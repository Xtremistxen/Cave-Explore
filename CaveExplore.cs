using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CaveExplorerTracker
{
    public partial class CaveExplore : Form
    {
        // This list stores all cave objects created in the program.
        private List<Cave> caves = new List<Cave>();

        public CaveExplore()
        {
            InitializeComponent();

            // Set up combo boxes when the form starts.
            Setup();
        }

        // This method adds the choices to the combo boxes.
        private void Setup()
        {
            // Add cave type choices.
            caveTypeComboBox.Items.Add("Wild Cave");
            caveTypeComboBox.Items.Add("Tourist Cave");
            caveTypeComboBox.SelectedIndex = 0;

            // Add danger level choices.
            dangerLevelComboBox.Items.Add("Low");
            dangerLevelComboBox.Items.Add("Medium");
            dangerLevelComboBox.Items.Add("High");
            dangerLevelComboBox.Items.Add("Extreme");
            dangerLevelComboBox.SelectedIndex = 0;
        }

        // This runs when the Add Cave button is clicked.
        // It reads the user input, creates the correct type of cave,
        // and adds it to the list box.
        private void addCaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get basic cave information from the form.
                string name = caveNameTextBox.Text;
                string location = locationTextBox.Text;

                int depth = int.Parse(depthTextBox.Text);
                int length = int.Parse(lengthTextBox.Text);
                bool explored = exploredCheckBox.Checked;
                string danger = dangerLevelComboBox.Text;

                // This variable will hold either a WildCave or TouristCave object.
                Cave newCave;

                // Create the correct object based on the cave type selected.
                if (caveTypeComboBox.Text == "Wild Cave")
                {
                    newCave = new WildCave(
                        name, location, depth, length, explored, danger,
                        extraTextBox1.Text,
                        extraTextBox2.Text,
                        extraCheckBox.Checked
                    );
                }
                else
                {
                    newCave = new TouristCave(
                        name, location, depth, length, explored, danger,
                        extraCheckBox.Checked,
                        decimal.Parse(extraTextBox1.Text),
                        giftShopCheckBox.Checked
                    );
                }

                // Add the new cave object to the list.
                caves.Add(newCave);

                // Show the cave information in the list box.
                cavesListBox.Items.Add(newCave.display());
            }
            catch
            {
                // Show an error if the user enters invalid data.
                MessageBox.Show("Invalid input.");
            }
        }

        // This runs when the Clear button is clicked.
        // It clears the text boxes on the form.
        private void clearButton_Click(object sender, EventArgs e)
        {
            caveNameTextBox.Clear();
            locationTextBox.Clear();
            depthTextBox.Clear();
            lengthTextBox.Clear();
            extraTextBox1.Clear();
            extraTextBox2.Clear();
        }

        // This event runs when the form loads.
        private void CaveExplore_Load(object sender, EventArgs e)
        {

        }
    }
}