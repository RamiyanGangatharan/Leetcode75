namespace LeetCode75
{
    /// <summary>
    /// GREATEST COMMON DIVISOR OF STRINGS
    /// For two strings s and t, we say "t divides s" if and only if 
    /// s = t + t + t + ... + t + t (i.e., t is concatenated with itself 
    /// one or more times). Given two strings str1 and str2, return the 
    /// largest string x such that x divides both str1 and str2.
    /// 
    /// Example 1:
    /// Input: str1 = "ABCABC", str2 = "ABC"
    /// Output: "ABC"
    /// 
    /// Example 2:
    /// Input: str1 = "ABABAB", str2 = "ABAB"
    /// Output: "AB"
    /// 
    /// Example 3:
    /// Input: str1 = "LEET", str2 = "CODE"
    /// Output: "" 
    /// 
    /// Constraints:
    /// 1 <= str1.length, str2.length <= 1000
    /// str1 and str2 consist of English uppercase letters.
    /// </summary>
    internal class LC1071
    {
        /// <summary>
        /// This function basically takes the 'remainder' of dividing the two string values,
        /// then it outputs the remainder via the modulo operator
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public string GcdOfStrings(string str1, string str2)
        {
            // Check if str1 + str2 is the same as str2 + str1
            if (str1 + str2 != str2 + str1) { return string.Empty; }
            int gcdLength = Gcd(str1.Length, str2.Length);
            return str1[..gcdLength];
        }

        /// <summary>
        /// This is a helper function to determine the greatest common divisor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
