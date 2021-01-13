using System;
using System.Collections.Generic;

namespace N1ghtMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class HashMap<T, V>
    {
        private List<T> m_array;

        public HashMap()
        {
            m_array = new List<T>();
        }

        public HashMap(int size)
        {
            m_array = new List<T>(size);
        }

        private int GetHashIndex(T key)
        {
            throw new NotImplementedException();
        }

        private void Add(T key, V value)
        {
            throw new NotImplementedException();
        }

        private void Remove(T key)
        {
            throw new NotImplementedException();
        }
    }
}
