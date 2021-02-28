using EntityFrameworkCore.Data;
using EntityFrameworkCore.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace EntityFrameworkCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var stdAddress = new StudentAddress()
                {
                    City = "HCM",
                    Address = "District 4",
                    Country = "Viet Nam"
                };

                var grade = new Grade
                { 
                    GradeName = "Math"
                };

                var std = new Student()
                {
                    Name = "Bill",
                    Grade = grade,
                    Address = stdAddress
                };

                context.Students.Add(std);
                context.SaveChanges();
            }
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