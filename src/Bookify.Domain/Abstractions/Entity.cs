namespace Bookify.Domain.Abstractions;

public abstract class Entity
{
    private readonly List<IDomainEvent> _domainEvents = new();
    
    protected Entity(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; init; }

    protected void RaiseDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
    
    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
    
    public List<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents;
    }
}