using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        string _charSet;

        // dictionary containing essential char sets for every checkbox selected //
        Dictionary<string, string> optionCharsPairs = new Dictionary<string, string>
        {
            {"symbolsCheckBox","!@#$%^&*()-_+=" },
            {"numbersCheckBox", "1234567890" },
            {"lowercaseCharsCheckBox", "qwertyuiopasdfghjklzxcvbnm" },
            {"uppercaseCharsCheckBox", "QWERTYUIOPASDFGHJKLZXCVBNM" },
            {"ambiguousCharsCheckBox", "{}[]:'|;,./<>?`~" }
        };



        private static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string _charSet = "";

            // check if there's any checkbox in groupbox that is checked //
            if (groupBox2.Controls.OfType<CheckBox>().Any(c=>c.Checked))
            {
                foreach (Control control in groupBox2.Controls)
                {

                    if(control is CheckBox)
                    {
                        var checkBox = control as CheckBox;
                        if(checkBox.Checked == true)
                        {
                            // check if there's any key in dictionary that is equal to the checkbox.Name property //
                            if(optionCharsPairs.Any(x => x.Key == checkBox.Name))
                            {
                                _charSet += optionCharsPairs[checkBox.Name];
                            }
                        }
                    }
                }

                passwordTextBox.Text = new string(Enumerable.Repeat(_charSet, Convert.ToInt32(lengthComboBox.SelectedItem.ToString())).Select(s => s[random.Next(s.Length)]).ToArray());
            }
            else
            {
                MessageBox.Show("Please check at least one option!");
            }
            
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if(!(passwordTextBox.Text == String.Empty))
                Clipboard.SetText(passwordTextBox.Text);
        }
    }
}
