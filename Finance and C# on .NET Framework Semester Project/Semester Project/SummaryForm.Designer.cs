
namespace Semester_Project
{
    partial class SummaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            this.currentRatioLabel = new System.Windows.Forms.Label();
            this.showEPSLabel = new System.Windows.Forms.Label();
            this.showPERatioLabel = new System.Windows.Forms.Label();
            this.currentRatioTitle = new System.Windows.Forms.Label();
            this.epsRatioTitleLabel = new System.Windows.Forms.Label();
            this.PeRatioTitleLabel = new System.Windows.Forms.Label();
            this.dollarSignLabel = new System.Windows.Forms.Label();
            this.yourCompanyLabel = new System.Windows.Forms.Label();
            this.companyDatabaseDataSet = new Semester_Project.CompanyDatabaseDataSet();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companiesTableAdapter = new Semester_Project.CompanyDatabaseDataSetTableAdapters.CompaniesTableAdapter();
            this.tableAdapterManager = new Semester_Project.CompanyDatabaseDataSetTableAdapters.TableAdapterManager();
            this.companiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.companiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.companiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.companyDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingNavigator)).BeginInit();
            this.companiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // currentRatioLabel
            // 
            this.currentRatioLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentRatioLabel.Location = new System.Drawing.Point(158, 241);
            this.currentRatioLabel.Name = "currentRatioLabel";
            this.currentRatioLabel.Size = new System.Drawing.Size(112, 34);
            this.currentRatioLabel.TabIndex = 0;
            this.currentRatioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showEPSLabel
            // 
            this.showEPSLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showEPSLabel.Location = new System.Drawing.Point(158, 170);
            this.showEPSLabel.Name = "showEPSLabel";
            this.showEPSLabel.Size = new System.Drawing.Size(112, 34);
            this.showEPSLabel.TabIndex = 1;
            this.showEPSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showPERatioLabel
            // 
            this.showPERatioLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showPERatioLabel.Location = new System.Drawing.Point(158, 311);
            this.showPERatioLabel.Name = "showPERatioLabel";
            this.showPERatioLabel.Size = new System.Drawing.Size(112, 34);
            this.showPERatioLabel.TabIndex = 2;
            this.showPERatioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentRatioTitle
            // 
            this.currentRatioTitle.AutoSize = true;
            this.currentRatioTitle.Location = new System.Drawing.Point(32, 177);
            this.currentRatioTitle.Name = "currentRatioTitle";
            this.currentRatioTitle.Size = new System.Drawing.Size(108, 20);
            this.currentRatioTitle.TabIndex = 3;
            this.currentRatioTitle.Text = "Current Ratio:";
            // 
            // epsRatioTitleLabel
            // 
            this.epsRatioTitleLabel.AutoSize = true;
            this.epsRatioTitleLabel.Location = new System.Drawing.Point(32, 248);
            this.epsRatioTitleLabel.Name = "epsRatioTitleLabel";
            this.epsRatioTitleLabel.Size = new System.Drawing.Size(87, 20);
            this.epsRatioTitleLabel.TabIndex = 4;
            this.epsRatioTitleLabel.Text = "EPS Ratio:";
            // 
            // PeRatioTitleLabel
            // 
            this.PeRatioTitleLabel.AutoSize = true;
            this.PeRatioTitleLabel.Location = new System.Drawing.Point(32, 318);
            this.PeRatioTitleLabel.Name = "PeRatioTitleLabel";
            this.PeRatioTitleLabel.Size = new System.Drawing.Size(80, 20);
            this.PeRatioTitleLabel.TabIndex = 5;
            this.PeRatioTitleLabel.Text = "P/E Ratio:";
            // 
            // dollarSignLabel
            // 
            this.dollarSignLabel.AutoSize = true;
            this.dollarSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarSignLabel.Location = new System.Drawing.Point(134, 248);
            this.dollarSignLabel.Name = "dollarSignLabel";
            this.dollarSignLabel.Size = new System.Drawing.Size(20, 22);
            this.dollarSignLabel.TabIndex = 6;
            this.dollarSignLabel.Text = "$";
            // 
            // yourCompanyLabel
            // 
            this.yourCompanyLabel.AutoSize = true;
            this.yourCompanyLabel.Location = new System.Drawing.Point(90, 123);
            this.yourCompanyLabel.Name = "yourCompanyLabel";
            this.yourCompanyLabel.Size = new System.Drawing.Size(118, 20);
            this.yourCompanyLabel.TabIndex = 8;
            this.yourCompanyLabel.Text = "Your Company:";
            // 
            // companyDatabaseDataSet
            // 
            this.companyDatabaseDataSet.DataSetName = "CompanyDatabaseDataSet";
            this.companyDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "Companies";
            this.companiesBindingSource.DataSource = this.companyDatabaseDataSet;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompaniesTableAdapter = this.companiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Semester_Project.CompanyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // companiesBindingNavigator
            // 
            this.companiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.companiesBindingNavigator.BindingSource = this.companiesBindingSource;
            this.companiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.companiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.companiesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.companiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.companiesBindingNavigatorSaveItem});
            this.companiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.companiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.companiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.companiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.companiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.companiesBindingNavigator.Name = "companiesBindingNavigator";
            this.companiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.companiesBindingNavigator.Size = new System.Drawing.Size(1330, 33);
            this.companiesBindingNavigator.TabIndex = 9;
            this.companiesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // companiesBindingNavigatorSaveItem
            // 
            this.companiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.companiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("companiesBindingNavigatorSaveItem.Image")));
            this.companiesBindingNavigatorSaveItem.Name = "companiesBindingNavigatorSaveItem";
            this.companiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.companiesBindingNavigatorSaveItem.Text = "Save Data";
            this.companiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.companiesBindingNavigatorSaveItem_Click);
            // 
            // companiesDataGridView
            // 
            this.companiesDataGridView.AutoGenerateColumns = false;
            this.companiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.companiesDataGridView.DataSource = this.companiesBindingSource;
            this.companiesDataGridView.Location = new System.Drawing.Point(399, 126);
            this.companiesDataGridView.Name = "companiesDataGridView";
            this.companiesDataGridView.RowHeadersWidth = 62;
            this.companiesDataGridView.RowTemplate.Height = 28;
            this.companiesDataGridView.Size = new System.Drawing.Size(864, 287);
            this.companiesDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CompanyNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "CompanyNumber";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Company Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Company Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Current Ratio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Current Ratio";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EPSRatio";
            this.dataGridViewTextBoxColumn4.HeaderText = "EPSRatio";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "P/E Ratio";
            this.dataGridViewTextBoxColumn5.HeaderText = "P/E Ratio";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(260, 73);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(784, 20);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Summary Of Your Company and Other Blue Chip Companies (Feel Free to Add Yours to " +
    "The List)";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(158, 389);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 34);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.companiesDataGridView);
            this.Controls.Add(this.companiesBindingNavigator);
            this.Controls.Add(this.yourCompanyLabel);
            this.Controls.Add(this.dollarSignLabel);
            this.Controls.Add(this.PeRatioTitleLabel);
            this.Controls.Add(this.epsRatioTitleLabel);
            this.Controls.Add(this.currentRatioTitle);
            this.Controls.Add(this.showPERatioLabel);
            this.Controls.Add(this.showEPSLabel);
            this.Controls.Add(this.currentRatioLabel);
            this.Name = "SummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SummaryForm";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingNavigator)).EndInit();
            this.companiesBindingNavigator.ResumeLayout(false);
            this.companiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentRatioLabel;
        private System.Windows.Forms.Label showEPSLabel;
        private System.Windows.Forms.Label showPERatioLabel;
        private System.Windows.Forms.Label currentRatioTitle;
        private System.Windows.Forms.Label epsRatioTitleLabel;
        private System.Windows.Forms.Label PeRatioTitleLabel;
        private System.Windows.Forms.Label dollarSignLabel;
        private System.Windows.Forms.Label yourCompanyLabel;
        private CompanyDatabaseDataSet companyDatabaseDataSet;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private CompanyDatabaseDataSetTableAdapters.CompaniesTableAdapter companiesTableAdapter;
        private CompanyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator companiesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton companiesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView companiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button exitButton;
    }
}