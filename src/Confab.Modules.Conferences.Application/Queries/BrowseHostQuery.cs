﻿using Confab.Modules.Conferences.Application.Dto;
using Convey.CQRS.Queries;

namespace Confab.Modules.Conferences.Application.Queries;

public record BrowseHostQuery() : IQuery<IReadOnlyList<HostDto>>;
