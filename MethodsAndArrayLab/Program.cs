namespace MethodsAndArrayLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            /*
             Area(5);
            Area(2, 3);
            Area(2, 4, 5);
            Area(5, 6, 2, 4);
             */
            #endregion

            #region Task2
            /*
             int x = 5;
            int y = 10;

            ChangeNumbers(ref x, ref y, out int c);

            Console.WriteLine("Result: x={0}; y={1}; c={2}", x, y, c);
             */
            #endregion

            #region Task3
            /*
                         int[] numbers = { 1, 2, 3, 4, 5 };

                        int[] newArray = ReverseArray(numbers);

                        PrintArray(newArray);
             */
            #endregion

            #region Task4
            /*
             int[] firstArray = { 1, 2, 3, 4 };
            int[] secondArray = { 5, 6, 7, 8 };

            int[] newArray = ConcatArray(firstArray, secondArray);

            PrintArray(newArray);
             */
            #endregion

            #region Task5
            /*
             int[] numbers = { 1, 2, 3, 4 };
            int[] newArr = ShiftArray(numbers, 2, "left");

            PrintArray(newArr);
             */
            #endregion

            #region Task6
            /*
             char[] array1 = { 'a', 'n', 'g', 'r', 'a', 'm' };
            char[] array2 = { 'n', 'a', 'g', 'a', 'r', 'm' };

            bool isAnagram = IsAnagram(array1, array2);

            Console.WriteLine(isAnagram);
             */
            #endregion
        }

        #region Task1
        /*
         Area deyə Method(lar) yaradın:
         a. Çevrənin sahəsi -> S = p*r² (p=3)
         b. Düzbucaqlının sahəsi -> S = a*b
         c. Düzbucaqlı paralelpipedin tam səthinin sahəsi -> S=2(a*b + a*c + b*c)
         d. Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi -> S=p*r; p=(a + b + c)/2
        */

        /*
         static void Area(int radius)
        {
            int p = 3;
            Console.WriteLine(p * radius * radius);
        }

        static void Area(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Area(int a, int b, int c)
        {
            Console.WriteLine(2 * (a * b + a * c + b * c));
        }

        static void Area(int a, int b, int c, int radius)
        {
            int peremetr = (a + b + c) / 2;
            Console.WriteLine(peremetr * radius);
        }
         */

        #endregion

        #region Task2
        /*
         x, y və c ədədləri qəbul edən method yazın. Bu method x və y -in yerini dəyişdirsin 
        (x-in qiyməti y olsun, y-in qiyməti x). c ədədinə isə x və y -in hasilini mənimsətsin 
        (c ədədinə əvvəlcədən dəyər verilməməlidir). Method void method olmalıdı.
         */

        /*
         static void ChangeNumbers(ref int x, ref int y, out int c)
        {
            int temp = x;
            x = y;
            y = temp;

            c = x * y;
        }
         */
        #endregion

        #region Task3
        /*
         Array-i tərsinə çevirmək: Integer array qəbul edən bir method yazırsınız. 
        Bu method array-i tərsinə çevirən bir method olur və geriyə tərsinə çevirilmiş array qaytarır. 
        (Sonda ədədləri Console-da göstərirsiniz)
         */

        /*
         static int[] ReverseArray(int[] numbers)
        {
            int startIndex = 0;
            int endIndex = numbers.Length - 1;

            while (startIndex < endIndex)
            {
                int temp = numbers[startIndex];

                numbers[startIndex] = numbers[endIndex];
                numbers[endIndex] = temp;

                startIndex++;
                endIndex--;
            }

            return numbers;
        }
         */
        #endregion

        #region Task4
        /*
         İki Array-i Birləşdirmək:  İki integer array qəbul edən methodunuz olur. 
        Bu method array-ləri bir array-ə birləşdirir.
         */

        /*
         static int[] ConcatArray(int[] firstArr, int[] secondArr)
        {
            int[] combinedArray = new int[firstArr.Length + secondArr.Length];

            for (int i = 0; i < firstArr.Length; i++)
            {
                combinedArray[i] = firstArr[i];
            }

            for (int i = 0; i < secondArr.Length; i++)
            {
                combinedArray[firstArr.Length + i] = secondArr[i];
            }

            return combinedArray;
        }
         */

        #endregion

        #region Task5
        /*
        Array-dəki elementləri "Shift" etmək: Parametr olaraq hər hansısa type-dan olan array, 
        integer neçə ədəd sürüşdürüləcək olan ədəd, string tipindən hansı tərəfə (sağa, sola) olacaq dəyərlər qəbul olunur. 
        Bu method verilmiş parametrlərə görə elementləri verilən yöndə və verilən dəyər qədər sürüşdürür.

         int[] rəqəmlər = { 1, 2, 3, 4, 5 };
         ShiftArray(rəqəmlər, 2, "right"); // Nəticə: {4, 5, 1, 2, 3}
         */

        /*
         static int[] ShiftArray(int[] numbers, int shiftCount, string direction)
        {
            int length = numbers.Length;
            int[] tempArr = new int[length];

            if (direction.ToLower() == "right")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    tempArr[(i + shiftCount) % length] = numbers[i];
                }
            }
            else if (direction.ToLower() == "left")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    tempArr[i] = numbers[(i + shiftCount) % length];
                }
            }
            else
            {
                Console.WriteLine("Please write correct direction!");
            }

            return tempArr;
        }

         */
        #endregion

        #region Task6
        /*
         İki arrayin Anagram olub olmadığını yoxlamaq: İki array qəbul edən methodunuz olur. 
         Bu array-lərin anagram olub olmadığını yoxlayırsınız.

         char[] array1 = { 'a', 'n', 'g', 'r', 'a', 'm' };
         char[] array2 = { 'n', 'a', 'g', 'a', 'r', 'm' };
         Console.WriteLine(AreAnagrams(array1, array2)); // Nəticə: True və ya False
         */

        /*
         static bool IsAnagram(char[] firstArr, char[] secondArr)
        {
            if (firstArr.Length != secondArr.Length) return false;

            int[] count = new int[256];

            for (int i = 0; i < firstArr.Length; i++)
            {
                count[firstArr[i]]++;
            }

            for (int i = 0; i < secondArr.Length; i++)
            {
                count[secondArr[i]]--;
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] != 0) return false;
            }

            return true;
        }
         */


        #endregion

        static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.WriteLine(number);
            }
        }
    }
}
