package Ornek2;

public class Main {
	public static void main(String[] args) {
		
		Musteri musteri = new Musteri("Ali", "Kaya");

		MusteriYonetimi musteriYonetimi = new MusteriYonetimi(new OracleMusteriKayit());
		musteriYonetimi.kayit(musteri);
		
		

	}
}
