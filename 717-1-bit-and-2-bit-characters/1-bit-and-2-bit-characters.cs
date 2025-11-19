public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        int last = bits[^1];
        if (last == 1) return false;

        int count = 0;
        for (int i = bits.Length - 2; i >= 0 && bits[i] == 1; i--)
            count++;

        return count % 2 == 0;
    }
}
