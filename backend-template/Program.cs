using backend;
using Microsoft.EntityFrameworkCore;

namespace projekatBE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

//KOMANDA SCUFFOLDA
//Scaffold-DbContext "Server=IMESERVERA;Database=IMEBAZE;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models 