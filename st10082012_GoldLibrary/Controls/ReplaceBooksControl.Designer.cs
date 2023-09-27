
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace st10082012_GoldLibrary.Controls
{
    partial class ReplaceBooksControl
    {


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
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.flpGenBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlShelfBooks = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimer.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(535, 76);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(62, 19);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "02:00";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(12)))), ((int)(((byte)(17)))));
            this.btnStart.Font = new System.Drawing.Font("Castellar", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(527, 136);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 38);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(12)))), ((int)(((byte)(17)))));
            this.btnCheck.Font = new System.Drawing.Font("Castellar", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheck.Location = new System.Drawing.Point(527, 279);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(88, 38);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(52)))), ((int)(((byte)(40)))));
            this.txtInstructions.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructions.ForeColor = System.Drawing.SystemColors.Window;
            this.txtInstructions.Location = new System.Drawing.Point(37, 318);
            this.txtInstructions.Margin = new System.Windows.Forms.Padding(2);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.Size = new System.Drawing.Size(439, 74);
            this.txtInstructions.TabIndex = 4;
            this.txtInstructions.Text = "Well Hello there fellow Librarian! Place the books on the shelf in ascending order to defend the library from the devious book worms >:( Click 'START' to play! And 'CHECK' to check you answers :)";
            this.txtInstructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flpGenBooks
            // 
            this.flpGenBooks.Location = new System.Drawing.Point(96, 207);
            this.flpGenBooks.Margin = new System.Windows.Forms.Padding(2);
            this.flpGenBooks.Name = "flpGenBooks";
            this.flpGenBooks.Size = new System.Drawing.Size(409, 95);
            this.flpGenBooks.TabIndex = 5;
            // 
            // pnlShelfBooks
            // 
            this.pnlShelfBooks.Location = new System.Drawing.Point(37, 76);
            this.pnlShelfBooks.Margin = new System.Windows.Forms.Padding(2);
            this.pnlShelfBooks.Name = "pnlShelfBooks";
            this.pnlShelfBooks.Size = new System.Drawing.Size(437, 88);
            this.pnlShelfBooks.TabIndex = 6;
            // 
            // ReplaceBooksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlShelfBooks);
            this.Controls.Add(this.flpGenBooks);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReplaceBooksControl";
            this.Size = new System.Drawing.Size(667, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //click event for btnStart
        public void SetStartButtonClickEvent(EventHandler eventHandler)
        {
            btnStart.Click += eventHandler;
        }

        public void UpdateTimerLabel(int remainingTime)
        {
            // Format the remaining time as minutes and seconds
            int minutes = remainingTime / 60;
            int seconds = remainingTime % 60;

            // Update the timer label in the user control
            lblTimer.Text = $"Time: {minutes:D2}:{seconds:D2}";
        }


        public void UpdateFlowLayout(List<string> deweyDecimals, List<Color> colors)
        {
            // Clear existing controls in the FlowLayoutPanel
            flpGenBooks.Controls.Clear();

            for (int i = 0; i < deweyDecimals.Count; i++)
            {
                Label bookLabel = new Label
                {
                    Size = new Size(30, 80),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = colors[i],
                    Text = deweyDecimals[i],
                    ForeColor = Color.White,
                    AllowDrop = true  // Enable drag-and-drop for the Label
                };

                // Add event handlers for drag-and-drop
                bookLabel.MouseDown += BookLabel_MouseDown;
                bookLabel.MouseMove += BookLabel_MouseMove;

                // Add the Label to the FlowLayoutPanel
                flpGenBooks.Controls.Add(bookLabel);
            }
        }

        private void BookLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Start dragging when the left mouse button is pressed
                Label label = sender as Label;
                label.DoDragDrop(label.Text, DragDropEffects.Move);
            }
        }

        private void BookLabel_MouseMove(object sender, MouseEventArgs e)
        {
            // Update cursor during the drag operation
            if (e.Button == MouseButtons.Left)
            {
                Label label = sender as Label;
                label.DoDragDrop(label.Text, DragDropEffects.Move);
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
    }
}
