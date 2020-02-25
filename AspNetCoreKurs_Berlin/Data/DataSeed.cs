using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreKurs_Berlin.Data
{
    public static class DataSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AufgabenContext(serviceProvider.GetRequiredService<DbContextOptions<AufgabenContext>>()))
            {
                if(context.Aufgaben.Any())
                {
                    return;
                }

                context.Aufgaben.AddRange(
                    new Aufgaben
                    {
                        Text = "Windows aufsetzen",
                        DeadlineDatum = DateTime.Now,
                        AufgabeFertig = false
                    },

                    new Aufgaben
                    {
                        Text = "Linux aufsetzen",
                        DeadlineDatum = DateTime.Now,
                        AufgabeFertig = true
                    },

                    new Aufgaben
                    {
                        Text = "Update Firewall",
                        DeadlineDatum = DateTime.Now,
                        AufgabeFertig = false
                    },

                    new Aufgaben
                    {
                        Text = "Pizza bestellen",
                        DeadlineDatum = DateTime.Now,
                        AufgabeFertig = true
                    },
                    new Aufgaben
                    {
                        Text = "Pizza essen",
                        DeadlineDatum = DateTime.Now,
                        AufgabeFertig = false
                    }
                );

                context.SaveChanges();

            }
        }
    }
}
