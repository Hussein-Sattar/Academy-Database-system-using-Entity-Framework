namespace Academy.Entities
{
    public class Office
    {
        public int Id { get; set; }
        public string? officeName { get; set; }
        public string? officeLocation { get; set; }
        public Instructor? instructor { get; set; }
    }
}
