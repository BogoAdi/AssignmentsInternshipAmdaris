
namespace LINQAssignment
{
    public static class LINQ
    {
        public static void Main(string[] args)
        {
            //   Console.WriteLine("Write an integer number:");
            //   var x = Convert.ToInt32(Console.ReadLine());
            //   Console.WriteLine("Is it pozitive? A:"+x.IsItPozitive());
            //
            //   Console.WriteLine("Write a string :");
            //   var d = Console.ReadLine();
            //   Console.WriteLine("String Length: "+d.StringLength());
            //
            //   Console.WriteLine("Write a double number:");
            //
            //   var e = Convert.ToDouble(Console.ReadLine());
            //   Console.WriteLine("FractionalPart: "+e.FractionalPart());

            Console.WriteLine("Filtering:");
            Console.WriteLine();
            Filtering();

            Console.WriteLine("Ordering");
            Console.WriteLine();
            Ordering();

            Console.WriteLine("Quantifiers");
            Console.WriteLine();
            Quantifiers();

            Console.WriteLine("Projection");
            Console.WriteLine();
            Projection();

            Console.WriteLine("Grouping");
            Console.WriteLine();
            Grouping();

            Console.WriteLine("Generation");
            Console.WriteLine();
            Generation();

            Console.WriteLine("ElementOperators");
            Console.WriteLine();
            ElementOperators();

            Console.WriteLine("DataConversion");
            Console.WriteLine();
            DataConversion();


            Console.WriteLine("Aggregation");
            Console.WriteLine();
            Aggregation();

            Console.WriteLine("SetOperation");
            Console.WriteLine();
            SetOperations();

            Console.WriteLine("Joins");
            Console.WriteLine();
            Joins();

        }
        private static void PrintAll<T>(IEnumerable<T> source)
        {
            foreach (var item in source)
            {

                Console.WriteLine(item);
            }
        }
        public static void Filtering()
        {
            //Where
            Console.WriteLine();
            Console.WriteLine("Where :");
            var query = _books.Take(1).ToList();
            var book = query.First();
            Console.WriteLine(book);

            //Skip
            Console.WriteLine();
            Console.WriteLine("Skip :");
            var skipequery = _books.Skip(3);
            PrintAll(skipequery);

            //TakeWhile
            Console.WriteLine();
            Console.WriteLine("Take While :");
            var whilequery = _books.TakeWhile(book => book.NumberOfPages > 300);
            PrintAll(whilequery);

            //SkipWhile
            Console.WriteLine();
            Console.WriteLine("Skip While :");
            var skipWhileQuery = _books.TakeWhile(book => book.NumberOfPages > 300);
            PrintAll(skipWhileQuery);

            //Distinct
            Console.WriteLine();
            Console.WriteLine("Distinct :");
            var distinct = _books.Distinct();
            PrintAll(distinct);

            //DistinctBY
            Console.WriteLine();
            Console.WriteLine("Distinct By title:");
            var distinctBy = _books.DistinctBy(book => book.Title);
            PrintAll(distinctBy);

            // OfType
            Console.WriteLine();
            Console.WriteLine("Children Books: ");
            var childrenbook = _books.OfType<ChildrenBook>();
            PrintAll(childrenbook);
            Console.WriteLine();
        }
        public static void Ordering()
        {
            //OrderBy then By
            Console.WriteLine("Ordered Books: ");
            var ordered = _books.OrderBy(x => x.Author).ThenBy(x => x.Title).ThenBy(x => x.NumberOfPages).ToList();
            PrintAll(ordered);
            Console.WriteLine();

            //OrderBy Descending 
            Console.WriteLine("Ordered Descending");
            var orderedDesc = _books.OrderByDescending(x => x.Author);
            PrintAll(orderedDesc);
            Console.WriteLine();

            //Reverse
            Console.WriteLine("Reversed");
            var reversed = _books.Reverse();
            PrintAll(reversed);
            Console.WriteLine();
        }
        public static void Quantifiers()
        {
            //Contains
            Console.WriteLine("Contains");
            string[] cars = { "audi", "mercedes", "dacia", "audi" };
            Console.WriteLine("From a string array which contains cars. Is there an audi?");
            Console.WriteLine(cars.Contains("dacia"));
            Console.WriteLine();

            //Any
            Console.WriteLine("Any");
            Console.WriteLine("Is there a book that has the title longer then 20 ?");
            Console.WriteLine(_books.Any(x => x.Title.Length > 20));
            Console.WriteLine();

            //All
            Console.WriteLine("All");
            Console.WriteLine("Are all books longer than 100 pages?");
            Console.WriteLine(_books.All(x => x.NumberOfPages > 100));

            //SequenceEqual
            Console.WriteLine("SequenceEqual");
            Console.WriteLine("are the two sequnce:cars and cars1 equal?");
            string[] cars2 = { "audi", "mercedes", "audi", "dacia" };
            Console.WriteLine(cars.SequenceEqual(cars2));
            Console.WriteLine();
        }
        public static void Projection()
        {
            
            //Select
            Console.WriteLine("Select: ");
            var selected = _books.Select(x => x.Title + " " + x.Author);
            PrintAll(selected);
            Console.WriteLine();

            //SelectMany
            Console.WriteLine("SelectMany");
            var selectMany = _libraries.SelectMany(lib => lib.Books);
            //var proba= selectMany.Select(book => book.Title);
            PrintAll(selectMany);
            Console.WriteLine();
            // PrintAll(proba);
        }
        public static void Grouping()
        {
            //Grouping
            Console.WriteLine("GroupBy:");
            var groupedBooks = _books.GroupBy(x => x.Category);
            int i = 0;
            foreach (var category in groupedBooks)
            {
                Console.WriteLine(i++ + "  " + category.Key + ":");
                foreach (var book in category)
                {
                    Console.WriteLine(book.Title);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        public static void Generation()
        {
            //
            //Repeat
            Console.WriteLine("Repeat: ");
            IEnumerable<Book> rep = Enumerable.Repeat(new Book { Author = "Charles Dickens", Title = "Great Expectation", NumberOfPages = 300 }, 5);
            foreach (Book str in rep)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();

            //Range
            Console.WriteLine("Range: ");
            IEnumerable<int> obj1 = Enumerable.Range(100, 5);
            PrintAll(obj1);
            Console.WriteLine();

            ///Empty
            Console.WriteLine("Empty ");
            var empty = Enumerable.Empty<string>();
            PrintAll(empty);
            Console.WriteLine();

        }
        public static void ElementOperators()
        {
            //First,FirstOrDefault
            Console.WriteLine("First book:");
            var first = _books.First();
            Console.WriteLine(first.Title);
            Console.WriteLine();

            //Last,LastOrDeafault
            Console.WriteLine("Last book");
            var last = _books.Last();
            Console.WriteLine(last.Title);
            Console.WriteLine();

            //Single
            Console.WriteLine("Single book that starts with M: ");
            var single = _books.Single(x => x.Title.StartsWith("M"));
            Console.WriteLine(single.Title);
            Console.WriteLine();

            //ElementAt
            Console.WriteLine("The 3rd Book is: ");
            var third = _books.ElementAt(2);
            Console.WriteLine(third);
            Console.WriteLine();

            //DefaultIfEmpty
            Console.WriteLine("DefaultIfEmplty");
            Book bDefault = new Book { Author = "Mihai Eminescu", Title = "Poezi", Category = "Literature", NumberOfPages = 300 };
            List<Book> emptyList = new List<Book>();
            var defaultIfEmpty = emptyList.DefaultIfEmpty(bDefault);
            PrintAll(defaultIfEmpty);
            Console.WriteLine();


        }
        //DataConversion
        public static void DataConversion()
        {
            //Lookup
            Console.WriteLine("Lookup:");
            ILookup<string, string> lookup = _books.ToLookup(p => p.Category, p => p.Title + " --" + p.Author);

            foreach (IGrouping<string, string> lk in lookup)
            {
                Console.WriteLine(lk.Key);
                foreach (string k in lk)
                {
                    Console.WriteLine("     " + k);
                }
            }
            Console.WriteLine();

            //OfType
            Console.WriteLine("OfType:");
            System.Collections.ArrayList cars = new System.Collections.ArrayList(4);
            cars.Add("BMW");
            cars.Add("Ferarri");
            cars.Add("Dacia");
            cars.Add(3.0);
            cars.Add("Audi");
            IEnumerable<string> query1 = cars.OfType<string>();
            PrintAll(query1);
            Console.WriteLine();

            //Cast
            Console.WriteLine("Cast:");
            System.Collections.ArrayList cars2 = new System.Collections.ArrayList(4);
            cars2.Add("BMW");
            cars2.Add("Ferarri");
            cars2.Add("Dacia");
            cars2.Add(3.0);             //exception trown
            cars2.Add("Audi");
            IEnumerable<string> query2 = cars2.Cast<string>();
            PrintAll(query1);
            Console.WriteLine();

            //toArray
            Console.WriteLine("toArray:");
            var toArray =_books.ToArray();
            Console.WriteLine(toArray.GetType());
            Console.WriteLine();

            //toList
            Console.WriteLine("to List");
            var newList = _books.ToList();
            Console.WriteLine(newList.GetType());
            Console.WriteLine();

            //toDictionary
            Console.WriteLine("to Dictionary");
            var dictionary = _books.Union(_comicBooks).ToDictionary(book => book.Author, book => book.Title);
            //PrintAll(dictionary);
            Console.WriteLine(dictionary.GetType());
            Console.WriteLine();

            //AS Enumerable
            Console.WriteLine("Downcasting to IEnumerable");
            List<int> numbers = new List<int>{ 10, 2, 4, 20 };
            var newNumber=numbers.AsEnumerable();
            Console.WriteLine(newNumber.GetType());
            Console.WriteLine();

            //AS Queryable
            Console.WriteLine("Cast to IQueryable");
            var qi = _books.Where(book => book.NumberOfPages > 500);
            qi=qi.AsQueryable();
            Console.WriteLine(qi.GetType());
            Console.WriteLine();
        }
        public static void Aggregation()
        {
            //Min
            Console.WriteLine("Minimal number of Pages:");
            var minimal = _books.Min(book => book.NumberOfPages);
            Console.WriteLine(minimal);
            Console.WriteLine();

            //Count
            Console.Write("NumberOfBooks with a number of pages over 400 is: ");
            var count = _books.Count(book => book.NumberOfPages > 400);
            Console.WriteLine(count);
            Console.WriteLine();

            //Avrage
            Console.Write("The average number of pages is: ");
            var average = _books.Average(book => book.NumberOfPages);
            Console.WriteLine(average);
            Console.WriteLine();

            //Aggregate
            Console.WriteLine("Aggregate");
            Book b1 = new Book { Author = "Vadmin Tudor", NumberOfPages = 10, Title = "Istoria Romanilor" };
            Book longestBook = _books.Aggregate(b1,
                    (longestBook, next) =>
                        next.NumberOfPages > longestBook.NumberOfPages ? next : longestBook, result => result);

            Console.WriteLine("The book with the biggest number of Pages is {0}", longestBook);
            Console.WriteLine();
        }
        public static void SetOperations()
        {
            //Union
            IEnumerable<Book> union = _books.Union(_comicBooks);
            PrintAll(union);
            Console.WriteLine();

            //Concat
            Console.WriteLine("Concat:");
            var concat = _books.Select(book => book.Title).Concat(_comicBooks.Select(comic => comic.Title));
            PrintAll(concat);
            Console.WriteLine();

            //Intersect
            Console.WriteLine("Intersect");
            var intersect=_books.Intersect(_comicBooks);
            PrintAll(intersect);
            Console.WriteLine();

            //Except
            Console.WriteLine("Except");
            var except = _books.Except(_comicBooks);
            PrintAll(except);
            Console.WriteLine();

        }
        public static void Joins()
        {
            //Join
            Console.WriteLine("Join:");
            var libraryByBooks = from book in _books
                                 join library in _libraries on book.IdLibrary equals library.Id
                                 select new { book.Title, library.Name };

            PrintAll(libraryByBooks);
            Console.WriteLine();

            //Group join
            Console.WriteLine("GroupJoin:");
            var query =
                    _libraries.GroupJoin(_books,
                                     libr => libr.Id,
                                     book => book.IdLibrary,
                                     (libr, setOfBooks) =>
                                         new
                                         {
                                             nameOfLibrary = libr.Name,
                                             books = setOfBooks.Select(book => book.Title + " " + book.Author)
                                         }); 

            foreach (var obj in query)
            {
                
                Console.WriteLine("{0}:", obj.nameOfLibrary);

                foreach (string bk in obj.books)
                {
                    Console.WriteLine("  {0}", bk);
                }
            }
            Console.WriteLine();

            //Zip
            Console.WriteLine("ZIP");
            foreach ((Library l1, Book b1) in _libraries.Zip(_books))
               {
                   Console.WriteLine($"At library: {l1.Name} is the book  {b1.Title}");
               }
            Console.WriteLine();

        }

        private static readonly IEnumerable<Book> _comicBooks = new List<Book> { new Book { Id = "20", Title = "Amazing Spider-man Issue #25", Author = "Stan Lee", Category = "Comics" }, new Book { Title = "Lord of the Rings", Author = "JRR Tolkien", NumberOfPages = 1000, Placemant = "Et2", Category = "Literature", IdLibrary = "1" }, };

        private static readonly IEnumerable<Book> _books = CreateBooksList();
        private static IEnumerable<Book> CreateBooksList()
        {
            return new List<Book>
            {
                new Book { Id="1", Title="Lord of the Rings", Author="JRR Tolkien", NumberOfPages=1000, Placemant="Et2", Category="Literature", IdLibrary="1"},
                new Book { Id="2", Title="Computer Architecture", Author="David Patterson & John Hennessy", NumberOfPages=500, Placemant="Et1", Category="ComputerScience", IdLibrary="2" },
                new Book { Id="29", Title="Computer Architecture", Author="David Patterson & John Hennessy", NumberOfPages=500, Placemant="Et1", Category="ComputerScience", IdLibrary="2" },
                new Book { Id="3", Title="Design Patterns: Elements of Reusable Object‑Oriented", Author="Richard Helm", NumberOfPages=700, Placemant="Et2", Category="ComputerScience", IdLibrary="2"},
                new Book { Id="4", Title="Moby Dick", Author="Herman Melville", NumberOfPages=400, Placemant="Et9", Category="Literature", IdLibrary="2"},
                new Book { Id="5", Title="Pure mathematics", Author="John K. Backhouse", NumberOfPages=530, Placemant="Et7", Category="Mathematics",IdLibrary="1"},
                new Book {Id="6",Title="The Physics Book: Big Ideas Simply Explained",Author="im Al-Khalili ",NumberOfPages=200,IdLibrary="2",Category="Physics"},
                new ChildrenBook {Id="7",Title="Baba Iarna intra-n sat",Author="Otilia Cazimir",NumberOfPages=40,Category="Literature",IdLibrary="1",ColoringBook=false},
                new ChildrenBook {Id="8",Title="Gradina Secreta",Author="Johanna Basford",NumberOfPages=50,Category="Psychology",IdLibrary="1",Placemant="Et2"},
                new Book { Id="9",Title="Baltagul",Author="Mihail Sadoveanu",NumberOfPages=150,Category="Literature",IdLibrary="1"},
                new Book {Id="10",Title="Ion",Author="Liviu Rebreanu",NumberOfPages=260,Category="Literature",IdLibrary="2"},
                new Book {Id="11",Title="Code Complete",Author="Steve McConnell",NumberOfPages=340, Category="ComputerScience",IdLibrary="1"},
            };
        }

        private static readonly IEnumerable<Library> _libraries = CreateLibrariesList();
        private static IEnumerable<Library> CreateLibrariesList()
        {
            return new List<Library>
            {
                new Library { Name = "UPT", Id = "1",
                    Books = new List<Book> { new Book() { Title = "Tehnici de programare" ,Author="Razvan Aciu"}, new Book { Title = "Constructii Metalice"} } },
                new Library { Name = "UVT", Id = "2",
                    Books = new List<Book> { new Book() { Title = "Psihologia copiilor"  }, new Book { Title = "Programare Web",Author="Razvan Cioarga"},new Book{Title="Manual dacia 1310"} } },
                new Library { Name = "Library of Congress", Id = "3",Books = new List<Book>{new Book{Title="PMD" } } } ,
                new Library { Name = "VaticanLibrary", Id = "4",
                  Books = new List<Book> { new Book() { Title = "History Of Religions" }, new Book { Title = "The Holy Bible"} }},
            };
        }
    }

}