using Data_Access_Layer.dbContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Session3_Employee.Interface;
using Session3_Employee.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddScoped<IEmployeeService,EmployeeService> ();

var LocalConnectionString = builder.Configuration.GetConnectionString("LocalDbConnection");
builder.Services.AddDbContext<EmployeeDbContext>(u => u.UseSqlServer(LocalConnectionString));
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=GetAllEmployees}/{id?}");

app.Run();
