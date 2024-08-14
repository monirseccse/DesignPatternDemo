using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class BoldTextDecorator : TextDecorator
    {
        public BoldTextDecorator(ITextComponent textComponent) : base(textComponent)
        {
        }
        public override string GetText()
        {
            return "bold" + base.GetText();
        }

    }
}
