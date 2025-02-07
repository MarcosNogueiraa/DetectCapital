public class Solution {
    public bool DetectCapitalUse(string word) 
    {
        bool isUpper = char.IsUpper(word[0]);

        if (char.IsUpper(word[0]) && word.Substring(1) == word.Substring(1).ToLower())
            return true;

        foreach(char n in word)
        {
            if(char.IsUpper(n) != isUpper)
                return false;
        }

        return true;
    }
}
