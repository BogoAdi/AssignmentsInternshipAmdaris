using DesignPatterns.Domain;


namespace StructuralDesignPatterns.Proxy
{
    internal interface ISportFieldProvider
    {
            public void ListSportFields();

            public void GetField(Guid id);

            public void AddSportField(SportField sportField);
    }
}
