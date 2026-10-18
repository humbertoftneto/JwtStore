using JwtStore.Core.AccountContext.ValueObjects;
using JwtStore.Core.SharedContext.Entities;

namespace JwtStore.Core.AccountContext.Entities;

public class User : Entity
{
    public User(string email, string password)
    {
        Email = email;
        Password = new Password(password);
    }
    
    public string Nome {get; private set;} = string.Empty;
    public Email Email { get; private set; } = null!;
    public Password Password { get; private set; } = null!;
    public string Image { get; set; } = string.Empty;
}