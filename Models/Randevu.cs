using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
  public class Randevu
  {
    public int Id { get; set; }
        
    public DateTime Tarih { get; set; }
    public int HastaId { get; set; }
		[Required]
		[StringLength(100)]
		[Display(Name = "Hasta Ad")]

	public Hasta Hasta { get; set; }
		[Required]
		[StringLength(100)]
    public int DoktorId { get; set; }
		[Required]
		[StringLength(100)]
		[Display(Name = "Doktor Ad")]
	public Doktor Doktor { get; set; }
		[Required]
		[StringLength(100)]

	public Poliklinik Poliklinik { get; set; }
		[Required]
		[StringLength(100)]

	public Birim Birim { get; set; }
		[Required]
		[StringLength(100)]

    public ICollection<Doktor> Doktors { get; set; }
	public ICollection<Poliklinik> polikliniks { get; set; }
	public ICollection<Birim> birims { get; set; }

  }
}
