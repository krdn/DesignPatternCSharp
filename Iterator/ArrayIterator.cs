namespace Iterator
{
    internal class ArrayIterator : Iterator
    {
        private Array _array;
        private int _index;

        public ArrayIterator(Array array)
        {
            this._array = array;
            this._index = 0;
        }

        public bool Next()
        {
            if (_index < _array.getCount())
            {
                _index++;
                return true;
            }
            return false;
        }

        public Object Current()
        {
            return _array.getItem(_index);
        }
    }
}