using System;
using System.ComponentModel.DataAnnotations;

namespace Pet_Management.Models
{
    public class MWARD
    {
        /// <summary> ward_id <summary>
        [Required]
        [Key]
        [MaxLength(10)]
        public Int16 ward_id { get; set; }

        /// <summary> ward_name <summary>
        [Required]
        [Display(Name = "Phường/Xã")]
        public String ward_name { get; set; }

        /// <summary> type <summary>
        [Required]
        public String type { get; set; }

        #region References
        /// <summary> city_id (MCITY) <summary>
        [Required]
        [MaxLength(3)]
        public Int16 city { get; set; }

        /// <summary> district_id (MDISTRICT) <summary>
        [Required]
        [MaxLength(5)]
        public Int16 district { get; set; }
        #endregion
    }
}
