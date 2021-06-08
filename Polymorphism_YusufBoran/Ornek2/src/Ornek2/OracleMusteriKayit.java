package Ornek2;

public class OracleMusteriKayit implements MusteriKayit {

	@Override
	public void kayit(Musteri musteri) {
		System.out.println(musteri.getAd() + " " + musteri.getSoyad() + " Oracle ile kayıt yapıldı.");
	}

}
