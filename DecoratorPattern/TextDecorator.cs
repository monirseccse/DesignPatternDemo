using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal abstract class TextDecorator : ITextComponent
    {
        protected readonly ITextComponent _textComponent;

        protected TextDecorator(ITextComponent textComponent)
        {
            _textComponent = textComponent;
        }

        public virtual string GetText()
        {
            return _textComponent.GetText();
        }
    }
}
