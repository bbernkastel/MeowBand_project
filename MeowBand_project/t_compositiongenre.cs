namespace MeowBand_project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("meowband.t_compositiongenre")]
    public partial class t_compositiongenre
    {
        [Key]
        public int id_composgenre { get; set; }

        public int id_genre { get; set; }

        public int id_composition { get; set; }

        public virtual t_composition t_composition { get; set; }

        public virtual t_genre t_genre { get; set; }
    }
}
