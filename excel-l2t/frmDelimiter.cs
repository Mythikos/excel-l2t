using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excel_load_to_text
{
    public partial class frmDelimiter : Form
    {
        public DelimiterItem DelimiterItem { get; private set; } = default(DelimiterItem);

		#region Constructor
		/// <summary>
		/// Default constructor
		/// </summary>
		public frmDelimiter()
        {
            InitializeComponent();
			this.cmbTextQualifier.SelectedIndex = 0;
        }
		#endregion

		#region Control Event
		/// <summary>
		/// Handles the submission and validation of the delimiter form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDone_Click(object sender, EventArgs e)
        {
			//
			// Validate
            if (this.chkDelimiterTab.Checked == false && this.chkDelimiterSemicolon.Checked == false
                && this.chkDelimiterComma.Checked == false && this.chkDelimiterSpace.Checked == false
                && this.chkDelimiterOther.Checked == false)
            {
                MessageBox.Show("Must provide atleast one delimiter.", Constants.Application.Name + " " + Constants.Application.Version, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.chkDelimiterOther.Checked == true && string.IsNullOrEmpty(this.txtOtherDelimiter.Text))
            {
                MessageBox.Show("Must provide the other delimiter.", Constants.Application.Name + " " + Constants.Application.Version, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

			//
			// Delimiter
            this.DelimiterItem = new DelimiterItem();
			this.DelimiterItem.IsTab = this.chkDelimiterTab.Checked;
			this.DelimiterItem.IsSemicolon = this.chkDelimiterSemicolon.Checked;
			this.DelimiterItem.IsComma = this.chkDelimiterComma.Checked;
			this.DelimiterItem.IsSpace = this.chkDelimiterSpace.Checked;
			this.DelimiterItem.IsOther = this.chkDelimiterOther.Checked;
			this.DelimiterItem.OtherChar = this.txtOtherDelimiter.Text;
			this.DelimiterItem.TreatConsecutiveDelimitersAsOne = this.chkTreatConsecutiveDelimitersAsOne.Checked;
			if (this.cmbTextQualifier.Text != "(None)")
				this.DelimiterItem.TextQualifier = this.cmbTextQualifier.Text;
			else
				this.DelimiterItem.TextQualifier = this.cmbTextQualifier.Text;

			//
			// Close
			this.Close();
        }

		/// <summary>
		/// Handles the checking/unchecking of the other checkbox
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void chkDelimiterOther_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkDelimiterOther.Checked == true)
			{
				this.txtOtherDelimiter.Enabled = true;
			}
			else
			{
				this.txtOtherDelimiter.Text = string.Empty;
				this.txtOtherDelimiter.Enabled = false;
			}
		}
		#endregion
	}
}
