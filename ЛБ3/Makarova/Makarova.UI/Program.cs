using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Claims;
using Yeroma.UI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireDigit = false;
})
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddAuthorization(opt =>
{
    opt.AddPolicy("admin", p =>
    p.RequireClaim(ClaimTypes.Role, "admin"));
});

//builder.Services.AddSingleton<IEmailSender, NoOpEmailSender>();

builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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

var serviceProvider = app.Services.CreateScope().ServiceProvider;
var logger = serviceProvider.GetRequiredService<ILoggerFactory>();
var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
//var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

await DbInit.SeedData(app);

app.Run();