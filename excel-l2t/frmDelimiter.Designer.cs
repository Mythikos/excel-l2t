namespace excel_load_to_text
{
    partial class frmDelimiter
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
			this.label1 = new System.Windows.Forms.Label();
			this.chkDelimiterTab = new System.Windows.Forms.CheckBox();
			this.chkDelimiterSemicolon = new System.Windows.Forms.CheckBox();
			this.chkDelimiterComma = new System.Windows.Forms.CheckBox();
			this.chkDelimiterSpace = new System.Windows.Forms.CheckBox();
			this.chkDelimiterOther = new System.Windows.Forms.CheckBox();
			this.txtOtherDelimiter = new System.Windows.Forms.TextBox();
			this.chkTreatConsecutiveDelimitersAsOne = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbTextQualifier = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnDone = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Delimiters";
			// 
			// chkDelimiterTab
			// 
			this.chkDelimiterTab.AutoSize = true;
			this.chkDelimiterTab.Location = new System.Drawing.Point(21, 29);
			this.chkDelimiterTab.Name = "chkDelimiterTab";
			this.chkDelimiterTab.Size = new System.Drawing.Size(45, 17);
			this.chkDelimiterTab.TabIndex = 1;
			this.chkDelimiterTab.Text = "Tab";
			this.chkDelimiterTab.UseVisualStyleBackColor = true;
			// 
			// chkDelimiterSemicolon
			// 
			this.chkDelimiterSemicolon.AutoSize = true;
			this.chkDelimiterSemicolon.Location = new System.Drawing.Point(21, 52);
			this.chkDelimiterSemicolon.Name = "chkDelimiterSemicolon";
			this.chkDelimiterSemicolon.Size = new System.Drawing.Size(75, 17);
			this.chkDelimiterSemicolon.TabIndex = 2;
			this.chkDelimiterSemicolon.Text = "Semicolon";
			this.chkDelimiterSemicolon.UseVisualStyleBackColor = true;
			// 
			// chkDelimiterComma
			// 
			this.chkDelimiterComma.AutoSize = true;
			this.chkDelimiterComma.Location = new System.Drawing.Point(21, 75);
			this.chkDelimiterComma.Name = "chkDelimiterComma";
			this.chkDelimiterComma.Size = new System.Drawing.Size(61, 17);
			this.chkDelimiterComma.TabIndex = 3;
			this.chkDelimiterComma.Text = "Comma";
			this.chkDelimiterComma.UseVisualStyleBackColor = true;
			// 
			// chkDelimiterSpace
			// 
			this.chkDelimiterSpace.AutoSize = true;
			this.chkDelimiterSpace.Location = new System.Drawing.Point(21, 98);
			this.chkDelimiterSpace.Name = "chkDelimiterSpace";
			this.chkDelimiterSpace.Size = new System.Drawing.Size(57, 17);
			this.chkDelimiterSpace.TabIndex = 4;
			this.chkDelimiterSpace.Text = "Space";
			this.chkDelimiterSpace.UseVisualStyleBackColor = true;
			// 
			// chkDelimiterOther
			// 
			this.chkDelimiterOther.AutoSize = true;
			this.chkDelimiterOther.Location = new System.Drawing.Point(21, 121);
			this.chkDelimiterOther.Name = "chkDelimiterOther";
			this.chkDelimiterOther.Size = new System.Drawing.Size(52, 17);
			this.chkDelimiterOther.TabIndex = 5;
			this.chkDelimiterOther.Text = "Other";
			this.chkDelimiterOther.UseVisualStyleBackColor = true;
			this.chkDelimiterOther.CheckedChanged += new System.EventHandler(this.chkDelimiterOther_CheckedChanged);
			// 
			// txtOtherDelimiter
			// 
			this.txtOtherDelimiter.Enabled = false;
			this.txtOtherDelimiter.Location = new System.Drawing.Point(79, 119);
			this.txtOtherDelimiter.Name = "txtOtherDelimiter";
			this.txtOtherDelimiter.Size = new System.Drawing.Size(42, 20);
			this.txtOtherDelimiter.TabIndex = 6;
			// 
			// chkTreatConsecutiveDelimitersAsOne
			// 
			this.chkTreatConsecutiveDelimitersAsOne.AutoSize = true;
			this.chkTreatConsecutiveDelimitersAsOne.Location = new System.Drawing.Point(188, 29);
			this.chkTreatConsecutiveDelimitersAsOne.Name = "chkTreatConsecutiveDelimitersAsOne";
			this.chkTreatConsecutiveDelimitersAsOne.Size = new System.Drawing.Size(193, 17);
			this.chkTreatConsecutiveDelimitersAsOne.TabIndex = 7;
			this.chkTreatConsecutiveDelimitersAsOne.Text = "Treat consecutive delimiters as one";
			this.chkTreatConsecutiveDelimitersAsOne.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(180, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Options";
			// 
			// cmbTextQualifier
			// 
			this.cmbTextQualifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTextQualifier.FormattingEnabled = true;
			this.cmbTextQualifier.Items.AddRange(new object[] {
            "(None)",
            "\"",
            "\'"});
			this.cmbTextQualifier.Location = new System.Drawing.Point(188, 52);
			this.cmbTextQualifier.Name = "cmbTextQualifier";
			this.cmbTextQualifier.Size = new System.Drawing.Size(118, 21);
			this.cmbTextQualifier.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(312, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Text qualifier";
			// 
			// btnDone
			// 
			this.btnDone.Location = new System.Drawing.Point(188, 117);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new System.Drawing.Size(191, 23);
			this.btnDone.TabIndex = 11;
			this.btnDone.Text = "Done";
			this.btnDone.UseVisualStyleBackColor = true;
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// frmDelimiter
			// 
			this.AcceptButton = this.btnDone;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 150);
			this.Controls.Add(this.btnDone);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbTextQualifier);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.chkTreatConsecutiveDelimitersAsOne);
			this.Controls.Add(this.txtOtherDelimiter);
			this.Controls.Add(this.chkDelimiterOther);
			this.Controls.Add(this.chkDelimiterSpace);
			this.Controls.Add(this.chkDelimiterComma);
			this.Controls.Add(this.chkDelimiterSemicolon);
			this.Controls.Add(this.chkDelimiterTab);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmDelimiter";
			this.Text = "w";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDelimiterTab;
        private System.Windows.Forms.CheckBox chkDelimiterSemicolon;
        private System.Windows.Forms.CheckBox chkDelimiterComma;
        private System.Windows.Forms.CheckBox chkDelimiterSpace;
        private System.Windows.Forms.CheckBox chkDelimiterOther;
        private System.Windows.Forms.TextBox txtOtherDelimiter;
        private System.Windows.Forms.CheckBox chkTreatConsecutiveDelimitersAsOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDone;
		private System.Windows.Forms.ComboBox cmbTextQualifier;
	}
}