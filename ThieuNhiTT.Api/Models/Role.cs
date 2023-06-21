namespace ThieuNhiTT.Api.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public int CanAccess { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
