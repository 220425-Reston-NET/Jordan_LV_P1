
using StoreBL;
using StoreDL;
using StoreModel;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IRepository<StoreItem>, SQLStoreRepository>(repo => new SQLStoreRepository(Environment.GetEnvironmentVariable("StoreProgramSetting")));
builder.Services.AddScoped<IStoreItemBL, StoreItemBL>();
builder.Services.AddScoped<IRepository<StoreAbilityJoin>, SQLStoreAbilityJoinRepo>(repo => new SQLStoreAbilityJoinRepo(Environment.GetEnvironmentVariable("StoreProgramSetting")));
builder.Services.AddScoped<IStoreAbilityJoinBL, StoreAbilityJoinBL>();
builder.Services.AddScoped<IRepository<Customer>, SQLCustomerRepo>(repo => new SQLCustomerRepo(Environment.GetEnvironmentVariable("StoreProgramSetting")));
builder.Services.AddScoped<ICustomerBL, CustomerBL>();
// builder.Services.AddScoped<IRepository<Customer>, SQLCustomerRepo>(repo => new SQLCustomerRepo(builder.Configuration.GetConnectionString("StoreProgramSetting")));
// builder.Services.AddScoped<ICustomerBL, CustomerBL>();

// (Environment.GetEnvironmentVariable("StoreProgramSetting"
// builder.Configuration.GetConnectionString

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


//add comment





// builder.Services.AddScoped<IRepository<Pokemon>, SQLPokemonRepository>(repo => new SQLPokemonRepository(builder.Configuration.GetConnectionString("Stephen_Pagdilao_DbDemo")));
// builder.Services.AddScoped<IPokemonBL, PokemonBL>();
// builder.Services.AddScoped<IRepository<PokemonAbilityJoin>, SQLPokeAbilityJoinRepo>(repo => new SQLPokeAbilityJoinRepo(builder.Configuration.GetConnectionString("Stephen_Pagdilao_DbDemo")));
// builder.Services.AddScoped<IPokeAbiJoinBL, PokeAbiJoinBL>();

