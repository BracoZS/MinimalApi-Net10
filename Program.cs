var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

// GET /
// Root endpoint - API info
app.MapGet("/", () => Results.Ok(new { 
    api = "MinimalApiNet10", 
    version = "1.0.0",
    status = "running",
    timestamp = DateTime.UtcNow
}));

// GET /hello
// Sample endpoint
app.MapGet("/hello", () => Results.Ok("Hello World!"));

// GET /greet?name=Jhon&city=Miami
// Query parameters example 
app.MapGet("/api/greet", (string? name, string? city) => 
{
    return $"Hello {name} from {city}!";
});

app.Run();