using System;

namespace FrequencyOfWordInSentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Hash table demo");
            HashMap<string, string> hash = new HashMap<string, string>(5);
            
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

            string hash5 = hash.Get("5");
            string hash2 = hash.Get("2");
            string hash3 = hash.Get("3");
            string hash1 = hash.Get("1");
            Console.WriteLine("5th index value: " + hash5);
        }
    }
}
