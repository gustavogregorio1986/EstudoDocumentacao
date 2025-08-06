using System;
using System.Text;

class Program
{
    static int Main(string[] args)
    {
        StringBuilder builder = new();
        builder.AppendLine("The following arguments are passed:");

        foreach (var arg in args)
        {
            builder.AppendLine(arg);
        }

        Console.WriteLine(builder.ToString());

        return 0; // Código de saída do programa
    }
}
