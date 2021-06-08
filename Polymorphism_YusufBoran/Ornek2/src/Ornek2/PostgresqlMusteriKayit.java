package Ornek2;

public class PostgresqlMusteriKayit implements MusteriKayit{

	@Override
	public void kayit(Musteri musteri) {
		System.out.println(musteri.getAd() + " " + musteri.getSoyad() + " Postgresql ile kayıt yapıldı.");
		
	}

}
