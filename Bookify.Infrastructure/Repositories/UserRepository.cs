using Bookify.Domain.Users;

namespace Bookify.Infrastructure.Repositories;

public class UserRepository(ApplicationDbContext dbContext) : Repository<User>(dbContext), IUserRepository
{
}