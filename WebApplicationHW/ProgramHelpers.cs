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
}