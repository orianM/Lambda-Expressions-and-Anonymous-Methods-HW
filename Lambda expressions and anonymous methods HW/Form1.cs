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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void greetingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GreetingsControl greetControl = new GreetingsControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(greetControl);
            greetControl.Dock = DockStyle.Fill;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculatorControl calculatorControl = new CalculatorControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(calculatorControl);
            calculatorControl.Dock = DockStyle.Fill;
        }
    }
}
