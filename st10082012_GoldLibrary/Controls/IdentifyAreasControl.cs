using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st10082012_GoldLibrary.Controls
{
    public partial class IdentifyAreasControl : UserControl
    {
        #region Global Variables
        // Used in switching call number and description buttons
        private bool switchToCallNumbers = true;

        // Used to display instructions mssagebox
        private bool instructionsShown = false;

        // Used in button matching handling
        private Dictionary<Button, string> selectedButtons = new Dictionary<Button, string>();
        private List<Button> greenButtons = new List<Button>();

        // Used in score handling
        private int score = 0;

        // Used in displaying final score handling
        private Label lblWellDone;
        private Label lblFinalScore;
        #endregion

        #region Control Constructor
        public IdentifyAreasControl()
        {
            InitializeComponent();

            // Initializing buttons (call number/description)
            // and labels (well done and final score).
            InitializeButtons();

            InitializeLabels();
        }
        #endregion

        #region Initialization of Buttons/Labels
        private void InitializeButtons()
        {
            // Attaching the same event handler to all buttons, both on the left and right.
            btnCallOne.Click += Button_Click;
            btnCallTwo.Click += Button_Click;
            btnCallThree.Click += Button_Click;
            btnCallFour.Click += Button_Click;
            btnDescOne.Click += Button_Click;
            btnDescTwo.Click += Button_Click;
            btnDescThree.Click += Button_Click;
            btnDescFour.Click += Button_Click;
            btnDescFive.Click += Button_Click;
            btnDescSix.Click += Button_Click;
            btnDescSeven.Click += Button_Click;
        }

        private void InitializeLabels()
        {
            //Create and configure the "Well Done!" label.
            lblWellDone = new Label();
            lblWellDone.Text = "Well Done!";
            lblWellDone.Font = new Font(FontFamily.GenericSansSerif, 24, FontStyle.Bold);
            lblWellDone.TextAlign = ContentAlignment.MiddleCenter;
            lblWellDone.AutoSize = true; //Automatically adjust size based on text.
            lblWellDone.Visible = false; //Initially hidden.
            lblWellDone.ForeColor = Color.White;

            // Calculate the position to center the label horizontally and vertically.
            int centerX = (this.Width - lblWellDone.Width) / 2;
            int centerY = (this.Height - lblWellDone.Height) / 2;

            lblWellDone.Location = new Point(centerX, centerY); //Setting lblWellDone location.
            this.Controls.Add(lblWellDone);

            // Create and configure the label to display the final score.
            lblFinalScore = new Label();
            lblFinalScore.Font = new Font(FontFamily.GenericSansSerif, 18, FontStyle.Bold);
            lblFinalScore.TextAlign = ContentAlignment.MiddleCenter;
            lblFinalScore.AutoSize = true; //Automatically adjust size based on text.
            lblFinalScore.Visible = false; //Initially hidden.
            lblFinalScore.ForeColor = Color.White;

            // Center the final score label.
            centerX = (this.Width - lblFinalScore.Width) / 2;
            centerY = (this.Height - lblFinalScore.Height) / 2;

            lblFinalScore.Location = new Point(centerX, centerY); //Setting lblFinalScore location.
            this.Controls.Add(lblFinalScore);
        }
        #endregion

        #region Button-Matching Logic
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string clickedText = clickedButton.Text;

            // Create a list to store the items to be removed.
            List<Button> itemsToRemove = new List<Button>();

            if (selectedButtons.ContainsKey(clickedButton))
            {
                // If the button is already selected, clear its selection.
                selectedButtons.Remove(clickedButton);
                clickedButton.BackColor = Color.White;
            }
            else
            {
                // If the button is not already selected, check for a match.
                if (selectedButtons.Count == 1)
                {
                    foreach (var pair in selectedButtons)
                    {
                        string selectedText = pair.Value;
                        if (IsMatch(selectedText, clickedText))
                        {
                            // Correct match, clear both buttons.
                            pair.Key.Text = "";
                            clickedButton.Text = "";
                            itemsToRemove.Add(pair.Key);
                            itemsToRemove.Add(clickedButton);
                            pair.Key.BackColor = Color.Green;
                            clickedButton.BackColor = Color.Green;

                            // Increase the score by 10 for correct pairings.
                            score += 10;
                            UpdateScore();  //Update the score display.

                            // Track the buttons turned green.
                            greenButtons.Add(pair.Key);
                            greenButtons.Add(clickedButton);
                        }
                        else
                        {
                            // Incorrect match, flash the selected button red.
                            FlashButtonRed(pair.Key);
                            itemsToRemove.Add(pair.Key);

                            //Decreasing the score by 10 for incorrect pairings.
                            score -= 10;
                            UpdateScore();  //Updating the score display.
                        }
                    }
                }
                else
                {
                    // First button of a pair selected.
                    selectedButtons.Add(clickedButton, clickedText);
                    clickedButton.BackColor = Color.White; //Set background color to white for description buttons.

                }
            }

            // Remove the items from the selectedButtons collection
            foreach (var button in itemsToRemove)
            {
                selectedButtons.Remove(button);
            }
        }

        
        private void RevertGreenButtonsToOriginalColors()
        {
            // Loop to revert green buttons to their original colors.
            foreach (var button in greenButtons)
            {
                button.BackColor = button == btnCallOne || button == btnCallTwo || button == btnCallThree || button == btnCallFour
                    ? Color.DarkOrange
                    : Color.White;
            }

            // Clear the list of green buttons.
            greenButtons.Clear();
        }

        private bool IsMatch(string text1, string text2)
        {
            //DeweyDictionary object.
            DeweyDictionary deweyDictionary = new DeweyDictionary();

            if (deweyDictionary.Dictionary.ContainsKey(text1) && deweyDictionary.Dictionary.ContainsValue(text2))
            {
                // text1 is a call number, and text2 is a description.
                string description1 = deweyDictionary.Dictionary[text1];
                return description1 == text2;
            }
            else if (deweyDictionary.Dictionary.ContainsKey(text2) && deweyDictionary.Dictionary.ContainsValue(text1))
            {
                // text2 is a call number, and text1 is a description.
                string description2 = deweyDictionary.Dictionary[text2];
                return description2 == text1;
            }
            else
            {
                // No match for other cases.
                return false;
            }
        }

        private bool IsDescription(Button button)
        {
            DeweyDictionary deweyDictionary = new DeweyDictionary();

            // Check if the button's Text is a value in the dictionary (description).
            return deweyDictionary.Dictionary.ContainsValue(button.Text);
        }

        private async void FlashButtonRed(Button button)
        {
            // Changes button colour and resets to origional
            // colour after time delay of 500ms.
            button.BackColor = Color.Red;
            await Task.Delay(500);
            button.BackColor = IsDescription(button) ? Color.White : Color.DarkOrange;  // Reset to the original color.
        }

        private void UpdateScore()
        {
            // Updates txtScoreCount textbox (makes string).
            txtScoreCount.Text = score.ToString();
        }
        #endregion

        #region Populating/Randomizing Dewey call numbers/descriptions
        public void PopulateButtonsWithRandomData()
        {
            // Object Initialization
            DeweyDictionary deweyDictionary = new DeweyDictionary();
            Random random = new Random();

            // List Initialization
            List<string> callNumbers = new List<string>(deweyDictionary.Dictionary.Keys);
            List<string> allDescriptions = new List<string>(deweyDictionary.Dictionary.Values);

            // Shuffle the list of call numbers and descriptions independently.
            ShuffleList(callNumbers, random);
            ShuffleList(allDescriptions, random);

            if (switchToCallNumbers)
            {
                // Assign the shuffled call numbers to the buttons on the left.
                btnCallOne.Text = callNumbers[0];
                btnCallTwo.Text = callNumbers[1];
                btnCallThree.Text = callNumbers[2];
                btnCallFour.Text = callNumbers[3];

                // Create a list for descriptions, including both correct and incorrect ones.
                List<string> descriptions = new List<string>();

                // Adding the correct descriptions.
                descriptions.Add(deweyDictionary.Dictionary[btnCallOne.Text]);
                descriptions.Add(deweyDictionary.Dictionary[btnCallTwo.Text]);
                descriptions.Add(deweyDictionary.Dictionary[btnCallThree.Text]);
                descriptions.Add(deweyDictionary.Dictionary[btnCallFour.Text]);

                // Generating three incorrect random descriptions.
                while (descriptions.Count < 7)
                {
                    string randomDescription = allDescriptions[random.Next(allDescriptions.Count)];
                    if (!descriptions.Contains(randomDescription))
                    {
                        descriptions.Add(randomDescription);
                    }
                }

                // Shuffling the descriptions.
                ShuffleList(descriptions, random);

                // Assigning the shuffled descriptions to the buttons on the right.
                btnDescOne.Text = descriptions[0];
                btnDescTwo.Text = descriptions[1];
                btnDescThree.Text = descriptions[2];
                btnDescFour.Text = descriptions[3];
                btnDescFive.Text = descriptions[4];
                btnDescSix.Text = descriptions[5];
                btnDescSeven.Text = descriptions[6];
            }
            else
            {
                // Assign the shuffled descriptions to the buttons on the left.
                btnCallOne.Text = allDescriptions[0];
                btnCallTwo.Text = allDescriptions[1];
                btnCallThree.Text = allDescriptions[2];
                btnCallFour.Text = allDescriptions[3];

                // Creating a list for call numbers, including both correct and incorrect ones.
                List<string> callNumbersList = new List<string>();

                // Adding the correct call numbers.
                foreach (var description in new[] { btnCallOne.Text, btnCallTwo.Text, btnCallThree.Text, btnCallFour.Text })
                {
                    callNumbersList.Add(deweyDictionary.Dictionary.First(x => x.Value == description).Key);
                }

                // Generate three random incorrect call numbers.
                while (callNumbersList.Count < 7)
                {
                    string randomCallNumber = callNumbers[random.Next(callNumbers.Count)];
                    if (!callNumbersList.Contains(randomCallNumber))
                    {
                        callNumbersList.Add(randomCallNumber);
                    }
                }

                // Shuffle the call numbers.
                ShuffleList(callNumbersList, random);

                // Assign the shuffled call numbers to the buttons on the right.
                btnDescOne.Text = callNumbersList[0];
                btnDescTwo.Text = callNumbersList[1];
                btnDescThree.Text = callNumbersList[2];
                btnDescFour.Text = callNumbersList[3];
                btnDescFive.Text = callNumbersList[4];
                btnDescSix.Text = callNumbersList[5];
                btnDescSeven.Text = callNumbersList[6];
            }
        }

        private List<T> ShuffleList<T>(List<T> list, Random random)
        {
            int n = list.Count; // Get the number of elements in the List.

            // Iterate through the List in reverse order.
            // Starting at the end and move towards the beginning.
            while (n > 1)
            {
                n--; // Decrease the number of remaining elements.

                // Generate a random index 'k' between 0 (inclusive) and 'n + 1' (exclusive).
                int k = random.Next(n + 1);

                // Swap the element at index 'k' with the element at index 'n'.
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list; // Return the shuffled List.
        }
        #endregion

        #region Game Controls Click Events
        private void btnPlayNext_Click(object sender, EventArgs e)
        {
            // Changing button text, changing use of button to user.
            btnPlayNext.Text = "NEXT";

            // Method call to change selected buttons back to thier origional colours.
            RevertGreenButtonsToOriginalColors();

            // Showing Instructions (only once).
            if (!instructionsShown)
            {
                MessageBox.Show(
                    "Welcome to the call number matching game! To get you started, here is a bit of a cheat sheet before you play (you'll only get to see this once, so pay close attention):\n\n" +
                    "000 = Computer Science, Information, and General Works\n" +
                    "100 = Philosophy and Psychology\n" +
                    "200 = Religion\n" +
                    "300 = Social Sciences\n" +
                    "400 = Language\n" +
                    "500 = Natural Sciences and Mathematics\n" +
                    "600 = Technology\n" +
                    "700 = Arts and Recreation\n" +
                    "800 = Literature\n" +
                    "900 = History and Geography\n\n" +
                    "Press PLAY to play and EXIT to see your score. Happy playing!",
                    "Instructions"
                );
                instructionsShown = true;
            }

            // Populating 4 buttons on the left and 7 buttons on the right.
            PopulateButtonsWithRandomData();
            
            // Allows for switching of left and right buttons.
            switchToCallNumbers = !switchToCallNumbers;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Hide game elements.
            HideGameElements();

            // Display "Well Done!" and final score.
            lblWellDone.Visible = true;

            lblFinalScore.Text = "Final Score: " + txtScoreCount.Text;

            // Calculate the position to center the labels horizontally and set lblWellDone above lblFinalScore.
            int centerX = (this.Width - lblFinalScore.Width) / 2;
            int centerY = (this.Height - (lblWellDone.Height + lblFinalScore.Height)) / 2;

            // Position lblWellDone above lblFinalScore.
            lblWellDone.Location = new Point(centerX, centerY);
            lblFinalScore.Location = new Point(centerX, centerY + lblWellDone.Height);

            lblFinalScore.Visible = true;
        }

        private void HideGameElements()
        {
            // Hiding game buttons, labels, and textboxes
            btnCallOne.Visible = false;
            btnCallTwo.Visible = false;
            btnCallThree.Visible = false;
            btnCallFour.Visible = false;
            btnDescOne.Visible = false;
            btnDescTwo.Visible = false;
            btnDescThree.Visible = false;
            btnDescFour.Visible = false;
            btnDescFive.Visible = false;
            btnDescSix.Visible = false;
            btnDescSeven.Visible = false;
            btnExit.Visible = false;
            btnPlayNext.Visible = false;
            lblScore.Visible = false;
            txtScoreCount.Visible = false;
        }
        #endregion
    }
}
