using Microsoft.EntityFrameworkCore;
using NFL.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddNewtonsoftJson();


//Lower case Urls
builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    //options.AppendTrailingSlash = true;
});

//ConnectionString
builder.Services.AddDbContext<TeamContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("TeamContext")
    ));
builder.Services.AddMemoryCache();
builder.Services.AddSession();
//builder.Services.AddSession(options =>
//{
//    options.IdleTimeout = TimeSpan.FromSeconds(60 * 5);
//    options.Cookie.HttpOnly = false;
//    options.Cookie.IsEssential = true;
//});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "",
    pattern: "{controller=Home}/{action=Index}/conf/{activeConf}/div/{activeDiv}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
