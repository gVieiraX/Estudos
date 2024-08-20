using System.Globalization;

namespace Datas;

class Program
{
    static void Main(string[] args)
    {
        var data = new DateTime(2022, 12, 31,13,23,14);
        Console.WriteLine(data);
        Console.WriteLine(data.Day);
        Console.WriteLine(data.Date);
        Console.WriteLine(data.DayOfWeek);
        Console.WriteLine(data.DayOfYear.ToString());
        Console.WriteLine(data.Hour);
        Console.WriteLine(data.Millisecond.ToString());

        var data_formatada = string.Format("{0:s}", data);
        Console.WriteLine(data_formatada);

       
        Console.WriteLine(data.AddDays(2));
        Console.WriteLine($"Data com 3 dias adicionados: {data.AddDays(3)}, Data com 2 anos adicionados: {data.AddYears(2)}");

        if (!data.Equals(DateTime.Now))
        {
            Console.WriteLine($"Data com 5 dias adicionados: {data.AddDays(3)}");
        }
        
        Console.Clear();
        
        var pt = new CultureInfo("pt-PT");
        var br = new CultureInfo("pt-BR");
        var en = new CultureInfo("pt-EN");
        var atual = CultureInfo.CurrentCulture;
        Console.WriteLine(DateTime.Now.ToString("D",pt));

        Console.Clear();
        var utcdateTime = DateTime.UtcNow;
        Console.WriteLine(utcdateTime);
        Console.WriteLine(DateTime.Now);

        Console.WriteLine(utcdateTime.ToLocalTime());
        
        var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
        Console.WriteLine(timezoneAustralia);
        
        var horaAustralia =  TimeZoneInfo.ConvertTimeFromUtc(utcdateTime, timezoneAustralia);
        Console.WriteLine(horaAustralia);

        var timezones = TimeZoneInfo.GetSystemTimeZones();
        foreach (var timezone in timezones)
        {
            Console.WriteLine(timezone.Id);
            Console.WriteLine(timezones);
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcdateTime, timezone));
            Console.WriteLine("------------------");
            
            Console.Clear();

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);
            
            var timeSpan2 = new TimeSpan(1); 
            Console.WriteLine(timeSpan2);
            
            Console.Clear();
            
            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
             Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

             var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
             Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);
             
             Console.Clear();

             Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
             Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
             Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
             
             Console.Clear();

            Console.WriteLine(DateTime.DaysInMonth(2020, 2));
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
            
        }
        
        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
        
    }
}