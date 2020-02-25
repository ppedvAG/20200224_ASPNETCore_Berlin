using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace AspNetCoreKurs_Berlin.Pages.Modul05
{
    public class ThumbNailGen
    {

        public ThumbNailGen(RequestDelegate next)
        {

        }

        /// <summary>
        /// Invokes the specified context. SAMPLE2
        /// </summary>
        /// <param name="context">The context.</param>
        public async Task Invoke(HttpContext context)
        {
            var img = context.Request.Query["img"][0];
            var pfad = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\" + img;
            using (var sr = new FileStream(pfad, FileMode.Open))
            {
                using (var image = new Bitmap(sr))
                {
                    var resized = new Bitmap(300, 200);
                    using (var graphics = Graphics.FromImage(resized))
                    {
                        graphics.DrawImage(image, 0, 0, 300, 200);
                        var ms = new MemoryStream();
                        resized.Save(ms, ImageFormat.Jpeg);

                        //context.Response.Body.Write(ms.ToArray());
                        await context.Response.Body.WriteAsync(ms.ToArray());
                    }
                }
            }
        }
    }

    public static class ThumbNailGenExtensions
    {
        public static IApplicationBuilder UseThumbnailGen(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ThumbNailGen>();
        }
    }
}
