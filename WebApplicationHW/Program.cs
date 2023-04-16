using System.Diagnostics.Metrics;
using System.Text;
using WebApplicationHW.Interfaces;
using WebApplicationHW.Model;
using WebApplicationHW.Services;

namespace WebApplicationHW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //builder.Services.AddRazorPages();

            builder.Services.AddTransient<IManagementCars, ManagementCars>();

            var app = builder.Build();

            app.Map("/GetCarName", ProgramHelpers.HandleCarName);
            app.Map("/GetCarEngine", ProgramHelpers.HandleCarEngine);
            app.Map("/GetCarAge", ProgramHelpers.HandleCarAge);


            app.Use(async (context, next) => 
                {
                var msg = app.Services.GetService<IManagementCars>();
                    //style
                    string html = $"<style>\r\ntable {{\r\n  font-family: arial, sans-serif;\r\n  border-collapse: collapse;\r\n  width: 100%;\r\n}}\r\n\r\ntd, th {{\r\n  border: 1px solid #dddddd;\r\n  text-align: left;\r\n  padding: 8px;\r\n}}\r\n\r\ntr:nth-child(even) {{\r\n  background-color: #dddddd;\r\n}}\r\n</style>" +
                    //data
                    $"<table><tr><th>Name</th><th>Engine</th><th>Age</th></tr><tr><td>{msg?.GetCarName()}</td><td>{msg?.GetCarEngine()}</td><td>{msg?.GetCarAge()}</td></tr></table>";
                    await context.Response.WriteAsync(html);
                    await next.Invoke();
                //await context.Response.WriteAsync(msg?.GetCarName());
                //await context.Response.WriteAsync(msg?.GetCarEngine());
                //await context.Response.WriteAsync(msg?.GetCarAge());
                }
                );

            app.Use(async (context, next) =>
                {

                    await context.Response.WriteAsync("<br><a href=\"GetCarName\" />CAR NAME</a>");
                    await context.Response.WriteAsync("<br><a href=\"GetCarEngine\" />CAR ENGINE</a>");
                    await context.Response.WriteAsync("<br><a href=\"GetCarAge\" />CAR AGE</a>");
                    await next.Invoke();
                }
                );

            //app.Run(async (context) => {
            //    await context.Response.WriteAsync("<a href=\"GetCarName\" /><br>");
            //    //await next.Invoke();
            //});

            //// Configure the HTTP request pipeline.
            //if (!app.Environment.IsDevelopment())
            //{
            //    app.UseExceptionHandler("/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();
            //app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.MapRazorPages();

            //app.Run(
            //    async context =>
            //    {
            //        var sb = new StringBuilder();
            //        sb.Append("<h1> TEST ТЕКСТ</h1>");
            //        context.Response.ContentType = "text/html;charset=utf-8";
            //        await context.Response.WriteAsync(sb.ToString());
            //    }
            //    );

            app.Run();
        }


    }
}