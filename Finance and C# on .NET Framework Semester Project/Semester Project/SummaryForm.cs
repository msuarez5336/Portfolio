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
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDatabaseDataSet.Companies' table. You can move, or remove it, as needed.
            this.companiesTableAdapter.Fill(this.companyDatabaseDataSet.Companies);
            currentRatioLabel.Text = semesterProject.currentRatio;
            showEPSLabel.Text = semesterProject.EPSRatio;
            showPERatioLabel.Text = semesterProject.PERatio;
        }

        private void companiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companyDatabaseDataSet);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
