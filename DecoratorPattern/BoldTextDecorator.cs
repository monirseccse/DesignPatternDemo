﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class BoldTextDecorator : TextDecorator
    {
        private readonly ITextComponent _textComponent;
        public BoldTextDecorator(ITextComponent textComponent) : base(textComponent)
        {
            _textComponent = textComponent;
        }
        public override string GetText()
        {
            return "bold " + _textComponent.GetText();
        }

    }
}
