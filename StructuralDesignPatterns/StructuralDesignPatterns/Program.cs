
using DesignPatterns.Repositories;
using DesignPatterns.Domain;
namespace DesignPatterns
{
    public  class Program
    {
        public static void Main(string[] argv)
        {
            UserRepository r1=new UserRepository();
            AppointmentRepository r3 = new AppointmentRepository();

            
            SportFieldRepository r2= new SportFieldRepository();
            var t = new SportField { Id = Guid.NewGuid(), Address = "TimeSquare", Category = "tennis", City = "New York", Name = "1FirstOne", PricePerHour = 100 };
            var ti = new SportField { Id = Guid.NewGuid(), Address = "LibertyAvenue", Category = "swimming", City = "Timisoara", Name = "2One", PricePerHour = 240 };
            r2.AddSportField(t);

            var qi=new Appointment { Id = Guid.NewGuid(), IdField=ti.Id , ClientName = "Will", PhoneNumber = "0755078099", Date = new DateTime(2022, 11, 12), Hours = 3, };
            qi.TotalPrice = ti.PricePerHour * qi.Hours;
            var q = new Appointment { ClientName = "gigi", PhoneNumber = "0755030799", Date = new DateTime(1995, 11, 12), Hours = 2, Id = Guid.NewGuid(), IdField = r2.GetSportField("1FirstOne").Id, TotalPrice = r2.GetSportField("1FirstOne").PricePerHour };
            q.TotalPrice = t.PricePerHour * q.Hours;
          
            r2.AddAppointment(q,t);
            r2.AddSportField(ti);
            r2.AddAppointment(qi, ti);

            r3.AddAppointment(q);
            r3.AddAppointment(qi);
            int selection = Convert.ToInt32(Console.ReadLine());



            var fieldsHelp = new YouTubeProviderProxy();
            youtubeHelper.ListVideos();
            youtubeHelper.DownloadVideo();

            Console.ReadKey();

        }
    }
}