using BLL.Interfaces;
using BLL.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Owin;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Ninject.Modules;
using Spotidie.DAL.EF;
using Spotidie.DAL.Interfaces;
using Spotidie.DAL.Repositories;
using Spotidie.Utils;

var builder = WebApplication.CreateBuilder(args);

//var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection");;

//Я не знаю ,что здесь это делает,ведь у нас контекст даже по-другому называется,поэтому пока что закомменчу
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(connectionString));;

//builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<ApplicationDbContext>();;

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<SpotidieContext>(options => options.UseNpgsql(
        builder.Configuration.GetConnectionString("Connect")
    )
);

// builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
// {
//     options.User.RequireUniqueEmail = true;
//     options.SignIn.RequireConfirmedAccount = true;
// }).AddEntityFrameworkStores<SpotidieContext>();

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<SpotidieContext>()
    .AddDefaultTokenProviders();

// builder.Services.AddScoped<IUserService, UserService>();
// builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddHttpClient();
builder.Services.AddRazorPages();

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


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();