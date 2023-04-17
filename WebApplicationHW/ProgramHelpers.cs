using Microsoft.AspNetCore.Http;
using System.Text;
using WebApplicationHW.Interfaces;

internal static class ProgramHelpers
{
    public static void HandleCarAge(IApplicationBuilder app)
    {
        app.Run(
                async context =>
                {
                    var msg = app.ApplicationServices.GetService<IManagementCars>();
                    await context.Response.WriteAsync(msg?.GetCarAge());
                }
                );
    }

    public static void HandleCarEngine(IApplicationBuilder app)
    {
        app.Run(
                async context =>
                {
                    var msg = app.ApplicationServices.GetService<IManagementCars>();
                    await context.Response.WriteAsync(msg?.GetCarEngine());
                }
                );
    }
    public static void HandleCarName(IApplicationBuilder app)
    {
        app.Run(
                async context =>
                {
                    var msg = app.ApplicationServices.GetService<IManagementCars>();
                    await context.Response.WriteAsync(msg?.GetCarName());
                }
                );
    }

    public static void HandleCars(IApplicationBuilder app)
    {
        app.Run(
                async context =>
                {
                    var msg = app.ApplicationServices.GetService<IManagementCars>();
                    var cars = msg?.GetCars();
                    StringBuilder sbHTML = new StringBuilder($"<style>\r\ntable {{\r\n  font-family: arial, sans-serif;\r\n  border-collapse: collapse;\r\n  width: 100%;\r\n}}\r\n\r\ntd, " +
                        $"th {{\r\n  border: 1px solid #dddddd;\r\n  text-align: left;\r\n  padding: 8px;\r\n}}\r\n\r\ntr:nth-child(even) {{\r\n  background-color: #dddddd;\r\n}}\r\n</style>" +
                        $"<table><tr><th>Name</th><th>Engine</th><th>Age</th></tr>");
                    
                    foreach ( var car in cars ) 
                    {
                        sbHTML.Append($"<tr><td>{car.Maker}</td><td>{car.Engine}</td><td>{car.Year}</td></tr>");
                    }
                    sbHTML.Append("</table>");
                    await context.Response.WriteAsync(sbHTML.ToString());
                }
                );
    }
}