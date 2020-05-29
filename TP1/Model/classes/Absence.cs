using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.classes
{
    [Table("tp1_absence")]
    public class Absence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateAbsence { get; set; }
        public String Motif { get; set; }
        public int EleveId { get; set; }

        [ForeignKey("EleveId")] 
        public Eleve Eleve { get; set; }
    }
}
