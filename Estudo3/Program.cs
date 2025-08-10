var dict = new Dictionary<string, int>();
dict["primeiro"] = 10;
dict["segundo"] = 20;
dict["terceiro"] = 30;

Console.WriteLine(string.Join("; ", dict.Select(entry => $"{entry.Key}: {entry.Value}")));