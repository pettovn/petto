using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Management.Models
{
    public class DPETTYPE
    {
        /// <summary> type id <summary>
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 d_type_id { get; set; }

        /// <summary> type name <summary>
        [Required]
        [Display(Name = "Tên loại thú cưng")]
        public String d_type_name { get; set; }

        /// <summary> type name <summary>
        [Required]
        public Int16 m_type_id { get; set; }

        public Int64 crt_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public Int64 upd_usr { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
