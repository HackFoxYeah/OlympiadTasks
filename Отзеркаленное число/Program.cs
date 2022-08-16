//Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes 
//the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0.

public int ReverseNumber(int value)
        {
            int reverseValue = 0;

            while (value != 0)
            {
                int temp = value % 10;

                value /= 10;

                if (reverseValue > Int32.MaxValue / 10 || (reverseValue == Int32.MaxValue / 10 && temp > 7)) // защита от выхода за пределы int32
                {
                    return 0;
                }

                if (reverseValue < Int32.MinValue / 10 || (reverseValue == Int32.MinValue / 10 && temp < -8)) // защита от выхода за пределы int32
                {
                    return 0;
                }

                reverseValue = reverseValue * 10 + temp;
            }

            return reverseValue;
        }
