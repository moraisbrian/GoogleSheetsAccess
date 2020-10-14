using System;

namespace SheetsAccess
{
    public static class FormatSheetCell
    {
        public static string FormatCell(this string cell) 
        {
            return cell.Split(new string[] { "$t\":" }, StringSplitOptions.None)[1].RemoveSpecialChars();
        }
    }
}