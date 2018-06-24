using System.Collections.Generic;
using XIVAnalysis.Sync.Entities;

namespace XIVAnalysis.Sync.Abstract.Factory
{
    public interface ISyncActionFactory
    {
        IEnumerable<SyncAction> ExtractSyncActions<T>(IEnumerable<T> input) where T : class, new();
    }
}
