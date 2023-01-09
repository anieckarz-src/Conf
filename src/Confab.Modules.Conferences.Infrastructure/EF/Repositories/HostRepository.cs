using Confab.Modules.Conferences.Core.Entities;
using Confab.Modules.Conferences.Core.Repositories;

namespace Confab.Modules.Conferences.Infrastructure.EF.Repositories;

public class HostRepository : IHostRepository
{
    public Task<Host> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<Host>> BrowseAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Host host)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Host host)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Host host)
    {
        throw new NotImplementedException();
    }
}