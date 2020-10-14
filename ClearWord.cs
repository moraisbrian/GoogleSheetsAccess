namespace GoogleSheetsAccess
{
    public static class ClearWord
    {
        public static string RemoveSpecialChars(this string word)
        {
            return word.Replace("[", "").Replace("]", "")
                .Replace("{", "").Replace("}", "")
                .Replace("\"", "").Replace("\r\n", "")
                .Replace("\n", "").Replace(",", "")
                .Replace(".", "").Trim();
        }
    }
}