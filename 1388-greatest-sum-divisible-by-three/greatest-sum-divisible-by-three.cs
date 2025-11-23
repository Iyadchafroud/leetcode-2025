public class Solution
{
    public int MaxSumDivThree(int[] nums)
    {
        var mod1 = new List<int>();
        var mod2 = new List<int>();
        int sum = 0;

        foreach (int n in nums)
        {
            sum += n;

            int r = n % 3;
            if (r == 1)
                mod1.Add(n);
            else if (r == 2)
                mod2.Add(n);
        }

        
        mod1.Sort();
        mod2.Sort();

        int mod = sum % 3;
        if (mod == 0)
            return sum;

        int removeOne = int.MaxValue;
        int removeTwo = int.MaxValue;

        if (mod == 1)
        {
            if (mod1.Count >= 1)
                removeOne = mod1[0];

            if (mod2.Count >= 2)
                removeTwo = mod2[0] + mod2[1];
        }
        else // mod == 2
        {
            if (mod2.Count >= 1)
                removeOne = mod2[0];

            if (mod1.Count >= 2)
                removeTwo = mod1[0] + mod1[1];
        }

        int toRemove = Math.Min(removeOne, removeTwo);
        if (toRemove == int.MaxValue)
            return 0; // no valid way

        return sum - toRemove;
    }
}
