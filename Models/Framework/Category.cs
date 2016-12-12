namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        [DisplayName("Tên Danh Mục")]
        [Required(ErrorMessage ="Bạn chưa nhập tên danh mục")]
        public string Name { get; set; }

        [StringLength(50)]
        [DisplayName("Tiêu đề SEO")]
        public string Alias { get; set; }

        public int? ParentID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? Order { get; set; }

        public bool? Status { get; set; }
    }
}
