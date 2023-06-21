using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThieuNhiTT.Api.Models
{
	public class LopHoc
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? TenLop { get; set; }
        public string? Nganh { get; set; }
        public string? NamHoc { get; set; }
        public string? GVCN { get; set; }
        public ICollection<Profile> DanhSach { get; set; }

    }
}

