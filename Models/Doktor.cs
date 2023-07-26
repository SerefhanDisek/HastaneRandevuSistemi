using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
  public class Doktor
  {
    public int DoktorId { get; set; }
        [Required]
		[MaxLength(100)]
		[Display(Name = "Doktor Ad")]
	public string Isim { get; set; }
		[Required]
		[MaxLength(100)]
		[Display(Name = "Doktor Soy Isim")]
	public string SoyIsim { get; set; }
		[Required]
		[MaxLength(100)]
		
    public int BirimId { get; set; }
		[Required]	
		[MaxLength(100)]
		[Display(Name = "Birim Ad")]
	public string Birim { get; set; }
		[Required]
		[MaxLength(100)]
		

	public int PoliklinikId { get ; set; }
		[Required]
		[MaxLength(100)]
		[Display(Name = "Polikinlik Ad")]
	public Randevu Poliklinik { get ; set; }
		[Required]
		[MaxLength(100)]

	public ICollection<Birim> birims { get; set; }
	public ICollection<Poliklinik> polikliniks { get; set; }
		

  }
}
