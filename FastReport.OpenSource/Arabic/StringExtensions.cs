using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FastReport.Arabic
{
    public static class StringExtensions
    {
        private static readonly Regex ContainsArabicCharsOnlyRegex = new Regex(
            @"^[\u0020-\u002F|\u0600-\u06FF|\d]+$",
            RegexOptions.CultureInvariant | RegexOptions.Compiled);

        public static bool ContainsArabicCharactersOnly(this string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            if (text == string.Empty)
            {
                return false;
            }

            return ContainsArabicCharsOnlyRegex.IsMatch(text);
        }
        //--------------------------
        private static readonly Regex ArabicCharRegex = new Regex(
        @"[\u0020-\u002F|\u0600-\u06FF|\d]+",
        RegexOptions.CultureInvariant | RegexOptions.Compiled);

        public static string ConvertToArabicGlyphs(this string text)
        {
            MatchEvaluator m = match => string.Concat(ArabicGlyphConverter.ConvertToArabicGlyphs(match.Value).Reverse());
            return ArabicCharRegex.Replace(text, m);
        }
    }
}
