/* 
 * Developed by:        Miguel Suarez
 * Purpose:             Create a Hub for Investors to 
 *                      Calculate Ratios and Compare Them
 *                      to Those of Blue-Chip Companies
 * Date                 12/04/2021
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Project
{ 
    public partial class semesterProject : Form
    {
        public semesterProject()
        {
            InitializeComponent();
        }

        public static string currentRatio = "";
        public static string EPSRatio = "";
        public static string PERatio = "";

        CurrentRatio currentratio;
        EPSRatio epsratio;
        PERatio peratio;
        private decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
        private void semesterProject_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ready to Invest? Welcome To the Hub!");
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal assets = 0.0m;
            decimal liabilities = 0.0m;
            decimal currentRatio;

            assetErrorProvider.SetError(assetsTextBox, "");
            liabilitiesErrorProvider.SetError(liabilitiesTextBox, "");

            if (decimal.TryParse(assetsTextBox.Text, out assets) && decimal.TryParse(liabilitiesTextBox.Text, out liabilities))
            {
                currentratio = new CurrentRatio(assets, liabilities);

                currentRatio = Divide(assets, liabilities);

                showLabel.Text = currentRatio.ToString("n2");
            
            } else
            {
                MessageBox.Show("You failed to input a valid value in both of the textboxes.");
                assetErrorProvider.SetError(assetsTextBox, "The Data Must Be Numeric and Present. Try Again.");
                liabilitiesErrorProvider.SetError(liabilitiesTextBox, "The Data Must Be Numeric and Present. Try Again.");
            }

        }
        private void calculateEPSLabel_Click(object sender, EventArgs e)
        {
            decimal earnings = 0.0m;
            decimal shares = 0.0m;
            decimal epsRatio;

            earningsErrorProvider.SetError(earningsTextBox, "");
            sharesErrorProvider.SetError(sharesTextBox, "");

            if (decimal.TryParse(earningsTextBox.Text, out earnings) && decimal.TryParse(sharesTextBox.Text, out shares))
            {
                epsratio = new EPSRatio(earnings, shares);

                epsRatio = Divide(earnings, shares);

                showEPSLabel.Text = epsRatio.ToString("n2");

            }
            else
            {
                MessageBox.Show("You Input an Invalid Value in the Text Boxes. Please Try Again.");
                earningsErrorProvider.SetError(earningsTextBox, "The Data Must Be Numeric and Present. Try Again.");
                sharesErrorProvider.SetError(sharesTextBox, "The Data Must Be Numeric and Present. Try Again.");
            }
        }
        private void calculatePEButton_Click(object sender, EventArgs e)
        {
            decimal sharePrice = 0.0m;
            decimal eps = 0.0m;
            decimal peRatio;

            sharePriceErrorProvider.SetError(sharePriceTextBox, "");
            epsErrorProvider.SetError(epsTextBox, "");

            if (decimal.TryParse(sharePriceTextBox.Text, out sharePrice) && decimal.TryParse(epsTextBox.Text, out eps))
            {
                peratio = new PERatio(sharePrice, eps);

                peRatio = Divide(sharePrice, eps);
                
                showPELabel.Text = peRatio.ToString("n2");

            }
            else
            {
                MessageBox.Show("You Input an Invalid Value in the Text Boxes. Please Try Again.");
                sharePriceErrorProvider.SetError(sharePriceTextBox, "The Data Must Be Numeric and Present. Try Again.");
                epsErrorProvider.SetError(epsTextBox, "The Data Must Be Numeric and Present. Try Again.");
            }
        }

        private void summaryFormButton_Click(object sender, EventArgs e)
            {
                currentRatio = showEPSLabel.Text;
            EPSRatio = showLabel.Text;
                PERatio = showPELabel.Text;

                SummaryForm summaryForm = new SummaryForm();
                summaryForm.Show();
            }

        private void blueChipCompaniesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string company;
            if (blueChipCompaniesComboBox.SelectedIndex != 0) 
            {
                company = blueChipCompaniesComboBox.SelectedItem.ToString();
                
                switch (company)
                {
                    case "Apple":
                        MessageBox.Show("Apple's Ratios Are: " +
                            " Current Ratio: 1.08" + " "+
                            "EPS Ratio: $1.23" + " "+
                            "P/E Ratio: 29.14 ");
                        break;
                    case "Microsoft":
                        MessageBox.Show("Microsoft's Ratios Are: " +
                            " Current Ratio: 2.17" + " " +
                            "EPS Ratio: $2.71" + "                      " +
                            "P/E Ratio: 39.13 ");
                        break;
                    case "Walmart":
                        MessageBox.Show("Walmart's Ratios Are: " +
                            " Current Ratio: 0.95" + " " +
                            "EPS Ratio: $1.11" + "                      " +
                            "P/E Ratio: 21.1 ");
                        break;
                }

            }
            else
            {
                MessageBox.Show("No Company Was Selected");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentRatio = showEPSLabel.Text;
            EPSRatio = showLabel.Text;
            PERatio = showPELabel.Text;
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.Show();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
