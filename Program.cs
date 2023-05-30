using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Machine_arts.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<MachineArtsContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MachineArtsContext") ?? throw new InvalidOperationException("Connection string 'MachineArtsContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
