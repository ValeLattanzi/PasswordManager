namespace PasswordManager.Domain.Contract;

public interface IEncryptPassword
{
    public string Encrypt(string password);
    bool VerifyPassword(string password, string hashedPassword);
}
