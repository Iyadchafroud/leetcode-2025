public class Solution {
    public void MoveZeroes(int[] nums) {
        var zeroList = new List<int>();
        var integerList = new List<int>();

        foreach (int n in nums) {
            if (n == 0)
                zeroList.Add(n);
            else
                integerList.Add(n);
        }

        int i = 0;
        foreach (int n in integerList)
            nums[i++] = n;
        foreach (int n in zeroList)
            nums[i++] = n;

        Console.WriteLine("[" + string.Join(", ", nums) + "]");
    }
}
