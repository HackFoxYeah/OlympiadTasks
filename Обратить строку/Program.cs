public static string StrReversed(string row)
        {
            int i = 0, j = row.Length - 1;

            char temp;

            char[] charArr = row.ToCharArray();

            while(i <= j)
            {
                temp = charArr[j];

                charArr[j] = charArr[i];

                charArr[i] = temp;

                i++; j--;
            }
            
            return new string(charArr);
        }
