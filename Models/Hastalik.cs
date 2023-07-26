using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
	public class Hastalik
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(100)]
		[Display(Name = "Hastalýk Isim")]
		public string Isim { get; set; }
		[Required]
		[MaxLength(100)]

		public string Tanim { get; set; }

		public string Belirti { get; set; }
		

		public ICollection<Poliklinik> polikliniks { get; set; }
		

	}
}
