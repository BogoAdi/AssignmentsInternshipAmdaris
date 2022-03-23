
namespace LINQAssignment
{
    public static class LINQ
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write an integer number:");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is it pozitive? A:"+x.IsItPozitive());

            Console.WriteLine("Write a string :");
            var d = Console.ReadLine();
            Console.WriteLine("String Length: "+d.StringLength());

            Console.WriteLine("Write a double number:");

            var e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("FractionalPart: "+e.FractionalPart());
           
            Filtering();
            Ordering();
            Quantifiers();
            Projection();
            Grouping();
            Generation();
            ElementOperators();
            DataConversion();
            Aggregation();
            SetOperations();
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
            // OfType
            Console.WriteLine();
            Console.WriteLine("Children Books: ");
            var childrenbook = _books.OfType<ChildrenBook>();
            PrintAll(childrenbook);
            Console.WriteLine();
        }
        public static void Ordering()
        {
            //Ordering
            Console.WriteLine("Ordered Books: ");
            var ordered = _books.OrderBy(x => x.Author).ThenBy(x => x.Title).ThenBy(x => x.NumberOfPages).ToList();
            PrintAll(ordered);
            Console.WriteLine();
        }
        public static void Quantifiers()
        {
            //Quantifiers
            Console.WriteLine("Is there a book that has the title longer then 20 ?");
            Console.WriteLine(_books.Any(x => x.Title.Length > 20));

            Console.WriteLine();
        }
        public static void Projection()
        {
            //Projection
            //Zip
            foreach ((Library l1, Book b1) in _libraries.Zip(_books))
            {
                Console.WriteLine($"At library: {l1.Name} is the book  {b1}");
            }

            Console.WriteLine();

        }
        public static void Grouping()
        {
            //Grouping
            var groupedBooks = _books.GroupBy(x => x.Category);

            foreach (var category in groupedBooks)
            {
                Console.WriteLine(category.Key);
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
            //Generation
            //
            Console.WriteLine("Repeat: ");
            IEnumerable<Book> rep = Enumerable.Repeat(new Book { Author = "Charles Dickens", Title = "Great Expectation", NumberOfPages = 300 }, 5);
            foreach (Book str in rep)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
        }
        public static void ElementOperators()
        {
            //ElementOperators

            Console.WriteLine("First book:");
            var first = _books.First();
            Console.WriteLine(first.Title);

            Console.WriteLine();

        }
        //DataConversion
        public static void DataConversion()
        {
            //Lookup
            ILookup<string, string> lookup =
            _books
            .ToLookup(p => p.Category,
                      p => p.Title + " --" + p.Author);

            foreach (IGrouping<string, string> lk in lookup)
            {
                Console.WriteLine(lk.Key);
                foreach (string k in lk)
                {
                    Console.WriteLine("     " + k);
                }
            }
        }
        public static void Aggregation()
        {
            //Min
            var minimal = _books.Min(book => book.NumberOfPages);
            Console.WriteLine(minimal);

            Console.WriteLine();
        }
        public static void SetOperations()
        {
            //SetOperations
            //Union
            IEnumerable<Book> union = _books.Union(_comicBooks);
            PrintAll(union);
            Console.WriteLine();

        }
        public static void Joins()
        {
            var libraryByBooks = from book in _books
                                 join library in _libraries on book.IdLibrary equals library.Id
                                 select new { book.Title, library.Name };

            PrintAll(libraryByBooks);
        }

        private static readonly IEnumerable<Book> _comicBooks=new List<Book> { new Book { Id="20",Title="Amazing Spider-man Issue #25",Author="Stan Lee",Category="Comics"} };

        private static readonly IEnumerable<Book> _books = CreateBooksList();
        private static IEnumerable<Book> CreateBooksList()
        {
            return new List<Book>
            {
                new Book { Id="1", Title="Lord of the Rings", Author="JRR Tolkien", NumberOfPages=1000, Placemant="Et2", Category="Literature", IdLibrary="1"},
                new Book { Id="2", Title="Computer Architecture", Author="David Patterson & John Hennessy", NumberOfPages=500, Placemant="Et1", Category="ComputerScience", IdLibrary="2" },
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