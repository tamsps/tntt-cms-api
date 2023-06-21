using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThieuNhiTT.Api.Models
{
	public class KetQuaHocTap
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? PIN { get; set; }
        public string? GVCN_PIN { get; set; }
        public string? NamHoc { get; set; }
        public string? ThanhTich { get; set; }
        public string? KetLuan { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public ICollection<MonHoc>? MonHocs{ get; set; }
    }
}

