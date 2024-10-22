using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class ListImp
    {
        public class ArrayList<T>
        {
            private T[] _elements;
            private int _size;
            private const int DefaultCapacity = 6;

            public ArrayList()
            {
                _elements = new T[DefaultCapacity];
                _size = 0;
            }

            public void AddElement(T item)
            {
                if (_size == _elements.Length)
                {
                    Resize(_elements.Length * 2);
                }
                _elements[_size++] = item;  
            }

            public void RemoveAtIndex(int index)
            {
                if (index < 0 || index >= _size)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                }

                for (int i = index; i < _size - 1; i++)
                {
                    _elements[i] = _elements[i + 1];  
                }

                _elements[--_size] = default(T);  
                if (_size > 0 && _size == _elements.Length / 4)
                {
                    Resize(_elements.Length / 2);  
                }
            }

            public T GetElementAt(int index)
            {
                if (index < 0 || index >= _size)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                }
                return _elements[index];
            }

            public int Count => _size;

            public void Resize(int newCapacity)
            {
                T[] newarray = new T[newCapacity];
                Array.Copy(_elements, newarray, _size);
                _elements = newarray;
            }
        }
    }
}
