public class Solution {
    public bool DetectCapitalUse(string word) 
    {
        bool isUpper = char.IsUpper(word[0]);

        foreach(char n in word)
        {
            if(char.IsUpper(n) != isUpper)
                return false;
        }

        return true;
    }
}
