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





            #region Question 07
            //7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //5 -->120
            static long Fact(int num)
            {
                int fact = 1;

                for (int i = 1; i <= num; i++)
                {
                    fact *= i;
                }
                return fact;
            }



            #endregion

            #region Question 08
            //8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter


            static string ChangeChar(string text, int position, char C)
            {
                text = text.Remove(position, 1);
                text = text.Insert(position, C.ToString());
                return text;

            }

            #endregion




            //9- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            // 1 0 0
            // 0 1 0
            // 0 0 1

            //int Num;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter number ");
            //    flage = int.TryParse(Console.ReadLine(), out Num);
            //} while (!flage);

            //for (int i = 0; i < Num; i++)
            //{
            //    for (int j = 0; j < Num; j++) 
            //    {
            //        if(i == j)
            //            Console.Write($" {1} ");
            //        else
            //            Console.Write($" {0} ");

            //    }
            //    Console.WriteLine();


            //}


            //10- Write a program in C# Sharp to find the sum of all elements of the array.

            //int Size;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter Size ");
            //    flage = int.TryParse(Console.ReadLine(), out Size);
            //} while (!flage);

            //int[] arr = new int[Size];
            //for (int i = 0; i < Size; i++)
            //{

            //    bool flage02;
            //    do
            //    {
            //        Console.WriteLine($"Enter number {i+1}");
            //        flage02 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    } while (!flage02);

            //}

            //int sum = 0;

            //for (int i = 0; i < Size; i++)
            //{ 
            //    sum += arr[i];
            //}

            //Console.WriteLine($"Sum = {sum}");






            //11- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.


            //int Size;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter number of Size");
            //    flage = int.TryParse(Console.ReadLine(), out Size);
            //} while (!flage);

            //int[] arr01 =new int[Size];
            //int[] arr02 =new int[Size];
            //int[] arr03 =new int[Size*2];

            //for (int i = 0; i < Size; i++)
            //{
            //    bool flage02;
            //    do
            //    {
            //        Console.WriteLine($"Enter number {i+1}");
            //        flage02 = int.TryParse(Console.ReadLine(), out arr01[i]);
            //    } while (!flage02);

            //}
            //for (int i = 0; i < Size; i++)
            //{
            //    bool flage03;
            //    do
            //    {
            //        Console.WriteLine($"Enter number {i + 1}");
            //        flage03 = int.TryParse(Console.ReadLine(), out arr02[i]);
            //    } while (!flage03);

            //}

            //int x;
            //for (x = 0; x < Size; x++)
            //{
            //    arr03[x]= arr01[x];
            //}

            //for(int i=0; i<Size; i++)
            //{

            //    arr03[x] = arr02[i];
            //    x++;
            //}
            //int temp;
            //for( int i=0; i < Size * 2; i++)
            //{
            //    for(int j = i+1; j< Size * 2; j++)
            //    {
            //       if( arr03[i]> arr03[j])
            //        {
            //            temp = arr03[i];
            //            arr03[i] = arr03[j];
            //            arr03[j] = temp;

            //        }
            //    }
            //}
            //Console.WriteLine("Sorted array :");
            //for( int i=0; i<Size*2;i++)
            //{

            //    Console.WriteLine($" {arr03[i]}");
            //}














            //12- Write a program in C# Sharp to count the frequency of each element of an array.
            //int Size;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter number of hours");
            //    flage = int.TryParse(Console.ReadLine(), out Size);
            //} while (!flage);

            //int[] arr =new int[Size]; 
            //int[] freq =new int[Size];

            //for (int i = 0; i < Size; i++)
            //{
            //    bool flage02;
            //    do
            //    {
            //        Console.WriteLine($"Enter number {i + 1}");
            //        flage02 = int.TryParse(Console.ReadLine(), out arr[i]);
            //        freq[i] = -1;
            //    } while (!flage02);

            //}

            //int X,j,counter = 0;  //[2,1,1]    freq [-1,-1,-1]

            //for (int i = 0; i < Size; i++) //i=2
            //{
            //    counter = 1;

            //    for (j = i+1; j < Size;j++) 
            //    {

            //        if (arr[i] == arr[j])
            //        {
            //            counter++;
            //            freq[j] = 0;
            //        }

            //    }
            //    if (freq[i] != 0)
            //    {
            //        freq[i] = counter;

            //    }

            //}
            //Console.WriteLine("Frequesncy Equal = ");
            //for(int i = 0;i < Size; i++)
            //{
            //    if (freq[i] > 0)
            //        Console.WriteLine($"{arr[i]} Repeated {freq[i]}");
            //}


            //13- Write a program in C# Sharp to find maximum and minimum element in an array
            //int Size;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter number of Size");
            //    flage = int.TryParse(Console.ReadLine(), out Size);
            //} while (!flage);

            //int[] arr = new int[Size];

            //for (int i = 0; i < Size; i++)
            //{
            //    bool flage02;
            //    do
            //    {
            //        Console.WriteLine($"Enter number {i + 1}");
            //        flage02 = int.TryParse(Console.ReadLine(), out arr[i]);                   
            //    } while (!flage02);

            //}

            //int max = arr[0]; //[1,5,3]
            //int min = arr[0];

            //for (int i = 0; i < Size; ++i)
            //{
            //    if (max < arr[i])
            //        max = arr[i];
            //    if (min > arr[i])
            //        min = arr[i];
            //}
            //Console.WriteLine($"Max ={max}");
            //Console.WriteLine($"Min ={min}");






            //14- Write a program in C# Sharp to find the second largest element in an array.

            //int Size;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter number of Size");
            //    flage = int.TryParse(Console.ReadLine(), out Size);
            //} while (!flage);

            //int[] arr = new int[Size];

            //for (int i = 0; i < Size; i++)
            //{
            //    bool flage02;
            //    do
            //    {
            //        Console.WriteLine($"Enter number {i + 1}");
            //        flage02 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    } while (!flage02);

            //}
            //int temp;
            //for (int i = 0; i < Size; i++)
            //{
            //    for (int j = i + 1; j < Size; j++)
            //    {
            //        if (arr[i]> arr[j])
            //        {
            //            temp =arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }

            //    }
            //}

            //int SecMax= arr[Size-2];

            //Console.WriteLine($"Second largest Element = {SecMax}");




            //15 -.Consider an Array of Integer values with size N, having values as in this Example
            //7   0    0   0  0  5   6   7   5   0   7   5   3

            //write a program find the longest distance between Two equal cells.In this example.The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2(cell 2 and cell 3).

            //In the example above, the longest distance is between the first 7 and the
            //10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            //And the 10th 7s.

            //Note:
            //-Array values will be taken from the user
            //-If you have input like 1111111 then the distance is the number of
            //Cells between the first and the last cell.

            //int Size;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter number of Size");
            //    flage = int.TryParse(Console.ReadLine(), out Size);
            //} while (!flage);

            //int[] arr = new int[Size];

            //for (int i = 0; i < Size; i++)
            //{
            //    bool flage02;
            //    do
            //    {
            //        Console.WriteLine($"Enter number {i + 1}");
            //        flage02 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    } while (!flage02);

            //}
            //int distance = 0;


            //for (int i = 0; i < Size; i++)
            //{
            //    for (int j = i + 1; j < Size; j++)//[1,2,4,2,1,2,1] i=0,j=6
            //    {
            //        if (arr[i] == arr[j])
            //            if (distance < j - i - 1) //3
            //                distance = j - i - 1;//5

            //    }
            //}
            //Console.WriteLine($"Distance = {distance}");

















        }
    }
}
