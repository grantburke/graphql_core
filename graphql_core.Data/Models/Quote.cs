namespace graphql_core.Data.Models
{
    public class Quote : TEntity
    {
        public int Id { get; set; }
        public string Phrase { get; set; }
        public string Emoji { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}