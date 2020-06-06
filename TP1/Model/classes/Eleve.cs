using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.classes
{
    [Table("tp1_eleve")]
    public class Eleve
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        
        [Column(TypeName = "datetime2")]
        public DateTime DateDeNaissance { get; set; }
        public int ClasseId { get; set; }

        [ForeignKey("ClasseId")]
        public Classe Classe { get; set; }
        public ICollection<Absence> Absences { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}
