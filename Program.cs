using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Machine_arts.Data;
using Machine_arts.Seed;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<MachineArtsContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MachineArtsContext") ?? throw new InvalidOperationException("Connection string 'MachineArtsContext' not found.")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedUsers.Initialize(services);
    SeedGradevinskiStrojevi.Initialize(services);
    SeedBageri.Initialize(services);
    SeedBuldozeri.Initialize(services);
    SeedDemperi.Initialize(services);
    SeedKiperi.Initialize(services);
    SeedKombinirke.Initialize(services);
    SeedKranDizalice.Initialize(services);
    SeedMikseri.Initialize(services);
    SeedTegljaci.Initialize(services);
    SeedUtovarivaci.Initialize(services);
    SeedValjci.Initialize(services);
}


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
