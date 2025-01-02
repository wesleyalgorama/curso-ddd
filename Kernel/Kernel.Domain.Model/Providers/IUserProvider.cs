namespace Kernel.Domain.Model.Providers;

using Kernel.Domain.Model.Dtos;
using System.Threading.Tasks;

public interface IUserProvider
{
    Task SaveTokenString(string tokenString);
    Task<Token> GetToken();
    Task RemoveToken();
}
