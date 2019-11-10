using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Management.Models
{
    public class IMAGE
    {
        /// <summary> image_id <summary>
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 image_id { get; set; }

        /// <summary> image_name <summary>
        [Required]
        public String image_name { get; set; }

        /// <summary> path <summary>
        [Required]
        public String path { get; set; }

        public Int64 crt_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public Int64 upd_usr { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
