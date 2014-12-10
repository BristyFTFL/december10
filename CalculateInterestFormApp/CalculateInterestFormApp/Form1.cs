using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateInterestFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void interestButton_Click(object sender, EventArgs e)
        {
            string bankName = bankNameComboBox.Text;
            string year = yearTextBox.Text;
            string amount = amountTextBox.Text;
            double interest = 0;
            if (bankName == "BRAC")
            {
                interest = (6*Convert.ToDouble( amount)*Convert.ToInt32(year))/100;
            }
            else if(bankName == "DBBL")
            {
                interest = (7 * Convert.ToDouble(amount) * Convert.ToInt32(year)) / 100;
            }
            else if(bankName == "HSBC")
            {
                interest = (8 * Convert.ToDouble(amount) * Convert.ToInt32(year)) / 100;
            }
            interestLabel.Text = Convert.ToString(interest);
        }
    }
}
