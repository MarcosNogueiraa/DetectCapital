public class Solution {
    public bool DetectCapitalUse(string word) 
    {
        int upperCount = 0;
        int length = word.Length;

        foreach (char n in word)
        {
            if (char.IsUpper(n)) 
                upperCount++;
        }

        return upperCount == 0 || upperCount == length || (upperCount == 1 && char.IsUpper(word[0]));
    }
}
