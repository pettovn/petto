using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Management.Models
{
    public class MSERVICE
    {
        /// <summary> check_id <summary>
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 checkID { get; set; }

        /// <summary> check_name <summary>
        [Display(Name = "Loại kiểm tra")]
        public String checkName { get; set; }

        /// <summary> description <summary>
        [Display(Name = "Mô tả")]
        public String description { get; set; }

        public Int64 crt_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public Int64 upd_usr { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
