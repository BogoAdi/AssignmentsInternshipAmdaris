using DesignPatterns.Domain;
using DesignPatterns.Strategy;

namespace DesignPatterns.Interfaces
{
    internal interface ISportField
    {
        void AddSportField(SportField sportField);
        void ShowAll(IChangeCurrencyStrategy _strategy);
        void DeleteSportField(SportField sportField);
        void ShowAllAppointments(SportField s1, IChangeCurrencyStrategy _strategy);
        SportField GetSportField(string sportField);
        void AddAppointment(Appointment appointment,SportField sportField);
    }
}
