namespace ConsoleApp1;

public class Item<T>
{
    public Item(T data)
    {
        if(data == null)
        {
            throw new ArgumentNullException(nameof(data));
        }
        Data = data;
    }
    
    public override string ToString() => Data?.ToString() ?? throw new InvalidOperationException();
    
    public T Data { get; }
    public Item<T>? Next { get; set; }
}