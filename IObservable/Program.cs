using ObservablePattern;

var subscriber = new Subscribe();
var newspaper = new NewsPaper();
newspaper.Subscribe(subscriber);
newspaper.Publish("kd");
