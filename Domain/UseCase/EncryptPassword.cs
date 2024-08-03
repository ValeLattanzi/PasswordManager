using PasswordManager.Domain.Contract;

namespace PasswordManager.Domain.UseCase;

public class EncryptPassword : IEncryptPassword
{
    public EncryptPassword()
    {
    }

    public string Encrypt(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    public bool VerifyPassword(string password, string hashedPassword)
    {
        return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
    }
}
