using System.ComponentModel.DataAnnotations;

namespace CloudCustomers.API.Models;

public class User
{
    public User()
    { }

    public User(int id, string username, string password)
    {
        Id = id;
        Username = username;
        Password = password;
    }

    public int Id { get; set; }
    [DataType(DataType.Text)]
    public string Username { get; set; } = string.Empty;
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;
}