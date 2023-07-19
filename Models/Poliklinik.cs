namespace HastaneRandevuSistemi.Models
{
  public class Poliklinik
  {
    public int Id { get; set; }
    public string Isim { get; set; }
    public ICollection<Doktor> Doktors { get; set; }
  }
}
