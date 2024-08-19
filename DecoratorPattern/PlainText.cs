using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class PlainText : ITextComponent
    {
        private readonly string _text;

        public PlainText(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }
    }
}
