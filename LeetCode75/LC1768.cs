using System.Text;

namespace LeetCode75
{
    /// <summary>
    /// You are given two strings word1 and word2. Merge the strings by adding letters in 
    /// alternating order, starting with word1. If a string is longer than the other, 
    /// append the additional letters onto the end of the merged string. 
    ///
    /// Return the merged string.
    /// </summary>
    internal class LC1768
    {

        /// <summary>
        /// This program takes each string, deconstructs them both, then append it to a new string using string builder
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public string MergeAlternately(string word1, string word2)
        {
            StringBuilder result = new();

            int i = 0;
            int j = 0;

            // Loop through both strings checking whether one string is longer then the other
            while (i < word1.Length || j < word2.Length)
            {
                if (i < word1.Length) { _ = result.Append(word1[i]); i++; }
                if (j < word2.Length) { _ = result.Append(word2[j]); j++; }
            }

            return result.ToString(); // merged string
        }
    } 
}