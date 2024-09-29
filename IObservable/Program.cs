using ObservablePattern;

var subscriber = new Subscribe();
var subscriber2 = new Subscribe();
var newspaper = new NewsPaper();
newspaper.Subscribe(subscriber);
newspaper.Subscribe(subscriber2);
newspaper.Publish("123");
