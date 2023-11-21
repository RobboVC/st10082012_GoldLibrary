using st10082012_GoldLibrary.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st10082012_GoldLibrary
{
    public partial class MainMenu : Form
    {
        /// <summary>
        /// Constructor for the MainMenu form.
        /// Initializes the form and calls the "DisableFindButton" method of the mainMenuControl1 control.
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the "Replace" button's click event.
        /// Calls the "SetReplaceButton" method of the mainMenuControl1 control.
        /// </summary>
        private void btnReplace_Click(object sender, EventArgs e)
        {
            mainMenuControl1.SetReplaceButton();
        }

        /// <summary>
        /// Event handler for the "Identify" button's click event.
        /// Calls the "SetIdentifyButton" method of the mainMenuControl1 control.
        /// </summary>
        private void btnIdentify_Click(object sender, EventArgs e)
        {
            mainMenuControl1.SetIdentifyButton();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            mainMenuControl1.SetFindButton();
        }
    }
}
