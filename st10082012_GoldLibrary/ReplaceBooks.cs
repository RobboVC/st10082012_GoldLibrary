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
    
    public partial class ReplaceBooks : Form
    {
        public ReplaceBooks()
        {
            
            InitializeComponent();
            replaceBooksControl1.SetStartButtonClickEvent(btnStart_Click);
            replaceBooksControl1.SetCheckButtonClickEvent(btnCheck_Click);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            replaceBooksControl1.StartButtonClicked();

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            replaceBooksControl1.CheckButtonClicked();
        }
    }
}
