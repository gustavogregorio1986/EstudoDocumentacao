List<int> xs = new();
List<int> ys = new(capacity: 10_000);
List<int> zs = new() { Capacity = 20_000 };

Dictionary<int, List<int>> dict = new()
{
    [1] = new() { 1,2,3 },
    [2] = new() { 5, 8, 3 },
    [5] = new() { 1, 0, 4 }
};

Console.WriteLine(xs);
Console.WriteLine(ys);
Console.WriteLine(zs);

foreach(var item in dict)
{
    Console.WriteLine($"Chave: {item.Key}, Valores: {string.Join(", ", item.Value)}");
}