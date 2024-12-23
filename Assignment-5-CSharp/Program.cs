namespace Assignment_5_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1

            //Console.WriteLine("Enter an integer: ");
            //int num;
            //if (int.TryParse(Console.ReadLine(), out num)) {
            //    for (int i = 1; i <= num; i++)
            //    {
            //        Console.Write(i + (i < num ? ", " : "\n"));

            //    }

            //}


            #endregion
            #region q2
            //Console.WriteLine("Enter an integer: ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++) {

            //       Console.WriteLine($"{num} * {i} =   {num * i}  ");
            //}

            #endregion
            #region q3

            //Console.WriteLine("Enter an integer: ");
            //int num;
            //if (int.TryParse(Console.ReadLine(), out num))
            //{
            //    for (int i = 2; i <= num; i += 2)
            //    {
            //        Console.Write(i + " ");

            //    }

            //}


            #endregion
            #region q4
            //Console.WriteLine("enter first int");
            //int number01 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter second int");
            //int number02 = int.Parse(Console.ReadLine());
            //double result = Math.Pow(number01, number02);
            //Console.WriteLine($"{result}");
            #endregion
            #region q5
            //Console.Write("Enter a String : ");
            //string originalString = Console.ReadLine();
            //string reverseString = string.Empty;
            //for (int i = originalString.Length - 1; i >= 0; i--)
            //{
            //    reverseString += originalString[i];
            //}
            //Console.Write($"Reverse String is : {reverseString} ");
            //Console.ReadLine();
            #endregion
            #region q6

            //    Console.Write("Input starting number of range: ");
            //    int startRange = int.Parse(Console.ReadLine());

            //    Console.Write("Input ending number of range: ");
            //    int endRange = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"The prime numbers between {startRange} and {endRange} are:");
            //    for (int i = startRange; i <= endRange; i++)
            //    {
            //        if (IsPrime(i))
            //        {
            //            Console.Write(i + " ");
            //        }
            //    }
            //}
            //static bool IsPrime(int number)
            //{
            //    if (number < 2)
            //        return false;

            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0)
            //            return false;
            //    }
            //    return true;  
            //}
            #endregion
            #region q7
            //Console.Write("Enter a number to convert: ");
            //    int decimalNumber = int.Parse(Console.ReadLine());

            //    string binaryNumber = "";

            //    if (decimalNumber == 0)
            //    {
            //        binaryNumber = "0";
            //    }
            //    else
            //    {
            //        while (decimalNumber > 0)
            //        {
            //            binaryNumber = (decimalNumber % 2) + binaryNumber;
            //            decimalNumber /= 2;
            //        }
            //    }

            //    Console.WriteLine($"The Binary of {decimalNumber} is {binaryNumber}");
            //}
            #endregion
            #region q8

            //Console.Write("Enter the size of the matrix (n): ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Identity Matrix:");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {

            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            #endregion
            #region q9
            string inputString = "Hello Developer";
            string substring = inputString.Substring(7, 4);
            Console.WriteLine(substring);
            #endregion
        }
        }
    }
