using TakeAway.Application.CQRS.Handlers.AddressHandlers;
using TakeAway.Application.CQRS.Handlers.OrderDetailHandlers;
using TakeAway.Application.CQRS.Queries.OrderDetailQueries;
using TakeAway.Application.Interfaces;
using TakeAway.Application.Services;
using TakeAway.Persistance.Context;
using TakeAway.Persistance.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<OrderContext>();
#region CQRS
builder.Services.AddScoped<GetOrderDetailQueryHandler>();
builder.Services.AddScoped<GetOrderDetailByIdQueryHandler>();
builder.Services.AddScoped<CreateOrderDetailCommandHandler>();
builder.Services.AddScoped<RemoveOrderDetailCommandHandler>();
builder.Services.AddScoped<UpdateOrderDetailCommandHandler>();
#endregion

#region CQRS Address
builder.Services.AddScoped<GetAddressByIdQueryHandler>();
builder.Services.AddScoped<GetAddressQueryHandler>();
builder.Services.AddScoped<CreateAddressCommandHandler>();
builder.Services.AddScoped<UpdateAddressCommandHandler>();
builder.Services.AddScoped<RemoveAddressCommandHandler>();

#endregion

#region Repository
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddApplicationService(builder.Configuration);
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
