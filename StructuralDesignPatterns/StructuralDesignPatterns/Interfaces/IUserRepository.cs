using DesignPatterns.Domain;
using DesignPatterns.Strategy;

namespace DesignPatterns.Interfaces
{
    internal interface IUserRepository
    {
        void AddUser(User user);
        void RemoveUser(User user);
        void ShowAll();
        User GetUser(string user);
        void AddAppointment(Appointment appointment,User user);
       
    }
}
