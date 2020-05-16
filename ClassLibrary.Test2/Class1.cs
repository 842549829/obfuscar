using System;

namespace ClassLibrary.Test2
{
    public class Class1
    {
        private readonly object _lock = new object();

        public int Add(int left , int right)
        {
            lock (_lock)
            {
                return left + right;
            }
        }
    }
}
