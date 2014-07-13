namespace TextCleaner
{
    partial class Clean
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
            this.grpCommon = new System.Windows.Forms.GroupBox();
            this.chkNumber = new System.Windows.Forms.CheckBox();
            this.btnCommonNone = new System.Windows.Forms.Button();
            this.btnCommonAll = new System.Windows.Forms.Button();
            this.chkNBSP = new System.Windows.Forms.CheckBox();
            this.chkSpaces = new System.Windows.Forms.CheckBox();
            this.chkYo = new System.Windows.Forms.CheckBox();
            this.chkPageBreak = new System.Windows.Forms.CheckBox();
            this.chkDigitDashDigit = new System.Windows.Forms.CheckBox();
            this.chkSpaceDots = new System.Windows.Forms.CheckBox();
            this.chkCRLFSpace = new System.Windows.Forms.CheckBox();
            this.chkSpaceCRLF = new System.Windows.Forms.CheckBox();
            this.chkLineBreak = new System.Windows.Forms.CheckBox();
            this.chkTab = new System.Windows.Forms.CheckBox();
            this.chkPercent = new System.Windows.Forms.CheckBox();
            this.chkSpaceDashSpace = new System.Windows.Forms.CheckBox();
            this.prgrsMain = new System.Windows.Forms.ProgressBar();
            this.grpSecondary = new System.Windows.Forms.GroupBox();
            this.btnSecondaryNone = new System.Windows.Forms.Button();
            this.btnSecondaryAll = new System.Windows.Forms.Button();
            this.chkPreposition = new System.Windows.Forms.CheckBox();
            this.chkYearAndCity = new System.Windows.Forms.CheckBox();
            this.chkItalicBrackets = new System.Windows.Forms.CheckBox();
            this.chkItalicDigits = new System.Windows.Forms.CheckBox();
            this.grpRare = new System.Windows.Forms.GroupBox();
            this.chkEquationsReset = new System.Windows.Forms.CheckBox();
            this.chkInitials = new System.Windows.Forms.CheckBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFormatting = new System.Windows.Forms.GroupBox();
            this.btnFormatingNone = new System.Windows.Forms.Button();
            this.btnFormattingAll = new System.Windows.Forms.Button();
            this.chkHyphen = new System.Windows.Forms.CheckBox();
            this.chkTracking = new System.Windows.Forms.CheckBox();
            this.chkBlack = new System.Windows.Forms.CheckBox();
            this.chkHyperlinks = new System.Windows.Forms.CheckBox();
            this.grpCommon.SuspendLayout();
            this.grpSecondary.SuspendLayout();
            this.grpRare.SuspendLayout();
            this.grpFormatting.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCommon
            // 
            this.grpCommon.Controls.Add(this.chkHyperlinks);
            this.grpCommon.Controls.Add(this.chkNumber);
            this.grpCommon.Controls.Add(this.btnCommonNone);
            this.grpCommon.Controls.Add(this.btnCommonAll);
            this.grpCommon.Controls.Add(this.chkNBSP);
            this.grpCommon.Controls.Add(this.chkSpaces);
            this.grpCommon.Controls.Add(this.chkYo);
            this.grpCommon.Controls.Add(this.chkPageBreak);
            this.grpCommon.Controls.Add(this.chkDigitDashDigit);
            this.grpCommon.Controls.Add(this.chkSpaceDots);
            this.grpCommon.Controls.Add(this.chkCRLFSpace);
            this.grpCommon.Controls.Add(this.chkSpaceCRLF);
            this.grpCommon.Controls.Add(this.chkLineBreak);
            this.grpCommon.Controls.Add(this.chkTab);
            this.grpCommon.Controls.Add(this.chkPercent);
            this.grpCommon.Controls.Add(this.chkSpaceDashSpace);
            this.grpCommon.Location = new System.Drawing.Point(12, 12);
            this.grpCommon.Name = "grpCommon";
            this.grpCommon.Size = new System.Drawing.Size(372, 167);
            this.grpCommon.TabIndex = 0;
            this.grpCommon.TabStop = false;
            this.grpCommon.Text = "Common substitutions";
            // 
            // chkNumber
            // 
            this.chkNumber.AutoSize = true;
            this.chkNumber.Checked = true;
            this.chkNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumber.Location = new System.Drawing.Point(6, 65);
            this.chkNumber.Name = "chkNumber";
            this.chkNumber.Size = new System.Drawing.Size(37, 17);
            this.chkNumber.TabIndex = 14;
            this.chkNumber.Text = "№";
            this.chkNumber.UseVisualStyleBackColor = true;
            // 
            // btnCommonNone
            // 
            this.btnCommonNone.Location = new System.Drawing.Point(291, 138);
            this.btnCommonNone.Name = "btnCommonNone";
            this.btnCommonNone.Size = new System.Drawing.Size(75, 23);
            this.btnCommonNone.TabIndex = 13;
            this.btnCommonNone.Text = "None";
            this.btnCommonNone.UseVisualStyleBackColor = true;
            this.btnCommonNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnCommonAll
            // 
            this.btnCommonAll.Location = new System.Drawing.Point(209, 138);
            this.btnCommonAll.Name = "btnCommonAll";
            this.btnCommonAll.Size = new System.Drawing.Size(75, 23);
            this.btnCommonAll.TabIndex = 12;
            this.btnCommonAll.Text = "All";
            this.btnCommonAll.UseVisualStyleBackColor = true;
            this.btnCommonAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // chkNBSP
            // 
            this.chkNBSP.AutoSize = true;
            this.chkNBSP.Checked = true;
            this.chkNBSP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNBSP.Location = new System.Drawing.Point(265, 88);
            this.chkNBSP.Name = "chkNBSP";
            this.chkNBSP.Size = new System.Drawing.Size(55, 17);
            this.chkNBSP.TabIndex = 11;
            this.chkNBSP.Text = "NBSP";
            this.chkNBSP.UseVisualStyleBackColor = true;
            // 
            // chkSpaces
            // 
            this.chkSpaces.AutoSize = true;
            this.chkSpaces.Checked = true;
            this.chkSpaces.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpaces.Location = new System.Drawing.Point(265, 65);
            this.chkSpaces.Name = "chkSpaces";
            this.chkSpaces.Size = new System.Drawing.Size(62, 17);
            this.chkSpaces.TabIndex = 10;
            this.chkSpaces.Text = "Spaces";
            this.chkSpaces.UseVisualStyleBackColor = true;
            // 
            // chkYo
            // 
            this.chkYo.AutoSize = true;
            this.chkYo.Location = new System.Drawing.Point(265, 42);
            this.chkYo.Name = "chkYo";
            this.chkYo.Size = new System.Drawing.Size(53, 17);
            this.chkYo.TabIndex = 9;
            this.chkYo.Text = "ё -> е";
            this.chkYo.UseVisualStyleBackColor = true;
            // 
            // chkPageBreak
            // 
            this.chkPageBreak.AutoSize = true;
            this.chkPageBreak.Location = new System.Drawing.Point(265, 19);
            this.chkPageBreak.Name = "chkPageBreak";
            this.chkPageBreak.Size = new System.Drawing.Size(79, 17);
            this.chkPageBreak.TabIndex = 8;
            this.chkPageBreak.Text = "PageBreak";
            this.chkPageBreak.UseVisualStyleBackColor = true;
            // 
            // chkDigitDashDigit
            // 
            this.chkDigitDashDigit.AutoSize = true;
            this.chkDigitDashDigit.Checked = true;
            this.chkDigitDashDigit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDigitDashDigit.Location = new System.Drawing.Point(140, 88);
            this.chkDigitDashDigit.Name = "chkDigitDashDigit";
            this.chkDigitDashDigit.Size = new System.Drawing.Size(93, 17);
            this.chkDigitDashDigit.TabIndex = 7;
            this.chkDigitDashDigit.Text = "DigitDashDigit";
            this.chkDigitDashDigit.UseVisualStyleBackColor = true;
            // 
            // chkSpaceDots
            // 
            this.chkSpaceDots.AutoSize = true;
            this.chkSpaceDots.Checked = true;
            this.chkSpaceDots.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpaceDots.Location = new System.Drawing.Point(140, 65);
            this.chkSpaceDots.Name = "chkSpaceDots";
            this.chkSpaceDots.Size = new System.Drawing.Size(79, 17);
            this.chkSpaceDots.TabIndex = 6;
            this.chkSpaceDots.Text = "SpaceDots";
            this.chkSpaceDots.UseVisualStyleBackColor = true;
            // 
            // chkCRLFSpace
            // 
            this.chkCRLFSpace.AutoSize = true;
            this.chkCRLFSpace.Checked = true;
            this.chkCRLFSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCRLFSpace.Location = new System.Drawing.Point(140, 42);
            this.chkCRLFSpace.Name = "chkCRLFSpace";
            this.chkCRLFSpace.Size = new System.Drawing.Size(84, 17);
            this.chkCRLFSpace.TabIndex = 5;
            this.chkCRLFSpace.Text = "CRLFSpace";
            this.chkCRLFSpace.UseVisualStyleBackColor = true;
            // 
            // chkSpaceCRLF
            // 
            this.chkSpaceCRLF.AutoSize = true;
            this.chkSpaceCRLF.Checked = true;
            this.chkSpaceCRLF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpaceCRLF.Location = new System.Drawing.Point(140, 19);
            this.chkSpaceCRLF.Name = "chkSpaceCRLF";
            this.chkSpaceCRLF.Size = new System.Drawing.Size(84, 17);
            this.chkSpaceCRLF.TabIndex = 4;
            this.chkSpaceCRLF.Text = "SpaceCRLF";
            this.chkSpaceCRLF.UseVisualStyleBackColor = true;
            // 
            // chkLineBreak
            // 
            this.chkLineBreak.AutoSize = true;
            this.chkLineBreak.Checked = true;
            this.chkLineBreak.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLineBreak.Location = new System.Drawing.Point(6, 111);
            this.chkLineBreak.Name = "chkLineBreak";
            this.chkLineBreak.Size = new System.Drawing.Size(77, 17);
            this.chkLineBreak.TabIndex = 3;
            this.chkLineBreak.Text = "Line Break";
            this.chkLineBreak.UseVisualStyleBackColor = true;
            // 
            // chkTab
            // 
            this.chkTab.AutoSize = true;
            this.chkTab.Checked = true;
            this.chkTab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTab.Location = new System.Drawing.Point(6, 88);
            this.chkTab.Name = "chkTab";
            this.chkTab.Size = new System.Drawing.Size(76, 17);
            this.chkTab.TabIndex = 2;
            this.chkTab.Text = "Tabulation";
            this.chkTab.UseVisualStyleBackColor = true;
            // 
            // chkPercent
            // 
            this.chkPercent.AutoSize = true;
            this.chkPercent.Checked = true;
            this.chkPercent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPercent.Location = new System.Drawing.Point(6, 42);
            this.chkPercent.Name = "chkPercent";
            this.chkPercent.Size = new System.Drawing.Size(34, 17);
            this.chkPercent.TabIndex = 1;
            this.chkPercent.Text = "%";
            this.chkPercent.UseVisualStyleBackColor = true;
            // 
            // chkSpaceDashSpace
            // 
            this.chkSpaceDashSpace.AutoSize = true;
            this.chkSpaceDashSpace.Checked = true;
            this.chkSpaceDashSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpaceDashSpace.Location = new System.Drawing.Point(6, 19);
            this.chkSpaceDashSpace.Name = "chkSpaceDashSpace";
            this.chkSpaceDashSpace.Size = new System.Drawing.Size(113, 17);
            this.chkSpaceDashSpace.TabIndex = 0;
            this.chkSpaceDashSpace.Text = "SpaceDashSpace";
            this.chkSpaceDashSpace.UseVisualStyleBackColor = true;
            // 
            // prgrsMain
            // 
            this.prgrsMain.Location = new System.Drawing.Point(11, 462);
            this.prgrsMain.Name = "prgrsMain";
            this.prgrsMain.Size = new System.Drawing.Size(373, 17);
            this.prgrsMain.TabIndex = 1;
            // 
            // grpSecondary
            // 
            this.grpSecondary.Controls.Add(this.btnSecondaryNone);
            this.grpSecondary.Controls.Add(this.btnSecondaryAll);
            this.grpSecondary.Controls.Add(this.chkPreposition);
            this.grpSecondary.Controls.Add(this.chkYearAndCity);
            this.grpSecondary.Controls.Add(this.chkItalicBrackets);
            this.grpSecondary.Controls.Add(this.chkItalicDigits);
            this.grpSecondary.Location = new System.Drawing.Point(12, 185);
            this.grpSecondary.Name = "grpSecondary";
            this.grpSecondary.Size = new System.Drawing.Size(372, 95);
            this.grpSecondary.TabIndex = 2;
            this.grpSecondary.TabStop = false;
            this.grpSecondary.Text = "Secondary substitutions";
            // 
            // btnSecondaryNone
            // 
            this.btnSecondaryNone.Location = new System.Drawing.Point(291, 66);
            this.btnSecondaryNone.Name = "btnSecondaryNone";
            this.btnSecondaryNone.Size = new System.Drawing.Size(75, 23);
            this.btnSecondaryNone.TabIndex = 15;
            this.btnSecondaryNone.Text = "None";
            this.btnSecondaryNone.UseVisualStyleBackColor = true;
            this.btnSecondaryNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnSecondaryAll
            // 
            this.btnSecondaryAll.Location = new System.Drawing.Point(209, 66);
            this.btnSecondaryAll.Name = "btnSecondaryAll";
            this.btnSecondaryAll.Size = new System.Drawing.Size(75, 23);
            this.btnSecondaryAll.TabIndex = 14;
            this.btnSecondaryAll.Text = "All";
            this.btnSecondaryAll.UseVisualStyleBackColor = true;
            this.btnSecondaryAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // chkPreposition
            // 
            this.chkPreposition.AutoSize = true;
            this.chkPreposition.Checked = true;
            this.chkPreposition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreposition.Location = new System.Drawing.Point(140, 42);
            this.chkPreposition.Name = "chkPreposition";
            this.chkPreposition.Size = new System.Drawing.Size(78, 17);
            this.chkPreposition.TabIndex = 6;
            this.chkPreposition.Text = "Preposition";
            this.chkPreposition.UseVisualStyleBackColor = true;
            // 
            // chkYearAndCity
            // 
            this.chkYearAndCity.AutoSize = true;
            this.chkYearAndCity.Location = new System.Drawing.Point(140, 19);
            this.chkYearAndCity.Name = "chkYearAndCity";
            this.chkYearAndCity.Size = new System.Drawing.Size(89, 17);
            this.chkYearAndCity.TabIndex = 5;
            this.chkYearAndCity.Text = "Year and City";
            this.chkYearAndCity.UseVisualStyleBackColor = true;
            // 
            // chkItalicBrackets
            // 
            this.chkItalicBrackets.AutoSize = true;
            this.chkItalicBrackets.Checked = true;
            this.chkItalicBrackets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkItalicBrackets.Location = new System.Drawing.Point(6, 42);
            this.chkItalicBrackets.Name = "chkItalicBrackets";
            this.chkItalicBrackets.Size = new System.Drawing.Size(93, 17);
            this.chkItalicBrackets.TabIndex = 4;
            this.chkItalicBrackets.Text = "Italic Brackets";
            this.chkItalicBrackets.UseVisualStyleBackColor = true;
            // 
            // chkItalicDigits
            // 
            this.chkItalicDigits.AutoSize = true;
            this.chkItalicDigits.Checked = true;
            this.chkItalicDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkItalicDigits.Location = new System.Drawing.Point(6, 19);
            this.chkItalicDigits.Name = "chkItalicDigits";
            this.chkItalicDigits.Size = new System.Drawing.Size(77, 17);
            this.chkItalicDigits.TabIndex = 3;
            this.chkItalicDigits.Text = "Italic Digits";
            this.chkItalicDigits.UseVisualStyleBackColor = true;
            // 
            // grpRare
            // 
            this.grpRare.Controls.Add(this.chkEquationsReset);
            this.grpRare.Controls.Add(this.chkInitials);
            this.grpRare.Location = new System.Drawing.Point(12, 394);
            this.grpRare.Name = "grpRare";
            this.grpRare.Size = new System.Drawing.Size(372, 42);
            this.grpRare.TabIndex = 3;
            this.grpRare.TabStop = false;
            this.grpRare.Text = "Rare substitutions";
            // 
            // chkEquationsReset
            // 
            this.chkEquationsReset.AutoSize = true;
            this.chkEquationsReset.Checked = true;
            this.chkEquationsReset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEquationsReset.Location = new System.Drawing.Point(140, 19);
            this.chkEquationsReset.Name = "chkEquationsReset";
            this.chkEquationsReset.Size = new System.Drawing.Size(124, 17);
            this.chkEquationsReset.TabIndex = 1;
            this.chkEquationsReset.Text = "Reset equations size";
            this.chkEquationsReset.UseVisualStyleBackColor = true;
            // 
            // chkInitials
            // 
            this.chkInitials.AutoSize = true;
            this.chkInitials.Enabled = false;
            this.chkInitials.Location = new System.Drawing.Point(6, 19);
            this.chkInitials.Name = "chkInitials";
            this.chkInitials.Size = new System.Drawing.Size(55, 17);
            this.chkInitials.TabIndex = 0;
            this.chkInitials.Text = "Initials";
            this.chkInitials.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(309, 485);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(12, 444);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(24, 13);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "Idle";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(11, 485);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(245, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 7;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpFormatting
            // 
            this.grpFormatting.Controls.Add(this.btnFormatingNone);
            this.grpFormatting.Controls.Add(this.btnFormattingAll);
            this.grpFormatting.Controls.Add(this.chkHyphen);
            this.grpFormatting.Controls.Add(this.chkTracking);
            this.grpFormatting.Controls.Add(this.chkBlack);
            this.grpFormatting.Location = new System.Drawing.Point(12, 288);
            this.grpFormatting.Name = "grpFormatting";
            this.grpFormatting.Size = new System.Drawing.Size(372, 82);
            this.grpFormatting.TabIndex = 8;
            this.grpFormatting.TabStop = false;
            this.grpFormatting.Text = "Formating";
            // 
            // btnFormatingNone
            // 
            this.btnFormatingNone.Location = new System.Drawing.Point(291, 53);
            this.btnFormatingNone.Name = "btnFormatingNone";
            this.btnFormatingNone.Size = new System.Drawing.Size(75, 23);
            this.btnFormatingNone.TabIndex = 17;
            this.btnFormatingNone.Text = "None";
            this.btnFormatingNone.UseVisualStyleBackColor = true;
            this.btnFormatingNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnFormattingAll
            // 
            this.btnFormattingAll.Location = new System.Drawing.Point(209, 53);
            this.btnFormattingAll.Name = "btnFormattingAll";
            this.btnFormattingAll.Size = new System.Drawing.Size(75, 23);
            this.btnFormattingAll.TabIndex = 16;
            this.btnFormattingAll.Text = "All";
            this.btnFormattingAll.UseVisualStyleBackColor = true;
            this.btnFormattingAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // chkHyphen
            // 
            this.chkHyphen.AutoSize = true;
            this.chkHyphen.Checked = true;
            this.chkHyphen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHyphen.Location = new System.Drawing.Point(265, 19);
            this.chkHyphen.Name = "chkHyphen";
            this.chkHyphen.Size = new System.Drawing.Size(101, 17);
            this.chkHyphen.TabIndex = 18;
            this.chkHyphen.Text = "Off hyphenation";
            this.chkHyphen.UseVisualStyleBackColor = true;
            // 
            // chkTracking
            // 
            this.chkTracking.AutoSize = true;
            this.chkTracking.Checked = true;
            this.chkTracking.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTracking.Location = new System.Drawing.Point(140, 19);
            this.chkTracking.Name = "chkTracking";
            this.chkTracking.Size = new System.Drawing.Size(107, 17);
            this.chkTracking.TabIndex = 17;
            this.chkTracking.Text = "Remove tracking";
            this.chkTracking.UseVisualStyleBackColor = true;
            // 
            // chkBlack
            // 
            this.chkBlack.AutoSize = true;
            this.chkBlack.Checked = true;
            this.chkBlack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBlack.Location = new System.Drawing.Point(6, 19);
            this.chkBlack.Name = "chkBlack";
            this.chkBlack.Size = new System.Drawing.Size(97, 17);
            this.chkBlack.TabIndex = 16;
            this.chkBlack.Text = "Set black color";
            this.chkBlack.UseVisualStyleBackColor = true;
            // 
            // chkHyperlinks
            // 
            this.chkHyperlinks.AutoSize = true;
            this.chkHyperlinks.Checked = true;
            this.chkHyperlinks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHyperlinks.Location = new System.Drawing.Point(140, 111);
            this.chkHyperlinks.Name = "chkHyperlinks";
            this.chkHyperlinks.Size = new System.Drawing.Size(75, 17);
            this.chkHyperlinks.TabIndex = 15;
            this.chkHyperlinks.Text = "Hyperlinks";
            this.chkHyperlinks.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(396, 519);
            this.Controls.Add(this.grpFormatting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.grpRare);
            this.Controls.Add(this.grpSecondary);
            this.Controls.Add(this.prgrsMain);
            this.Controls.Add(this.grpCommon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.Text = "Text Cleaner";
            this.grpCommon.ResumeLayout(false);
            this.grpCommon.PerformLayout();
            this.grpSecondary.ResumeLayout(false);
            this.grpSecondary.PerformLayout();
            this.grpRare.ResumeLayout(false);
            this.grpRare.PerformLayout();
            this.grpFormatting.ResumeLayout(false);
            this.grpFormatting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCommon;
        private System.Windows.Forms.CheckBox chkSpaceDashSpace;
        private System.Windows.Forms.CheckBox chkNBSP;
        private System.Windows.Forms.CheckBox chkSpaces;
        private System.Windows.Forms.CheckBox chkYo;
        private System.Windows.Forms.CheckBox chkPageBreak;
        private System.Windows.Forms.CheckBox chkDigitDashDigit;
        private System.Windows.Forms.CheckBox chkSpaceDots;
        private System.Windows.Forms.CheckBox chkCRLFSpace;
        private System.Windows.Forms.CheckBox chkSpaceCRLF;
        private System.Windows.Forms.CheckBox chkLineBreak;
        private System.Windows.Forms.CheckBox chkTab;
        private System.Windows.Forms.CheckBox chkPercent;
        private System.Windows.Forms.ProgressBar prgrsMain;
        private System.Windows.Forms.Button btnCommonNone;
        private System.Windows.Forms.Button btnCommonAll;
        private System.Windows.Forms.GroupBox grpSecondary;
        private System.Windows.Forms.Button btnSecondaryNone;
        private System.Windows.Forms.Button btnSecondaryAll;
        private System.Windows.Forms.CheckBox chkPreposition;
        private System.Windows.Forms.CheckBox chkYearAndCity;
        private System.Windows.Forms.CheckBox chkItalicBrackets;
        private System.Windows.Forms.CheckBox chkItalicDigits;
        private System.Windows.Forms.GroupBox grpRare;
        private System.Windows.Forms.CheckBox chkInitials;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkNumber;
        private System.Windows.Forms.GroupBox grpFormatting;
        private System.Windows.Forms.CheckBox chkBlack;
        private System.Windows.Forms.CheckBox chkTracking;
        private System.Windows.Forms.CheckBox chkHyphen;
        private System.Windows.Forms.Button btnFormatingNone;
        private System.Windows.Forms.Button btnFormattingAll;
        private System.Windows.Forms.CheckBox chkEquationsReset;
        private System.Windows.Forms.CheckBox chkHyperlinks;
    }
}