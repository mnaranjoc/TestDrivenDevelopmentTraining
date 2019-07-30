namespace Chapter1
{
    public class StringUtilities
    {
        public int CountOccurences(string stringToCheck,
        string stringToFind)
        {
            if (stringToCheck == null || stringToCheck == "") return -1;
            var stringAsCharArray = stringToCheck.ToUpper().ToCharArray();
            var stringToCheckForAsChar = stringToFind.ToUpper().ToCharArray()[0];
            var occuranceCount = 0;
            for (var characterIndex = 0;
                characterIndex <= stringAsCharArray.GetUpperBound(0);
                characterIndex++)
            {
                if (stringAsCharArray[characterIndex] == stringToCheckForAsChar)
                {
                    occuranceCount++;
                }
            }
            return occuranceCount;
        }
    }
}
