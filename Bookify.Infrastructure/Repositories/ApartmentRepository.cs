using Bookify.Domain.Apartments;

namespace Bookify.Infrastructure.Repositories;

public class ApartmentRepository(ApplicationDbContext dbContext) : Repository<Apartment>(dbContext), IApartmentRepository
{
}