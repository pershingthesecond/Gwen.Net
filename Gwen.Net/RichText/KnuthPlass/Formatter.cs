﻿using System.Collections.Generic;
using Gwen.Net.Renderer;

namespace Gwen.Net.RichText.KnuthPlass
{
    internal abstract class Formatter
    {
        protected readonly Font defaultFont;
        protected readonly RendererBase renderer;

        public Formatter(RendererBase renderer, Font defaultFont)
        {
            this.renderer = renderer;
            this.defaultFont = defaultFont;
        }

        public void MeasureText(Font font, string text, out int width, out int height)
        {
            Size p = renderer.MeasureText(font, text);
            width = p.Width;
            height = p.Height;
        }

        public Size MeasureText(Font font, string text)
        {
            Size size = renderer.MeasureText(font, text);

            return size;
        }

        public abstract List<Node> FormatParagraph(Paragraph paragraph);
    }
}
