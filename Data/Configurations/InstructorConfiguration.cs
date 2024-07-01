using Academy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Data.Configurations
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Name)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne(e => e.Office)
                .WithOne(e => e.instructor)
                .HasForeignKey<Instructor>(e => e.OfficeId)
                .IsRequired(false);

            builder.ToTable("Instructors");

            // Publshing The Database with data (data insertion)
           // builder.HasData(LoadCourses());
        }

        //static List<Instructor> LoadCourses()
        //{
        //    return new List<Instructor>
        //  {
        //      new Instructor { Id = 1, Name = "Ahmed Abdullah", OfficeId = 1 },
        //      new Instructor { Id = 2, Name = "Yassmin Mohammed", OfficeId = 2},
        //      new Instructor { Id = 3, Name = "Khalid Hassan", OfficeId = 3},
        //      new Instructor { Id = 4, Name = "Nadia Ali", OfficeId = 4},
        //      new Instructor { Id = 5, Name = "Ali Ibrahim", OfficeId = 5}
        //  };
        //}
    }
}
