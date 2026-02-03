var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


app.UseStaticFiles();

app.MapGet("/greet/{name?}", (string? name) =>
{
    if (string.IsNullOrWhiteSpace(name))
        name = "unknown";

    var message = $"Hello, {name}! \nTime: {DateTime.Now:HH:mm:ss}";
    return message;
});


app.Run();
