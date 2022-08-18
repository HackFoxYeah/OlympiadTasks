public static int[] DoTwoArr(int[] arr)
        {
            int[] newArr = new int[arr.Length * 2];

            for (int i = 0, j = 0; j < newArr.Length; j++)
            {
                newArr[j] = arr[i];

                if (i == arr.Length - 1)
                {
                    i = 0;
                }
                else
                {
                    i++;
                }
            }
            return newArr;
        }
