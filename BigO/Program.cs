using System;

namespace BigO
{
    internal class Program
    {
        static void Main()
        {
            #region Task-1
            //int[] array = { 1, 2 };
            //AddArray(array, 3);
            #endregion
            #region Task-2
            string value = "Ali  Aliyev";
            ClearSpaces(value);
            #endregion
            #region Task-3
            //int[] array = { 9, -8, 2, 10, -23, -99 };
            //ChangeNegativeNumber(array);
            //foreach (int i in array)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion
            #region Task-4
            //int result = Faktorial(5);
            //Console.WriteLine($"ededin faktoriali ---> {result}");
            #endregion
            #region Task-5
            //Fibonacci(10);
            #endregion

        }
        static void AddArray(int[] array, int value)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = value;
            foreach (int i in array)
            {
                Console.WriteLine(i + " ");
            }
        }
        static void ClearSpaces(string value)
        {
            string temp = "";
            int leftSpace = 0;
            int rightSpace = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == ' ' && i != value.Length - 1)
                {
                    leftSpace++;
                    if (value[i + 1] != ' ')
                    {

                        break;
                    }

                }
                else
                {
                    break;
                }
            }
            for (int i = value.Length - 1; i >= 0; i--)
            {
                if (value[i] == ' ' && i != 0)
                {
                    rightSpace++;
                    if (value[i - 1] != ' ')
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            for (int i = leftSpace; i < value.Length  - rightSpace; i++)
            {
                temp += value[i];
            }

            Console.WriteLine(leftSpace);
            Console.WriteLine(rightSpace);
            Console.WriteLine(temp);
        }
        static void ChangeNegativeNumber(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = array[i] * -1;
                }
            }
        }
        static int Faktorial(int number)
        {
            int pow = 1;
            for (int i = 1; i <= number; i++)
            {
                pow *= i;
            }
            return pow;
        }
        static void Fibonacci(int rage)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int temp;
            for (int i = 0; i < rage; i++)
            {
                Console.WriteLine(firstNumber);
                temp = firstNumber;
                firstNumber = firstNumber + secondNumber;
                secondNumber = temp;
            }
        }

    }
}
