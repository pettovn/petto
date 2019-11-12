using System;
using System.ComponentModel.DataAnnotations;

namespace Pet_Management.Models
{
    public class MDISTRICT
    {
        /// <summary> district_id <summary>
        [Required]
        [Key]
        [MaxLength(5)]
        public Int16 district_id { get; set; }

        /// <summary> district_name <summary>
        [Required]
        [Display(Name = "Quận/Huyện")]
        [MaxLength(50)]
        public String district_name { get; set; }

        /// <summary> type <summary>
        [Required]
        [MaxLength(20)]
        public String type { get; set; }

        #region References
        /// <summary> city_id (MCITY) <summary>
        [Required]
        [MaxLength(3)]
        public Int16 city { get; set; }
        #endregion
    }
}
