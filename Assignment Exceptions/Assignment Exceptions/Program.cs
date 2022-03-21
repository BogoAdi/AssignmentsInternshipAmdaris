using System.Diagnostics;


namespace AssignmentExceptions
{
    class Program
    {
        public static bool PossibleDivision(int a, int b)
        {

            if (b == 0)
                throw new ArithmeticException("Impossible division");
            int rezult = a / b;
            return true;
        }
        public static int SumArray(int[] array, int length)
        {
            int sum = 0;
            try
            {
                for (int i = 0; i < length; i++)
                    sum += array[i];
                return sum;
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
                return 0;
            }
            return sum;
        }


        public static void CatchingExceptions(int x)
        {
            Console.WriteLine("numarul " + x + " ");
            if (x % 3 == 0) throw new ExceptionDividedBy3("Exception 3 : ");
            if (x % 4 == 0) throw new ExceptionDividedBy4("Exception 4: " );


        }

        public static void CountIt(Exception ex)
        {
            throw new CounterException("New:", ex);
        }
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, };
             Console.Write("Numaratorul este : ");
            int a = 0;
            a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(a);
             Console.Write("Numitorul este : ");
            int b = 0;
            b = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Is it possible? " + PossibleDivision(a, b));

            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine(exception.Message,exception);
            }
            int c = 0;
            Console.Write("Value c: ");
            c = Convert.ToInt32(Console.ReadLine());
            int d = SumArray(array, c);
            Console.WriteLine("Sum equals from the 0 index till the " + c + " is " + d);

            int four = 0;
            int three = 0;

            int e;
            Console.WriteLine("Read numbers until you get the value 0");
            Console.Write("Value e: ");
            e = Convert.ToInt32(Console.ReadLine());
                while (e!=0) {
                try
                {
                    CatchingExceptions(e);
                }
                catch (ExceptionDividedBy3 ex)
                {
                    three++;
                    //  Console.WriteLine(" ");
                    try
                    {
                        CountIt(ex);
                    }
                    catch
                    {
                        Console.WriteLine("count: ");
                    }

                }
                catch (ExceptionDividedBy4 ex)
                {
                    four++;
                    //   Console.WriteLine(" ");
                    try
                    {
                        CountIt(ex);
                    }
                    catch
                    {
                        Console.WriteLine("Saving....");
                    }

                }
                finally
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Thank you! If you want to exit type: 0");
                    Console.Write("Value e: ");
                    e = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("there were " + three + " numbers the divide by 3");
            Console.WriteLine("there were " + four + " numbers the divide by 4");

#if DEBUG
            Console.WriteLine("Debug version");
#endif

        }
    }
}