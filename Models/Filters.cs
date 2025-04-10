namespace NZwalks.Models
{
    public class WalksFilters
    {
        private bool _sortAsc = true;

        public Guid? R_id { get; set; } = null;
        public Guid? D_id { get; set; } = null;
        public int Min_d { get; set; } = 0;
        public int Max_d { get; set; } = 1000;
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 1000;
        public string SortBy { get; set; } = "length";
        public bool? SortAsc
        {
            get { return _sortAsc; }
            set
            {
                _sortAsc = value ?? true;
            }
        }
    }
}
