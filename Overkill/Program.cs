using Delegate = Overkill.Delegate.Delegate;

var delegate1 = new Delegate(Console.WriteLine,
    (value1, value2) => value1 == value2,
    (value1, value2) => value1 + value2);
delegate1.InvokeAll(3, 3);
delegate1.InvokeAll(3, 2);