package Ornek2;

public class MusteriYonetimi {

	MusteriKayit musteriKayit;

	public MusteriYonetimi(MusteriKayit musteriKayit) {
		this.musteriKayit = musteriKayit;
	}

	public void kayit(Musteri musteri) {
		musteriKayit.kayit(musteri);
	}
}
