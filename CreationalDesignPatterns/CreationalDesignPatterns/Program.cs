
using DesignPatterns.Repositories;
using DesignPatterns.Domain;
using DesignPatterns.Strategy;
using CreationalDesignPatterns;

namespace DesignPatterns
{
    public  class Program
    {
        public static void Main(string[] argv)
        {

            TestSingleton();
        }
        public static void TestSingleton()
        {
            var instance1 = SingletonRepoSportField.Instance;
            IChangeCurrencyStrategy _strategy;
            _strategy = new RONChangeCurrencyStrategy();

            instance1.AddSportField(new SportField { Address="Station",City="New York",Name="TennisCourt 1643",
                Category="tennis", PricePerHour=250, Id=Guid.NewGuid()});


            instance1.ShowAll(_strategy);
            var instance2 = SingletonRepoSportField.Instance;
            Console.WriteLine(instance1 == instance2);
            instance2.ShowAll(_strategy);
        }
    }
}