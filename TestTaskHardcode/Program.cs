using Microsoft.EntityFrameworkCore;
using TestTaskHardcode.DAL;
using TestTaskHardcode.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//adding DBContext
builder.Services.AddDbContext<DataBaseContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("HardcodeDB")));

//for interaction with the product service
builder.Services.AddScoped<IProductsService, ProductsService>();

//adding controllers
builder.Services.AddControllersWithViews().AddJsonOptions(o => {
    o.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    o.JsonSerializerOptions.PropertyNamingPolicy = null;
});

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
