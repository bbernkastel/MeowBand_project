namespace MeowBand_project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("meowband.t_userlikes")]
    public partial class t_userlikes
    {
        [Key]
        public int id_userlike { get; set; }

        public int id_user { get; set; }

        public int id_composition { get; set; }

        public virtual t_composition t_composition { get; set; }

        public virtual t_user t_user { get; set; }
    }
}
