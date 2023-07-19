namespace HastaneRandevuSistemi.Models
{
  public class Doktor
  {
    public int Id { get; set; }
    public string Isim { get; set; }
    public string SoyIsim { get; set; }
    public int BirimId { get; set; }
    public Birim Birim { get; set; }

    public int PoliklinikId { get ; set; }
    public Randevu Poliklinik { get ; set; }
      

  }
}
