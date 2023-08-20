using BAI_01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BAI_01.Configuration
{
    public class SinhVienConfig : IEntityTypeConfiguration<SinhVien>
    {
        public void Configure(EntityTypeBuilder<SinhVien> builder)
        {
            builder.HasKey(x => x.Code).HasName("Code");
            builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("nvarchar(50)");
            builder.Property(x => x.Class).HasColumnName("Class").HasColumnType("nvarchar(50)");
        }
    }
}
