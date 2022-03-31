

using DesignPatterns.Repositories;

namespace CreationalDesignPatterns
{
    public class SingletonRepoSportField : SportFieldRepository
    {
        private static SingletonRepoSportField _instance;
        private SingletonRepoSportField()
        {
            Console.WriteLine("Constructor called");

        }
        public static SingletonRepoSportField Instance
        {
            get
            {
                Console.WriteLine("Instance called");
                if (_instance == null)
                {
                    _instance = new SingletonRepoSportField();
                }
                return _instance;
            }
            private set { }
        }
    }
}
