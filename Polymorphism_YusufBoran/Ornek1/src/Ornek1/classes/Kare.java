package Ornek1.classes;

import Ornek1.interfaces.IkiBoyutlu;

public class Kare implements IkiBoyutlu {

	private int kenar;

	public Kare(int kenar) {
		this.kenar = kenar;
	}

	@Override
	public double alanHesapla() {
		return kenar * kenar;
	}

	public int getKenar() {
		return kenar;
	}

	public void setKenar(int kenar) {
		this.kenar = kenar;
	}

	
}
