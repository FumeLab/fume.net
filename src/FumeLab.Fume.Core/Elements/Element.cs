﻿using FumeLab.Fume.Core.Selectors;

namespace FumeLab.Fume.Core.Elements
{
    public abstract class Element
    {
        public Selector Selector { get; set; }

        public Element(Selector selector)
        {
            Selector = selector;
        }
    }
}
