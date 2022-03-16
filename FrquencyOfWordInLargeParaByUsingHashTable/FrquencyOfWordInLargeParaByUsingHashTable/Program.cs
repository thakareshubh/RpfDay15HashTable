using System;

namespace FrquencyOfWordInLargeParaByUsingHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating object of hashtable class
            
            HashTableList<string, string> hash = new HashTableList<string, string>(13);
            
            //storing the value at key point

            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "Paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "keep");
            hash.Add("7", "putting");
            hash.Add("8", "themselves");
            hash.Add("9", "deliberatly");
            hash.Add("10", "into");
            hash.Add("11", "avoidable");
            hash.Add("12", "situation");

            ///calling the value by usng key value pair

            string hash7 = hash.Get("7");
            Console.WriteLine("7 th index value: " + hash7);




        }
    }
}
