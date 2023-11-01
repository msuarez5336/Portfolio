
namespace Semester_Project
{
    partial class semesterProject
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
            this.summaryFormButton = new System.Windows.Forms.Button();
            this.assetsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.showLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.currentRatioTitleLabel = new System.Windows.Forms.Label();
            this.currentAssetsLabel = new System.Windows.Forms.Label();
            this.currentLiabilitiesLabel = new System.Windows.Forms.Label();
            this.ratio1Label = new System.Windows.Forms.Label();
            this.peTitleLabel = new System.Windows.Forms.Label();
            this.earningsPerShareLabel = new System.Windows.Forms.Label();
            this.sharePriceLabel = new System.Windows.Forms.Label();
            this.peRatioTitle = new System.Windows.Forms.Label();
            this.epsTextBox = new System.Windows.Forms.TextBox();
            this.showPELabel = new System.Windows.Forms.Label();
            this.calculatePEButton = new System.Windows.Forms.Button();
            this.sharePriceTextBox = new System.Windows.Forms.TextBox();
            this.earningsPerShareLabel2 = new System.Windows.Forms.Label();
            this.liabilitiesTextBox = new System.Windows.Forms.TextBox();
            this.sharesTextBox = new System.Windows.Forms.TextBox();
            this.epsRatioTitle = new System.Windows.Forms.Label();
            this.outstandingSharesLabel = new System.Windows.Forms.Label();
            this.earningsLabel = new System.Windows.Forms.Label();
            this.epsTitleLabel = new System.Windows.Forms.Label();
            this.showEPSLabel = new System.Windows.Forms.Label();
            this.calculateEPSLabel = new System.Windows.Forms.Button();
            this.earningsTextBox = new System.Windows.Forms.TextBox();
            this.dollarSignLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.blueChipCompaniesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.assetErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.liabilitiesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.earningsErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sharesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sharePriceErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.epsErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateLabel = new System.Windows.Forms.Label();
            this.semesterProjectLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.assetErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liabilitiesErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earningsErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharesErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharePriceErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsErrorProvider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // summaryFormButton
            // 
            this.summaryFormButton.Location = new System.Drawing.Point(709, 445);
            this.summaryFormButton.Name = "summaryFormButton";
            this.summaryFormButton.Size = new System.Drawing.Size(128, 32);
            this.summaryFormButton.TabIndex = 0;
            this.summaryFormButton.Text = "See Summary";
            this.summaryToolTip.SetToolTip(this.summaryFormButton, "See a Summary Of the Ratios of Your Company and Other Blue-Chip Companies");
            this.summaryFormButton.UseVisualStyleBackColor = true;
            this.summaryFormButton.Click += new System.EventHandler(this.summaryFormButton_Click);
            // 
            // assetsTextBox
            // 
            this.assetsTextBox.Location = new System.Drawing.Point(303, 153);
            this.assetsTextBox.Name = "assetsTextBox";
            this.assetsTextBox.Size = new System.Drawing.Size(100, 26);
            this.assetsTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(303, 238);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(93, 35);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // showLabel
            // 
            this.showLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showLabel.Location = new System.Drawing.Point(456, 178);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(89, 37);
            this.showLabel.TabIndex = 4;
            this.showLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(526, 52);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(166, 29);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Investor Hub!";
            // 
            // currentRatioTitleLabel
            // 
            this.currentRatioTitleLabel.AutoSize = true;
            this.currentRatioTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRatioTitleLabel.Location = new System.Drawing.Point(48, 118);
            this.currentRatioTitleLabel.Name = "currentRatioTitleLabel";
            this.currentRatioTitleLabel.Size = new System.Drawing.Size(294, 20);
            this.currentRatioTitleLabel.TabIndex = 7;
            this.currentRatioTitleLabel.Text = "Calculate Your Company\'s Current Ratio";
            // 
            // currentAssetsLabel
            // 
            this.currentAssetsLabel.AutoSize = true;
            this.currentAssetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAssetsLabel.Location = new System.Drawing.Point(17, 158);
            this.currentAssetsLabel.Name = "currentAssetsLabel";
            this.currentAssetsLabel.Size = new System.Drawing.Size(234, 17);
            this.currentAssetsLabel.TabIndex = 8;
            this.currentAssetsLabel.Text = "Company Current Assets (in USD $)";
            // 
            // currentLiabilitiesLabel
            // 
            this.currentLiabilitiesLabel.AutoSize = true;
            this.currentLiabilitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLiabilitiesLabel.Location = new System.Drawing.Point(17, 198);
            this.currentLiabilitiesLabel.Name = "currentLiabilitiesLabel";
            this.currentLiabilitiesLabel.Size = new System.Drawing.Size(250, 17);
            this.currentLiabilitiesLabel.TabIndex = 9;
            this.currentLiabilitiesLabel.Text = "Company Current Liabilities (in USD $)";
            // 
            // ratio1Label
            // 
            this.ratio1Label.AutoSize = true;
            this.ratio1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratio1Label.Location = new System.Drawing.Point(441, 140);
            this.ratio1Label.Name = "ratio1Label";
            this.ratio1Label.Size = new System.Drawing.Size(122, 20);
            this.ratio1Label.TabIndex = 10;
            this.ratio1Label.Text = "Current Ratio:";
            // 
            // peTitleLabel
            // 
            this.peTitleLabel.AutoSize = true;
            this.peTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peTitleLabel.Location = new System.Drawing.Point(427, 339);
            this.peTitleLabel.Name = "peTitleLabel";
            this.peTitleLabel.Size = new System.Drawing.Size(90, 20);
            this.peTitleLabel.TabIndex = 18;
            this.peTitleLabel.Text = "P/E Ratio:";
            // 
            // earningsPerShareLabel
            // 
            this.earningsPerShareLabel.AutoSize = true;
            this.earningsPerShareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earningsPerShareLabel.Location = new System.Drawing.Point(32, 390);
            this.earningsPerShareLabel.Name = "earningsPerShareLabel";
            this.earningsPerShareLabel.Size = new System.Drawing.Size(172, 17);
            this.earningsPerShareLabel.TabIndex = 17;
            this.earningsPerShareLabel.Text = "Current Quarter Earnings ";
            // 
            // sharePriceLabel
            // 
            this.sharePriceLabel.AutoSize = true;
            this.sharePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharePriceLabel.Location = new System.Drawing.Point(32, 353);
            this.sharePriceLabel.Name = "sharePriceLabel";
            this.sharePriceLabel.Size = new System.Drawing.Size(203, 17);
            this.sharePriceLabel.TabIndex = 16;
            this.sharePriceLabel.Text = "Current Share Price (in USD $)";
            // 
            // peRatioTitle
            // 
            this.peRatioTitle.AutoSize = true;
            this.peRatioTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peRatioTitle.Location = new System.Drawing.Point(48, 313);
            this.peRatioTitle.Name = "peRatioTitle";
            this.peRatioTitle.Size = new System.Drawing.Size(266, 20);
            this.peRatioTitle.TabIndex = 15;
            this.peRatioTitle.Text = "Calculate Your Company\'s P/E Ratio";
            // 
            // epsTextBox
            // 
            this.epsTextBox.Location = new System.Drawing.Point(264, 393);
            this.epsTextBox.Name = "epsTextBox";
            this.epsTextBox.Size = new System.Drawing.Size(100, 26);
            this.epsTextBox.TabIndex = 14;
            // 
            // showPELabel
            // 
            this.showPELabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showPELabel.Location = new System.Drawing.Point(431, 382);
            this.showPELabel.Name = "showPELabel";
            this.showPELabel.Size = new System.Drawing.Size(89, 37);
            this.showPELabel.TabIndex = 13;
            this.showPELabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatePEButton
            // 
            this.calculatePEButton.Location = new System.Drawing.Point(264, 442);
            this.calculatePEButton.Name = "calculatePEButton";
            this.calculatePEButton.Size = new System.Drawing.Size(93, 35);
            this.calculatePEButton.TabIndex = 12;
            this.calculatePEButton.Text = "Calculate";
            this.calculatePEButton.UseVisualStyleBackColor = true;
            this.calculatePEButton.Click += new System.EventHandler(this.calculatePEButton_Click);
            // 
            // sharePriceTextBox
            // 
            this.sharePriceTextBox.Location = new System.Drawing.Point(264, 348);
            this.sharePriceTextBox.Name = "sharePriceTextBox";
            this.sharePriceTextBox.Size = new System.Drawing.Size(100, 26);
            this.sharePriceTextBox.TabIndex = 11;
            // 
            // earningsPerShareLabel2
            // 
            this.earningsPerShareLabel2.AutoSize = true;
            this.earningsPerShareLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earningsPerShareLabel2.Location = new System.Drawing.Point(32, 413);
            this.earningsPerShareLabel2.Name = "earningsPerShareLabel2";
            this.earningsPerShareLabel2.Size = new System.Drawing.Size(183, 17);
            this.earningsPerShareLabel2.TabIndex = 19;
            this.earningsPerShareLabel2.Text = "Per Share (EPS) (in USD $)";
            // 
            // liabilitiesTextBox
            // 
            this.liabilitiesTextBox.Location = new System.Drawing.Point(303, 193);
            this.liabilitiesTextBox.Name = "liabilitiesTextBox";
            this.liabilitiesTextBox.Size = new System.Drawing.Size(100, 26);
            this.liabilitiesTextBox.TabIndex = 20;
            // 
            // sharesTextBox
            // 
            this.sharesTextBox.Location = new System.Drawing.Point(903, 193);
            this.sharesTextBox.Name = "sharesTextBox";
            this.sharesTextBox.Size = new System.Drawing.Size(100, 26);
            this.sharesTextBox.TabIndex = 28;
            // 
            // epsRatioTitle
            // 
            this.epsRatioTitle.AutoSize = true;
            this.epsRatioTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epsRatioTitle.Location = new System.Drawing.Point(1052, 140);
            this.epsRatioTitle.Name = "epsRatioTitle";
            this.epsRatioTitle.Size = new System.Drawing.Size(97, 20);
            this.epsRatioTitle.TabIndex = 27;
            this.epsRatioTitle.Text = "EPS Ratio:";
            // 
            // outstandingSharesLabel
            // 
            this.outstandingSharesLabel.AutoSize = true;
            this.outstandingSharesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outstandingSharesLabel.Location = new System.Drawing.Point(630, 198);
            this.outstandingSharesLabel.Name = "outstandingSharesLabel";
            this.outstandingSharesLabel.Size = new System.Drawing.Size(207, 17);
            this.outstandingSharesLabel.TabIndex = 26;
            this.outstandingSharesLabel.Text = "Company\'s Outstanding Shares";
            // 
            // earningsLabel
            // 
            this.earningsLabel.AutoSize = true;
            this.earningsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earningsLabel.Location = new System.Drawing.Point(630, 158);
            this.earningsLabel.Name = "earningsLabel";
            this.earningsLabel.Size = new System.Drawing.Size(250, 17);
            this.earningsLabel.TabIndex = 25;
            this.earningsLabel.Text = "Company Quarter Earnings (in USD $)";
            // 
            // epsTitleLabel
            // 
            this.epsTitleLabel.AutoSize = true;
            this.epsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epsTitleLabel.Location = new System.Drawing.Point(601, 118);
            this.epsTitleLabel.Name = "epsTitleLabel";
            this.epsTitleLabel.Size = new System.Drawing.Size(425, 20);
            this.epsTitleLabel.TabIndex = 24;
            this.epsTitleLabel.Text = "Calculate Your Company\'s Earnings Per Share (EPS) Ratio";
            // 
            // showEPSLabel
            // 
            this.showEPSLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showEPSLabel.Location = new System.Drawing.Point(1056, 178);
            this.showEPSLabel.Name = "showEPSLabel";
            this.showEPSLabel.Size = new System.Drawing.Size(89, 37);
            this.showEPSLabel.TabIndex = 23;
            this.showEPSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateEPSLabel
            // 
            this.calculateEPSLabel.Location = new System.Drawing.Point(903, 238);
            this.calculateEPSLabel.Name = "calculateEPSLabel";
            this.calculateEPSLabel.Size = new System.Drawing.Size(93, 35);
            this.calculateEPSLabel.TabIndex = 22;
            this.calculateEPSLabel.Text = "Calculate";
            this.calculateEPSLabel.UseVisualStyleBackColor = true;
            this.calculateEPSLabel.Click += new System.EventHandler(this.calculateEPSLabel_Click);
            // 
            // earningsTextBox
            // 
            this.earningsTextBox.Location = new System.Drawing.Point(903, 153);
            this.earningsTextBox.Name = "earningsTextBox";
            this.earningsTextBox.Size = new System.Drawing.Size(100, 26);
            this.earningsTextBox.TabIndex = 21;
            // 
            // dollarSignLabel
            // 
            this.dollarSignLabel.AutoSize = true;
            this.dollarSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarSignLabel.Location = new System.Drawing.Point(1030, 186);
            this.dollarSignLabel.Name = "dollarSignLabel";
            this.dollarSignLabel.Size = new System.Drawing.Size(20, 22);
            this.dollarSignLabel.TabIndex = 29;
            this.dollarSignLabel.Text = "$";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(875, 445);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 32);
            this.exitButton.TabIndex = 30;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // blueChipCompaniesComboBox
            // 
            this.blueChipCompaniesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blueChipCompaniesComboBox.FormattingEnabled = true;
            this.blueChipCompaniesComboBox.Items.AddRange(new object[] {
            "",
            "Apple",
            "Microsoft",
            "Walmart"});
            this.blueChipCompaniesComboBox.Location = new System.Drawing.Point(756, 346);
            this.blueChipCompaniesComboBox.Name = "blueChipCompaniesComboBox";
            this.blueChipCompaniesComboBox.Size = new System.Drawing.Size(270, 28);
            this.blueChipCompaniesComboBox.TabIndex = 31;
            this.blueChipCompaniesComboBox.SelectedIndexChanged += new System.EventHandler(this.blueChipCompaniesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(648, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "See the Ratios of Other Famous Companies  (As of 12/4/2021)";
            // 
            // assetErrorProvider
            // 
            this.assetErrorProvider.ContainerControl = this;
            // 
            // liabilitiesErrorProvider
            // 
            this.liabilitiesErrorProvider.ContainerControl = this;
            // 
            // earningsErrorProvider
            // 
            this.earningsErrorProvider.ContainerControl = this;
            // 
            // sharesErrorProvider
            // 
            this.sharesErrorProvider.ContainerControl = this;
            // 
            // sharePriceErrorProvider
            // 
            this.sharePriceErrorProvider.ContainerControl = this;
            // 
            // epsErrorProvider
            // 
            this.epsErrorProvider.ContainerControl = this;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(16, 77);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(80, 20);
            this.dateLabel.TabIndex = 33;
            this.dateLabel.Text = "12/4/2021";
            // 
            // semesterProjectLabel
            // 
            this.semesterProjectLabel.AutoSize = true;
            this.semesterProjectLabel.Location = new System.Drawing.Point(16, 47);
            this.semesterProjectLabel.Name = "semesterProjectLabel";
            this.semesterProjectLabel.Size = new System.Drawing.Size(127, 20);
            this.semesterProjectLabel.TabIndex = 34;
            this.semesterProjectLabel.Text = "SemesterProject";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1223, 33);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.summaryToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // semesterProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 530);
            this.Controls.Add(this.semesterProjectLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blueChipCompaniesComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dollarSignLabel);
            this.Controls.Add(this.sharesTextBox);
            this.Controls.Add(this.epsRatioTitle);
            this.Controls.Add(this.outstandingSharesLabel);
            this.Controls.Add(this.earningsLabel);
            this.Controls.Add(this.epsTitleLabel);
            this.Controls.Add(this.showEPSLabel);
            this.Controls.Add(this.calculateEPSLabel);
            this.Controls.Add(this.earningsTextBox);
            this.Controls.Add(this.liabilitiesTextBox);
            this.Controls.Add(this.earningsPerShareLabel2);
            this.Controls.Add(this.peTitleLabel);
            this.Controls.Add(this.earningsPerShareLabel);
            this.Controls.Add(this.sharePriceLabel);
            this.Controls.Add(this.peRatioTitle);
            this.Controls.Add(this.epsTextBox);
            this.Controls.Add(this.showPELabel);
            this.Controls.Add(this.calculatePEButton);
            this.Controls.Add(this.sharePriceTextBox);
            this.Controls.Add(this.ratio1Label);
            this.Controls.Add(this.currentLiabilitiesLabel);
            this.Controls.Add(this.currentAssetsLabel);
            this.Controls.Add(this.currentRatioTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.showLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.assetsTextBox);
            this.Controls.Add(this.summaryFormButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "semesterProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Miguel Suarez STIM 2311";
            this.Load += new System.EventHandler(this.semesterProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liabilitiesErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earningsErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharesErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharePriceErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsErrorProvider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button summaryFormButton;
        private System.Windows.Forms.TextBox assetsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label showLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label currentRatioTitleLabel;
        private System.Windows.Forms.Label currentAssetsLabel;
        private System.Windows.Forms.Label currentLiabilitiesLabel;
        private System.Windows.Forms.Label ratio1Label;
        private System.Windows.Forms.Label peTitleLabel;
        private System.Windows.Forms.Label earningsPerShareLabel;
        private System.Windows.Forms.Label sharePriceLabel;
        private System.Windows.Forms.Label peRatioTitle;
        private System.Windows.Forms.TextBox epsTextBox;
        private System.Windows.Forms.Label showPELabel;
        private System.Windows.Forms.Button calculatePEButton;
        private System.Windows.Forms.TextBox sharePriceTextBox;
        private System.Windows.Forms.Label earningsPerShareLabel2;
        private System.Windows.Forms.TextBox liabilitiesTextBox;
        private System.Windows.Forms.TextBox sharesTextBox;
        private System.Windows.Forms.Label epsRatioTitle;
        private System.Windows.Forms.Label outstandingSharesLabel;
        private System.Windows.Forms.Label earningsLabel;
        private System.Windows.Forms.Label epsTitleLabel;
        private System.Windows.Forms.Label showEPSLabel;
        private System.Windows.Forms.Button calculateEPSLabel;
        private System.Windows.Forms.TextBox earningsTextBox;
        private System.Windows.Forms.Label dollarSignLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox blueChipCompaniesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider assetErrorProvider;
        private System.Windows.Forms.ErrorProvider liabilitiesErrorProvider;
        private System.Windows.Forms.ErrorProvider earningsErrorProvider;
        private System.Windows.Forms.ErrorProvider sharesErrorProvider;
        private System.Windows.Forms.ErrorProvider sharePriceErrorProvider;
        private System.Windows.Forms.ErrorProvider epsErrorProvider;
        private System.Windows.Forms.ToolTip summaryToolTip;
        private System.Windows.Forms.Label semesterProjectLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
    }
}

