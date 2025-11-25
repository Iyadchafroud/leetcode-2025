public class Solution {
    public int SmallestRepunitDivByK(int k) {
        if (k % 2 == 0 || k % 5 == 0)
        return -1;

    int rem = 0;

    // At most k iterations before remainder repeats
    for (int length = 1; length <= k; length++)
    {
        rem = (rem * 10 + 1) % k;
        if (rem == 0)
            return length;
    }

    return -1;
    }
}