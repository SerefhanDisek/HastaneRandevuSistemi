using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
  public class Poliklinik
  {
    public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Poliklinik Ad")]
    public string Isim { get; set; }
        [Required]
        [StringLength(100)]
    public ICollection<Doktor> Doktors { get; set; }
  }
}
