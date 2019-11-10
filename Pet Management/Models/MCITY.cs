using System;
using System.ComponentModel.DataAnnotations;

namespace Pet_Management.Models
{
    public class MCITY
    {
        /// <summary> city id <summary>
        [Required]
        [Key]
        public Int32 city_id { get; set; }

        /// <summary> city name <summary>
        [Required]
        [Display(Name = "Thành phố")]
        public String name { get; set; }

        /// <summary> type <summary>
        [Required]
        public String type { get; set; }
    }
}
