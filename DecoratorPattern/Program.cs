using DecoratorPattern;

var text = new Text("hello");
var bold = new BoldTextDecorator(text);
Console.WriteLine(bold.GetText());
