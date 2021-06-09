package com.mustafabilgin.implementasyon;

import com.mustafabilgin.arayuzler.Cikarici;
import com.mustafabilgin.arayuzler.Toplayici;

public class HesapMakinesi implements Toplayici, Cikarici {

	public long cikar(long... operands) {
		long sonuc = operands[0];
		
		for (int index = 1; index < operands.length; index++) {
			sonuc -= operands[index];
		}

		return sonuc;
	}

	public long topla(long... operands) {
		long sonuc = 0;
		
		for (long sayi : operands) {
			sonuc += sayi;
		}
		
		return sonuc;
	}

}
