using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Management.Models
{
    public class PET_IMG
    {
        /// <summary> pet_id (PET) <summary>
        [Required]
        public Int64 pet_id { get; set; }

        /// <summary> image_id (IMAGE) <summary>
        [Required]
        public Int64 img_id { get; set; }

        public Int64 crt_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public Int64 upd_usr { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
