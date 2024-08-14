using StrategyPattern;

var cart = new ShoppingCart();
cart.SetPaymentStrategy(new BkashPayment());
cart.CheckOut(100m);