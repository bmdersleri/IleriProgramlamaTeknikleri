package Ornek2;

public class MysqlMusteriKayit implements MusteriKayit {

	@Override
	public void kayit(Musteri musteri) {
		System.out.println(musteri.getAd() + " " + musteri.getSoyad() + " Mysql ile kayıt yapıldı.");
	}

}
