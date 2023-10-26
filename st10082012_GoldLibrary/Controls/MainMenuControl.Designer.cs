
using System;
using System.Drawing;
using System.Drawing.Text;

namespace st10082012_GoldLibrary.Controls
{
    partial class MainMenuControl
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Castellar", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(286, 163);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dewey Quest";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnReplace.Font = new System.Drawing.Font("Castellar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.ForeColor = System.Drawing.Color.White;
            this.btnReplace.Location = new System.Drawing.Point(352, 253);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(203, 105);
            this.btnReplace.TabIndex = 1;
            this.btnReplace.Text = "Replace Books";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnIdentify
            // 
            this.btnIdentify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnIdentify.Font = new System.Drawing.Font("Castellar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentify.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIdentify.Location = new System.Drawing.Point(352, 388);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(203, 105);
            this.btnIdentify.TabIndex = 2;
            this.btnIdentify.Text = "Identify Areas";
            this.btnIdentify.UseVisualStyleBackColor = false;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnFind.Font = new System.Drawing.Font("Castellar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFind.Location = new System.Drawing.Point(352, 525);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(203, 105);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find Call Numbers";
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // MainMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainMenuControl";
            this.Size = new System.Drawing.Size(1000, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        //public void DisableFindButton()
        //{
        //    btnFind.Enabled = false;
        //    //btnIdentify.Enabled = false;
        //}

        //public void SetReplaceButtonClickEvent(EventHandler eventHandler)
        //{
        //    btnReplace.Click += eventHandler;
        //}

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Button btnFind;
    }
}
