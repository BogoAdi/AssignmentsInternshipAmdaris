

namespace LINQ_Excercises
{
    public class Program
    {
        public static void Main(string[] argv)
        {
            //First Excercises
            Console.WriteLine("Ex1:");
            var array = new int[] { 8, 2, 3, 3, 5, 6, 5, 8, 9, 10, 1, 12, 2, 2, 25, 8, 16, 2 };
            //var distinctarray = array.Distinct();

            //var t = array.Count(x => x.Equals(array.ElementAt(1)));
            // var ex1 = array.ToDictionary(, array.GroupBy(x => x).Count(w3));
            
            var q= array.GroupBy(x=>x);
            foreach (var item in q)
            {
                Console.Write(item.Key );
                Console.WriteLine(": " + item.Count());
            }
            Console.WriteLine();

            //Excercises 2
            Console.WriteLine("Ex2:");
            var qr = array.GroupBy(x => x).MaxBy(x=>x.Count());
            Console.WriteLine(qr.Key)
            Console.WriteLine();

            //Excercises 3
            Console.WriteLine("Ex3:");
            string[] first = new string[] { "hello", "hi", "max", "good evening", "good day", "good morning", "goodbye" };
            string[] second = new string[] { "whatsup", "how are you", "hello", "bye", "maybe", "hi" };
            var third = second.Intersect(first).Where(x => x.StartsWith("h"));
            foreach (var item in third)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Exercises 4
            Console.WriteLine("Ex4");
            var fourth = first.Concat(second);
            string result = fourth.Aggregate("", (FinalString, next) => FinalString += next.Last());
            Console.WriteLine(result);
            Console.WriteLine();
            //Exercises 5
            Console.WriteLine("Ex5");
            Exercitiu ex5 = new Exercitiu();
        }
    }

    public class Exercitiu
    {
        private IEnumerable<Singer> _singers;
        private IEnumerable<Concert> _concerts;
        public Exercitiu()
        {
            _singers = GetSingers();
            _concerts = GetConcerts();

            var q5 = from singer in _singers
                     join concert in _concerts on singer.Id equals concert.SingerId
                     where singer.FirstName.Equals("Elvis") && singer.LastName.Equals("Presley")
                     where concert.Country.Equals("Germany")
                     where concert.Year >= 1950 && concert.Year <= 1980
                     select concert.Avenue;
     
            foreach (var item in q5)
            {
                Console.WriteLine(item);
            }
        //   var q6 = _concerts.Join(_singers, conc => conc.SingerId, sing => sing.Id, ( conc, sing) => conc).Where(conc => conc.Year > 1950 && conc.Year<=1980).Where(conc=> conc.Country.Equals("Germany")).Select(conc=>conc.Avenue);
        //   foreach (var item in q6)
        //   {
        //       Console.WriteLine(item);
        //   }
        //   Console.WriteLine(q6);
        }

        public static IEnumerable<Singer> GetSingers()
        {
            return new List<Singer>() {
            new Singer { Id = 1, FirstName = "Freddie", LastName = "Mercury" },
            new Singer { Id = 2, FirstName = "Elvis", LastName = "Presley" },
            new Singer { Id = 3, FirstName = "Chuck", LastName = "Berry" },
            new Singer { Id = 4, FirstName = "Ray", LastName = "Charles" },
            new Singer { Id = 5, FirstName = "David", LastName = "Bowie" } };
        }
        public static IEnumerable<Concert> GetConcerts()
        {
            return new List<Concert>(){new Concert { SingerId = 2, Country = "Germany", Avenue ="Alianz", Year = 1979},
                new Concert { SingerId = 1, Country = "USA", Avenue = "NYW", Year = 1980},
                new Concert { SingerId = 1, Country = "Germany", Avenue = "Opera Nazional", Year = 1981},
                new Concert { SingerId= 2, Country = "Germany", Avenue = "Berlin Arena", Year = 1970},
                new Concert { SingerId = 2, Country = "Rusia", Avenue = "Lujniki", Year = 1968},
                new Concert { SingerId = 3, Country = "UK", Avenue = "London Opera", Year = 1960},
                new Concert { SingerId = 3, Country = "USA", Avenue = "Central Park", Year = 1961},
                new Concert { SingerId = 2, Country = "Rusia", Avenue = "Red Square", Year = 1962},
                new Concert { SingerId = 4, Country = "USA", Avenue = "Capitolium", Year = 1950},
                new Concert { SingerId = 4, Country = "Romania", Avenue = "Arena nationala", Year = 1951},
                new Concert { SingerId = 5, Country = "France", Avenue = "Verdun", Year = 1983}};
        }
    }
    public class Concert
    {
        public int SingerId { get; set; }
        public string Avenue { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
    }
    public class Singer { public int Id { get; set; } public string FirstName { get; set; } public string LastName { get; set; } }
}