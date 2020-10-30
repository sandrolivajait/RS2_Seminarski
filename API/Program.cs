using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Model.Database;
using RepositoryLayer;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var ctx = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
                SeederFixer.seed(ctx);
                
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    public static class SeederFixer
    {
        public static void seed(ApplicationContext ctx)
        {
            ctx.Database.Migrate();
            Narudzba narudzba = new Narudzba
            {
                Datum = DateTime.Now,
                Kanton = "Hercegovacko-Neretvanski",
                KontaktTelefon = "063513758",
                KupacId = 1,
                PostanskiBroj = "88260",
                StanjeNarudzbeId = 1,
                Opcina = "Citluk",
                UkupnaCijena = 1500d,
                Ulica = "Markovac 36"
            };


            ctx.Narudzbe.Add(narudzba);
            ctx.SaveChanges();
            StavkaNarudzbe stavka = new StavkaNarudzbe
            {

                MobitelId = 1,
                Cijena = 1500,
                Kolicina = 1,
                NarudzbaId = narudzba.Id
            };
            ctx.StavkeNarudzbe.Add(stavka);
            ctx.SaveChanges();
            Narudzba narudzba1 = new Narudzba
            {
                Datum = DateTime.Now,
                Kanton = "Hercegovacko-Neretvanski",
                KontaktTelefon = "063513758",
                KupacId = 1,
                PostanskiBroj = "88260",
                StanjeNarudzbeId = 5,
                Opcina = "Citluk",
                UkupnaCijena = 1500d,
                Ulica = "Markovac 36"
            };
          

            ctx.Narudzbe.Add(narudzba1);
            ctx.SaveChanges();
            StavkaNarudzbe stavka1 = new StavkaNarudzbe
            {

                MobitelId = 1,
                Cijena = 1500,
                Kolicina = 1,
                NarudzbaId = narudzba1.Id
            };
            ctx.StavkeNarudzbe.Add(stavka1);
            ctx.SaveChanges();

           
        }
    }
}
