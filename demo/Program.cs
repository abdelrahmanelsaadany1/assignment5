using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using  demo;
namespace demo
{
    internal class Program
    {
        #region print function

        //public static void print(string pattern="#",int count=10)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(pattern);
        //    }
        //}

        #endregion
        #region fuunction value type

        //public static void swap(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;


        //}

        //public static void swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //}
        #endregion


        #region function reference type
        //public static  int sum(ref int[] array1) {
        //    int sum = 0;
        //    for (int i = 0; i < array1.Length; i++)
        //    {
        //        sum += array1[i];

        //    }
        //    return sum;

        //}
        //public static int sum(ref int[] array1)
        //{
        //    int sum = 0;
        //    array1 = new int[] { 5,6,7,8};
        //    for (int i = 0; i < array1.Length; i++)
        //    {
        //        sum += array1[i];

        //    }
        //    return sum;

        //}
        #endregion
        #region pass by output
        //public static void SumMul (int x, int y,out int sum, out int multiply)
        //{
        //    sum = x+y;
        //    multiply = x*y;

        //}
        #endregion
        #region params


        public static int Sum(params int[] Numbers)
        {
            int sum = 0;
            if (Numbers is not null)
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    sum += Numbers[i];
                }
                
            }
            return sum;
            

        }

        #endregion
        static void Main(string[] args)
        {
            #region judged array
            //// A jagged array is an array of arrays with different sizes.
            //int[][] numbers = new int[3][];
            //numbers[0] = new int[] { 1, 2, 3 };
            //numbers[1] = new int[] { 4, 5 };
            //numbers[2] = new int[] { 6 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.WriteLine(numbers[i][j]);
            //    }
            //}
            #endregion

            #region array methods
            //int[] num01 = { 1, 5, 7, 0, 11 };
            //int[] num02 = { 1, 2, 4 };
            //int[] num03 = new int[5];

            #region class member methods
            //Array.Sort(num01);
            //Console.WriteLine("Sorted num01 array:");
            //foreach (int num in num01)
            //{
            //    Console.WriteLine(num);
            //}
            //Array.Copy(num02, num03, 2);
            //foreach (int item in num03)
            //    Console.WriteLine(item);
            //{

            //}
            //Array.Clear(num02);
            //foreach (int item1 in num02)
            //{
            //    Console.WriteLine(item1);
            //}
            //Array.ConstrainedCopy(num01, 1, num03, 1, 2);
            //foreach (int item2 in num03) {
            //    Console.WriteLine(item2);

            //}
            //int[,]num04=(int[,]) Array.CreateInstance(typeof(int), 3,3);
            //foreach (int num in num04) {
            //    Console.WriteLine(num);
            //}

            #endregion
            #region object methods
            //num01.CopyTo(num03, 0);
            //foreach (int item in num03)
            //{
            //    Console.WriteLine(item);                
            //}
            //num03.SetValue(100, 1);
            //Console.WriteLine(num03[1]);
            #endregion

            #endregion
            #region functions call value type
            //Program.print("saadany",10);
            //print();
            //print(pattern:"hi",count:20);
            //int a = 5, b = 10;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //swap(a,b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //reference
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //swap(ref a,ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);





            #endregion

            #region function call reference type
            //int[] array1 = { 1, 2, 3, 4 };
            //int summition=sum(array1);//pass by value
            //Console.WriteLine(summition);
            //int summition = sum(ref array1);//pass by reference
            //Console.WriteLine(summition);
            //int summition = sum(array1);//pass by value
            //Console.WriteLine(summition);
            //Console.WriteLine(array1[0]);
            //int summition = sum(ref array1);//pass by reference
            //Console.WriteLine(summition);
            //Console.WriteLine(array1[0]);

            #endregion

            #region call by output 
            //int SumResult;
            //int MultiplyResult;
            //SumMul(6, 7, out SumResult,out MultiplyResult);
            //Console.WriteLine($"sum= {SumResult} , multiply= {MultiplyResult}");
            #endregion

            #region params
            //int[] Numbers = {1,2,3,4,5,6,7,8,9 };
            //int SumValue =Sum(1,2);
            //Console.WriteLine(SumValue);
            #endregion

            #region boxing and unboxing
            //object obj=new object();
            //obj=new string("any");
            //obj = 'a';
            //obj = true;
            //bool flag = (bool)obj;
            //Console.WriteLine(flag);
            //object x1 = 10;
            //x1 = "any name";
            //int y = (int)x1;
            #endregion
            #region nullable value type
            int? age = 10;
            age = null;
            Console.WriteLine(age);
            employee emp = new employee();
            int k = 3;
            int? y = null ;
            k = (int)y;
            k = y ?? 0;

            // Access and display properties
            Console.WriteLine("Employee Name: " + emp.Fname);

            #endregion

            #region null propagation operator 
            //double x = default;
            //int[]? Numbers = {1,2,3,4,5};
            //for (int i = 0;i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //if (Numbers != null)
            //{
            //    for (int i = 0; i < Numbers.Length; i++)
            //    {
            //        Console.WriteLine(Numbers[i]);
            //    }
            //}
            #endregion
          


        }
    }
}
