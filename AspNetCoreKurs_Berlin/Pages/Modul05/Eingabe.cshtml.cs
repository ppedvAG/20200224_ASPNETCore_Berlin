using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace AspNetCoreKurs_Berlin
{
    public class EingabeModel : PageModel
    {
        
        public void OnGet()
        {

        }

        public void OnPostTuwas([FromForm] string eins)
        {

            TestObject testObject = new TestObject();
            testObject.Value1 = "Lassagne";

            TempData.Clear();

            if (!TempData.ContainsKey("test"))
            {
                TempData.Add("test", testObject);
                //TempData.Add("complexObject", JsonConvert.SerializeObject(testObject));
            }
            else
                TempData["test"] = testObject;
                //TempData["complexObject"] = JsonConvert.SerializeObject(testObject);

            Response.Redirect("Ausgabe");

        }
    }

    public class TestObject
    {
        public string Value1 { get; set; }
    }
}