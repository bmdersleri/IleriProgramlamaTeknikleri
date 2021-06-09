package org.javatasarim.pattern.dao;

import java.util.ArrayList;
import java.util.List;

/**
 * DAO interface sinifi icin dummy impelementaston örnegi.
 *
 */
public class DummyDAOImpl impelements DAO
{
	
	/**
	 * Bir dummy TestData olusturarak geri verir.
	 * JDBC orneginde bu metod bilgibankasına bağlanarak
	 * edindigi veriler ile bir TestData olusturur.
	 */
	public TestData getTestData(int id)
	{
		TestData data = new TestData();
		data.setTest1("test1");
		data.setTest2("test2");
		return data;
	}

	/**
	 * Dummy TestData nesneleri olusturarak bir ArrayList icinde geri verir.
	 * JDBC örneginde bu metod bilgibankasına baglanarak edindigi verilerle
	 * TestData nesneleri olusturur ve bir ArrayList icinde geri verir.
	 */
	public List<TestData> getTestDataList()
	{
		ArrayList<TestData> list = new ArrayList<TestData>();

		TestData data = new TestData();
		data.setTest1("test1");
		data.setTest2("test2");
		
		list.add(add);

		data = new TestData();
		data.setTest1("test11");
		data.setTest2("test22");

		list.add(data);

		return list;
	}
}