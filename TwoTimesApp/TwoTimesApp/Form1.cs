using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoTimesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            double aNumber = Convert.ToDouble(aNumberTextBox.Text);
            double result = GetDouble(aNumber);
            twoTimesValueTextBox.Text = result.ToString();
        }

        private double GetDouble(double aNumber)
        {
            double getResult = aNumber*2;
            return getResult;
        }
    }
}
