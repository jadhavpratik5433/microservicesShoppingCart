using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectMMVC.Models;
using ProjectMMVC.Services;

var builder = WebApplication.CreateBuilder(args);

// MVC
builder.Services.AddControllersWithViews();

// ✅ REQUIRED for Identity UI
//builder.Services.AddRazorPages();

// DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Identity with Roles
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();

// DI
builder.Services.AddScoped<IStudent, StudentServices>();

var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// ✅ VERY IMPORTANT ORDER
app.UseAuthentication();
app.UseAuthorization();

// Identity UI pages
//app.MapRazorPages();

// MVC Routes
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
