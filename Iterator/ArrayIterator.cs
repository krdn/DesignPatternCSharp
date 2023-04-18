namespace Iterator
{
    internal class ArrayIterator : IIterator
    {
        private readonly Array _array;
        private          int   _index;

        public ArrayIterator(Array array)
        {
            this._array = array;
            this._index = -1;
        }

        public bool Next()
        {
            this._index++;
            return this._index < this._array.GetCount();
        }

        public object Current()
        {
            return _array.GetItem(_index);
        }
    }
}
