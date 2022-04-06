
using DesignPatterns.Domain;


namespace StructuralDesignPatterns.Proxy
{
    public class SportFieldProviderProxy : ISportFieldProvider
    {
        private SportFieldThirdParty _fields;

        public SportFieldProviderProxy()
        {
            _fields = new SportFieldThirdParty();
        }


        public void GetField(Guid id)
        {
            var found = _fields.Find(field => field.Id == id);
            if (found != null)
                Console.WriteLine(found);
            else Console.WriteLine("This field doesnt exists");
        }


        public void ListSportFields()
        {
            foreach (var sportField in _fields)
            {
                Console.WriteLine(sportField.Name + " " + sportField.Address + " " + sportField.City + " " + sportField.Category + " "
                   + sportField.PricePerHour);
            }
            Console.WriteLine();
        }

        public void AddSportField(SportField sportField)
        {
            _fields.Add(sportField);
        }
    }
}
