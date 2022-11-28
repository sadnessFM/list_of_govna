using System.Collections;

namespace ConsoleApp1
{
    public class speesok<T> : IEnumerable<T>
    {
        private Item<T>? _head;
        private Item<T>? _tail;
        private int Count { get; set; }

        public void Print(speesok<int> list)
        {
            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
        }
        
        public void Add(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            
            Item<T> item = new Item<T>(data);

            if (_head == null)
                _head = item;
            else
                _tail!.Next = item;

            _tail = item;

            Count++;
        }


        public void Delete(T data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Item<T>? current = _head;
            Item<T>? previous = null;
            
            while(current != null)
            {
                if(current.Data != null && current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if(current.Next == null)
                        {
                            _tail = previous;
                        }
                    }
                    else
                    {
                        _head = _head?.Next;
                        
                        if(_head == null)
                        {
                            _tail = null;
                        }
                    }
                    Count--;
                    break;
                }
                previous = current;
                current = current.Next;
            }
        }
        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            Item<T>? current = _head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();
    }
}
