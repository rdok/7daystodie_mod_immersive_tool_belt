using System;
using ImmersiveToolBelt.Harmony.Interfaces;

namespace ImmersiveToolBelt.Harmony.Seams
{
    public class EntityPlayerLocalSeam : IEntityPlayerLocal
    {
        private readonly EntityPlayerLocal _entityPlayerLocal;

        public EntityPlayerLocalSeam(EntityPlayerLocal entityPlayerLocal)
        {
            _entityPlayerLocal = entityPlayerLocal ?? throw new ArgumentNullException(nameof(entityPlayerLocal));
        }

        public ILocalPlayerUI PlayerUI => new LocalPlayerUISeam(_entityPlayerLocal.PlayerUI);
        public bool bPlayerStatsChanged => _entityPlayerLocal.bPlayerStatsChanged;
    }
}