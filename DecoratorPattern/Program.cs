using DecoratorPattern;

var text = new Text("hello");
var bold = new BoldTextDecorator(text);
Console.WriteLine(bold.GetText());
var italic = new ItalicTextDecorator(text);
Console.WriteLine(italic.GetText());
