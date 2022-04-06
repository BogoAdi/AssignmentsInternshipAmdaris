using DesignPatterns.Domain;
using DesignPatterns.Strategy;
namespace DesignPatterns.Interfaces
{
    internal interface IAppointmentRepository
    {
        void AddAppointment(Appointment appointment);
        void RemoveAppointment(Appointment appointment);
        void ShowAll(IChangeCurrencyStrategy _strategy);
        Appointment GetAppointment(Appointment appointment);
    }
}
