using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passwarden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // Random password generation takes place here
            RandomString rString = new RandomString();
            string val = rString.getString(25);
            passwordTextBox.Text = val;

            Options options = new Passwarden.Options(
                caseSensitiveCheckBox.Checked,
                nonsensitiveCheckBox.Checked,
                numericCheckBox.Checked,
                punctuationCheckBox.Checked
            );

            RandomString rString2 = new RandomString(options);
            //rString2.
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            // Copy test from text box to clipboard
            Clipboard.SetText(passwordTextBox.Text);
        }
    }
}
