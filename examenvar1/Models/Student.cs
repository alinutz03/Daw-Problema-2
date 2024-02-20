using System.ComponentModel.DataAnnotations.Schema;

namespace examenvar1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public DateTime DataNasterii { get; set; }
        [ForeignKey("GrupaId")]
        public int GrupaId { get; set; }
        public Grupa Grupa { get; set; }
    }
}
