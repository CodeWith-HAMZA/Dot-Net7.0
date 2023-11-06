using Microsoft.AspNetCore.Mvc;

namespace Learn_Dot_Net7._0.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
       // 'WeatherForecast' Route(shown-in-URL-Bar)
    [HttpGet(Name = "GetWeatherForecast")]
    public Person Get()
    {
        return new Person { FirstName = "hamza"};
    }
    
     [HttpGet("users", Name = "GetUserList")]
        public IEnumerable<User> GetUsers()
        {
            var userList = new List<User>
            {
                new User { Name = "hamza" },
                new User { Name = "aisha" }
            };

            return userList;
        }
    
}
 
 public class Person
{
    public  string FirstName { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
}
  public   class User
    {
        public string Name { get; set; }
    }
