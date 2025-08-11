using Estudo17;
using System;

namespace Estudo17
{
    public class GenericList<T>
    { 
          public void Add(T item) { }
    }

    public class ExampleClass { }

    public class TestGenericList
    {
        static void Main(string[] args)
        {
            GenericList<int> list1 = new();
            list1.Add(1);

            GenericList<string> list2 = new();
            list2.Add("");

            GenericList<ExampleClass> list3 = new();
        list3.Add(new ExampleClass());
    }
    }
}
