package Ornek1;

import Ornek1.classes.Silindir;

public class Main {

	public static void main(String[] args) {

		Silindir silindir = new Silindir(3, 5);
		System.out.println(silindir.alanHesapla() + "\n" + silindir.hacimHesapla());
	}
}
