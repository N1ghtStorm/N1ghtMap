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


    public class HashMap<T, E>
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

        
    }
}
