using System.Configuration;
using BLL.Interfaces;
using BLL.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spotidie.DAL.EF;
using Spotidie.DAL.Interfaces;
using Spotidie.DAL.Repositories;
using Spotidie.Utils;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<SpotidieContext>(options => options.UseNpgsql(
        builder.Configuration.GetConnectionString("Connect")
    )
);

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<SpotidieContext>()
    .AddDefaultTokenProviders();

builder.Services.AddHttpClient();
builder.Services.AddRazorPages();
builder.Services.AddSignalR();
builder.Services.AddResponseCompression(options=>options.EnableForHttps = true);

// dotnet user-secrets init --project Documents/Github/spotidie/Spotidie.WEB/Spotidie.WEB.csproj  
 builder.Services.AddAuthentication().AddGoogle(googleOptions =>
 {
     googleOptions.ClientId = configuration["Authentication:Google:ClientId"];
     googleOptions.ClientSecret = configuration["Authentication:Google:ClientSecret"];
 });

builder.Services.AddScoped<IPlaylistService, PlaylistService>();
builder.Services.AddScoped<IUnitOfWork, EFUnitOfWork>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<ITrackService, TrackService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseAuthentication();

//Minification
app.UseResponseCompression();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapHub<ChatHub>("/chat/hub");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();