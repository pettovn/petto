using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Management.Models
{
    public class HEALTHCARE
    {
        /// <summary> care_id <summary>
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 healthcare_id { get; set; }

        /// <summary> place <summary>
        [Display(Name = "Nơi khám")]
        public String place { get; set; }

        #region References
        /// <summary> pet_id (PET) <summary>
        [Required]
        public Int64 pet_id { get; set; }

        /// <summary> service id (MSERVICE) <summary>
        [Required]
        public Int16 service_id { get; set; }
        #endregion

        public Int64 crt_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public Int64 upd_usr { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
