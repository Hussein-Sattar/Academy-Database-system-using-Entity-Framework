using Academy.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Data.Configurations
{
    public class CoursConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.coursName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                 .IsRequired();

            builder.Property(e => e.price).HasPrecision(15, 2);

            builder.ToTable("Courses");


            // Publshing The Database with data (data insertion)
            //builder.HasData(LoadCourses());
        }

        //static List<Course> LoadCourses()
        //{
        //    return [
        //             new() { Id = 1, coursName = "Mathmatics", price = 1000m },
        //             new() { Id = 2, coursName = "Physics", price = 2000m },
        //             new() { Id = 3, coursName = "Chemistry", price = 1500m },
        //             new() { Id = 4, coursName = "Biology", price = 1200m },
        //             new() { Id = 5, coursName = "CS-50", price = 3000m }
        //           ];


        //}
    }

}
