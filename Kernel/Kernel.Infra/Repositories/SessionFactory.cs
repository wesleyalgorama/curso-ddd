namespace Kernel.Infra.Repositories;

using Kernel.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

public class SessionFactory : ISessionFactory
{
    public ISessionRepository OpenSession() =>
        new SessionRepository(IoC.Get<DbContext>());
}
