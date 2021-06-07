package ileriFinal;

public class EagerInitializationSingleton {
	
	private static final EagerInitializationSingleton INSTANCE =new EagerInitializationSingleton();
	
	
	private EagerInitializationSingleton() {

}

	public static EagerInitializationSingleton getInstance() {
		return INSTANCE;
		
	}
	
	public void SingletonTest() {
		System.out.println("Eager Singleton method çalýþtý.");
	}
		
	}
	
	