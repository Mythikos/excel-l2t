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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.chkDelimiterTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDelimiterTab.Location = new System.Drawing.Point(6, 6);
            this.chkDelimiterTab.Name = "chkDelimiterTab";
            this.chkDelimiterTab.Size = new System.Drawing.Size(42, 17);
            this.chkDelimiterTab.TabIndex = 1;
            this.chkDelimiterTab.Text = "Tab";
            this.chkDelimiterTab.UseVisualStyleBackColor = true;
            // 
            // chkDelimiterSemicolon
            // 
            this.chkDelimiterSemicolon.AutoSize = true;
            this.chkDelimiterSemicolon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDelimiterSemicolon.Location = new System.Drawing.Point(6, 29);
            this.chkDelimiterSemicolon.Name = "chkDelimiterSemicolon";
            this.chkDelimiterSemicolon.Size = new System.Drawing.Size(72, 17);
            this.chkDelimiterSemicolon.TabIndex = 2;
            this.chkDelimiterSemicolon.Text = "Semicolon";
            this.chkDelimiterSemicolon.UseVisualStyleBackColor = true;
            // 
            // chkDelimiterComma
            // 
            this.chkDelimiterComma.AutoSize = true;
            this.chkDelimiterComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDelimiterComma.Location = new System.Drawing.Point(6, 52);
            this.chkDelimiterComma.Name = "chkDelimiterComma";
            this.chkDelimiterComma.Size = new System.Drawing.Size(58, 17);
            this.chkDelimiterComma.TabIndex = 3;
            this.chkDelimiterComma.Text = "Comma";
            this.chkDelimiterComma.UseVisualStyleBackColor = true;
            // 
            // chkDelimiterSpace
            // 
            this.chkDelimiterSpace.AutoSize = true;
            this.chkDelimiterSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDelimiterSpace.Location = new System.Drawing.Point(6, 75);
            this.chkDelimiterSpace.Name = "chkDelimiterSpace";
            this.chkDelimiterSpace.Size = new System.Drawing.Size(54, 17);
            this.chkDelimiterSpace.TabIndex = 4;
            this.chkDelimiterSpace.Text = "Space";
            this.chkDelimiterSpace.UseVisualStyleBackColor = true;
            // 
            // chkDelimiterOther
            // 
            this.chkDelimiterOther.AutoSize = true;
            this.chkDelimiterOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDelimiterOther.Location = new System.Drawing.Point(6, 98);
            this.chkDelimiterOther.Name = "chkDelimiterOther";
            this.chkDelimiterOther.Size = new System.Drawing.Size(49, 17);
            this.chkDelimiterOther.TabIndex = 5;
            this.chkDelimiterOther.Text = "Other";
            this.chkDelimiterOther.UseVisualStyleBackColor = true;
            this.chkDelimiterOther.CheckedChanged += new System.EventHandler(this.chkDelimiterOther_CheckedChanged);
            // 
            // txtOtherDelimiter
            // 
            this.txtOtherDelimiter.Enabled = false;
            this.txtOtherDelimiter.Location = new System.Drawing.Point(61, 98);
            this.txtOtherDelimiter.Multiline = true;
            this.txtOtherDelimiter.Name = "txtOtherDelimiter";
            this.txtOtherDelimiter.Size = new System.Drawing.Size(64, 17);
            this.txtOtherDelimiter.TabIndex = 6;
            // 
            // chkTreatConsecutiveDelimitersAsOne
            // 
            this.chkTreatConsecutiveDelimitersAsOne.AutoSize = true;
            this.chkTreatConsecutiveDelimitersAsOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTreatConsecutiveDelimitersAsOne.Location = new System.Drawing.Point(6, 6);
            this.chkTreatConsecutiveDelimitersAsOne.Name = "chkTreatConsecutiveDelimitersAsOne";
            this.chkTreatConsecutiveDelimitersAsOne.Size = new System.Drawing.Size(190, 17);
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
            this.cmbTextQualifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTextQualifier.FormattingEnabled = true;
            this.cmbTextQualifier.Items.AddRange(new object[] {
            "(None)",
            "\"",
            "\'"});
            this.cmbTextQualifier.Location = new System.Drawing.Point(6, 29);
            this.cmbTextQualifier.Name = "cmbTextQualifier";
            this.cmbTextQualifier.Size = new System.Drawing.Size(118, 21);
            this.cmbTextQualifier.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Text qualifier";
            // 
            // btnDone
            // 
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Location = new System.Drawing.Point(183, 105);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(233, 46);
            this.btnDone.TabIndex = 11;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Location = new System.Drawing.Point(16, 29);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(133, 122);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.chkDelimiterTab);
            this.panel2.Controls.Add(this.chkDelimiterSemicolon);
            this.panel2.Controls.Add(this.chkDelimiterComma);
            this.panel2.Controls.Add(this.chkDelimiterSpace);
            this.panel2.Controls.Add(this.chkDelimiterOther);
            this.panel2.Controls.Add(this.txtOtherDelimiter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(131, 120);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel3.Location = new System.Drawing.Point(183, 29);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(1);
            this.panel3.Size = new System.Drawing.Size(233, 67);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.chkTreatConsecutiveDelimitersAsOne);
            this.panel4.Controls.Add(this.cmbTextQualifier);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(231, 65);
            this.panel4.TabIndex = 0;
            // 
            // frmDelimiter
            // 
            this.AcceptButton = this.btnDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 165);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDelimiter";
            this.Text = "Delimiter Info";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}