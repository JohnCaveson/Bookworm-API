using Bookworm.DTOs;
using Bookworm.Repository;
using DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//In-Memory DB
builder.Services.AddDbContext<BookClubDbContext>(options => options.UseInMemoryDatabase("items"));

//Dependency Injection
builder.Services.AddScoped<IBookClubRepository, BookClubRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/lookup", async ([FromQuery(Name = "bookName")] string bookName, IBookClubRepository repository) =>
    {
        
    })
    .WithName("Lookup")
    .WithOpenApi();

app.MapPost("/createBookClub", async (BookClubRequest request, IBookClubRepository bookClubRepository) =>
    {
        var t = await bookClubRepository.Create(request);
        return t;
    })
    .WithName("CreateBookClub")
    .WithOpenApi();

app.Run();