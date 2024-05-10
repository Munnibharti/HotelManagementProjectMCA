using HotelManagementProject.Models.Domain;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Define the MongoDB connection string
string connectionString = "mongodb://localhost:27017";

// Establish a connection to the MongoDB server
MongoClient client = new MongoClient(connectionString);

// Get a reference to the database
IMongoDatabase database = client.GetDatabase("HotelDb"); // Specify the database name

// Get a reference to the Hotel collection
IMongoCollection<Hotel> hotelCollection = database.GetCollection<Hotel>("Hotel"); // Specify the collection name

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
