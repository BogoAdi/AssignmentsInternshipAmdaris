namespace System.Globalization {
    class Program
    {
        public static void Main(string[] args)
        {
            var produs = "nume produs: {0, -20} Pret {1,10:C} ";

            Console.WriteLine(string.Format(produs, "Ulei de masline", 200));
            Console.WriteLine(string.Format(produs, "Apa plata ", 5));

            var strada = "Oituz";
            var numar = "13";

            string interpolation = $"It's the {strada} street {numar} number on today: {DateTime.Now} ";
            Console.WriteLine(interpolation);
            foreach (string word in interpolation.Split(" "))
            {
                Console.WriteLine(word);
            }
            TimeSpan ts = new TimeSpan(10, 25, 0);
            Console.WriteLine("The movies starts at: " + ts);
            DateTime dt = new DateTime(2009, 5, 29);
            Console.WriteLine("On " + dt + " Michel Jackson died");


            DateTimeOffset dto = new DateTimeOffset(dt, new TimeSpan(2, 0, 0));
            Console.WriteLine("I arrived at the cinemma at " + dto);
            Console.WriteLine();


            DateTime dt2 = DateTime.Now;
            Console.WriteLine("In romania the current date and time is: " + dt2 + " ");
            CultureInfo ro = CultureInfo.GetCultureInfo("ro-RO");
            Console.WriteLine("A costat " + (25.5).ToString("C", ro));

        }
    }
}