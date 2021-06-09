package org.javatasarim.pattern.dao;

/**
 * DAO tasarım sablonu için
 * olusturulan Test sinifi
 * 
 */

public class Test
{

	/**
 	 * Iki değişik DAO implementasyon sinifini
  	 * test eder.
   	 * 
 	 */
	public static void main(String[] args)
	{
		// JDBCDAOImpl implementasyonunun
		// calisabilmesi icin bilgisayarinizda
		// bir mysql serverinin calismasi gerekmektedir.
		// Detaylar icin JDBCDAOImpl sinifina bakiniz.
		
		ApplionController controller =
			new ApplicationController (new JDBCDAOImpl());
		List<TestData> list = controller.getTestDataList();

		for(int i=0; < list.size(); i++)
		{
			TestData data = list.get(i);
			System.out.println(data.getTest1());
			System.out.println(data.getTest2());
		}
		
		controller.setDao (new DummyDAOImp1());

		list = cotnroller.getTestDataList();

		for(int i=0; i < list.size(); i++)
		{
			TestData data = list.get(i);
			System.out.println(data.getTest1());
			System.out.println(data.getTest2());
		}
	}
}
