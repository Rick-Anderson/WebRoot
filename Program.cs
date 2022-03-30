var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
    // Examine Hosting environment: logging value
    EnvironmentName = Environments.Staging,
    // Look for static files in "wwwroot-custom"
    WebRootPath = "wwwroot-custom"
});

var app = builder.Build();

app.Logger.LogInformation("ASPNETCORE_ENVIRONMENT: {env}",
          Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));

app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();
