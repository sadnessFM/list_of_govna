namespace ConsoleApp1;

internal class Program
{
    private static void Main()
    {
        speesok<int> list = new() { 1, 5, 17, 42, -69 };

        list.Print(list);
        
        Console.WriteLine();
        
        list.Delete(17);
        
        list.Print(list);
        Console.WriteLine(list.GetCount());
        Console.WriteLine();
        list.Delete(42);
        list.Print(list);
        Console.WriteLine(list.GetCount());
    }
}