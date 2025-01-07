using Microsoft.EntityFrameworkCore;
using movieapp.business.Abstract;
using movieapp.data.Abstract;
using movieapp.data.Concrete;
using movieapp.business.Concrete;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MovieContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IUserRepository, EfCoreUserRepository>();
builder.Services.AddScoped<IMovieService, MovieManager>();
builder.Services.AddScoped<IMovieRepository, EfCoreMovieRepository>();
builder.Services.AddScoped<IActorService, ActorManager>();
builder.Services.AddScoped<IActorRepository, EfCoreActorRepository>();
builder.Services.AddScoped<IDirectorService, DirectorManager>();
builder.Services.AddScoped<IDirectorRepository, EfCoreDirectorRepository>();
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "movieDetails",
    pattern: "{controller=Movies}/{action=Details}/{id?}");
app.MapControllerRoute(
    name: "actorDetails",
    pattern: "{controller=Movies}/{action=ActorDetails}/{id?}");
app.MapControllerRoute(
    name: "directorDetails",
    pattern: "{controller=Movies}/{action=DirectorDetails}/{id?}");
app.MapControllerRoute(
    name: "genreDetails",
    pattern: "{controller=Movies}/{action=GenreDetails}/{id?}");

app.Run();