using System.Collections.Generic;
using XIVAnalysis.Sync.Entities.DTO.XIVDB;
using XIVAnalysis.Sync.Entities.Results;

namespace XIVAnalysis.Sync.Abstract.Repository.Services
{
    public interface IFFXIVServiceRepository
    {
        #region Get

        GenericResult<TErrorCode, IEnumerable<ActionInfo>> GetActions<TErrorCode>();

        GenericResult<TErrorCode, ActionInfo> GetAction<TErrorCode>(long ID);

        #endregion
    }
}
