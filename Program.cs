
// Importing all Classes In This Name-Space
using MyNamespace; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// this is app is almost like, app =express(); in node
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

// * Custome routes, and controllers, with json-response
app.MapGet("/aoeu/{id}", (int id  ) => "Hello Worled!" + id);
var callback = () => {
    return new User {Name="shaEeikh"};
};


// * Using Controllers-class, and its methods
var controllers = new MyControllers();
app.MapGet("/aou", controllers.Add(34,3));
app.Run();


public class User : IUser
{
    public string Name { get; set;}
}
interface IUser 
{
    public string Name {get; set;}
}