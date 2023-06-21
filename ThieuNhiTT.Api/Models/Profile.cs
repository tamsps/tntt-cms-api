using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThieuNhiTT.Api.Models
{
	public class Profile
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PIN { get; set; } //The id will be genarate unique in whole system
        public int XuDoanId { get; set; }
        public string TenThanh { get; set; }
        public int RoleId { get; set; }
        public string Ho { get; set; }
		public string Ten { get; set; }
		public string? ImageSmallUri { get; set; }
		public string? ImageLargeUri { get; set; }
        public DateTime NgaySinh { get; set; }
        public string? DiaChi { get; set; }
		public string? TenCha { get; set; }
		public string? TenMe { get; set; }
		public string SoDT1 { get; set; }
		public string? SoDT2 { get; set; }
        public string? NhanXet { get; set; }
        public int Type { get; set; }// 1: Huynh trương; 2: Thieu Nhi; 3: Khac
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }

    }
}

