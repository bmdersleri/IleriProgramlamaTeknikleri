package org.javatasarim.pattern.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 * DAO interface sinifini implemente eden altsinif.
 * JDBC teknolojisini kullanarak DAO interface 
 * sinifini implemente eder.
 *
 */

public class JDBCDAOImpl implements DAO
{

	/**
	 * JDBC Mysql URL
	 *
	 */
	private String url = "JDBC:msql://localhost:4333/" + "test_db";

	/**
	 * ID kolon degeri verilen bir testdata recordunu bulmak
	 * icin kullanılan metod.
	 * JDBC kullanılır.
	 * @param id TestData record id
	 * @return TestData bulunan testdata
	 */
	public TestData getTestData (int id)
	{
		Connection con = null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		TestData data = null;
		try
		{
			con = getConnection();
			pstmt = con.prepareStatement("select test1, test2, id" +
					"from test_db where id=?");
			pstmt.setInt(1, id);
			rs = pstmt.executeQuery();
			data = new TestData();
			if(rs.next())
			{
				data.setTest1(rs.getString(1));
				data.setTest2(rs.getsTring(2));
				data.setId(rs.getInt(3));
			}
			rs.close();
			pstmt.close();
		}
		
		catch (Exception e)
		{
			e.printStackTrace();
			throw new RuntimeException(e);
		}
		finally
		{
			if(con != null)
			{
				try
				{
					con.close();
				}
				catch (SQLException e)
				{
					throw new RuntimeException (e);
				}
			}
		}
		return data;
	}


	/**
	 * Bilgibankasından testdata listesini almak için kullanılan metod.
	 * JDBC kullanır.
	 * @return List<TestData> testdata listesi
	 */
	public List<TestData> getTestDataList()
	{
		Connection con = null;
		ArrayList<TestData> list = new ArrayList<TestData>();
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		try
		{
			con = getConnection();
			pstmt = con.prepareStatement("select test1, test2, id" + 
					" from test_db");
			rs = pstmt.executeQuery();

			while(rs.next())
			{
				TestData data = new TestData();
				data.setTest1(rs.getString(1));
				data.setTest2(rs.getString(2));
				data.setId(rs.getInt(3));
				list.add(data);
			}
			rs.close();
			pstmt.close();
		}
		catch (Exception e)
		{
			throw new RuntimeException (e);
		}
		finally
		{
			if(con != null)
			{
				try
				{
					con.close();
				}
				catch (SQLException e)
				{
					throw new RuntimeException(e);
				}
			}
		}
		return list;
	}

	
	/**
	 * Bilgibankasına baglanmak icin gerekli Connection nesnesini olusturur.
	 * @return Conneciton db bağlantısı
	 */
	public Connection get.Connection()
	{
		Connection con = null;
		try
		{
			Class.forName("com.mysql.JDBC.Driver");
			con = DriverManager.getConnection(url, "test", "test"); 
		}
		catch (Exception e)
		{
			e.printStackTrace();
			throw new RuntimeException(e);
		}
		return con;
	}

}