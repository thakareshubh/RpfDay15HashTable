using System;
using System.Collections;
using System.Collections.Generic;

namespace RemovalOfWordFromHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating object of hashtable class

            HashTableMap<string, string> hash = new HashTableMap<string, string>(13);

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

            

            
            

        }
    }
}
