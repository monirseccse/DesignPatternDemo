using ObservablePattern;

var weather = new Weather();
var observer = new Observable();
weather.Resgister(observer);
var observer2 = new Observable();
weather.Resgister(observer2);
weather.SetTemaparture(39);
