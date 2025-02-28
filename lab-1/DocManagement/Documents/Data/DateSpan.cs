namespace Documents.Documents.Data
{
    public class DateSpan
    {
        public DateTime DateIssued { get; set; }
        public DateTime DateExpire { get; set; }
        public DateSpan(DateTime dateIssued, DateTime dateExpire)
        {
            DateIssued = dateIssued;
            DateExpire = dateExpire;
        }
        public bool IsExpired()
        {
            return DateExpire < DateTime.Now;
        }
    }
}
