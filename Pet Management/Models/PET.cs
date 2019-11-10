using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Management.Models
{
    public class PET
    {
        /// <summary> pet_id <summary>
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 petID { get; set; }

        /// <summary> pet_name <summary>
        [Display(Name = "Tên Pet")]
        public String petName { get; set; }

        /// <summary> birthday <summary>
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime birthday { get; set; }

        /// <summary> gender <summary>
        [Required]
        [Display(Name = "Giới tính")]
        public Int16 gender { get; set; }

        /// <summary> price <summary>
        [Display(Name = "Price")]
        public Decimal price { get; set; }

        #region References
        /// <summary> d_type_id (DPETTYPE) <summary>
        [Required]
        public Int32 type { get; set; }

        /// <summary> color_id (MFURCOLOR) <summary>
        public Int64 color { get; set; }

        /// <summary> owner_id (TUSER.user_id) <summary>
        [Required]
        public Int64 owner { get; set; }

        /// <summary> father_id (TPET.pet_id) <summary>
        public Int64 father { get; set; }

        /// <summary> mother_id (TPET.pet_id) <summary>
        public Int64 mother { get; set; }
        #endregion

        public Int64 crt_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public Int64 upd_usr { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
