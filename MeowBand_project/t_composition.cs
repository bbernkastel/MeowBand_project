namespace MeowBand_project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("meowband.t_composition")]
    public partial class t_composition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_composition()
        {
            t_comment = new HashSet<t_comment>();
            t_compositiongenre = new HashSet<t_compositiongenre>();
            t_userlikes = new HashSet<t_userlikes>();
        }

        [Key]
        public int id_composition { get; set; }

        public int id_user { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        public long? duration { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }

        [StringLength(255)]
        public string artists { get; set; }

        [StringLength(255)]
        public string composers { get; set; }

        [StringLength(255)]
        public string album { get; set; }

        public int? compos_year { get; set; }

        public bool? is_visible { get; set; }

        public string composition_url { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_comment> t_comment { get; set; }

        public t_user t_user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_compositiongenre> t_compositiongenre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_userlikes> t_userlikes { get; set; }
    }
}
