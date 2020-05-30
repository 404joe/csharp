var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

app.UseRouting();

// Map JSON api
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

// Map  index.html 
app.UseDefaultFiles();
app.UseStaticFiles();

app.Run(async context =>
{
    await context.Response.SendFileAsync("index.html");
});

app.Run();
