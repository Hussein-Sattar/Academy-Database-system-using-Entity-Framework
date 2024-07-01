using Academy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Data.Configurations
{
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.sectionName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                 .IsRequired();

            builder.HasOne(e => e.course)
                .WithMany(e => e.Sections)
                .HasForeignKey(e => e.courseId)
                .IsRequired();

            builder.HasOne(e => e.Instructor)
                .WithMany(e => e.Sections)
                .HasForeignKey(e => e.InstructorId)
                .IsRequired(false);

            builder.OwnsOne(e => e.timeSlot, ts =>
            {
                ts.Property(p => p.StartTime).HasColumnType("time").HasColumnName("StartTime");
                ts.Property(p => p.EndTime).HasColumnType("time").HasColumnName("EndTime");
            });

            builder.HasOne(e => e.Schedule)
                .WithMany(e => e.Sections)
                .HasForeignKey(e=>e.ScheduleId)
                .IsRequired();

            builder.HasMany(e => e.Participants).WithMany(e => e.Sections).UsingEntity<Enrollment>();

            builder.ToTable("Sections");

            // Publshing The Database with data (data insertion)
           // builder.HasData(LoadSections());
        }

        //static List<Section> LoadSections()
        //{
        //    return [
        //        new() { Id = 1, sectionName = "S_MA1", courseId = 1, InstructorId = 1, ScheduleId = 1, StartTime = TimeSpan.Parse("08:00:00"), EndTime = TimeSpan.Parse("10:00:00") },
        //        new() { Id = 2, sectionName = "S_MA2", courseId = 1, InstructorId = 2, ScheduleId = 3, StartTime = TimeSpan.Parse("14:00:00"), EndTime = TimeSpan.Parse("18:00:00") },
        //        new() { Id = 3, sectionName = "S_PH1", courseId = 2, InstructorId = 1, ScheduleId = 4, StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("15:00:00") },
        //        new() { Id = 4, sectionName = "S_PH2", courseId = 2, InstructorId = 3, ScheduleId = 1, StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("12:00:00") },
        //        new() { Id = 5, sectionName = "S_CH1", courseId = 3, InstructorId = 2, ScheduleId = 1, StartTime = TimeSpan.Parse("16:00:00"), EndTime = TimeSpan.Parse("18:00:00") },
        //        new() { Id = 6, sectionName = "S_CH2", courseId = 3, InstructorId = 3, ScheduleId = 2, StartTime = TimeSpan.Parse("08:00:00"), EndTime = TimeSpan.Parse("10:00:00") },
        //        new() { Id = 7, sectionName = "S_BI1", courseId = 4, InstructorId = 4, ScheduleId = 3, StartTime = TimeSpan.Parse("11:00:00"), EndTime = TimeSpan.Parse("14:00:00") },
        //        new() { Id = 8, sectionName = "S_BI2", courseId = 4, InstructorId = 5, ScheduleId = 4, StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("14:00:00") },
        //        new() { Id = 9, sectionName = "S_CS1", courseId = 5, InstructorId = 4, ScheduleId = 4, StartTime = TimeSpan.Parse("16:00:00"), EndTime = TimeSpan.Parse("18:00:00") },
        //        new() { Id = 10, sectionName = "S_CS2", courseId = 5, InstructorId = 5,ScheduleId = 3, StartTime = TimeSpan.Parse("12:00:00"), EndTime = TimeSpan.Parse("15:00:00") },
        //        new() { Id = 11, sectionName = "S_CS3", courseId = 5, InstructorId = 4,ScheduleId = 5, StartTime = TimeSpan.Parse("09:00:00"), EndTime = TimeSpan.Parse("11:00:00") } 
        //        ];


        //}
    }

}
