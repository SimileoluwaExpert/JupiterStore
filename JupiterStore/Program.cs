using Microsoft.EntityFrameworkCore;
using JupiterStore.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StoreDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:JupiterStoreConnection"]);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//}
app.UseStaticFiles();
app.MapDefaultControllerRoute();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

app.Run();
