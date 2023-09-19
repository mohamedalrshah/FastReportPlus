// Copyright 2019 Stefan Holm Olsen
//
// Permission to use, copy, modify, and/or distribute this software for an
// purpose with or without fee is hereby granted, provided that the above
// copyright notice and this permission notice appear in all copies.
//
// THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
// WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
// MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
// ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
// WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
// ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT
// OF OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.

using System.Diagnostics;

namespace FastReport.Arabic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class ArabicGlyph
    {
        public ArabicGlyph(char code, char isolated, char initial, char medial, char final)
        {
            Code = code;
            Isolated = isolated;
            Initial = initial;
            Medial = medial;
            Final = final;
        }

        public char Code { get; set; }
        public char Isolated { get; set; }
        public char Initial { get; set; }
        public char Medial { get; set; }
        public char Final { get; set; }

        private string DebuggerDisplay => $"{(ushort)Code}/0x{(ushort)Code:X}";
    }
}