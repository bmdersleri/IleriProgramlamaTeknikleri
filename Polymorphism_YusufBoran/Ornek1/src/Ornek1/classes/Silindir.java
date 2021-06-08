package Ornek1.classes;

import Ornek1.interfaces.UcBoyutlu;

public class Silindir extends Daire implements UcBoyutlu {

	private int yaricap, yukseklik;

	public Silindir(double yaricap, int yükseklik) {
		super(yaricap);
		this.yukseklik = yükseklik;
	}

	@Override
	public double hacimHesapla() {
		return super.tabanAlani() * yukseklik;
	}

	@Override
	public double alanHesapla() {
		return (2 * super.tabanAlani()) + (yukseklik * 2 * Math.PI * getYaricap());
	}

	

}
