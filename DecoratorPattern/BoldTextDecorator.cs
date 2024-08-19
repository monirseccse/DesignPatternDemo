using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class BoldTextDecorator : ITextComponent
    {
        private readonly ITextComponent _textComponent;
        public BoldTextDecorator(ITextComponent textComponent) 
        {
            _textComponent = textComponent;
        }
        public string GetText()
        {
            return "bold " + _textComponent.GetText();
        }

    }
}
