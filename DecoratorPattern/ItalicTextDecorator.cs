namespace DecoratorPattern
{
    internal class ItalicTextDecorator : ITextComponent
    {
        private readonly ITextComponent _textComponent;
        public ItalicTextDecorator(ITextComponent textComponent)
        {
            _textComponent = textComponent;
        }

        public string GetText()
        {
            return "italic " + _textComponent.GetText();
        }
    }
}
