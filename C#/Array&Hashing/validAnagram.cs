public class Solution {
    public bool IsAnagram(string s, string t) {
        if( s.Length != t.Length){
            return false;
        }
    
        Dictionary<char, int> map = new Dictionary<char, int>();
        for( int ite = 0; ite < s.Length; ite++){
            char c = s[ite];

            // Add elements to the dictionary
            if( map.ContainsKey( c )){
                map[c]++;
            } else {
                map.Add( c, 1 );
            }

            //Check awainst the elements in t string
            // Add if does not exists, substract if exists
            if( map.ContainsKey( t[ite] ) ){
                map[ t[ite] ]--;
            } else {
                map.Add( t[ite], -1);
            }
        }

        return !map.Any( x => x.Value != 0);
    }
}