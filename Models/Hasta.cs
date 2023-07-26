using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
  public class Hasta
  {
    public int HastaID { get; set; }
        [Required]
		[MaxLength(100)]
		[Display(Name = "Hasta Ad")]
	public string Isim{ get; set; }
		[Required]
		[MaxLength(100)]
		[Display(Name = "Hasta Soyad")]
	public string SoyIsim { get; set; }
		[Required]
		[MaxLength(100)]
        
	public int TelefonNumarasi { get; set; }
		
	public string Email { get; set; }
	public DateTime DateofBirth { get; set; }
		
	public ICollection<Randevu> Randevular {get ; set;}


  }
}
