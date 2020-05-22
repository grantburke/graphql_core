namespace graphql_core.Data.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Phrase { get; set; }
        public string Emoji { get; set; }
        public int EmployeeId { get; set; }
    }
}