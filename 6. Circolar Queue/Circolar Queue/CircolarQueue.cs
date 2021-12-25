using System;

namespace Circolar_Queue
{
    class CircolarQueue <T>
    {
        private int _firstIndex = 0;
        private int _count = 0;
        private bool _isEmpty;
        private T[] _arr;
        private int _lenght;
        
        public CircolarQueue(int length = 10)
        {
            _arr = new T[length];
            _lenght = length;
            _isEmpty = true;
        }

        public int Lenght { get => _lenght;}

        public void Add(T val)
        {
            int possibleLastIndex;
            if(_count == _lenght - 1)
                possibleLastIndex = 0;
            else
                possibleLastIndex = _count + 1;
            
            if(!_isEmpty && _count == _firstIndex)//array full
            {
                ResizeAndReorder();
                _arr[_count] = val;//add element
            }
            else
            {
                _arr[_count] = val;//add element
                _count = possibleLastIndex;
            }
            _isEmpty = false;
        }
        public T Remove()
        {
            if(_isEmpty)
            {
                throw new NullReferenceException("The queue is empty");
            }
            T valoreRimosso = _arr[_firstIndex];
            int possibleFirstIndex;
            if (_firstIndex == _lenght - 1)
                possibleFirstIndex = 0;
            else
                possibleFirstIndex = _firstIndex + 1;


            if (possibleFirstIndex == _count)//array empty
            {
                _isEmpty = true;
                _firstIndex = 0;//reset index at 0
                _count = 0;
            }
            else
            {
                _firstIndex = possibleFirstIndex;//remove element
            }
            return valoreRimosso;

        }

        public void ResizeAndReorder()
        {
            Array.Resize(ref _arr, _lenght * 2);
            if(_firstIndex != 0)
            {
                int j = 0;
                for (int i = _firstIndex; i < _lenght; i++)
                {
                    _arr[j] = _arr[i];
                    j++;
                }
                for (int i = 0; i< _firstIndex; i++)
                {
                    _arr[j] = _arr[i];
                    j++;
                }
            }
            
            _firstIndex = 0;
            _count = _lenght;
            _lenght = _arr.Length;
        }
        public override string ToString()
        {
            string s = "";
            foreach (T item in _arr)
            {
                s += item+"\t";
            }
            return s;
        }
    }
}
