namespace MeowBand_project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("meowband.t_comment")]
    public partial class t_comment
    {
        [Key]
        public int id_comment { get; set; }

        public int id_user { get; set; }

        public int id_composition { get; set; }

        [Column(TypeName = "text")]
        public string comment_text { get; set; }

        [Column(TypeName = "date")]
        public DateTime? comment_date { get; set; }

        public virtual t_composition t_composition { get; set; }

        public virtual t_user t_user { get; set; }
    }
}
