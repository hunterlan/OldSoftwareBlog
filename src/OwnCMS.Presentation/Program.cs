using OwnCMS.Application.Contexts;
using OwnCMS.Application.Extensions;

const string ConnectionStringKey = "OwnCMS";

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString(ConnectionStringKey) ??
                throw new InvalidOperationException("Connection string is not found.");

builder.Services.AddDbContext<OwnCmsContext>();

builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
builder.Services.AddApplicationServices();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();