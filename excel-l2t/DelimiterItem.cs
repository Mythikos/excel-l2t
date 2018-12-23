using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excel_load_to_text
{
    public class DelimiterItem
    {
        public bool IsTab { get; set; }
        public bool IsSemicolon { get; set; }
        public bool IsComma { get; set; }
        public bool IsSpace { get; set; }
        public bool IsOther { get; set; }
        public bool TreatConsecutiveDelimitersAsOne { get; set; }
        public string TextQualifier { get; set; }
        public string OtherChar { get; set; }

        public DelimiterItem()
        {
            this.IsTab = false;
            this.IsSemicolon = false;
            this.IsComma = false;
            this.IsSpace = false;
            this.IsOther = false;
            this.TreatConsecutiveDelimitersAsOne = false;
            this.TextQualifier = string.Empty;
            this.OtherChar = string.Empty;
        }

        public string GetDelimitingCharacter()
        {
            if (this.IsTab)
                return "\t";
            else if (this.IsSemicolon)
                return ";";
            else if (this.IsComma)
                return ",";
            else if (this.IsSpace)
                return " ";
            else if (this.IsOther)
                return this.OtherChar;

            return string.Empty;
        }
    }
}
