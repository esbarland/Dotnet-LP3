using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.classes
{
    [Table("tp1_classe")]
    public class Classe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String NomEtablissement { get; set; }
        public String Niveau { get; set; }
    }
}
