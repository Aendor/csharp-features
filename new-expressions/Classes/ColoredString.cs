﻿using System;

namespace NewExpressions.Classes
{
    public class ColoredString
    {
        public ConsoleColor Color;
        public String Text;

        public ColoredString(ConsoleColor color, string text)
        {
            Color = color;
            Text = text;
        }
    }
}