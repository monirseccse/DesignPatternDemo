using Mediator;
//Each object will communicate through mediator.
Chatroom chatroom = new Chatroom();
var monir = new User(chatroom, "monir");
var kamal = new User(chatroom, "kamal");
monir.Send("Hi");
kamal.Send("Hello");