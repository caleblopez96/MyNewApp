var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// HTTP method get (MapGet)
// "/" url route
// () => "Hello World" handler than executes when an incoming request 
// is processed that matches the method and the route
app.MapGet("/", () => "Hello World!");

app.Run();
