namespace HastaneRandevuSistemi.Models
{
  public class Hasta
  {
    public int Id { get; set; }
    public string Isim{ get; set; }
    public string SoyIsim { get; set; }
    public string TelefonNumarasi { get; set; }
    public string Email { get; set; }
    public DateTime DateofBirth { get; set; }
    public ICollection<Randevu> Randevular {get ; set;}


  }
}
