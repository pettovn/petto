using System;
using System.ComponentModel.DataAnnotations;

namespace Pet_Management.Models
{
    public class PET_SERVICE
    {
        /// <summary> pet_id (PET) <summary>
        [Required]
        public Int64 pet_id { get; set; }

        /// <summary> service_id (MSERVICE) <summary>
        [Required]
        [MaxLength(5)]
        public Int16 service_id { get; set; }

        /// <summary> place <summary>
        [Display(Name = "Nơi khám")]
        [MaxLength(255)]
        public String place { get; set; }

        /// <summary> note <summary>
        [Display(Name = "Ghi chú")]
        public String note { get; set; }

        public Int64 crt_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public Int64 upd_usr { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
