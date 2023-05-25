public class Solution {
    public int[] GetConcatenation(int[] nums) {
        
        int n = nums.Length;
        int[] ans = new int[n*2];

        for( int ite = 0; ite < n; ite++ ) {
            ans[ite] = nums[ite];
            ans[ite + n] = nums[ite];
        }

        return ans;
    }
}