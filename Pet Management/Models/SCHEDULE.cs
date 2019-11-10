using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Management.Models
{
    public class SCHEDULE
    {
        /// <summary> schedule_id <summary>
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 schedule_id { get; set; }

        /// <summary> time <summary>
        [Required]
        [Display(Name = "Thời gian")]
        public DateTime schedule_time { get; set; }

        /// <summary> content <summary>
        [Required]
        [Display(Name = "Nội dung")]
        public String content { get; set; }

        #region References
        /// <summary> pet_id (PET) <summary>
        [Required]
        public Int64 pet_id { get; set; }
        #endregion

        public Int64 crt_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public Int64 upd_usr { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
