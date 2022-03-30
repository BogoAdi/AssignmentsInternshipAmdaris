using DesignPatterns.Domain;
using DesignPatterns.Interfaces;
using DesignPatterns.Strategy;

namespace DesignPatterns.Repositories
{
    internal class SportFieldRepository : ISportField
    {   
        private List<SportField> _fields = new List<SportField>();

        public void AddAppointment(Appointment appointment, SportField sportField)
        {
           sportField.Appointments.Add(appointment);
        }

        public void AddSportField(SportField sportField)
        {
            _fields.Add(sportField);
        }

        public void DeleteSportField(SportField sportField)
        {
           _fields.Remove(sportField);
        }

        public SportField GetSportField(string sportFieldName)
        {
            var found = _fields.Find(field =>field.Name==sportFieldName);
            if (found!=null)
                return found;
            return null;
        }

        public void ShowAll(IChangeCurrencyStrategy _strategy)
        {
            foreach (var sportField in _fields)
            {
                Console.WriteLine(sportField.Name+ " "+sportField.Address+ " "+ sportField.City+  " "+ sportField.Category+ " " 
                    + _strategy.ChangeCurrency(sportField.PricePerHour));
            }
            Console.WriteLine();
        }

        public void ShowAllAppointments(SportField s1, IChangeCurrencyStrategy _strategy)
        {
            var sportFields = _fields.First(field => field.Name==s1.Name);
            foreach (var appointment in sportFields.Appointments)
            {
                Console.WriteLine(appointment.ToString()+ "Total price " + _strategy.ChangeCurrency(appointment.TotalPrice));
            }
            Console.WriteLine();
        }
    }
}
