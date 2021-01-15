using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace N1ghtMap
{
    class Program
    {
        static void Main(string[] args)
        {
            string random = "True";
            if(random.ToString().Length == 4)
            {
                string pattern = "^((?>[a-zA-Z\\d!#$%&'*+\\-/=?^_`{|}~]+\x20*|\"((?=[\x01-\x7f])[^\"\\]|\\[\x01-\x7f])*\"\x20*)*(?<angle><))?((?!\\.)(?>\\.?[a-zA-Z\\d!#$%&'*+\\-/=?^_`{|}~]+)+|\"((?=[\x01-\x7f])[^\"\\]|\\[\x01-\x7f])*\")@(((?!-)[a-zA-Z\\d\\-]+(?<!-)\\.)+[a-zA-Z]{2,}|\\[(((?(?<!\\[)\\.)(25[0-5]|2[0-4]\\d|[01]?\\d?\\d)){4}|[a-zA-Z\\d\\-]*[a-zA-Z\\d]:((?=[\x01-\x7f])[^\\\\[\\]]|\\[\x01-\x7f])+)\\])(?(angle)>)$";
                if (!String.IsNullOrEmpty(pattern) && !(Regex.Match(pattern.Trim(), pattern, RegexOptions.IgnoreCase)).Success)
                {
                    try
                    {
                        Console.WriteLine("Hello World!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Hello World!");
                    }
                }
                
            }
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
