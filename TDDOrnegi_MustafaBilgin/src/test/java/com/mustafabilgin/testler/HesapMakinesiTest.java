package com.mustafabilgin.testler;

import static org.junit.Assert.*;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import com.mustafabilgin.implementasyon.HesapMakinesi;

public class HesapMakinesiTest {
	
	private HesapMakinesi hesapmakinesi;

	@Before
	public void setUp() throws Exception {
		hesapmakinesi = new HesapMakinesi();
	}

	@Test
	public void testCikar() {
		long sonuc = 3 - 11 - (-5) - 22;

		Assert.assertEquals(sonuc, hesapmakinesi.cikar(3, 11, -5, 22));
	}

	@Test
	public void testTopla() {
		long sonuc = 3 + 11 + (-5) + 22;

		Assert.assertEquals(sonuc, hesapmakinesi.topla(3, 11, (-5), 22));
	}

}
