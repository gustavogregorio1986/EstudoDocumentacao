var a = new int[3] { 10, 20, 30 };
var b = new[] { 10, 20, 30 };
var c = new[] { 10, 20, 30 };

foreach (var item in a)
    Console.WriteLine(item);

foreach (var item in c)
    Console.WriteLine(item);

Console.WriteLine(c.GetType());