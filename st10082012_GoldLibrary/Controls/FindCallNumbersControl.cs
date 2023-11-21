using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st10082012_GoldLibrary.Controls
{
    public partial class FindCallNumbersControl : UserControl
    {
        private List<DeweyEntry> entries;  // List to store Dewey Decimal entries
        private int currentLevel;           // Current level of the quiz
        private string currentQuestionDescription;  // Variable to store the current question description
        private string correctAnswer;       // Correct answer for the current question
        private DeweyEntry selectedThirdLevelEntry;  // Variable to store the selected third-level entry
        private Random random; // Declare Random object at the class level

        public FindCallNumbersControl()
        {
            InitializeComponent(); 
            InitializeEntries();  // Load Dewey Decimal entries
            random = new Random(); // Initialize the Random object
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartQuiz();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Check if a radio button is selected
            if (rbOptionOne.Checked || rbOptionTwo.Checked || rbOptionThree.Checked || rbOptionFour.Checked)
            {

                string selectedAnswer = GetSelectedAnswer();
                if (selectedAnswer == correctAnswer)
                {
                    MessageBox.Show("Correct answer", "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // User selected the correct answer
                    currentLevel++;

                    // Proceed to the next question based on the current level
                    if (currentLevel == 1)
                    {
                        LoadSecondQuestion();
                    }
                    else if (currentLevel == 2)
                    {
                        LoadFinalQuestion();
                    }

                }
                else
                {
                    // User selected the wrong answer
                    MessageBox.Show("Incorrect! Please try the next question.", "Incorrect Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Please select an answer before checking.", "No Answer Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StartQuiz()
        {
            // Reset quiz state
            currentLevel = 0;
            NextQuestion();
        }

        private void NextQuestion()
        {
            // Randomly select a third level entry for the question
            List<DeweyEntry> thirdLevelEntries = entries
                .Where(entry => entry.Level == 3)
                .ToList();

            Random random = new Random();
            DeweyEntry questionEntry = thirdLevelEntries[random.Next(thirdLevelEntries.Count)];

            currentQuestionDescription = questionEntry.Description;

            selectedThirdLevelEntry = questionEntry;

            // Display the description in the label
            lblDescription.Text = currentQuestionDescription;

            // Get the correct answer from the top level entries
            List<DeweyEntry> topLevelEntries = entries
                .Where(entry => entry.Level == 1)
                .ToList();

            // Filter top level entries based on the correct third level entry
            List<DeweyEntry> correctTopLevelEntries = topLevelEntries
                .Where(entry => questionEntry.Path.StartsWith(entry.Path))
                .ToList();

            // Get the correct answer
            correctAnswer = correctTopLevelEntries.First().Path;

            // Get three wrong answers
            List<DeweyEntry> wrongTopLevelEntries = topLevelEntries.Except(correctTopLevelEntries).ToList();
            List<DeweyEntry> wrongAnswers = wrongTopLevelEntries.OrderBy(x => random.Next()).Take(3).ToList();

            // Create a list with the correct answer and three wrong answers
            List<DeweyEntry> allOptions = new List<DeweyEntry> { correctTopLevelEntries.First() };
            allOptions.AddRange(wrongAnswers);

            // Shuffle the list
            allOptions = allOptions.OrderBy(x => random.Next()).ToList();

            // Display options in radio buttons
            rbOptionOne.Tag = allOptions[0].Path;  // Set Tag property with the path
            rbOptionOne.Text = allOptions[0].Path + " " + allOptions[0].Description;

            rbOptionTwo.Tag = allOptions[1].Path;
            rbOptionTwo.Text = allOptions[1].Path + " " + allOptions[1].Description;

            rbOptionThree.Tag = allOptions[2].Path;
            rbOptionThree.Text = allOptions[2].Path + " " + allOptions[2].Description;

            rbOptionFour.Tag = allOptions[3].Path;
            rbOptionFour.Text = allOptions[3].Path + " " + allOptions[3].Description;
        }

        private void LoadSecondQuestion()
        {

            // Use the same description for the second question
            lblDescription.Text = currentQuestionDescription;

            // Get the correct answer from the second level entries
            List<DeweyEntry> secondLevelEntries = entries
                .Where(entry => entry.Level == 2)
                .ToList();

            // Filter second level entries based on the correct third level entry
            List<DeweyEntry> correctSecondLevelEntries = secondLevelEntries
                .Where(entry => selectedThirdLevelEntry.Path.StartsWith(entry.Path)) //here
                .ToList();

            // Get the correct answer
            correctAnswer = correctSecondLevelEntries.First().Path;

            // Get three wrong answers
            List<DeweyEntry> wrongSecondLevelEntries = secondLevelEntries.Except(correctSecondLevelEntries).ToList();
            List<DeweyEntry> wrongAnswers = wrongSecondLevelEntries.OrderBy(x => random.Next()).Take(3).ToList();

            // Create a list with the correct answer and three wrong answers
            List<DeweyEntry> allOptions = new List<DeweyEntry> { correctSecondLevelEntries.First() };
            allOptions.AddRange(wrongAnswers);

            // Shuffle the list
            allOptions = allOptions.OrderBy(x => random.Next()).ToList();

            // Display options in radio buttons
            rbOptionOne.Tag = allOptions[0].Path;  // Set Tag property with the path
            rbOptionOne.Text = allOptions[0].Path + " " + allOptions[0].Description;

            rbOptionTwo.Tag = allOptions[1].Path;
            rbOptionTwo.Text = allOptions[1].Path + " " + allOptions[1].Description;

            rbOptionThree.Tag = allOptions[2].Path;
            rbOptionThree.Text = allOptions[2].Path + " " + allOptions[2].Description;

            rbOptionFour.Tag = allOptions[3].Path;
            rbOptionFour.Text = allOptions[3].Path + " " + allOptions[3].Description;
        }

        private void LoadFinalQuestion()
        {
            // Use the same description for the final question
            lblDescription.Text = currentQuestionDescription;

            // Get the correct answer from the third level entries
            List<DeweyEntry> thirdLevelEntries = entries
                .Where(entry => entry.Level == 3)
                .ToList();

            // Filter third level entries based on the correct third level entry
            List<DeweyEntry> correctThirdLevelEntries = thirdLevelEntries
                .Where(entry => selectedThirdLevelEntry.Path.StartsWith(entry.Path))
                .ToList();

            // Get the correct answer
            correctAnswer = correctThirdLevelEntries.First().Path;

            // Get three wrong answers
            List<DeweyEntry> wrongThirdLevelEntries = thirdLevelEntries.Except(correctThirdLevelEntries).ToList();
            List<DeweyEntry> wrongAnswers = wrongThirdLevelEntries.OrderBy(x => random.Next()).Take(3).ToList();

            // Create a list with the correct answer and three wrong answers
            List<DeweyEntry> allOptions = new List<DeweyEntry> { correctThirdLevelEntries.First() };
            allOptions.AddRange(wrongAnswers);

            // Shuffle the list
            allOptions = allOptions.OrderBy(x => random.Next()).ToList();

            // Display options in radio buttons
            rbOptionOne.Tag = allOptions[0].Path;  // Set Tag property with the path
            rbOptionOne.Text = allOptions[0].Path + " " + allOptions[0].Description;

            rbOptionTwo.Tag = allOptions[1].Path;
            rbOptionTwo.Text = allOptions[1].Path + " " + allOptions[1].Description;

            rbOptionThree.Tag = allOptions[2].Path;
            rbOptionThree.Text = allOptions[2].Path + " " + allOptions[2].Description;

            rbOptionFour.Tag = allOptions[3].Path;
            rbOptionFour.Text = allOptions[3].Path + " " + allOptions[3].Description;
        }

        private void InitializeEntries()
        {
            // Load Dewey Decimal entries from CSV
            string filePath = "C:\\Visual studio projects\\st10082012_GoldLibrary\\st10082012_GoldLibrary\\Data\\deweyMultiList.csv";

            try
            {
                entries = File.ReadLines(filePath)
                    .Select(line =>
                    {
                        string[] parts = line.Split(',');
                        return new DeweyEntry(parts[0], parts[1]);
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Dewey Decimal entries: {ex.Message}");
                entries = new List<DeweyEntry>();  // Set to an empty list to avoid null reference exceptions
            }
        }

        


        private string GetSelectedAnswer()
        {
            if (rbOptionOne.Checked) return rbOptionOne.Tag.ToString();
            if (rbOptionTwo.Checked) return rbOptionTwo.Tag.ToString();
            if (rbOptionThree.Checked) return rbOptionThree.Tag.ToString();
            if (rbOptionFour.Checked) return rbOptionFour.Tag.ToString();

            return string.Empty;
        }


    }

    // Class to represent Dewey Decimal entries
    public class DeweyEntry
    {
        public string Path { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }

        public DeweyEntry(string path, string description)
        {
            Path = path;
            Description = description;
            Level = path.Count(c => c == '/') + 1;
        }
    }
}

