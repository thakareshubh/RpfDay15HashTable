using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyOfWordInSentence
{
    public class HashMap<K, V>
    {        
        /// <summary>
        /// The size and key value pair  are initializig.
        /// </summary>
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
        

        /// <summary>
        /// Initializes a new instance of the <see cref="HashMap{K, V}"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
       
        public HashMap(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        

         /// <summary>
         /// Gets the linked list.
         /// </summary>
         /// <param name="position">The position.</param>
         /// <returns></returns>
         protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkList = items[position];
            if (linkList == null)
            {
                linkList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkList;
            }
            return linkList;
        }
        

         /// <summary>
         /// Gets the array position.
         /// </summary>
         /// <param name="key">The key.</param>
         /// <returns></returns>
         protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        

         /// <summary>
         /// Gets the specified key.
         /// </summary>
         /// <param name="key">The key.</param>
         /// <returns></returns>
         public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.Key.Equals(key) )
                {
                    return item.Value;
                }

            }
            return default(V);
        }
        

        /// <summary>
        /// Adds the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linklst = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linklst.AddLast(item);
        }



    }     
/// <summary>
/// Assing the value
/// </summary>
/// <typeparam name="k"></typeparam>
/// <typeparam name="v"></typeparam>
     public struct KeyValue<k, v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }
}
