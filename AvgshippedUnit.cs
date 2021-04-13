using System;
using System.Windows.Forms;

namespace AvgUnitsShipped
{
    public partial class formAvgShippedUnit : Form
    {
        // class-level variable declarations.
        int currentDay = 1;
        int currentTotal = 0;

        private static formAvgShippedUnit instance;
        public formAvgShippedUnit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the button is clicked do all of this stuff!
        /// Append the entries to the running total text box.
        /// Add a day to the current day.
        /// Validate the number to see if it is whole and in between 0-5000.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // declare constants and variables.
            const int MinimumUnits = 0;
            const int MaximumUnits = 5000;
            const int MaximumDays = 7;
            int lastEntry;

            // validate that the number entered is a whole number
            if (int.TryParse(textBoxEntryNumber.Text, out lastEntry))
            {
                // validate that the number entered is 0 and 5000
                if (lastEntry >= MinimumUnits && lastEntry <= MaximumUnits)
                {
                    // if the entry is valid,

                    //increment currentTotal by the entry
                    currentTotal += lastEntry;
                    textBoxPastEntries.Text += lastEntry + "\r\n";
                    //increment the day by 1
                    currentDay++;
                    // clear the entry textbox
                    textBoxEntryNumber.Clear();
                    // if the day is = 7 
                    if (currentDay > MaximumDays)
                    {
                        // Determine the average
                        double averageUnits;
                        averageUnits = (double)currentTotal / MaximumDays;
                        // Output the result
                        labelAvgOutput.Text = "Average per day: " + Math.Round(averageUnits, 2);
                        // Disable controls 
                        textBoxEntryNumber.Enabled = false;
                        buttonEnter.Enabled = false;
                        // set focus to reset button
                        buttonReset.Focus();
                    }
                    else
                    {
                        // Display the current day.
                        labelDay.Text = "Day " + currentDay;
                        // Set the focus to the new entry
                        textBoxEntryNumber.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Enter a value between" + MinimumUnits +
                        " and " + MaximumUnits + ".", "Invalid Entry!");
                    textBoxEntryNumber.SelectAll();
                    textBoxEntryNumber.Focus();
                }

            }
            else
            {
                // the value entered is not an integer
                MessageBox.Show("Entry must be a numeric value.", "Invalid Entry!");
                textBoxEntryNumber.SelectAll();
                textBoxEntryNumber.Focus();

            }
        }

        private void ButtonResetClick(object sender, EventArgs e)
        {
            // reset the global variables.
            currentDay = 1;
            currentTotal = 0;
            // clear the input and output fields.
            textBoxEntryNumber.Clear();
            textBoxPastEntries.Clear();
            labelAvgOutput.Text = string.Empty;
            labelDay.Text = "Day " + currentDay;



            // re-enable any controls that may be disabled.
            textBoxEntryNumber.Enabled = true;
            buttonEnter.Enabled = true;
            // set focus for easy data entry.
            textBoxEntryNumber.Focus();

        }
        /// <summary>
        /// closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();

        }

        public static formAvgShippedUnit Instance
        {
            get
            {
                // If there is no existing instance of the customer entry form.
                if (instance == null)
                {
                    // Create a new instance.
                    instance = new formAvgShippedUnit();
                }

                // Return either the existing or new instance.
                return instance;

            }
        }

        private void AverageUntisShippedClosing(object sender, FormClosingEventArgs e)
        {
            // Make the customer entry instance null.
            instance = null;
        }
    }
}
