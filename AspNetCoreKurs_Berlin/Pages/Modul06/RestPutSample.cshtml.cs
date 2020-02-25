using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AspNetCoreKurs_Berlin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreKurs_Berlin
{
    public class RestPutSampleModel : PageModel
    {
        public void OnGet()
        {

        }

        public void OnPostUpdate()
        {
            using (var client = new HttpClient())
            {
                Aufgaben aufgabe = new Aufgaben { Text = "TestAufgabe", DeadlineDatum=DateTime.Now, AufgabeFertig=false };
                client.BaseAddress = new Uri("http://localhost:1565/");


                var response = client.PostAsync("api/person", aufgabe).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");
            }
        }
    }
}