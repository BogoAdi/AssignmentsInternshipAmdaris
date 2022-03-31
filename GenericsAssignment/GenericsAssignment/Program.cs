
namespace GenericsAssignment {
    class MainPain
    {
        static void Main(string[] args)
        {
            Flower f1 = new Flower { Name = "Rose" };
            f1.setHeigth(2);
          
            Console.WriteLine(f1.getHeigth());
          //  f1.Name = "Trandafir";
            Console.WriteLine(f1.Name);
            Flower f2 = new Flower { Name = "Tulpin", Stage = (LifeStage)1 };
            Flower f3 = new Flower { Name = "Cactus",Stage = (LifeStage)1 };
            f2.setHeigth(4);

            Garden<Flower> garden1 = new Garden<Flower>();
            garden1.AddItem(f1);
            garden1.AddItem(f2);
            garden1.AddItem(f3);
            garden1.PrintAll();

            List<String> list = new List<String>();
            list.Add(f1.Name);
            list.Add(f2.Name);
            list.Add(f3.Name);
         
            Console.WriteLine();
            Console.WriteLine("List of Names:");
            foreach (String s in list)
            {
                Console.WriteLine(s);
            }
            //int? val= f1.getHeigth();
            Dictionary<String, int?> dictNameHeigth = new Dictionary<String, int?>();
            dictNameHeigth.Add(f1.Name, f1.getHeigth());
          //  val = f2.getHeigth();
            dictNameHeigth.Add(f2.Name,f2.getHeigth());
            Console.WriteLine("Dictionary:");

            foreach (var item in dictNameHeigth)
            {
                Console.WriteLine("Key: "+item.Key + "  Value: "+item.Value);
            }

            Console.WriteLine();
            Console.WriteLine($"Are the 2 flowers equal?: {f1.Equals(f1)}");

            Console.WriteLine($"Comparison betwwen first flower and the second using IComparer: {f1.Compare(f1,f2)}");
            //            Console.WriteLine(f1.c)
        }
    }
}