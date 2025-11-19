using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int FindFinalValue(int[] nums, int original)
    {
        // Sort array into a List<int>
        var sortedList = nums.OrderBy(x => x).ToList();

        // Find index of the original value
        var index = sortedList.IndexOf(original);

        if (index == -1)
        {
            // original not found, return it
            return original;
        }
        else
        {
            // Double original
            var dup = original * 2;

            // Slice the list from current index
            var subList = sortedList.GetRange(index, sortedList.Count - index);

            // Recursive call: just pass the values, no types
            return FindFinalValue(subList.ToArray(), dup);
        }
    }
}
