﻿using System;

namespace Gwen.Net.RichText
{
    public class FontPart : Part
    {
        private readonly Font font;

        public FontPart(Font font = null)
        {
            this.font = font;
        }

        public override string[] Split(ref Font splitFont)
        {
            splitFont = font;

            return Array.Empty<string>();
        }
    }
}
