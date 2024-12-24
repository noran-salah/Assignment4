using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Demo

    {
        #region  Function prototype and calling
        //static  void  PrintShape(string shape,int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(shape);
        //    }
        //} 
        #endregion

        #region Passing Value Type Parameters By Value

        static void Swap(ref int x, ref int y)
        {
            Console.WriteLine($"A = {x}, B = {y}");

            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"A = {x}, B = {y}");



            //(x, y) = (y, x);
        }

        #endregion

        #region 

        static int SumOfArray(params List<int> array)
        {
            int sum = 0;

            foreach (int item in array)
            {
                sum += item;
            }
            return sum;
        }


        static void SumMulOfTwoNumber(int x, int y, out int sum, out int mul)
        {
            sum = x + y;
            mul = x * y;


        }
        #endregion



        static void Main(string[] args)
        {


            #region Array

            // Array => set of elements that have the same dataType
            //index , size  => size = length
            //index less than size by one +> index = Length -1

            //int age1 = 5;
            //int age2 = 5;
            //int age3 = 5;
            //int age4 = 5;
            //int age5 = 5;
            //int age6 = 5;
            //int age7 = 5;
            //int age8 = 5;
            //int age9 = 5;




            //for (int i = 0; i <ages.Length; i++)
            //{
            //    Console.WriteLine(ages[i]);

            //}

            //ages[0]= 5;
            //ages[1]= 50;
            //ages[2]= 60;

            //for (int i = 0; i < ages.Length; i++)
            //{
            //    Console.WriteLine(ages[i]);

            //}
            //int[] ages = new int[3];

            //ages[0] = 5;
            //ages[1] = 50;
            //ages[2] = 60;


            //ages[3] = 1;
            //Console.WriteLine(ages[3]);

            //int sum = 0;
            //for (int i = 0; i < ages.Length; i++)
            //{
            //        sum += ages[i];

            //}

            //foreach(int age in ages)
            //{
            //    age = age + 1;
            //}

            //Console.WriteLine(sum);




            #endregion

            #region Clone
            //int[] number1 = { 1, 2, 3 };
            //int[] number2 = { 101,102, 103 };


            //Console.WriteLine($"Numbers 1 : GetHashcode => {number1.GetHashCode()}");

            //Console.WriteLine($"Numbers 2 : GetHashcode => {number2.GetHashCode()}");

            ////number2 = number1;

            //number2 = (int[])number1.Clone(); //Explicit Casting

            //number1[0] = 100000;


            //Console.WriteLine("After =================>");

            //Console.WriteLine(string.Join(", ", number2));
            //Console.WriteLine(string.Join(", ", number1));


            //Console.WriteLine($"Numbers 1 : GetHashcode => {number1.GetHashCode()}");

            //Console.WriteLine($"Numbers 2 : GetHashcode => {number2.GetHashCode()}");



            #endregion


            #region 2D Array

            // int[,] grades = new int[2,3];


            /*  col0    col1
             *  
             *   5        10    row0
             *   20       3     row1
             *   40       50    row2
             * 
             * 
             */
            ////row 0
            //grades[0, 0] = 5;
            //grades[1, 0] = 10;

            ////row 1

            //grades[0, 1] = 20;
            //grades[1, 1] = 3;
            ////row 2

            //grades[0, 2] = 40;
            //grades[1, 2] = 50;


            //for (int i = 0; i < grades.GetLength(1); i++)
            //{
            //    for (int j = 0; j < grades.GetLength(0); j++)
            //    {
            //        grades[j,i] = 5;

            //    }

            //}
            //for (int i = 0; i < grades.GetLength(1); i++)
            //{
            //    for (int j = 0; j < grades.GetLength(0); j++)
            //    {
            //        Console.Write($"{grades[j, i]}          ");

            //    }
            //    Console.WriteLine();
            //}


            //foreach (int grade in grades)
            //{

            //    Console.WriteLine(grade);
            //}

            //int[][] grades = new int[3][]; //Jagged Array
            //int[][] arr = { new int[3] { 5, 10, 20 }, new int[3] { 40, 80, 90 }, };
            //foreach (int[] items in arr)
            //{
            //    foreach (int item in items)
            //    {
            //        Console.Write($"{item}          ");

            //    }
            //    Console.WriteLine();

            //}

            #endregion


            #region Array Methods
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 13,8,15,9,7, 2 };
            //int[] numbers2 = new int[numbers.Length];
            //Point[] points = new Point[5];
            //for (int i = 0; i < points.Length; i++) 
            //{
            //    points[i] = new Point();
            //    points[i].x = i + 2;
            //    points[i].y = i + 4;

            //}

            #region Static Methods [Class member method]
            //Array.Reverse(numbers);
            //Console.WriteLine(string.Join(", ", numbers));
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point.ToString());

            //}

            //Array.Sort(points);

            //Array.Clear(numbers);
            // Array.Copy(numbers, numbers2, 5);

            //Array.ConstrainedCopy(numbers, 5, numbers2, 0, 7);

            //foreach (var point in points)
            //{
            //    Console.WriteLine(point.ToString());

            //}

            //for (int i = 0;i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < length; j++)
            //    {

            //    }

            //}
            //int[,,] ints = (int[,,])Array.CreateInstance(typeof(int), 5, 5, 5);   //Explicit Casting

            //int index = Array.IndexOf(numbers, 2);

            //int index = Array.LastIndexOf(numbers, 2);

            //Console.WriteLine(index);


            #endregion


            #region Non-Static Methods [object member method]

            //numbers.CopyTo(numbers2, 0 );
            //numbers.GetLength(0);

            //numbers.SetValue(50, 2);
            //Console.WriteLine(numbers.GetValue(2));

            #endregion


            #endregion


            #region Boxing & UnBoxing


            #region Boxing

            // implicit casting // safe casting
            //object obj = null;

            //obj = 3; //casting value Type[int] into reference type [Object] => boxing
            //obj = 3.0; //casting value Type[double] into reference type [Object] => boxing
            //obj = true; //casting value Type[bool] into reference type [Object] => boxing
            //obj = DateTime.Now; //casting value Type[DateTime] into reference type [Object] => boxing

            //explicit casting

            //obj = 5;

            #endregion
            #region Unboxing


            //int x = (int)obj;
            //Console.WriteLine(x);
            #endregion


            #endregion

            #region Default Values
            //default value for any valueType dataType doesn't equal null
            //default value int, double decimal , float  =0
            //default value datetime = 1/1/0001
            //int x = default;
            //double y = default;
            //decimal z = default;
            //float f = default;
            //DateTime dateTime = default;
            //bool flag   = default;

            //Console.WriteLine($"x = {x}");
            //Console.WriteLine(flag);
            //Console.WriteLine(dateTime);
            //Console.WriteLine(f);
            //Console.WriteLine(z);
            //Console.WriteLine(y);


            // default value for reference type = null
            //string s = default;
            //int[] ints = default;
            //object obj = default;

            //if(s is null)
            //    Console.WriteLine("string is null");

            //if (ints is null)
            //    Console.WriteLine("array is null");

            //if (obj is null)
            //    Console.WriteLine("object is null");

            #endregion



            #region Nullable

            #region Nullable ValueTypes [C# 2.0 2005]
            //int x = null;

            /*Nullable<int>*///int?  x = null;
                             //Console.WriteLine(x);

            //DateTime? dateTime = null;
            //Console.WriteLine(dateTime);


            #endregion
            #region Nullable ReferenceTypes [C# 10 2021]

            //string name = null!;
            //string str2 = null!;
            //object obj = null!;



            //string? str = null;

            //Console.WriteLine(name);
            //Console.WriteLine(str);
            //Console.WriteLine(str2);
            //Console.WriteLine(obj);

            #endregion


            #endregion


            #region Handling Null

            //int x = default; // => x=0;

            //int[] number = default; //numbers = null
            //number = [2, 45, 6, 485, 12, 843,];

            //null conditional operator [?.]  => return null  if reference not set to an instance


            //int index = number.Length;

            //int? index = number?.Length;
            //index = number is null ? null : number.Length;

            //for (int i = 0; i < number?.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}
            //for (int i = 0; number is not null && i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            //if(number is not null)
            //{
            //    for (int i = 0;i < number.Length; i++)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}

            #endregion


            #region Function

            #region Function Prototype and calling
            /*
             * prototype                         || Calling by name 
             * //  return  Name(Parameters)      ||  name(arg)
             * {
             *      body (logic)
             * }                              
             */

            ////Calling by name
            //PrintShape("O_O", 10);   // passing parameters by position


            //PrintShape(count: 15, shape: "#_#");     //Passing by name


            #endregion


            #region Passing value Type Parameters

            #region Passing Value Type Parameters By Value

            //int a = 5, b = 10;
            //Console.WriteLine($"A = {a}, B = {b}");

            //Swap(a, b);

            //Console.WriteLine($"A = {a}, B = {b}");




            #endregion

            #region Passing Value Type Parameters By Reference

            //int a = 5, b = 10;
            //Console.WriteLine($"A = {a}, B = {b}");

            //Swap(ref a,ref b);

            //Console.WriteLine($"A = {a}, B = {b}");

            #endregion


            #endregion

            #region Passing Reference Type Parameters

            #region Passing Reference Type Parameters By Value

            //int[] arr = { 1, 2, 3, 4 };

            //Console.WriteLine($"Array HashCode = {arr.GetHashCode()}");

            //Console.WriteLine(string.Join(", ", arr));

            //  int sum = SumOfArray(arr);
            //Console.WriteLine($"Array HashCode = {arr.GetHashCode()}");

            //Console.WriteLine(string.Join(", ", arr));

            //Console.WriteLine(sum);




            #endregion

            #region Passing Reference Type Parameters By Reference
            //int[] arr = { 1, 2, 3, 4 };

            //Console.WriteLine($"Array HashCode = {arr.GetHashCode()}");

            //Console.WriteLine(string.Join(", ", arr));

            //int sum = SumOfArray(ref arr);
            //Console.WriteLine($"Array HashCode = {arr.GetHashCode()}");

            //Console.WriteLine(string.Join(", ", arr));

            //Console.WriteLine(sum);

            #endregion


            #endregion

            #region Passing Parameters by out

            //int x =3, y =4;

            //int sum, mul ;

            //SumMulOfTwoNumber(x, y,out sum , out mul );

            //Console.WriteLine($"Sum = {sum}, Mul = {mul}");



            #endregion


            #region Params

            //int[] ints = { 1, 2, 3, 4, 5, 6, };

            //int sum = SumOfArray( 1, 2, 3, 4, 5);

            //Console.WriteLine(sum);




            #endregion










            #endregion







            //Console.WriteLine("hello");
            Console.Read();

        }
    }

}
    }
}
