
using System;

namespace st10082012_GoldLibrary
{
    partial class MainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuControl1 = new st10082012_GoldLibrary.Controls.MainMenuControl();
            this.SuspendLayout();
            // 
            // mainMenuControl1
            // 
            this.mainMenuControl1.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuControl1.Location = new System.Drawing.Point(-11, -44);
            this.mainMenuControl1.Name = "mainMenuControl1";
            this.mainMenuControl1.Size = new System.Drawing.Size(1000, 700);
            this.mainMenuControl1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::st10082012_GoldLibrary.Properties.Resources.imgLibrary;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.mainMenuControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Gold Library";
            this.ResumeLayout(false);

        }
        #endregion


        //WILL FIX THIS CODE LATER IN POE FINAL

        //private void btnReplace_Click(object sender, EventArgs e)
        //{
        //    // Hide the current MainMenu form
        //    this.Hide();

        //    // Create an instance of the ReplaceBooks form
        //    ReplaceBooks replaceBooksForm = new ReplaceBooks();

        //    // Show the ReplaceBooks form
        //    replaceBooksForm.ShowDialog(); // Use ShowDialog() to make it a modal dialog

            
        //    replaceBooksForm.Close();
        //    this.Show();
        //}

        private Controls.MainMenuControl mainMenuControl1;
    }
}

