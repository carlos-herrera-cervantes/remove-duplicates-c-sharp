using System;

namespace RemoveDuplicatesDomain.Models
{
    public class SuperArray
    {
        #region Snippet_PowerfulMethods

        /// <summary>
        /// Remove duplicated elements
        /// </summary>
        /// <typeparam name="T">Class</typeparam>
        /// <param name="elements">Array of elements</param>
        /// <returns>Array</returns>
        public static int RemoveDuplicates<T>(T[] elements)
        {
            if (elements.Length == 0 || elements is null) return 0;

            Array.Sort(elements);
            int i = 0;

            for (int j = 1; j < elements.Length; j++)
            {
                if (!elements[j].Equals(elements[i]))
                {
                    i++;
                    elements[i] = elements[j];
                }
            }

            return i + 1;
        }

        #endregion
    }
}
