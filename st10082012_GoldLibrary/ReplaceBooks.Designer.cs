﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RandonNumberGeneratorLibrary;

namespace st10082012_GoldLibrary
{
    partial class ReplaceBooks
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
            this.replaceBooksControl1 = new st10082012_GoldLibrary.Controls.ReplaceBooksControl();
            this.SuspendLayout();
            // 
            // replaceBooksControl1
            // 
            this.replaceBooksControl1.BackColor = System.Drawing.Color.Transparent;
            this.replaceBooksControl1.Location = new System.Drawing.Point(1, -5);
            this.replaceBooksControl1.Name = "replaceBooksControl1";
            this.replaceBooksControl1.Size = new System.Drawing.Size(1000, 700);
            this.replaceBooksControl1.TabIndex = 0;
            // 
            // ReplaceBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::st10082012_GoldLibrary.Properties.Resources.imgShelf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 658);
            this.Controls.Add(this.replaceBooksControl1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceBooks";
            this.Text = "Lets Play!";
            this.ResumeLayout(false);

        }

        #endregion



        private Controls.ReplaceBooksControl replaceBooksControl1;
    }
}