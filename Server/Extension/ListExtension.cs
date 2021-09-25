using System;
using System.Collections.Generic;

namespace Server.Extension
{
    public static class ListExtension
    {
        public static T GetAndRemove<T>(this IList<T> list, int index)
        {
            if (index < 0 || index >= list.Count)
            {
                return default;
            }
            var value = list[index];
            list.RemoveAt(index);
            return value;
        }

        public static void AppendAll<T>(this IList<T> destination, IList<T> source)
        {
            foreach (var element in source)
            {
                destination.Add(element);
            }
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            var random = new Random();
            for (var index = list.Count - 1; index > 0; index--)
            {
                list.Swap(index, random.Next(index + 1));
            }
        }

        public static void Swap<T>(this IList<T> list, int firstIndex, int secondIndex)
        {
            var element = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = element;
        }
    }
}
