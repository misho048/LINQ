using System.Collections.Generic;
using System.Linq;

namespace LinqTests
{
    internal static class Extensions
    {
        public static bool ContentEquals<TKey, TValue>(this Dictionary<TKey, TValue> dictionary,
                                                       Dictionary<TKey, TValue> otherDictionary)
        {
            if (otherDictionary == null)
            {
                otherDictionary = new Dictionary<TKey, TValue>();
            }

            return dictionary.SequenceEqual(otherDictionary);
        }

        public static bool ContentEquals<TKey, TValue, TInnerValue>(this Dictionary<TKey, TValue> dictionary,
                                                                    Dictionary<TKey, TValue> otherDictionary) where TValue : IEnumerable<TInnerValue>
        {
            if (otherDictionary == null)
            {
                otherDictionary = new Dictionary<TKey, TValue>();
            }

            return dictionary.Keys.SequenceEqual(otherDictionary.Keys) &&
                   dictionary.Keys.All(key => otherDictionary.ContainsKey(key) &&
                                              dictionary[key].SequenceEqual(otherDictionary[key]));
        }
    }
}