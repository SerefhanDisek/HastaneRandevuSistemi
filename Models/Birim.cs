using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
  public class Birim
  {
    public int BirimId { get; set; }
    [Required]
	[MaxLength(100)]
	[Display(Name = "Birim Ad")]
	public string Isim { get; set; }
	[Required]
	[MaxLength(100)]
	public ICollection<Doktor> Doktors { get; set;}
  }
}
