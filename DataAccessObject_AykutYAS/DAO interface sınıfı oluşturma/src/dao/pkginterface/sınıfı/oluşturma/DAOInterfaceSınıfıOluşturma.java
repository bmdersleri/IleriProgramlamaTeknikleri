package org.javatasarim.pattern.dao;

import java.util.List;

/**
 * DAO tasarım sablonu için bir interface
 * sinifi tanımlıyoroz.
 * 
 */

public interface DAO
{
	/**
 	 * Bilgibankasından testdata listesini
 	 * almak için tanımlanan metod
 	 */
	List<TestData> getTestDataList();
	
	/**
 	 * ID kolon degeri verilen bir testdata recordunu 
 	 * bulmak icin kullanılan metod.
 	 * @param id TestData record id
 	 * @return TestData bulunan testdata
 	 */
	TestData getTestData(int id);
}
	
	/**
 	 * DAO interface sınıfı getTestDataList()  
 	 * ve getTestData() isimlerinde iki metot tanımlar. 
 	 * Test.main() metodunun ilk bölümünde JDBCDAOImpl 
 	 * ikinci bölümünde DummyDAOImpl sınıflarını kullanarak 
 	 * ApplicationController nesneleri üretiyoruz. 
 	 */
