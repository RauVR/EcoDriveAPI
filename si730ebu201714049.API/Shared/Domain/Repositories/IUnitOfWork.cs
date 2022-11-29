namespace si730ebu201714049.API.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}