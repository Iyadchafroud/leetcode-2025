public class Solution {
    public IList<bool> PrefixesDivBy5(int[] nums) {
        var answer = new List<bool>(nums.Length);
        int rem = 0;

        foreach (int bit in nums) {
            rem = (rem * 2 + bit) % 5;
            answer.Add(rem == 0);
        }

        return answer;
    }
}
