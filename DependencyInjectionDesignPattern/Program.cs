using DependencyInjectionDesignPattern;
using Microsoft.Extensions.DependencyInjection;
var serviceProvider = new ServiceCollection()
    .AddTransient<IMessageService, EmailMessageService>()
    .AddTransient<IMessageService, SMSMessageService>()
    .AddTransient<IMessageStrategy, MessageStrategy>()
    .BuildServiceProvider();

var messageStrategy = serviceProvider.GetService<IMessageStrategy>();
messageStrategy.Send("email", "kldfjs", ConstantResources.EmailNotification);
messageStrategy.Send("sms", "kldfjs", ConstantResources.SMSNotification);
Console.WriteLine("hello");