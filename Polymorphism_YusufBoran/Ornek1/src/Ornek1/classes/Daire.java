package Ornek1.classes;

import Ornek1.interfaces.IkiBoyutlu;

public class Daire implements IkiBoyutlu {

	private double yaricap;
	
	public Daire(double yaricap) {
		this.yaricap = yaricap;
	}

	@Override
	public double alanHesapla() {
		return tabanAlani();
	}

	public double tabanAlani() {
		return yaricap * yaricap * Math.PI;
	}

	public double getYaricap() {
		return yaricap;
	}

	public void setYaricap(double yaricap) {
		this.yaricap = yaricap;
	}
	
}
