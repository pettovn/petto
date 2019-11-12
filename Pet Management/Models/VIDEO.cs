using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Management.Models
{
    public class VIDEO
    {
        /// <summary> video_id <summary>
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 video_id { get; set; }


        /// <summary> video_name <summary>
        [Required]
        [MaxLength(50)]
        public String video_name { get; set; }

        /// <summary> url path <summary>
        [Required]
        [MaxLength(255)]
        public String path { get; set; }

        public Int64 crt_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public Int64 upd_usr { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
