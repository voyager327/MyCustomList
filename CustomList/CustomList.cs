namespace CustomList
{
    public class CustomList<T>
    {
        T[] items;
        public int Capacity { get; set; }
        public int Count { get; set; }

        //constructor
        public CustomList()
        {
            Capacity = 4;
            items = new T[Capacity];
            // 0 1 2 3
            Count = 0;
        }
        // need to create an indexer

        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        public void Add(T item)
        {
            // check if capacity is equal to count
            // if capaciy is equal to count, you need to double the size of your items array
            CheckCapacity();
            items[Count] = item;
            Count++;
        }

        public void CheckCapacity()
        {
            if (Count >= Capacity)
            {   // doubling the capacity to 8
                Capacity = Capacity * 2;
                T[] tempArray = new T[Capacity];
                //copying the old data to the new Array
                for (int i = 0; i < Count; i++)
                {
                    tempArray[i] = items[i];
                }
                items = tempArray;

            }

        }
        public void Remove(T value)
        {
            for (int i = 0; i < Count ; i++)
            {
                if(value.Equals(items[i]))
                {
                    items[i] = items[i + 1];
                }
            }
            Count--;
        }
        public void ToString(T contents)
        {
            
            int spaces1 = 0;
            for (int i = 0; i < contents.Length; i++)
            {
                if (contents[i]  == '')
            }

        }

    }
}
