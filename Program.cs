using Challenge_Flextech.Persistence.MsSql;
using Challenge_Flextech.Repository.MovimientosBcra;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(o => o.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename)));


builder.Services.AddScoped<IMovimientosBcraRepository, MovimientosBcraRepository>();

builder.Services.AddMvc(options =>
{
    options.SuppressAsyncSuffixInActionNames = false;
});
builder.Services.AddMvcCore(opt =>
{
    opt.SuppressAsyncSuffixInActionNames = false;
});

var MsSqlConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<MsSqlContext>(options =>
{
    options.UseSqlServer(MsSqlConnectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
