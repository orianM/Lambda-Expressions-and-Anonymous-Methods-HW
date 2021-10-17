using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda_expressions_and_anonymous_methods_HW
{
    delegate void DelegateAnonMethod();
    delegate void GreetDelegate();
    public partial class GreetingsControl : UserControl
    {
        public GreetingsControl()
        {
            InitializeComponent();
        }

        #region Greetings (Anonymous methods)

        private void btnShalom_Click(object sender, EventArgs e)
        {
            DelegateAnonMethod shalom = delegate { MessageBox.Show("Shalom"); };
            shalom();
        }

        private void btnPrint2_Click(object sender, EventArgs e)
        {
            DelegateAnonMethod print2 = delegate { MessageBox.Show("Another anonymous function called with the same delegate"); };
            print2();
        }

        private void btnShalomName_Click(object sender, EventArgs e)
        {
            string recipient = txtShalomName.Text;
            GreetDelegate shalomName = delegate { MessageBox.Show($"Shalom {recipient}"); };
            try
            {
                if (string.IsNullOrEmpty(recipient))
                {
                    throw new ArgumentNullException("No name entered");
                }
                else
                {
                    shalomName();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a name");
            }
        }

        private void btnWelcomeName_Click(object sender, EventArgs e)
        {
            string recipient = txtWelcomeName.Text;
            GreetDelegate welcomeName = delegate { MessageBox.Show($"Welcome {recipient}"); };
            try
            {
                if (string.IsNullOrEmpty(recipient))
                {
                    throw new ArgumentNullException("No name entered");
                }
                else
                {
                    welcomeName();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a name");
            }
        }

        #endregion

    }
}
