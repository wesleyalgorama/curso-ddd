namespace Kernel.Domain.Model.Helpers;

using Kernel.Domain.Model.Dtos;

public interface ITokenHelper
{
    string GenerateNewSecret();
    string GetTokenString(Token token);
    Token GetToken(string tokenString);
}
