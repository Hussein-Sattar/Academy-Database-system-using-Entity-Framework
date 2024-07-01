namespace Academy.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string sectionName { get; set; }
        public int courseId { get; set; }
        public Course course { get; set; }

        public int? InstructorId { get; set; }
        public Instructor? Instructor { get; set; }

        public int ScheduleId { get; set; }
        public Schedule? Schedule { get; set; }

        public TimeSlot timeSlot { get; set; }

        public ICollection<Participant> Participants { get; set; } = new List<Participant>();
    }


    public class TimeSlot
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public override string ToString()
        {
            return $"{StartTime.ToString("hh\\:mm")} - {EndTime.ToString("hh\\:mm")}";
        }
    }

}