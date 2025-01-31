using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    /// <summary>
    /// There are 'n' kids with candies. You are given an int array candies, where 
    /// each candies[i] represents the number of candies the 'i'th kid has, and an int
    /// extraCandies, denoting the number of extra candies that you have. return a bool
    /// array result of length 'n', where result[i] is true if, after giving the 'i'th kid 
    /// all the extraCandies, they will have the greatest number of candies among all the kids,
    /// or false otherwise. Note that multiple kids can have the greatest number of candies
    /// 
    /// Example 1:
    /// Input: candies = [2,3,5,1,3], extraCandies = 3
    /// Output: [true, true, true, false, true]
    /// Explanation: If you give all extraCandies to:
    /// - Kid 1, they will have 2 + 3 = 5 candies, which is the greatest among the kids.
    /// - Kid 2, they will have 3 + 3 = 6 candies, which is the greatest among the kids.
    /// - Kid 3, they will have 5 + 3 = 8 candies, which is the greatest among the kids.
    /// - Kid 4, they will have 1 + 3 = 4 candies, which is not the greatest among the kids.
    /// - Kid 5, they will have 3 + 3 = 6 candies, which is the greatest among the kids.
    /// 
    /// Constraints:
    /// n == candies.length
    /// 2 <= n <= 100
    /// 1 <= candies[i] <= 100
    /// 1 <= extraCandies <= 50
    /// 
    /// </summary>
    internal class LC1431
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="candies"></param>
        /// <param name="extraCandies"></param>
        /// <returns></returns>
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> result = new List<bool>();

            int numberKids = candies.Length;


            return result;
        }
    }
}
