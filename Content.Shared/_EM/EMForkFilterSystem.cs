using Robust.Shared;
using Robust.Shared.Configuration;

namespace Content.Shared._EM;

public sealed class EMForkFilterSystem : EntitySystem
{
    [Dependency] private readonly IConfigurationManager _cfg = default!;

    public override void Initialize()
    {
        _cfg.SetCVar(CVars.EntitiesCategoryFilter, "ForkFiltered");
    }
}
