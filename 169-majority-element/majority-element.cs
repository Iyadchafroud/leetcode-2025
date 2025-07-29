public class Solution {
    public int MajorityElement(int[] nums) {
        var countMap = new Dictionary<int, int>();
        int majorityCount = nums.Length / 2;

        foreach (var num in nums) {
            if (countMap.ContainsKey(num))
                countMap[num]++;
            else
                countMap[num] = 1;

            if (countMap[num] > majorityCount)
                return num;
        }

        return -1; // ne sera jamais atteint car l’élément majoritaire est garanti
    }
}
