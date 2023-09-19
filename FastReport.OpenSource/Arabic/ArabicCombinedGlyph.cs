namespace FastReport.Arabic
{
    public class ArabicCombinedGlyph : ArabicGlyph
    {
        public ArabicCombinedGlyph(
            char code,
            char nextCode,
            char isolated,
            char initial,
            char medial,
            char final)
            : base(code, isolated, initial, medial, final)
        {
            NextCode = nextCode;
        }

        public char NextCode { get; set; }
    }
}