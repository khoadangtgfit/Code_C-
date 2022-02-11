namespace _1911066165_DangPhuocKhoa.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDan")]
    public partial class NguoiDan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CCCD { get; set; }

        [Required]
        [StringLength(150)]
        public string HoTen { get; set; }

        public int? XNLan1 { get; set; }

        [StringLength(50)]
        public string KetQuaLan1 { get; set; }

        public int? XNLan2 { get; set; }

        [StringLength(50)]
        public string KetQuaLan2 { get; set; }

        public virtual XetNghiem XetNghiem { get; set; }

        public virtual XetNghiem XetNghiem1 { get; set; }
    }
}
