
namespace st10082012_GoldLibrary
{
    partial class IdentifyAreas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifyAreas));
            this.identifyAreasControl1 = new st10082012_GoldLibrary.Controls.IdentifyAreasControl();
            this.SuspendLayout();
            // 
            // identifyAreasControl1
            // 
            this.identifyAreasControl1.BackColor = System.Drawing.Color.Transparent;
            this.identifyAreasControl1.Location = new System.Drawing.Point(-10, -1);
            this.identifyAreasControl1.Name = "identifyAreasControl1";
            this.identifyAreasControl1.Size = new System.Drawing.Size(1000, 650);
            this.identifyAreasControl1.TabIndex = 0;
            // 
            // IdentifyAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(978, 649);
            this.Controls.Add(this.identifyAreasControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IdentifyAreas";
            this.Text = "IdentifyAreas";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.IdentifyAreasControl identifyAreasControl1;
    }
}