using System.Linq.Expressions;

namespace Task9Generics
{
    internal class GenericArray<T> where T : Human
    {
        private T[]? _arrayOfElements;

        public T[]? ArrayOfElements { get => _arrayOfElements; private set => _arrayOfElements = value; }

        public GenericArray()
        {

        }

        public GenericArray(T[] array)
        {
            ArrayOfElements = array;
        }

        public void GetElementByIndex(int index)
        {
            if (ArrayOfElements is null)
            {
                throw new NullReferenceException();
            }
            else
            {
                Console.WriteLine($"Element at index {index} is {ArrayOfElements[index]}");
            }
        }

        public void GetElementCount()
        {
            if (ArrayOfElements is null)
            {
                throw new NullReferenceException();
            }
            else
            {
                Console.WriteLine($"Total elements in array: {ArrayOfElements.Length}");
            }
        }

        public void Add(T item)
        {
            ArrayOfElements ??= Array.Empty<T>();
            T[] temp = new T[ArrayOfElements.Length + 1];

            for (var i = 0; i < temp.Length; i++)
            {
                if (i == temp.Length - 1)
                {
                    temp[i] = item;
                }
                else
                {
                        temp[i] = ArrayOfElements[i];
                }
            }

            ArrayOfElements = temp;
        }

        public void RemoveAt(int index)
        {
            if (ArrayOfElements is null)
            {
                throw new NullReferenceException();
            }
            else
            {
                if (index > ArrayOfElements.Length || index < 0)
                {
                   throw new IndexOutOfRangeException();
                }
                else
                {
                    T[] temp = new T[ArrayOfElements.Length - 1];

                    for (var i = 0; i < temp.Length; i++)
                    {
                        if (i < index)
                        {
                            temp[i] = ArrayOfElements[i];
                        }
                        else
                        {
                            temp[i] = ArrayOfElements[i + 1];
                        }
                    }

                    ArrayOfElements = temp;
                }
            }
        }

        public void ClearData()
        {
            ArrayOfElements = Array.Empty<T>();
        }

        public override string ToString()
        {
            string? info = string.Empty;

            if (ArrayOfElements is not null)
            {
                var isMenHere = false;
                var isWomanHere = false;

                for (var i = 0; i < ArrayOfElements.Length; i++)
                {
                    info += $"{i}: {ArrayOfElements[i]}\n";

                    if (ArrayOfElements[i] is Man)
                    {
                        isMenHere = true;
                    }
                    else if (ArrayOfElements[i] is Woman)
                    {
                        isWomanHere = true;
                    }
                }

                if (!isWomanHere)
                {
                    info += "They're only men";
                }
                else if (!isMenHere)
                {
                    info += "They're only women";
                }
            }

            return info;
        }
    }
}
