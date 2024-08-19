namespace ObservablePattern
{
    internal class NewsPaper : INewsPaper
    {
        private List<ISubscriber> _subscribers = [];
        string _news;

        public void Notify()
        {
            foreach (var item in _subscribers)
            {
                item.Update(_news);
            }
        }

        public void Publish(string news)
        {
            _news = news;
            Notify();
        }

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void UnSubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }
    }
}