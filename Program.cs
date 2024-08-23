using Microsoft.Extensions.DependencyInjection;
using Suzane.WebApp;

var builder = WebApplication.CreateBuilder(args);

// Registrer IMyFileService
builder.Services.AddScoped<IMyFileService, MyFileService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Les innholdet fra filen og skriv det ut til konsollen
using (var scope = app.Services.CreateScope())
{
    var fileService = scope.ServiceProvider.GetRequiredService<IMyFileService>();

    // Definer filstien korrekt
    string filePath = "C:\\Code\\Suzane.WebApp\\omMeg.txt";

    // Sørg for at filen eksisterer før du prøver å lese den
    if (File.Exists(filePath))
    {
        IEnumerable<string> linje = fileService.ReadMyFile(filePath);

        int linjeNummer = 1;
        foreach (string line in linje)
        {
            Console.WriteLine($"{linjeNummer} : {line}");
            linjeNummer++;
        }
    }
    else
    {
        Console.WriteLine($"Filen finnes ikke på angitt sti: {filePath}");
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
