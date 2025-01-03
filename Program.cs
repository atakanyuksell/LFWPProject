var builder = WebApplication.CreateBuilder(args);


//Services
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Urls.Add("http://*:5003");

app.Run();
