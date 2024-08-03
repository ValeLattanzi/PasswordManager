# PasswordManager
Repository to encrypt passwords and protect them

## Dependencies 🔐
- `BCrypt.Net-Next`

## Usage 💻
- Install the dependencies
- Add reference to main project
- Add to services
- Send the password
- Receive the encrypted password

## Example
### Program.cs
```csharp
builder.Services.AddScoped<IEncryptPassword, EncryptPassword>();
```
