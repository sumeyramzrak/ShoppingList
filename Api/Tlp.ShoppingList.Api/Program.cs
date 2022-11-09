using Tlp.ShoppingList.Domain.Common;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<Settings>(builder.Configuration.GetSection(nameof(Settings)));

var section = builder.Configuration.GetSection($"{nameof(Settings)}");
var settings = section.Get<Settings>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddJwt(settings)
                .AddData(builder.Configuration)
                .AddDataServices()
                .AddAutoMapper();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseClaims(); //controller a d��meden claim instance � al�nacak
app.MapControllers();

app.Run();

public partial class Program { } //Minimal Api dan dolay� program class g�r�nm�yordu.