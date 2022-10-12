using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using csharp_boolflix.Data;
using Microsoft.EntityFrameworkCore;
using NToastNotify;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Server
builder.Services.AddDbContext<BoolflixContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
//Toast

builder.Services.AddRazorPages().AddNToastNotifyNoty(
    new NotyOptions {
    ProgressBar = true,
    Timeout = 2500
});

// Add ToastNotification
builder.Services.AddNotyf(config =>
{
    config.DurationInSeconds = 2;
    config.IsDismissable = true;
    config.Position = NotyfPosition.TopRight;
});

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

app.UseRouting();

app.UseAuthorization();

app.UseNToastNotify();

app.UseNotyf();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
