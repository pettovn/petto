using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Management.Models
{
    public class USER
    {
        /// <summary> user_id <summary>
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 user_id { get; set; }

        /// <summary> user_name <summary>
        [Required]
        [Display(Name = "Tên hiển thị")]
        [MaxLength(50)]
        public String user_name { get; set; }

        /// <summary> phone <summary>
        [Required]
        [Display(Name = "Số điện thoại")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "123")]
        [MaxLength(12)]
        public String phone { get; set; }

        /// <summary> email <summary>
        [Required]
        [Display(Name = "Email")]
        [MaxLength(254)]
        public String email { get; set; }

        /// <summary> address <summary>
        [Display(Name = "Địa chỉ")]
        [MaxLength(255)]
        public String address { get; set; }

        /// <summary> birthday <summary>
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime birthday { get; set; }

        /// <summary> gender <summary>
        [Display(Name = "Giới tính")]
        [MaxLength(1)]
        public Int16 gender { get; set; }

        /// <summary> url_facebook <summary>
        [Display(Name = "Url facebook")]
        [MaxLength(255)]
        public String facebook { get; set; }

        /// <summary> password <summary>
        [Required]
        [Display(Name = "Mật khẩu")]
        public String password { get; set; }

        /// <summary> classification (0: user, 1: customer) <summary>
        [Required]
        [MaxLength(3)]
        public Int16 classification { get; set; }

        /// <summary> role (0: admin, 1: author, 2: subscriber) <summary>
        [Required]
        [MaxLength(3)]
        public Int16 role { get; set; }

        /// <summary> status (0: comfirmed, 1: waitting, 2: unknown) <summary>
        [Required]
        [MaxLength(3)]
        public Int16 status { get; set; }

        #region References
        /// <summary> image_id (IMAGE) <summary>
        public Int64 avatar { get; set; }
        #endregion

        public Int64 crt_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public Int64 upd_usr { get; set; }
        public DateTime upd_dt { get; set; }

        [NotMapped]
        public String repPassword { get; set; }
    }
}
