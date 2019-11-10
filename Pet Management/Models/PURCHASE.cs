using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Management.Models
{
    public class PURCHASE
    {
        /// <summary> trade_id <summary>
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 purchase_id { get; set; }

        /// <summary> title <summary>
        [Required]
        [Display(Name = "Tiêu đề")]
        public String title { get; set; }

        /// <summary> number <summary>
        [Required]
        [Display(Name = "Số lượng")]
        public Int16 number { get; set; }

        /// <summary> price <summary>
        [Required]
        [Display(Name = "Giá")]
        public Decimal price { get; set; }

        /// <summary> address <summary>
        [Required]
        [Display(Name = "Địa chỉ người bán")]
        public String address { get; set; }

        /// <summary> note <summary>
        [Display(Name = "Chú thích")]
        public String note { get; set; }

        #region References
        /// <summary> user_id (USER) <summary>
        [Required]
        public Int64 seller { get; set; }

        /// <summary> pet_id (PET) <summary>
        public Int64 pet_id { get; set; }
        #endregion

        public Int64 crt_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public Int64 upd_usr { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
