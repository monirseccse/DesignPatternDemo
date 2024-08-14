namespace DependencyInjectionDesignPattern
{
    public interface IMessageService
    {
        void Send(string subject, string body);
        bool AppliesTo(IEnumerable<string> providers);
    }
}
