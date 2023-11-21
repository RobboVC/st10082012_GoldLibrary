
namespace st10082012_GoldLibrary
{
    partial class FindCallNumbers
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
            this.findCallNumbersControl1 = new st10082012_GoldLibrary.Controls.FindCallNumbersControl();
            this.SuspendLayout();
            // 
            // findCallNumbersControl1
            // 
            this.findCallNumbersControl1.BackColor = System.Drawing.Color.Transparent;
            this.findCallNumbersControl1.Location = new System.Drawing.Point(-13, 2);
            this.findCallNumbersControl1.Name = "findCallNumbersControl1";
            this.findCallNumbersControl1.Size = new System.Drawing.Size(1000, 649);
            this.findCallNumbersControl1.TabIndex = 0;
            // 
            // FindCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::st10082012_GoldLibrary.Properties.Resources.imgPinkBookcase;
            this.ClientSize = new System.Drawing.Size(978, 649);
            this.Controls.Add(this.findCallNumbersControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindCallNumbers";
            this.Text = "FindCallNumbers";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.FindCallNumbersControl findCallNumbersControl1;
    }
}