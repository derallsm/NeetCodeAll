public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        Dictionary <int, int> values = new Dictionary <int, int>();
        foreach(int num in nums){
            if(values.ContainsKey(num)){
                return true;
            }
            values[num] = num;
        }
        return false;

    } 
}