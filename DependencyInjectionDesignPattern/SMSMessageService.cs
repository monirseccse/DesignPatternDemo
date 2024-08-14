
namespace DependencyInjectionDesignPattern
{
    internal class SMSMessageService : IMessageService
    {
        public bool AppliesTo(IEnumerable<string> providers)
        {
            return providers.Contains(ConstantResources.SMSNotification);
        }

        public void Send(string message, string recipient)
        {
            Console.WriteLine("SMS send");
        }
    }
}
