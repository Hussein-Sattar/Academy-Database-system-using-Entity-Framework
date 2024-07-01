using Academy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Data.Configurations
{
    public class ParticipantConfiguration : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Name)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();


            builder.UseTptMappingStrategy();

            builder.ToTable("Participants");

            // Publshing The Database with data (data insertion)
           // builder.HasData(LoadStudents());
        }

        //private static List<Student> LoadStudents()
        //{
        //    return new List<Student>
        //    {
        //         new Student() { Id = 1, Name = "Fatima Ali" },
        //         new Student() { Id = 2, Name = "Noor Saleh" },
        //         new Student() { Id = 3, Name = "Omar Youssef" },
        //         new Student() { Id = 4, Name = "Huda Ahmed" },
        //         new Student() { Id = 5, Name = "Amira Tariq" },
        //         new Student() { Id = 6, Name = "Zainab Ismail" },
        //         new Student() { Id = 7, Name = "Yousef Farid" },
        //         new Student() { Id = 8, Name = "Layla Mustafa" },
        //         new Student() { Id = 9, Name = "Mohammed Adel" },
        //         new Student() { Id = 10,Name = "Samira Nabil" }
        //    };
        //}
    }
}
