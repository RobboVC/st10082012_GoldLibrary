
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RandonNumberGeneratorLibrary;

namespace st10082012_GoldLibrary
{
    partial class ReplaceBooks
    {
        private int remainingTime = 120; // 2 minutes in seconds

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.replaceBooksControl1 = new st10082012_GoldLibrary.Controls.ReplaceBooksControl();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // replaceBooksControl1
            // 
            this.replaceBooksControl1.BackColor = System.Drawing.Color.Transparent;
            this.replaceBooksControl1.Location = new System.Drawing.Point(-7, -2);
            this.replaceBooksControl1.Margin = new System.Windows.Forms.Padding(2);
            this.replaceBooksControl1.Name = "replaceBooksControl1";
            this.replaceBooksControl1.Size = new System.Drawing.Size(667, 455);
            this.replaceBooksControl1.TabIndex = 0;
            // 
            // ReplaceBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::st10082012_GoldLibrary.Properties.Resources.imgShelf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 428);
            this.Controls.Add(this.replaceBooksControl1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceBooks";
            this.Text = "Lets Play!";
            this.ResumeLayout(false);

            replaceBooksControl1.SetStartButtonClickEvent(btnStart_Click);
            replaceBooksControl1.UpdateTimerLabel(remainingTime);

        }

        #endregion


        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Start the timer
                timer1.Start();

                // Update instructions
                replaceBooksControl1.UpdateInstructions("FIGHT! FIGHT! FIGHT! You have got this furture Librarian, use that massive brain!!");

                // Populate FlowLayoutPanel with books
                PopulateBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnStart_Click: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                replaceBooksControl1.UpdateFlowLayout(deweyDecimals, colors);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in PopulateBooks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Color GetRandomColor()
        {
            // Generating random colors using the RGB values
            Random random = new Random();
            int red = random.Next(256); // 0 to 255
            int green = random.Next(256);
            int blue = random.Next(256);

            return Color.FromArgb(red, green, blue);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update timer label
            replaceBooksControl1.UpdateTimerLabel(remainingTime);

            // Decrement timer value
            remainingTime--;

            // Check if the timer reaches 0
            if (remainingTime == 0)
            {
                // Stop the timer
                timer1.Stop();

                // Display a message
                MessageBox.Show("Time's up! The bookworms have taken over. Try again.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the form
                this.Close();
            }
        }

        private Timer timer1;
        private Controls.ReplaceBooksControl replaceBooksControl1;
    }
}