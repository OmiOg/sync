using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVAnalysis.Sync.Entities.DTO.XIVDB
{
    public class PaginatedAction
    {
        public Pagination Pagination { get; set; }
        public IEnumerable<PaginatedResult> Results { get; set; }
    }
}
