using Academy.Entities;
using Academy.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Data.Configurations
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Title)
                .HasConversion(x=> x.ToString(),
                x => (ScheduleEnum) Enum.Parse(typeof(ScheduleEnum),x)
                );   


            builder.ToTable("Schedules");

            // Publshing The Database with data (data insertion)
            //builder.HasData(LoadSchedules());
        }

        //static List<Schedule> LoadSchedules()
        //{
        //    return new List<Schedule>
        //    {
        //        new Schedule { Id = 1, Title = "Daily", SUN = true, MON = true, TUE = true, WED = true, THU = true, FRI = false, SAT = false },
        //        new Schedule { Id = 2, Title = "DayAfterDay", SUN = true, MON = false, TUE = true, WED = false, THU = true, FRI = false, SAT = false },
        //        new Schedule { Id = 3, Title = "Twice-a-Week", SUN = false, MON = true, TUE = false, WED = true, THU = false, FRI = false, SAT = false },
        //        new Schedule { Id = 4, Title = "Weekend", SUN = false, MON = false, TUE = false, WED = false, THU = false, FRI = true, SAT = true },
        //        new Schedule { Id = 5, Title = "Compact", SUN = true, MON = true, TUE = true, WED = true, THU = true, FRI = true, SAT = true }
        //    };


        //}
    }

}
