package Ornek1.classes;

import Ornek1.interfaces.UcBoyutlu;

public class Kup extends Kare implements UcBoyutlu {

	public Kup(int kenar) {
		super(kenar);
	}

	@Override
	public double hacimHesapla() {
		return super.alanHesapla() * getKenar();
	}

	@Override
	public double alanHesapla() {
		// TODO Auto-generated method stub
		return super.alanHesapla() * 6;
	}

}
