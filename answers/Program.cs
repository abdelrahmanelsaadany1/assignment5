namespace answers
{
    class Person
    {
        public string Name;
    }
    internal class Program
    {
        #region are points collinear function 
        //static bool ArePointsCollinear(int x1, int y1, int x2, int y2, int x3, int y3)
        //{
        //    int determinant = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
        //    return determinant == 0;
        //}

        #endregion

        #region modify by value
        //static void ModifyByValue(int num)
        //{
        //    num = 100; // Modify the copy, not the original
        //}
        #endregion
        #region modify by reference
        //static void ModifyByReference(ref int num)
        //{
        //    num = 100; // Modify the original value
        //}
        #endregion
        #region modify by value q2
        //static void ModifyPersonByValue(Person p)
        //{
        //    p.Name = "ali";  
        //    p = new Person(); 
        //    p.Name = "mahmoud";   
        //}
        #endregion
        #region modify by reference q2
        //static void ModifyPersonByReference(ref Person p)
        //{
        //    p.Name = "ali";  
        //    p = new Person(); 
        //    p.Name = "mahmoud";  
        //}
        #endregion
        #region prime detector
        //static bool IsPrime(int number)
        //{

        //    if (number <= 1)
        //    {
        //        return false;
        //    }


        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            return false;  
        //        }
        //    }

        //    return true;  
        //}
        #endregion
        #region Max and min in array
        //static void MinMaxArray(int[] array, ref int min, ref int max)
        //{
        //    min = array[0];  
        //    max = array[0];


        //    foreach (int num in array)
        //    {
        //        if (num < min) min = num;
        //        if (num > max) max = num;
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Functions
            #region  q1
            #region f1 by value 
            //int a = 10;
            //Console.WriteLine("Before passing by value: " + a);

            //ModifyByValue(a); // Pass by value

            //Console.WriteLine("After passing by value: " + a);
            #endregion
            #region f1 by reference
            //int b = 10;
            //Console.WriteLine("Before passing by reference: " + b);

            //ModifyByReference(ref b); // Pass by reference

            //Console.WriteLine("After passing by reference: " + b);
            #endregion
            #endregion
            #region q2
            // by value
            //Person person1 = new Person();
            //person1.Name = "Alice";

            //Console.WriteLine("Before passing by value: " + person1.Name);

            //ModifyPersonByValue(person1); 

            //Console.WriteLine("After passing by value: " + person1.Name);
            //// by reference
            //Person person2 = new Person();
            //person1.Name = "Alice";

            //Console.WriteLine("Before passing by reference: " + person2.Name);

            //ModifyPersonByReference(ref person2); 

            //Console.WriteLine("After passing by reference: " + person2.Name); 
            #endregion
            #region q3
            //Console.WriteLine("Enter the first number:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the third number:");
            //int num3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the fourth number:");
            //int num4 = int.Parse(Console.ReadLine());


            //int sum = num1 + num2;
            //int difference = num3 - num4;


            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Difference: {difference}");
            #endregion
            #region q4
            // i dont know answer
            #endregion
            #region q5
            //Console.WriteLine("Enter a number:");
            //int number = int.Parse(Console.ReadLine());


            //if (IsPrime(number))
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}
            #endregion
            #region q6
            //int[] numbers = { 3, 5, 7, 2, 8, 1, 6 };


            //int min = 0, max = 0;


            //MinMaxArray(numbers, ref min, ref max);


            //Console.WriteLine($"Min: {min}, Max: {max}");
            #endregion
            // i dont know last two questions
            #endregion
        }
    }
}
