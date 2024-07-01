namespace Academy.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string? coursName { get; set; }
        public decimal price { get; set; }
        public ICollection<Section> Sections { get; set; } = new List<Section>();
    }


}
