namespace HastaneRandevuSistemi.Models
{
  public class Birim
  {
    public int Id { get; set; }
    public string Isim { get; set; }
    public ICollection<Doktor> Doktors { get; set;}
  }
}
