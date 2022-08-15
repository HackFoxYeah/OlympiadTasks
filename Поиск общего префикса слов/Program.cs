public static string TheLongestPrefix(string someString)
        {
            string[] strArr = someString.Split(' ', ',', '/');

            string prefix = strArr[0]; // взятие первой строки из массива строк как префикс

            for (int i = 1; i < strArr.Length; i++)
            {
                while (strArr[i].IndexOf(prefix) != 0) // строка-префикс обрезается, пока не сможет считаться началом текущей i-той строки массива строк
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    if (prefix == "") // если строка-префикс превратилась в пустую строку, то не существует общего префикса у всех строк из массива строк
                    {
                        return "";
                    }
                }
            }

            return prefix;
        }
