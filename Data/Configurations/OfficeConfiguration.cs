using Academy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Data.Configurations
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e  => e.Id).ValueGeneratedNever();

            builder.Property(e=>e.officeName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                 .IsRequired(); 

             builder.Property(e=>e.officeLocation)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                 .IsRequired(); 


            builder.ToTable("Offices");

            // Publshing The Database with data (data insertion)
            // builder.HasData(LoadOffices());
        }

        //static List<Office> LoadOffices()
        //{
        //    return new List<Office> {
        //        new() { Id = 1 , officeName = "off_05", officeLocation = "building A"},
        //        new() { Id = 2 , officeName = "off_12", officeLocation = "building B"},
        //        new() { Id = 3 , officeName = "off_32", officeLocation = "Adminstraiton"},
        //        new() { Id = 4 , officeName = "off_15", officeLocation = "IT Department"},
        //        new() { Id = 5 , officeName = "off_44", officeLocation = "IT Department"}
        //    };

        //}
    }

}
