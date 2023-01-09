using Confab.Modules.Conferences.Core.Entities;

namespace Confab.Modules.Conferences.Core.Policies;

public interface IConferenceDeletionPolicy
{
    Task<bool> CanDeleteAsync(Conference conference);
}