using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.classes
{
    [Table("tp1_note")]
    public class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Matiere { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateNote { get; set; }
        public String Appreciation { get; set; }
        public int Valeur { get; set; }

        public int EleveId { get; set; }

        [ForeignKey("EleveId")]
        public Eleve Eleve { get; set; }
    }
}
