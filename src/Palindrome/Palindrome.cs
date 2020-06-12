namespace Palindrome
{
    /// <summary>
    ///     Palindrome class is responsible for determining if an input is equal to a palindrome. 
    /// </summary>
    public class Palindrome
    {
        #region Methods

        /// <summary>
        ///     Is valid checks if a string (word or phrase) input is truely a panindrome.
        /// </summary>
        /// <param name="input">The input to validate.</param>
        /// <returns>If the input is a valid palindrome.</returns>
        public bool IsValid(string input)
        {
            if (input is null)
            {
                return false;
            }

            // Index's needed to compare letters or digits
            var index1 = 0;
            var index2 = input.Length - 1;

            while (true)
            {
                if (index1 > index2)
                {
                    return true;
                }

                // To hold characters
                var c1 = input[index1];
                var c2 = input[index2];

                // Loop forward while we don't have a letter or digit
                while (!char.IsLetterOrDigit(c1))
                {
                    index1++;

                    if (index1 > index2)
                    {
                        return true;
                    }

                    c1 = input[index1];
                }

                // Loop backward while we don't have a letter or digit
                while (!char.IsLetterOrDigit(c2))
                {
                    index2--;

                    if (index1 > index2)
                    {
                        return true;
                    }

                    c2 = input[index2];
                }

                if (char.ToLower(c1) != char.ToLower(c2))
                {
                    return false;
                }

                index1++;
                index2--;
            }
        }

        #endregion
    }
}
