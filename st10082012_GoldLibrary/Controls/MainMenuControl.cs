using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st10082012_GoldLibrary.Controls
{
    public partial class MainMenuControl : UserControl
    {

        public MainMenuControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Disables the "Find" button.
        /// </summary>
        public void DisableFindButton()
        {
            btnFind.Enabled = false;
            // btnIdentify.Enabled = false; // This line is commented out, so it doesn't affect the "Identify" button.
        }

        /// <summary>
        /// Opens the "Replace Books" form as a dialog.
        /// </summary>
        public void SetReplaceButton()
        {
            ReplaceBooks replaceBooksForm = new ReplaceBooks();
            replaceBooksForm.ShowDialog();
        }

        /// <summary>
        /// Opens the "Identify Areas" form as a dialog.
        /// </summary>
        public void SetIdentifyButton()
        {
            IdentifyAreas identifyAreasForm = new IdentifyAreas();
            identifyAreasForm.ShowDialog();
        }

        /// <summary>
        /// Handles the click event for the "Replace" button.
        /// Calls the SetReplaceButton method to open the "Replace Books" form.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnReplace_Click(object sender, EventArgs e)
        {
            SetReplaceButton();
        }

        /// <summary>
        /// Handles the click event for the "Identify" button.
        /// Calls the SetIdentifyButton method to open the "Identify Areas" form.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnIdentify_Click(object sender, EventArgs e)
        {
            SetIdentifyButton();
        }
    }
}
