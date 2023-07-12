public class Solution {
    public bool IsSubsequence(string s, string t) {
        //check s and t not null
        if(string.IsNullOrEmpty(s) && string.IsNullOrEmpty(s)) {
            return true;
        } else {
            int pointer = 0;
            for(int i = 0; i < t.Length && pointer < s.Length; i++) {
                if(t[i] == s[pointer]) {
                    pointer++;
                }
            }
            return pointer == s.Length;
        }
    }
}