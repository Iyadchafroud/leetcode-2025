public class Solution {
    public int CountPalindromicSubsequence(string s) {
        // Tableaux pour stocker la première et dernière position de chaque lettre
        int[] first = new int[26];
        int[] last = new int[26];
        
        // Initialisation avec -1
        Array.Fill(first, -1);
        
        // 1. Remplissage des positions
        for (int i = 0; i < s.Length; i++) {
            int idx = s[i] - 'a';
            if (first[idx] == -1) {
                first[idx] = i;
            }
            last[idx] = i;
        }
        
        int ans = 0;
        
        // 2. Itération sur l'alphabet (0 = a, 1 = b, ...)
        for (int i = 0; i < 26; i++) {
            // Vérifie si la lettre existe et s'il y a de la place au milieu
            if (first[i] != -1 && last[i] > first[i] + 1) {
                HashSet<char> uniqueChars = new HashSet<char>();
                
                // Parcourt la sous-chaîne entre la première et dernière occurrence
                for (int j = first[i] + 1; j < last[i]; j++) {
                    uniqueChars.Add(s[j]);
                }
                
                ans += uniqueChars.Count;
            }
        }
        
        return ans;
    }
}