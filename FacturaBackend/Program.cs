var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();
var configuration = builder.Configuration;
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddCors();
builder.Services.AddTransient<Entities.IControl, Entities.Control>();
builder.Services.AddTransient<Entities.Interfaces.IResult, Entities.Result>();

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

app.MapControllers();

app.UseCors( _cors =>
{
    _cors.AllowAnyOrigin();
    _cors.AllowAnyMethod();
    _cors.AllowAnyHeader();
});

var host = configuration["Settings:ConecctionDB"];
if (host != null)
{
    // establecemos la cadena de conexion en el archivo conexion
    Bussnies.InstanciaConexion instancia = new Bussnies.InstanciaConexion();
    instancia.Instancia(host);
}
app.Run();
