var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

// Custom deployment port: 5003.
app.Urls.Add("http://0.0.0.0:5003");

app.MapControllers();

app.Run();
