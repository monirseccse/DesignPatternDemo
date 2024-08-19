using DecoratorPattern;

var text = new PlainText("hello");
//dynamically changing behaviour of a text
var bold = new BoldTextDecorator(text);
Console.WriteLine(bold.GetText());
//dynamically changing behaviour of a text
var italic = new ItalicTextDecorator(text);
Console.WriteLine(italic.GetText());
