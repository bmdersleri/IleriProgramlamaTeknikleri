package Ornek1.classes;

import Ornek1.interfaces.IkiBoyutlu;

public class DikUcgen implements IkiBoyutlu {

	private int dikkenar, yataykenar;

	public DikUcgen(int dikkenar, int yataykenar) {
		this.dikkenar = dikkenar;
		this.yataykenar = yataykenar;
	}

	@Override
	public double alanHesapla() {
		return dikkenar * yataykenar / 2;
	}

}
