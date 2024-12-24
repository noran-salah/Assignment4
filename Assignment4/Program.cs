namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            #region 1-Passing By Value

            //static void Swap(int X, int y)
            //{
            //    int temp = X;
            //    X = y;
            //    y = temp;
            //    Console.WriteLine($"X= {X} , Y={y}");


            //}


            //#endregion
            //#region 2-Passing By Reference
            //static void Swap(ref int X, ref int y)
            //{
            //    int temp = X;
            //    X = y;
            //    y = temp;
            //    Console.WriteLine($"X= {X} , Y={y}");


            //}

            //#endregion


            ////2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            //#region 1-Passing By Value
            //static void Fun01(int[] arr)
            //{
            //    if (arr == null)
            //        return;
            //    //arr[0] = 100;
            //    arr = new int[] { 100, 200, 300 };

            //}

            //#endregion

            //#region 2-Passing By Reference
            //static void Fun02(ref int[] arr)
            //{
            //    if (arr == null)
            //        return;
            //    //arr[0] = 100;
            //    arr = new int[] { 100, 200, 300 };

            //}
            //#endregion

            //#endregion


           
            //3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            static void Calc(int X, int Y, out int Sum, out int Sub)
            {
                Sum = X + Y;
                Sub = Y - X;
            }
            #endregion

            #region Question 04
            //4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Output should be like
            //Enter a number: 25                                                                                            
            //The sum of the digits of the number 25 is: 7         
            // 25
            static int SumOfDigits(int Num)//25
            {
                int sum = 0;

                while (Num != 0)
                {
                    int digit = Num % 10;//2
                    sum += digit; //7
                    Num /= 10; //2


                }

                return sum;
            }


            #endregion



            #region Question 05
            //5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            static bool IsPrime(int num)
            {
                if (num == 1)
                    return false;
                for (int i = 2; i < num; i++)
                    if (num % i == 0)
                        return false;
                return true;


            }



            #endregion



            #region Question 06
            //6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            static void MinMaxArray(ref int[] arr, out int Max, out int Min)
            {
                Max = arr[0]; Min = arr[1];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Max < arr[i])
                        Max = arr[i];
                    if (Min > arr[i])
                        Min = arr[i];
                }

            }


            #endregion

        }
    }
}
