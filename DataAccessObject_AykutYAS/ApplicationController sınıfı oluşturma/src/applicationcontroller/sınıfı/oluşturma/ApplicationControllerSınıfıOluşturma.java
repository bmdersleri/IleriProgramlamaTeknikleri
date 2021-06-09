package org.javatasarim.pattern.dao;

import java.util.List;

/**
 * DAO tasarım sablonunu
 * kullanan Controller sinifi.
 * 
 */

public class ApplicationController
{
	private DAO dao;
	
	public ApplicationController(DAO dao)
	{
		this.dao = dao;
	}

	public DAO getDao()
	{
		return dao;
	}
	
	public void setDao (DAO dao)
	{
		this.dao = dao;
	}

	/**
	 * DAO üzerinden bir TestData nesnesi edinir.
	 *
	 * @param id int
	 * @return TestData
	 */
	public TestData getTestData (int id)
	{
		return dao.getTestData(id);
	}

	/**
	 * DAO üzerinden tüm TestData listesini edinir.
	 *
	 * @return List TestData listesi
	 */
	public List<TestData> getTestDataList()
	{
		return dao.get.TestDataList();
	}

}