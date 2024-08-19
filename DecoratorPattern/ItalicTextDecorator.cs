using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class ItalicTextDecorator : TextDecorator
    {
        private readonly ITextComponent _textComponent;
        public ItalicTextDecorator(ITextComponent textComponent) : base(textComponent)
        {
            _textComponent = textComponent;
        }

        public override string GetText()
        {
            return "italic "+ _textComponent.GetText();
        }
    }
}
