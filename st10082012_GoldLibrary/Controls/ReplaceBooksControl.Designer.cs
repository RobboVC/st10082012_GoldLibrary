using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RandonNumberGeneratorLibrary;

namespace st10082012_GoldLibrary.Controls
{
    partial class ReplaceBooksControl
    {
        private int remainingTime = 120; // 2 minutes in seconds
        private Random random = new Random();

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.flpGenBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlShelfBooks = new System.Windows.Forms.Panel();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimer.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(802, 117);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(88, 29);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "02:00";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(12)))), ((int)(((byte)(17)))));
            this.btnStart.Font = new System.Drawing.Font("Castellar", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(790, 209);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 58);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(12)))), ((int)(((byte)(17)))));
            this.btnCheck.Font = new System.Drawing.Font("Castellar", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheck.Location = new System.Drawing.Point(790, 429);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(132, 58);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(52)))), ((int)(((byte)(40)))));
            this.txtInstructions.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructions.ForeColor = System.Drawing.SystemColors.Window;
            this.txtInstructions.Location = new System.Drawing.Point(56, 489);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.Size = new System.Drawing.Size(656, 112);
            this.txtInstructions.TabIndex = 4;
            this.txtInstructions.Text = "Well Hello there fellow Librarian! Place the books on the shelf in ascending orde" +
    "r to defend the library from the devious book worms >:( Click \'START\' to play! A" +
    "nd \'CHECK\' to check you answers :)";
            this.txtInstructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flpGenBooks
            // 
            this.flpGenBooks.AllowDrop = true;
            this.flpGenBooks.Location = new System.Drawing.Point(134, 310);
            this.flpGenBooks.Name = "flpGenBooks";
            this.flpGenBooks.Size = new System.Drawing.Size(614, 146);
            this.flpGenBooks.TabIndex = 5;
            // 
            // pnlShelfBooks
            // 
            this.pnlShelfBooks.AllowDrop = true;
            this.pnlShelfBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShelfBooks.Location = new System.Drawing.Point(100, 90);
            this.pnlShelfBooks.MaximumSize = new System.Drawing.Size(656, 186);
            this.pnlShelfBooks.Name = "pnlShelfBooks";
            this.pnlShelfBooks.Size = new System.Drawing.Size(656, 130);
            this.pnlShelfBooks.TabIndex = 6;
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ReplaceBooksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlShelfBooks);
            this.Controls.Add(this.flpGenBooks);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimer);
            this.Name = "ReplaceBooksControl";
            this.Size = new System.Drawing.Size(1000, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //click event for btnStart
        public void SetStartButtonClickEvent(EventHandler eventHandler)
        {
            btnStart.Click += eventHandler;
        }

        public void SetCheckButtonClickEvent(EventHandler eventHandler)
        {
            btnCheck.Click += eventHandler;
        }

        static void SortDeweyDecimals(List<string> deweyDecimals)
        {
            deweyDecimals.Sort((a, b) =>
            {
                string[] partsA = a.Split(' ');
                string[] partsB = b.Split(' ');

                // Parse the numeric parts (mainClass and division)
                int mainClassA = int.Parse(partsA[0].Split('.')[0]);
                int mainClassB = int.Parse(partsB[0].Split('.')[0]);

                int divisionA = int.Parse(partsA[0].Split('.')[1]);
                int divisionB = int.Parse(partsB[0].Split('.')[1]);

                // Compare the numeric parts
                if (mainClassA != mainClassB)
                    return mainClassA.CompareTo(mainClassB);
                if (divisionA != divisionB)
                    return divisionA.CompareTo(divisionB);

                // Compare the alphabetic parts (authorCutter)
                return string.Compare(partsA[1], partsB[1]);
            });
        }

        private bool AreBooksInAscendingOrder(List<string> deweyDecimals)
        {
            for (int i = 1; i < deweyDecimals.Count; i++)
            {
                if (string.Compare(deweyDecimals[i - 1], deweyDecimals[i]) > 0)
                {
                    return false;
                }
            }
            return true;
        }

        private bool AreBooksInShelfInAscendingOrder()
        {
            List<string> booksOnShelf = new List<string>();

            // Extract Dewey Decimal numbers from labels in pnlShelfBooks
            foreach (Control control in pnlShelfBooks.Controls)
            {
                if (control is Label label)
                {
                    booksOnShelf.Add(label.Text);
                }
            }

            // Create a sorted copy of the books on the shelf
            List<string> sortedBooksOnShelf = new List<string>(booksOnShelf);
            SortDeweyDecimals(sortedBooksOnShelf);

            // Check if the Dewey Decimal numbers are in ascending order
            return booksOnShelf.SequenceEqual(sortedBooksOnShelf);
        }

        public void CheckButtonClicked()
        {
            try
            {
                // Check if the books are in ascending order
                if (AreBooksInShelfInAscendingOrder())
                {
                    UpdateInstructions("You have correctly sorted the books!! And even better driven away the book worms, valiant effort indeed! HUZZAH!!!");
                }
                else
                {
                    UpdateInstructions("You have not sorted the books correctly; careful, the book worms are ever encroaching :O");
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine($"Error in CheckButtonClicked: {ex.Message}");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update timer label
            UpdateTimerLabel(remainingTime);

            // Decrement timer value
            remainingTime--;

            // Check if the timer reaches 0
            if (remainingTime == 0)
            {
                // Stop the timer
                tmrCountdown.Stop();

                // Display a message
                MessageBox.Show("Time's up! The bookworms have taken over. Try again.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void UpdateTimerLabel(int remainingTime)
        {
            // Format the remaining time as minutes and seconds
            int minutes = remainingTime / 60;
            int seconds = remainingTime % 60;

            // Update the timer label in the user control
            lblTimer.Text = $"Time: {minutes:D2}:{seconds:D2}";
        }


        public void UpdateFlowLayout(List<string> deweyDecimals, List<Color> colours)
        {
            // Clear existing controls in the FlowLayoutPanel
            flpGenBooks.Controls.Clear();

            for (int i = 0; i < deweyDecimals.Count; i++)
            {
                Label bookLabel = new Label
                {
                    Size = new Size(30, 80),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = colours[i],
                    Text = deweyDecimals[i],
                    ForeColor = Color.White
                };


                // Add event handlers for drag-and-drop
                bookLabel.MouseDown += BookLabel_MouseDown;

                bookLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlShelfBooks_DragDrop);

                // Add the Label to the FlowLayoutPanel
                flpGenBooks.Controls.Add(bookLabel);
            }
        }

        private void PopulateBooks()
        {
            try
            {
                // Initialize lists to store Dewey Decimal numbers and colors
                List<string> deweyDecimals = new List<string>();
                List<Color> colors = new List<Color>();

                for (int i = 0; i < 10; i++)
                {
                    //Calling and assigning methods from Class Library to variables
                    int mainClass = DeweyDecimalGenerator.GenerateMainClass();
                    int division = DeweyDecimalGenerator.GenerateDivision();
                    string authorCutter = DeweyDecimalGenerator.GenerateAuthorCutter();

                    string deweyDecimalCallNumber = $"{mainClass}.{division} {authorCutter}";

                    // Add Dewey Decimal to the list
                    deweyDecimals.Add(deweyDecimalCallNumber);

                    // Add a random color to the list
                    colors.Add(GetRandomColor());
                }

                // Call the UpdateFlowLayout method in ReplaceBooksControl
                UpdateFlowLayout(deweyDecimals, colors);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in PopulateBooks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Color GetRandomColor()
        {
            int red = random.Next(256); // 0 to 255
            int green = random.Next(256);
            int blue = random.Next(256);

            return Color.FromArgb(red, green, blue);
        }

        public void StartButtonClicked() 
        {
            remainingTime = 120;
            tmrCountdown.Start();
            UpdateTimerLabel(remainingTime);
            UpdateInstructions("FIGHT! FIGHT! FIGHT! You have got this furture Librarian, use that massive brain!!");
            pnlShelfBooks.Controls.Clear();
            PopulateBooks();
            // Register drag-and-drop event handlers for labels
            foreach (Control control in flpGenBooks.Controls)
            {
                if (control is Label label)
                {
                    label.MouseDown += BookLabel_MouseDown;
                }
            }

            // Set up the DragDrop event handler for pnlShelfBooks
            pnlShelfBooks.DragEnter += pnlShelfBooks_DragEnter;
            pnlShelfBooks.DragDrop += pnlShelfBooks_DragDrop;
        }

        private void BookLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = sender as Label;

                // Initiate the drag-and-drop operation
                label.DoDragDrop(label, DragDropEffects.Move);
            }
        }

        private void pnlShelfBooks_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(typeof(Label)) ? DragDropEffects.Move : DragDropEffects.None;
        }


        private void pnlShelfBooks_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Label)))
            {
                Label label = e.Data.GetData(typeof(Label)) as Label;

                //Calculating the position where the label should be placed within the panel
                Point targetLocation = pnlShelfBooks.PointToClient(new Point(e.X, e.Y));

                //Ensuring that the label is placed within the panel's boundaries
                if (targetLocation.Y < 0) targetLocation.Y = 0;
                if (targetLocation.Y > pnlShelfBooks.ClientSize.Height - label.Height)
                    targetLocation.Y = pnlShelfBooks.ClientSize.Height - label.Height;

                //Setting the label's new location within the panel
                label.Location = targetLocation;

                //Adding the label to the panel
                pnlShelfBooks.Controls.Add(label);
            }

        }

        public void UpdateInstructions(string newInstructions)
        {
            txtInstructions.Text = newInstructions;
        }

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.FlowLayoutPanel flpGenBooks;
        private System.Windows.Forms.Panel pnlShelfBooks;
        private Timer tmrCountdown;
    }
}
