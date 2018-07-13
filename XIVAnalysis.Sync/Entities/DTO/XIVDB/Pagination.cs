namespace XIVAnalysis.Sync.Entities.DTO.XIVDB
{
    public class Pagination
    {
        public long Page { get; set; }
        public long Page_Next { get; set; }
        public bool Page_Prev { get; set; }
        public int Page_total { get; set; }
        public int Results { get; set; }
        public int Results_per_page { get; set; }
        public int Results_total { get; set; }
    }
}
