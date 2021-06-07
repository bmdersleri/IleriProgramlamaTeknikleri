package ileriFinal;

public class BillPughSingleton {
	
	private BillPughSingleton() {
		
		
	}
	
	public static BillPughSingleton getBillPughSingleton() {
		return SingletonHelper.INSTANCE;
		
	}
	private static class SingletonHelper{
		
		private static final BillPughSingleton INSTANCE=new BillPughSingleton();
	}
	
	public void SingletonTest() {
		
		System.out.println("Bill Pugh Singleton method çalýþtý.");
	}

}
