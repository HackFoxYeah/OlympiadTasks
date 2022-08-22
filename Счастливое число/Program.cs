// A happy number is a number defined by the following process:
//Starting with any positive integer, replace the number by the sum of the squares of its digits.
//Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
//Those numbers for which this process ends in 1 are happy.
//Return true if n is a happy number, and false if not.

private static int GetNext(int value) // метод ищет сумму цифр числа
        {
            int totalSum = 0;

            while (value > 0)
            {
                int temp = value % 10;

                value = value / 10;

                totalSum += temp * temp;
            }

            return totalSum;
        }

        public static bool IsHappy(int value)
        {
            HashSet<int> valuesSet = new HashSet<int>();

            while (value != 1 && !valuesSet.Contains(value)) // пока число не равняется единице и пока не имеется в коллекции 
            {
                valuesSet.Add(value);
                value = GetNext(value);
            }

            return value == 1;
        }  
