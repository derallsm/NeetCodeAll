using System.Text.RegularExpressions;

public class Solution {
    public int LengthOfLastWord(string s) {
        int counter = 0;
        int pointer = s.Length - 1;
        
        while(!Char.IsLetterOrDigit(s[pointer])) {
            pointer--;
        }
        
        while(Char.IsLetterOrDigit(s[pointer])) {
            //Console.WriteLine($"{s[pointer]} char in position {pointer}");
            counter++;
            pointer--;
            if (pointer < 0){
                return counter;        
            }
        }
        
        return counter;
    }
}