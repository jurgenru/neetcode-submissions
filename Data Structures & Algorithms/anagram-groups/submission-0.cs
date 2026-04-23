public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary <string, List<string>> anagramDict = new Dictionary <string, List<string>>();
        for (int i = 0; i < strs.Length; i++) {
            string uniqueWord = FingerPrint(strs[i]);
            if (anagramDict.ContainsKey(uniqueWord)) {
                anagramDict[uniqueWord].Add(strs[i]);
            } else {
                anagramDict.Add(uniqueWord, [strs[i]]);
            }
        }
        return anagramDict.Values.ToList();
    }

    public string FingerPrint(string word) {
        return String.Concat(word.OrderBy(c => c));
    }
}
