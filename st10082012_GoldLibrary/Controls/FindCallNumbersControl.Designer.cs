
namespace st10082012_GoldLibrary.Controls
{
    partial class FindCallNumbersControl
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.rbOptionOne = new System.Windows.Forms.RadioButton();
            this.rbOptionTwo = new System.Windows.Forms.RadioButton();
            this.rbOptionThree = new System.Windows.Forms.RadioButton();
            this.rbOptionFour = new System.Windows.Forms.RadioButton();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescription.Location = new System.Drawing.Point(36, 15);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(295, 59);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Book Label";
            // 
            // rbOptionOne
            // 
            this.rbOptionOne.AutoSize = true;
            this.rbOptionOne.BackColor = System.Drawing.Color.MidnightBlue;
            this.rbOptionOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOptionOne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbOptionOne.Location = new System.Drawing.Point(46, 113);
            this.rbOptionOne.Name = "rbOptionOne";
            this.rbOptionOne.Size = new System.Drawing.Size(150, 36);
            this.rbOptionOne.TabIndex = 1;
            this.rbOptionOne.TabStop = true;
            this.rbOptionOne.Text = "option 1";
            this.rbOptionOne.UseVisualStyleBackColor = false;
            // 
            // rbOptionTwo
            // 
            this.rbOptionTwo.AutoSize = true;
            this.rbOptionTwo.BackColor = System.Drawing.Color.RoyalBlue;
            this.rbOptionTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOptionTwo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbOptionTwo.Location = new System.Drawing.Point(46, 451);
            this.rbOptionTwo.Name = "rbOptionTwo";
            this.rbOptionTwo.Size = new System.Drawing.Size(150, 36);
            this.rbOptionTwo.TabIndex = 2;
            this.rbOptionTwo.TabStop = true;
            this.rbOptionTwo.Text = "option 2";
            this.rbOptionTwo.UseVisualStyleBackColor = false;
            // 
            // rbOptionThree
            // 
            this.rbOptionThree.AutoSize = true;
            this.rbOptionThree.BackColor = System.Drawing.Color.MidnightBlue;
            this.rbOptionThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOptionThree.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbOptionThree.Location = new System.Drawing.Point(46, 219);
            this.rbOptionThree.Name = "rbOptionThree";
            this.rbOptionThree.Size = new System.Drawing.Size(150, 36);
            this.rbOptionThree.TabIndex = 3;
            this.rbOptionThree.TabStop = true;
            this.rbOptionThree.Text = "option 3";
            this.rbOptionThree.UseVisualStyleBackColor = false;
            // 
            // rbOptionFour
            // 
            this.rbOptionFour.AutoSize = true;
            this.rbOptionFour.BackColor = System.Drawing.Color.RoyalBlue;
            this.rbOptionFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOptionFour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbOptionFour.Location = new System.Drawing.Point(46, 341);
            this.rbOptionFour.Name = "rbOptionFour";
            this.rbOptionFour.Size = new System.Drawing.Size(150, 36);
            this.rbOptionFour.TabIndex = 4;
            this.rbOptionFour.TabStop = true;
            this.rbOptionFour.Text = "option 4";
            this.rbOptionFour.UseVisualStyleBackColor = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(694, 533);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(150, 54);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(111, 533);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 54);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FindCallNumbersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.rbOptionFour);
            this.Controls.Add(this.rbOptionThree);
            this.Controls.Add(this.rbOptionTwo);
            this.Controls.Add(this.rbOptionOne);
            this.Controls.Add(this.lblDescription);
            this.Name = "FindCallNumbersControl";
            this.Size = new System.Drawing.Size(1000, 649);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RadioButton rbOptionOne;
        private System.Windows.Forms.RadioButton rbOptionTwo;
        private System.Windows.Forms.RadioButton rbOptionThree;
        private System.Windows.Forms.RadioButton rbOptionFour;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnStart;
    }
}
