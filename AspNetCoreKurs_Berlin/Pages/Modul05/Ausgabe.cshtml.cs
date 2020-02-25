using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace AspNetCoreKurs_Berlin
{
    public class AusgabeModel : PageModel
    {
        public TestObject MyTestObject { get; set; }

        public string TestObjectValueOutput { get; set; }

        public void OnGet()
        {
            if (TempData.ContainsKey("complexObject"))
            {
                MyTestObject = (TestObject)TempData["test"];

                ///*MyTestObject = JsonConvert.DeserializeObject<TestObject*/> (TempData["complextObject"]);
                TestObjectValueOutput = MyTestObject.Value1;
            }
        }
    }
}