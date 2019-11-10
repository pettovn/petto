using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Management.Models
{
    public class MWARD
    {
        /// <summary> city id <summary>
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 ward_id { get; set; }

        /// <summary> district id <summary>
        [Required]
        public Int32 district_id { get; set; }

        /// <summary> ward name <summary>
        [Required]
        [Display(Name = "Phường/Xã")]
        public String name { get; set; }

        /// <summary> type <summary>
        [Required]
        public String type { get; set; }
    }
}
