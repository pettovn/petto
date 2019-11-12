using System;
using System.ComponentModel.DataAnnotations;

namespace Pet_Management.Models
{
    public class MCITY
    {
        /// <summary> city_id <summary>
        [Required]
        [Key]
        [MaxLength(3)]
        public Int16 city_id { get; set; }

        /// <summary> city_name <summary>
        [Required]
        [Display(Name = "Thành phố")]
        [MaxLength(50)]
        public String city_name { get; set; }

        /// <summary> type <summary>
        [Required]
        [MaxLength(20)]
        public String type { get; set; }
    }
}
