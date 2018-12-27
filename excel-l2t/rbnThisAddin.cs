using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace excel_load_to_text
{
    public partial class rbnThisAddin
    {
		/// <summary>
		/// Called when the Load From Text ribbon action is pressed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void btnLoadDelimitedFile_Click(object sender, RibbonControlEventArgs e)
        {
            DelimiterItem delimiterItem;
            int columnCount = 0;
            OpenFileDialog fileDialog;
            DialogResult dialogResult;
            Tuple<bool, string> importResult = new Tuple<bool, string>(false, string.Empty);

            //
            // Open a file dialog
            fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text (*.pip,*.prn,*.txt,*.csv)|*.pip;*.prn;*.txt;*.csv|All Files (*.*)|*.*";
            fileDialog.Multiselect = false;
            dialogResult = fileDialog.ShowDialog();

            //
            // Was the result ok?
            if (dialogResult == DialogResult.OK)
            {
                //
                // Does the file exist?
                if (fileDialog.CheckFileExists)
                {
                    //
                    // Get the file delimiter
                    delimiterItem = GetDelimiter();
                    if (delimiterItem == default(DelimiterItem))
                    {
                        MessageBox.Show($"File delimiter was not provided.", Constants.Application.Name + " " + Constants.Application.Version, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //
                    // Get the column count
                    columnCount = GetColumnCount(fileDialog.FileName, delimiterItem);
                    if (columnCount == 0)
                    {
                        MessageBox.Show($"Using the delimiter provided, we were unable to identify any columns.", Constants.Application.Name + " " + Constants.Application.Version, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //
                    // Import the file!
                    importResult = OpenDelimitedFileAsText(fileDialog.FileName, delimiterItem, columnCount);
                    if (importResult.Item1 == false)
                        MessageBox.Show($"File failed to load. The following error was captured: {importResult.Item2}", Constants.Application.Name + " " + Constants.Application.Version, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Prompts the user to provide delimiter information for the file
        /// </summary>
        /// <returns></returns>
        private DelimiterItem GetDelimiter()
        {
            DelimiterItem result = default(DelimiterItem);

            try
            {
                //
                // Open the delimiter info form
                frmDelimiter delimiterForm = new frmDelimiter();
				delimiterForm.StartPosition = FormStartPosition.CenterParent;
                delimiterForm.ShowDialog();

                //
                // Capture delimiter result
                result = delimiterForm.DelimiterItem;
            }
            catch { }

            return result;
        }

        /// <summary>
        /// Counts the amount of columns based on the delimiters defined by the user
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="delimiterItem"></param>
        /// <returns></returns>
        private int GetColumnCount(string filePath, DelimiterItem delimiterItem)
        {
            int result = 0;
            int count = 0;
            string[] allLines;
            string[] splitLine;
            FileInfo file;

            try
            {
                //
                // Get the file info
                file = new FileInfo(filePath);
                if (file.Exists)
                {
                    //
                    // Do we have a delimiter?
                    if (!string.IsNullOrEmpty(delimiterItem.GetDelimitingCharacter()))
                    {
                        //
                        // Load all lines
                        allLines = File.ReadAllLines(filePath);
                        foreach (string line in allLines)
                        {
                            //
                            // Split the line at the delimiter
                            splitLine = line.Split(char.Parse(delimiterItem.GetDelimitingCharacter()));
                            if (result < splitLine.Count())
                                result = splitLine.Count();

                            //
                            // If the file > 10000 lines and we have analyzed 30% of the file, break out
                            if (allLines.Count() > 10000 && (count++ / 100) >= 0.30)
                                break;
                        }
                    }
                }
            }
            catch { }

            return result;
        }

        /// <summary>
        /// Loads the delimited file using the delimiters defined by the user
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="delimiterItem"></param>
        /// <param name="columnCount"></param>
        /// <returns></returns>
        private Tuple<bool, string> OpenDelimitedFileAsText(string filePath, DelimiterItem delimiterItem, int columnCount)
        {
            Tuple<bool, string> result;
            object[] fieldInfoArray;
            FileInfo file;
            QueryTable queryTable;
            Worksheet resultWorksheet;

            try
            {
                //
                // Load file info
                file = new FileInfo(filePath);
                if (file.Exists)
                {
                    //
                    // Build file info array
                    fieldInfoArray = new object[columnCount];
                    for (int i = 0; i < columnCount; i++)
                        fieldInfoArray[i] = (int)XlColumnDataType.xlTextFormat;

                    //
                    // Create a new sheet to work with
                    resultWorksheet = Globals.ThisAddIn.Application.ActiveWorkbook.Sheets.Add();
                    resultWorksheet.Name = "Sheet" + Globals.ThisAddIn.Application.ActiveWorkbook.Sheets.Count;

                    //
                    // Import file as text
                    queryTable = resultWorksheet.QueryTables.Add(Connection: $"TEXT;{file.FullName}", Destination: resultWorksheet.Range["$A$1"]);
                    queryTable.TextFileTabDelimiter = delimiterItem.IsTab;
                    queryTable.TextFileSemicolonDelimiter = delimiterItem.IsSemicolon;
                    queryTable.TextFileCommaDelimiter = delimiterItem.IsComma;
                    queryTable.TextFileSpaceDelimiter = delimiterItem.IsSpace;
                    queryTable.TextFileConsecutiveDelimiter = delimiterItem.TreatConsecutiveDelimitersAsOne;
                    queryTable.TextFileParseType = XlTextParsingType.xlDelimited;
                    queryTable.TextFileColumnDataTypes = fieldInfoArray;

                    if (delimiterItem.IsOther) queryTable.TextFileOtherDelimiter = delimiterItem.OtherChar;

                    if (delimiterItem.TextQualifier.Equals("\"")) queryTable.TextFileTextQualifier = XlTextQualifier.xlTextQualifierDoubleQuote;
                    else if (delimiterItem.TextQualifier.Equals("'")) queryTable.TextFileTextQualifier = XlTextQualifier.xlTextQualifierSingleQuote;
                    else queryTable.TextFileTextQualifier = XlTextQualifier.xlTextQualifierNone;

                    queryTable.Refresh();
                    queryTable.Delete();

                    //
                    // Autofit
                    Globals.ThisAddIn.Application.Columns.EntireColumn.AutoFit();

                    //
                    // Set success
                    result = Tuple.Create(true, string.Empty);
                }
                else
                {
                    //
                    // Set failure
                    result = Tuple.Create(false, "File could not be found.");
                }
            }
            catch (Exception ex)
            {
                //
                // Set failure
                result = Tuple.Create(false, ex.Message);
            }

            return result;
        }
    }
}