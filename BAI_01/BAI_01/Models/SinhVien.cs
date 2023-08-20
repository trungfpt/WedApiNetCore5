namespace BAI_01.Models
{
    public class SinhVienPTPM
    {
        public string Name { get; set; }
        public string Class { get; set; }
    }
    public class SinhVien : SinhVienPTPM
    {
        public Guid Code { get; set; }
    }
}