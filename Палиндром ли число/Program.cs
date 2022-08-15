       public static bool PalindromeNumber(int number)
        {
            int revertedNumber = 0;

            if (number < 0 || (number % 10 == 0 && number != 0))
            {
                return false; // отрицательные числа не явлвются палиндромами,
            }                 // как и числа, окончивающиеся на 0, не являющиеся 0.           

            while (number > revertedNumber) // проверка на достижение половины числа (так как половины друг другу равны в палиндроме, то большего нам не нужно.
            {
                revertedNumber = revertedNumber * 10 + number % 10;
                number /= 10;
            }

            return number == revertedNumber || number == revertedNumber / 10;

            // во второй проверке на равенство можно откинуть последнее число в дубликате,                                                                              
            // так как оно является серединой и не влияет на палиндромность числа (в случае, если кол-во цифр нечётное).
        }
