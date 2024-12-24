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




        }
    }
}
