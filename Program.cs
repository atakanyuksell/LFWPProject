using LawFirmWebPage;
using LawFirmWebPage.Services;
using LawFirmWebPage.ServiceContracts;
using LawFirmWebPage.Data;
using LawFirmWebPage.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

var builder = WebApplication.CreateBuilder(args);


//Services
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddSession();
builder.Services.AddDbContext<ApplicationDbContext>(
    options => {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

    });

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.MapControllers();



app.Urls.Add("http://*:5003");

app.Run();
