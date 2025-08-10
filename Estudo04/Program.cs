var dict = new Dictionary<string, object>
{
    ["primeiro"] = 10,
    ["segundo"] = 20,
    ["terceiro"] = 30

};

Console.WriteLine(string.Join("; ", dict.Select(entry => $"{entry.Key}: {entry.Value}")));