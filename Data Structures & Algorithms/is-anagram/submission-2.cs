public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> sDict = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            if (sDict.ContainsKey(s[i])) {
                sDict[s[i]] += 1;
            } else {
                sDict.Add(s[i], 1);
            }
        }
        for (int j = 0; j < t.Length; j++) {
            if (sDict.ContainsKey(t[j])) {
                if (sDict[t[j]] == 0)
                    return false;
                sDict[t[j]] -= 1;
            } else {
                return false;
            }
        }
        if (sDict.Values.All(v => v == 0))
            return true;
        return false;
    }
}
