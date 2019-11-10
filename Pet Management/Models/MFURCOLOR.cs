using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Management.Models
{
    public class MFURCOLOR
    {
        /// <summary> color_id <summary>
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 color_id { get; set; }

        /// <summary> color_name <summary>
        [Display(Name = "Màu lông")]
        public String color_name { get; set; }

        #region References
        /// <summary> image_id (IMAGE) <summary>
        public Int64 avatar { get; set; }
        #endregion

        public Int64 crt_usr { get; set; }
        public DateTime crt_dt { get; set; }
        public Int64 upd_usr { get; set; }
        public DateTime upd_dt { get; set; }
    }
}
