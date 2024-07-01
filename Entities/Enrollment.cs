namespace Academy.Entities
{
    public class Enrollment
    {
        public int SectionId { get; set; }
        public int StudentId { get; set; }
        public Section section { get; set; }
        public Participant student { get; set; } 
        
    }
}
