using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using whatsapp_WEBAPI.Controllers;
using whatsapp_WEBAPI.Data;
using whatsapp_WEBAPI.Hubs;
using whatsapp_WEBAPI.Services;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();

builder.Services.AddDbContext<whatsapp_WEBAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("whatsapp_WEBAPIContext") ?? throw new InvalidOperationException("Connection string 'whatsapp_WEBAPIContext' not found.")));


builder.Services.AddCors(option =>
{
    option.AddPolicy("Allow All",
        builder =>
        {
            builder.SetIsOriginAllowed(origin => true)
            .AllowCredentials()
            .AllowAnyMethod()
            .AllowAnyHeader();
        }
        );
});

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IContactsService, ContactsService>();
builder.Services.AddScoped<IMessagesService, MessagesService>();
builder.Services.AddScoped<IUsersService, UsersService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Allow All");
app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapHub<ChatsHub>("/Chats");


app.Run();
