public class Solution {
    const long MOD = 1_000_000_007;
    public int CountTrapezoids(int[][] points) {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        // Count how many points lie on each horizontal line (same y)
        foreach (var p in points) {
            int y = p[1];
            if (!freq.ContainsKey(y))
                freq[y] = 0;
            freq[y]++;
        }

        long S = 0;          // sum of C(cnt, 2)
        long sumSquares = 0; // sum of C(cnt, 2)^2

        foreach (var kv in freq) {
            int count = kv.Value;
            if (count >= 2) {
                long pairs = ((long)count * (count - 1) / 2) % MOD;
                S = (S + pairs) % MOD;
                sumSquares = (sumSquares + (pairs * pairs) % MOD) % MOD;
            }
        }

        // total = (S^2 - sumSquares) / 2 mod MOD
        long S2 = (S * S) % MOD;
        long diff = (S2 - sumSquares + MOD) % MOD;

        // modular inverse of 2 under MOD = (MOD + 1) / 2
        long inv2 = (MOD + 1) / 2;

        return (int)((diff * inv2) % MOD);
    }
}