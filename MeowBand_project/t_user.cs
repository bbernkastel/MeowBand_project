namespace MeowBand_project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("meowband.t_user")]
    public partial class t_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_user()
        {
            t_comment = new HashSet<t_comment>();
            t_composition = new HashSet<t_composition>();
            t_userlikes = new HashSet<t_userlikes>();
        }

        [Key]
        public int id_user { get; set; }

        [Required]
        [StringLength(30)]
        public string userlogin { get; set; }

        [Required]
        [StringLength(255)]
        public string userpass { get; set; }

        [StringLength(50)]
        public string firstname { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        public bool? superuser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_comment> t_comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_composition> t_composition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_userlikes> t_userlikes { get; set; }
    }
}
