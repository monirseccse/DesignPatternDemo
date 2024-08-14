using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Text : ITextComponent
    {
        private readonly string _text;

        public Text(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            Console.WriteLine("plain");
            return _text;
        }
    }
}
