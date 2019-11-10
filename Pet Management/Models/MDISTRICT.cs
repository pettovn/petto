using System;
using System.ComponentModel.DataAnnotations;

namespace Pet_Management.Models
{
    public class MDISTRICT
    {
        /// <summary> city id <summary>
        [Required]
        [Key]
        public Int32 district_id { get; set; }

        /// <summary> district name <summary>
        [Required]
        public Int32 city_id { get; set; }

        /// <summary> district name <summary>
        [Required]
        [Display(Name = "Quận/Huyện")]
        public String name { get; set; }

        /// <summary> type <summary>
        [Required]
        public String type { get; set; }
    }
}
